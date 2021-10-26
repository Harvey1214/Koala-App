using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KoalaApp.Data;
using DataAccessLibrary;
using Microsoft.AspNetCore.Components;
using KoalaApp.Shared;

namespace KoalaApp.Pages
{
    public partial class Trees
    {
        [Inject] AccountHandler AccountHandler { get; set; }
        [Inject] ProjectsHandler ProjectsHandler { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }
        [Inject] ShareHandler ShareHandler { get; set; }
        [Inject] UsersHandler UsersHandler { get; set; }
        [Inject] TwigsHandler TwigsHandler { get; set; }
        [Inject] ShareProject ShareProject { get; set; }
        [Inject] Blazored.LocalStorage.ILocalStorageService LocalStorage { get; set; }

        public List<Project> Projects { get; set; } = new List<Project>();

        private bool redirectToLoginPage = false;

        private EditTree EditTree { get; set; }

        private void Share(Project project)
        {
            ShareProject.Project = project;
            NavigationManager.NavigateTo("/share");
        }

        private void OpenProjectPreferences(Project project)
        {
            if (EditTree == null)
            {
                return;
            }

            EditTree.Edit(project);
        }

        private void OpenProject(int id)
        {
            ProjectsHandler.UpdateProjectLastOpened(new Project() { Id = id, LastOpened = DateTime.Now });
            NavigationManager.NavigateTo($"/tree/{id}");
        }

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender) LoadProjects();

            if (redirectToLoginPage)
            {
                NavigationManager.NavigateTo("/login");
            }
        }

        private async void LoadProjects()
        {
            if (AccountHandler.User == null)
            {
                var cookieContent = await LocalStorage.GetItemAsync<string>("QoAOgiNzhb");
                AccountHandler.HandleCookies(cookieContent);
            }

            if (AccountHandler.User == null)
            {
                redirectToLoginPage = true;
                return;
            }

            Projects = ProjectsHandler.GetProjectsOfUser(AccountHandler.User.Id) ?? new List<Project>();
            LoadSharedProjects();

            Projects = Projects.OrderByDescending(o => o.LastOpened).ToList();

            await InvokeAsync(StateHasChanged);
        }

        private void LoadSharedProjects()
        {
            var collaborations = ShareHandler.GetCollaborationsWithUser(AccountHandler.User.Id);

            if (collaborations == null) return;

            foreach (var collaboration in collaborations)
            {
                var project = ProjectsHandler.GetProject(collaboration.ProjectId).ToList();
                if (project != null)
                    if (project.Count == 1)
                        Projects.Add(project.First());
            }
        }

        private ProjectDueDateInfo GetProjectDueDateInfo(Project project)
        {
            var twigs = TwigsHandler.GetTwigsOfProject(project.Id);

            if (twigs is null) return ProjectDueDateInfo.ALLCOMPLETED;
            twigs.RemoveAll(o => o.State == State.COMPLETED);

            if (twigs.Any(o => o.DueDate.Date == DateTime.Now.Date))
            {
                return ProjectDueDateInfo.TODOTODAY;
            }
            else if (twigs.Any(o => o.DueDate.Date < DateTime.Now.Date))
            {
                return ProjectDueDateInfo.LEFTOVER;
            }
            else
            {
                return ProjectDueDateInfo.ALLCOMPLETED;
            }
        }

        public void Update()
        {
            InvokeAsync(StateHasChanged);
            LoadProjects();
        }
    }

    public enum ProjectDueDateInfo
    {
        LEFTOVER,
        TODOTODAY,
        ALLCOMPLETED
    }
}
