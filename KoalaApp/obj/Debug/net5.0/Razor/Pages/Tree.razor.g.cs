#pragma checksum "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55bea85ecc08ac5f34d2b800632206713cc115dd"
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
#line 14 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
 if (ProjectNotFound)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"alert alert-warning\">\r\n        Tree <strong>was not found</strong>, please check your spelling and <a href=\"/trees\" class=\"alert-link\">tree list</a></div>");
#nullable restore
#line 19 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
 if (ValidURL == false)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"alert alert-warning\">\r\n        The url is <strong>invalid</strong>, the correct form is base URL + /tree/{Tree Id}\r\n    </div>");
#nullable restore
#line 25 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
 if (Project != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "h5");
            __builder.AddContent(3, 
#nullable restore
#line 29 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
         Project.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<KoalaApp.Shared.NestedStructure>(5);
            __builder.AddAttribute(6, "ProjectId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 30 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
                                 Project.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Project", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DataAccessLibrary.Project>(
#nullable restore
#line 30 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
                                                       Project

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "resizable-window");
            __builder.AddAttribute(11, "style", "float: right; position:fixed; top:1rem; right:1rem; height: 95%;");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "resizable-window-content");
            __builder.OpenComponent<KoalaApp.Shared.SearchSort>(14);
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenComponent<KoalaApp.Shared.Edit>(16);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Tree.razor"
       
    [Parameter]
    public string TreeIdText { get; set; }

    private int TreeId { get; set; }
    public Project Project { get; set; }

    private bool ValidURL { get; set; } = true;
    private bool ProjectNotFound { get; set; } = false;
    private bool RedirectToLogin { get; set; } = false;

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
        }
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
                return projects.Where(o => o.Id == TreeId).ToList().FirstOrDefault();
            }
        }

        return null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TwigsTempStorage TwigsTempStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AccountHandler AccountHandler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProjectsHandler ProjectsHandler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TwigsHandler TwigsHandler { get; set; }
    }
}
#pragma warning restore 1591
