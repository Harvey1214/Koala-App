using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KoalaApp.Data;
using DataAccessLibrary;
using System.Threading;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Havit.Blazor.Components.Web.Bootstrap;

namespace KoalaApp.Shared
{
    public partial class Edit
    {
        [Inject] EditedTwig EditedTwig { get; set; }
        [Inject] TwigsHandler TwigsHandler { get; set; }
        [Inject] TwigsTempStorage TwigsTempStorage { get; set; }
        [Inject] WindowDimensions WindowDimensions { get; set; }
        [Inject] ProjectsHandler ProjectsHandler { get; set; }
        [Inject] IJSRuntime JS { get; set; }

        [Parameter] public bool Visible { get; set; } = true;
        
        private string visible
        {
            get
            {
                if (Visible) return "block";
                return "none";
            }
        }

        protected HxInputText Title;

        protected HxInputTextArea Description;
        private string DescriptionWidth
        {
            get
            {
                if (TwigsTempStorage == null) return "";
                if (TwigsTempStorage.Tree == null) return "";
                if (TwigsTempStorage.Tree.Project == null) return "";
                if (TwigsTempStorage.Tree.Project.DescriptionFieldWidth == 0) return "";

                return $"height: {TwigsTempStorage.Tree.Project.DescriptionFieldWidth}px";
            }
        }

        private DateTime StartLoadTime { get; set; }
        private double Latency { get; set; }

        private double LatencyLimitForInstantUpdating { get; } = 50;

        private string DeleteButtonVisibility { get; set; } = displayBlock;
        private string ConfirmDeletionButtonVisiblity { get; set; } = displayNone;

        #region ReadonlyConstants
        private static readonly string displayBlock = "display: block;";
        private static readonly string displayNone = "display: none;";
        #endregion

        private State TwigState
        {
            get
            {
                return EditedTwig.Twig.State;
            }
            set
            {
                SetState(value);
            }
        }

        private DateTime TwigDueDate
        {
            get
            {
                return EditedTwig.Twig.DueDate;
            }
            set
            {
                SetDueDate(value);
                UpdateEditedTwig();
                UpdateTwigDueDateInDatabase();
            }
        }

        private List<State> GetStateValues()
        {
            return new List<State>() { State.NOTSTARTED, State.INPROGRESS, State.COMPLETED };
        }

        private string GetLabel(State state) => state switch
        {
            State.NOTSTARTED => "Not started yet",
            State.INPROGRESS => "In Progress",
            State.COMPLETED => "Completed",
            _ => "",
        };

        private void Copy()
        {
            TwigsTempStorage.CopiedTwig = EditedTwig.Twig.Copy();
        }

        private void Paste()
        {
            // check if there's a twig in the clipboard
            if (TwigsTempStorage.CopiedTwig == null || TwigsTempStorage.CopiedTwig == EditedTwig.Twig)
            {
                return;
            }

            Twig twig = TwigsTempStorage.CopiedTwig.Copy();

            EditedTwig.Twig.Title = twig.Title;
            EditedTwig.Twig.Description = twig.Description;
            EditedTwig.Twig.Priority = twig.Priority;
            EditedTwig.Twig.State = twig.State;
            EditedTwig.Twig.DueDate = twig.DueDate;
            EditedTwig.Twig.CompletedDate = twig.CompletedDate;
            EditedTwig.Twig.ShowChildren = twig.ShowChildren;

            Update();
            EditedTwig.NestedTwig.Update();

            UpdateTwigInDatabase();
            TwigsHandler.UpdateTwigDueDate(EditedTwig.Twig);
            TwigsHandler.UpdateTwigCompletedDate(EditedTwig.Twig);
            TwigsHandler.UpdateTwigShowChildren(EditedTwig.Twig);

        }

