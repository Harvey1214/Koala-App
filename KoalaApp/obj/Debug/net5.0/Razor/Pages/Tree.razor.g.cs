#pragma checksum "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4aba7f2fc7ea9c825a771c22640fcbc2ee85ab2"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 16 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
 if (ProjectNotFound)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"alert alert-warning\">\r\n        Tree <strong>was not found</strong>, please check your spelling and <a href=\"/trees\" class=\"alert-link\">tree list</a></div>");
#nullable restore
#line 21 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
 if (ValidURL == false)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"alert alert-warning\">\r\n        The url is <strong>invalid</strong>, the correct form is base URL + /tree/{Tree Id}\r\n    </div>");
#nullable restore
#line 27 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
 if (Project != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "h5");
            __builder.AddContent(3, 
#nullable restore
#line 31 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
         Project.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
     if (WindowDimensions.Mobile == false)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<KoalaApp.Shared.NestedStructure>(4);
            __builder.AddAttribute(5, "ProjectId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
                                     Project.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Project", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DataAccessLibrary.Project>(
#nullable restore
#line 34 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
                                                           Project

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "resizable-window");
            __builder.AddAttribute(10, "style", "float: right; position:fixed; top:1rem; right:1rem; height: 95%;");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "resizable-window-content");
            __builder.OpenComponent<KoalaApp.Shared.SearchSort>(13);
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenComponent<KoalaApp.Shared.Edit>(15);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "btn btn-primary switch-view");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
                                                              SwitchViewInMobile

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Switch View");
            __builder.CloseElement();
            __builder.OpenComponent<KoalaApp.Shared.NestedStructure>(20);
            __builder.AddAttribute(21, "ProjectId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 46 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
                                     Project.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "Project", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DataAccessLibrary.Project>(
#nullable restore
#line 46 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
                                                           Project

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 46 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
                                                                             NestedStructureVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenComponent<KoalaApp.Shared.SearchSort>(25);
            __builder.AddAttribute(26, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
                             !NestedStructureVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenComponent<KoalaApp.Shared.Edit>(28);
            __builder.AddAttribute(29, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
                       false

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 49 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
       
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
        InvokeAsync(StateHasChanged);
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
