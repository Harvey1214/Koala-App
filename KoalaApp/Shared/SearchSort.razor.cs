using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KoalaApp.Data;
using DataAccessLibrary;
using Microsoft.AspNetCore.Components;
using Havit.Blazor.Components.Web.Bootstrap;

namespace KoalaApp.Shared
{
    public partial class SearchSort
    {
        [Inject] TwigsTempStorage TwigsTempStorage { get; set; }
        [Inject] ProjectsHandler ProjectsHandler { get; set; }
        [Inject] EditedTwig EditedTwig { get; set; }

        [Parameter] public bool Visible { get; set; } = true;

        private string visible
        {
            get
            {
                if (Visible) return "block";
                return "none";
            }
        }

        private bool dropdownOpened;
        private string dropdownOpenedStyle
        {
            get
            {
                if (dropdownOpened) return "display: block;";
                return "display: none";
            }
        }

        private void ToggleDropdown()
        {
            dropdownOpened = !dropdownOpened;
        }

        private void CloseDropdown()
        {
            dropdownOpened = false;
        }

        private void UpdateSort(SortBy sortBy)
        {
            TwigsTempStorage.SortBy = sortBy;

            if (TwigsTempStorage.Tree != null)
                if (TwigsTempStorage.Tree.Project != null)
                    TwigsTempStorage.Tree.Project.SortBy = sortBy;

            TwigsTempStorage.Order();

            CloseDropdown();

            ProjectsHandler.UpdateProjectSortBy(TwigsTempStorage.Tree.Project);
        }

        protected override void OnInitialized()
        {
            TwigsTempStorage.SearchSort = this;
        }

        private string GetTitle(Twig twig)
        {
            if (twig == null) return "";

            string title = "";

            int maxLength = 50;

            if (twig.Description != null)
                if (maxLength < twig.Description.Length)
                    title += $"{twig.Description.Substring(0, maxLength)}...{Environment.NewLine}";
                else
                    title += $"{twig.Description}{Environment.NewLine}";

            title += $"Due Date: {twig.DueDate}{Environment.NewLine}";
            title += $"Priority: {twig.Priority}";

            return title;
        }

        private void OpenForEditting(Twig twig)
        {
            EditedTwig.Twig = twig;
            EditedTwig.NestedTwig = null;

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

        private ThemeColor? GetTwigButtonColor(Twig twig)
        {
            DateTime dueDate = twig.DueDate;
            DateTime now = DateTime.Now;

            if (dueDate.Date == now.Date)
            {
                return ThemeColor.Primary;
            }
            else if (dueDate.Date < now.Date)
            {
                return ThemeColor.Danger;
            }

            return null;
        }
    }
}