        private void SetState(State state)
        {
            EditedTwig.Twig.State = state;

            if (state == State.COMPLETED)
            {
                EditedTwig.Twig.CompletedDate = DateTime.Now;
            }
            else
            {
                EditedTwig.Twig.CompletedDate = null;
            }

            Update();

            UpdateTwigInDatabase();
            TwigsHandler.UpdateTwigCompletedDate(EditedTwig.Twig);

            TwigsTempStorage.Order();
        }

        private void SetDueDate(DateTime dueDate)
        {
            if (dueDate.Year > 1800 && dueDate.Year < 9000)
            {
                EditedTwig.Twig.DueDate = dueDate;
            }

            TwigsTempStorage.Order();
        }
        private void SetPriority(string priorityText)
        {
            int priority;
            bool success = Int32.TryParse(priorityText, out priority);

            if (success)
            {
                EditedTwig.Twig.Priority = priority;
            }

            TwigsTempStorage.Order();
        }

        private void UpdateTwigInDatabase()
        {
            if (EditedTwig.Twig != null)
            {
                TwigsHandler.UpdateTwig(EditedTwig.Twig);
            }
        }

        private void ShowConfirmDeletionDialog(bool show, bool delay = false)
        {
            if (delay) Thread.Sleep(500);

            if (show)
            {
                ConfirmDeletionButtonVisiblity = displayBlock;
                DeleteButtonVisibility = displayNone;
            }
            else
            {
                DeleteButtonVisibility = displayBlock;
                ConfirmDeletionButtonVisiblity = displayNone;
            }
        }
        private void DeleteTwig()
        {
            // deleting the twig record from the database
            TwigsHandler.RemoveTwig(EditedTwig.Twig.Id);

            // removing the twig from the GUI
            TwigsTempStorage.Twigs.Remove(EditedTwig.Twig);
            TwigsTempStorage.Order();

            // not displaing the twig anymore in the edit
            EditedTwig.Twig = null;

            ShowConfirmDeletionDialog(false);
        }

        private void UpdateEditedTwig()
        {
            if (EditedTwig.NestedTwig != null)
                EditedTwig.NestedTwig.Update();
            else
            {
                TwigsTempStorage.NestedStructure.UpdateAll();
            }

            TwigsTempStorage.UpdateSearchSort();
        }

        protected override void OnInitialized()
        {
            EditedTwig.Twig = null;
            EditedTwig.NestedTwig = null;

            StartLoadTime = DateTime.Now;
            EditedTwig.Edit = this;
        }

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                Latency = (DateTime.Now - StartLoadTime).TotalMilliseconds;
                InvokeAsync(StateHasChanged);
            }
        }

        private void UpdateTwigDueDateInDatabase()
        {
            TwigsHandler.UpdateTwigDueDate(EditedTwig.Twig);
        }

        public void MobileOpenForEdittingCheck()
        {
            if (WindowDimensions.Mobile)
            {
                Visible = true;
            }
        }
        private void Close()
        {
            Visible = false;
        }

        public void Update()
        {
            ShowConfirmDeletionDialog(false);
            InvokeAsync(StateHasChanged);
        }

        public void FocusOnTitle()
        {
            if (Title.Equals(null) == false) Title.FocusAsync();
        }

        /*private async void SaveDescriptionWidth()
        {
            if (Description.Equals(null) || TwigsTempStorage.Tree == null) return;

            // @onmouseup="SaveDescriptionWidth" has to be added to the textarea component along with this: style="@DescriptionWidth"
            BoundingClientRect rect = await GetElementRect(Description);
            TwigsTempStorage.Tree.Project.DescriptionFieldWidth = (int)rect.Height;

            ProjectsHandler.UpdateProjectDescriptionFieldWidth(TwigsTempStorage.Tree.Project);
        }*/

        public async Task<BoundingClientRect> GetElementRect(ElementReference elementReference)
        {
            return await JS.InvokeAsync<BoundingClientRect>("MyDOMGetBoundingClientRect", elementReference);
        }
    }
}
