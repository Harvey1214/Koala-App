using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KoalaApp.Data;
using DataAccessLibrary;
using Microsoft.AspNetCore.Components;

namespace KoalaApp.Shared
{
    public partial class NestedTwig
    {
        [Inject] DragAndDropContainer DragAndDropContainer { get; set; }
        [Inject] TwigsTempStorage TwigsTempStorage { get; set; }
        [Inject] TwigsHandler TwigsHandler { get; set; }
        [Inject] EditedTwig EditedTwig { get; set; }

        [Parameter] public Twig Twig { get; set; }

        [Parameter] public NestedStructure NestedStructure { get; set; }

        private string block = "";

        // choose a contrasting color for the add new twig button (mobile)
        private string addNewTwigButtonColor
        {
            get
            {
                if (Twig.RelativeLevel == 0 || Twig.RelativeLevel == 3) return "btn-light";
                return "btn-dark";
            }
        }

        // calculating margin using the nesting level
        private string margin
        {
            get
            {
                float result = Twig.AbsoluteLevel * UISettings.MarginMultiplier;
                return $"{result}rem";
            }
        }
        private string cardStyle
        {
            get
            {
                string style = "";
                style = UISettings.LevelStyles[Twig.RelativeLevel];

                return style;
            }
        }
        // choosing a color that stands out against the background
        private string color
        {
            get
            {
                if (Twig.RelativeLevel != 1) return "color: white;";
                return "";
            }
        }

        // finding out if this twig has children
        private bool hasChildren
        {
            get
            {
                bool children = false;

                foreach (var twig in TwigsTempStorage.Twigs)
                {
                    if (twig.ParentId.HasValue == false) continue;

                    if (twig.ParentId.Value == Twig.Id)
                    {
                        children = true;
                        break;
                    }
                }

                return children;
            }
        }

        // if this twig is currently being dragged
        private bool Dragging { get; set; } = false;
        private string paddingLeft
        {
            get
            {
                if (Dragging) return "padding-left: 0px;";
                return "";
            }
        }

        // if another twig is being dragged over this one
        private bool DragOver { get; set; } = false;
        private string onDragOverHoverEffect
        {
            get
            {
                if (DragOver) return "";
                return "";
            }
        }

        // composing the title displayed when a user hovers over this task
        private string title
        {
            get
            {
                if (Twig == null) return "";

                string title = "";

                int maxLength = 50;

                if (Twig.Description != null)
                    if (maxLength < Twig.Description.Length)
                        title += $"{Twig.Description.Substring(0, maxLength)}...{Environment.NewLine}";
                    else
                        title += $"{Twig.Description}{Environment.NewLine}";

                title += $"Due Date: {Twig.DueDate}{Environment.NewLine}";
                title += $"Priority: {Twig.Priority}";

                return title;
            }
        }

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                Update();
            }

            // open this task for editting if it has been newly created
            if (TwigsTempStorage.OpenForEdittingId == Twig.Id)
            {
                OpenForEditting();
                TwigsTempStorage.OpenForEdittingId = null;
                EditedTwig.Edit.FocusOnTitle();
            }
        }

        // add the task that has been dropped onto this one as a new child
        private void OnDrop()
        {
            if (DragAndDropContainer.TransportedTwig == null) return;
            if (DragAndDropContainer.TransportedTwig == Twig) return;
            if (GetParentIds().Contains(DragAndDropContainer.TransportedTwig.Id)) return;

            DragAndDropContainer.TransportedTwig.ParentId = Twig.Id;
            TwigsHandler.UpdateTwigParent(DragAndDropContainer.TransportedTwig);

            TwigsTempStorage.Order();
        }

        private List<int> GetParentIds()
        {
            List<int> result = new();

            int currentParentId = Twig.ParentId.GetValueOrDefault();
            while (true)
            {
                result.Add(currentParentId);
                var parents = TwigsTempStorage.Twigs.Where(o => o.Id == currentParentId).ToList();
                if (parents is not null && parents.Count == 1)
                {
                    currentParentId = parents.FirstOrDefault().ParentId.GetValueOrDefault();
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        // when this twig is being dragged
        private void OnDragStart()
        {
            DragAndDropContainer.TransportedTwig = Twig;
            Dragging = true;
        }
        private void OnDragEnd()
        {
            Dragging = false;
        }

        // when another twig is being dragged over this twig
        private void OnDragOver()
        {
            DragOver = true;
        }
        private void OnDragLeave()
        {
            DragOver = false;
        }

        private void Collapse()
        {
            Twig.ShowChildren = !Twig.ShowChildren;
            TwigsTempStorage.Order();

            TwigsHandler.UpdateTwigShowChildren(Twig);
        }

        public void OpenForEditting()
        {
            EditedTwig.Twig = Twig;
            EditedTwig.NestedTwig = this;

            if (EditedTwig.Edit != null)
            {
                EditedTwig.Edit.MobileOpenForEdittingCheck();
                EditedTwig.Edit.Update();
            }
        }

        public void Update()
        {
            InvokeAsync(StateHasChanged);
        }

        private void AddTwig()
        {
            for (int i = 0; i < TwigsTempStorage.Twigs.Count; i++)
            {
                if (TwigsTempStorage.Twigs[i].Id == Twig.Id)
                {
                    // insert the new twig into the database
                    TwigsHandler.InsertTwig(NestedStructure.ProjectId, Twig.Id);

                    // add the new twig to the GUI
                    int newTwigId = TwigsHandler.GetLastId();
                    TwigsTempStorage.Twigs.Insert(i + 1,
                        new Twig()
                        {
                            Id = newTwigId,
                            ProjectId = NestedStructure.ProjectId,
                            ParentId = Twig.Id,
                            Title = "",
                            DueDate = DateTime.Now,
                            Priority = 0,
                            Description = "",
                            State = State.NOTSTARTED,
                            AbsoluteLevel = Twig.AbsoluteLevel + 1,
                            RelativeLevel = GetNextRelativeLevel()
                        });

                    TwigsTempStorage.OpenForEdittingId = newTwigId;

                    // sort twigs and update nested structure
                    TwigsTempStorage.Order();
                }
            }
        }

        private int GetNextRelativeLevel()
        {
            int nextRelativeLevel = Twig.RelativeLevel + 1;
            if (nextRelativeLevel >= UISettings.LevelStyles.Length)
            {
                nextRelativeLevel = 0;
            }

            return nextRelativeLevel;
        }
    }
}
