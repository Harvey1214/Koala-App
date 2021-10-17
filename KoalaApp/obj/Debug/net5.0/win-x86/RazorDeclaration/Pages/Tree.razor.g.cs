// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace KoalaApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\_Imports.razor"
using KoalaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\_Imports.razor"
using KoalaApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\_Imports.razor"
using Havit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\_Imports.razor"
using Havit.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\_Imports.razor"
using Havit.Blazor.Components.Web.Bootstrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\_Imports.razor"
using Havit.Blazor.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\_Imports.razor"
using KoalaApp.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tree")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tree/{TreeIdText}")]
    public partial class Tree : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
       
    [Parameter]
    public string TreeIdText { get; set; }

    private int TreeId { get; set; }
    public Project Project { get; set; }

    private bool ValidURL { get; set; } = true;
    private bool ProjectNotFound { get; set; } = false;
    private bool RedirectToLogin { get; set; } = false;

    private bool NestedStructureVisible { get; set; } = true;

    protected override void OnInitialized()
    {
        TwigsTempStorage.Tree = this;
    }

    protected async override void OnAfterRender(bool firstRender)
    {
        if (RedirectToLogin)
        {
            RedirectToLoginPage();
        }

        if (firstRender)
        {
            if (AccountHandler.User == null)
            {
                var cookieContent = await LocalStorage.GetItemAsync<string>("QoAOgiNzhb");
                AccountHandler.HandleCookies(cookieContent);
            }

            LoadProject();

            LoadDimensions();
        }
    }

    private async void LoadDimensions()
    {
        await WindowDimensions.MainLayout.AdjustUIBasedOnWindowDimensions();
        await InvokeAsync(StateHasChanged);
    }

    private void SwitchViewInMobile()
    {
        NestedStructureVisible = !NestedStructureVisible;
    }

    private void RedirectToLoginPage()
    {
        NavigationManager.NavigateTo("/login");
    }

    protected override void OnParametersSet()
    {
        int treeId;
        bool success = Int32.TryParse(TreeIdText, out treeId);

        if (success)
        {
            TreeId = treeId;
        }
        else
        {
            ValidURL = false;
        }
    }

    private void LoadProject()
    {
        if (AccountHandler.User == null)
        {
            RedirectToLogin = true;
            return;
        }
        if (ValidURL == false)
        {
            return;
        }

        Project = GetProject();
        if (Project == null)
        {
            ProjectNotFound = true;
            return;
        }

        TwigsTempStorage.Twigs = GetTwigs();

        TwigsTempStorage.SortBy = Project.SortBy;

        InvokeAsync(StateHasChanged);
    }

    private List<Twig> GetTwigs()
    {
        return TwigsHandler.GetTwigsOfProject(Project.Id) ?? new List<Twig>();
    }

    private Project GetProject()
    {
        var projects = ProjectsHandler.GetProjectsOfUser(AccountHandler.User.Id);
        if (projects != null)
        {
            if (projects.Count > 0)
            {
                var project = projects.Where(o => o.Id == TreeId).ToList().FirstOrDefault();
                if (project != null) return project;
            }
        }

        var collaborations = ShareHandler.GetCollaborations(TreeId);
        if (collaborations == null) return null;
        if (collaborations.Count == 0) return null;

        if (collaborations.Where(o => o.UserId == AccountHandler.User.Id).ToList().Count > 0)
        {
            return ProjectsHandler.GetProject(TreeId).ToList().FirstOrDefault();
        }

        return null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WindowDimensions WindowDimensions { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ShareHandler ShareHandler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TwigsTempStorage TwigsTempStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AccountHandler AccountHandler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProjectsHandler ProjectsHandler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TwigsHandler TwigsHandler { get; set; }
    }
}
#pragma warning restore 1591
