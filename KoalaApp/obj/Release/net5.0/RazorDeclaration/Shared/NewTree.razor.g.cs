// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace KoalaApp.Shared
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
#line 1 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NewTree.razor"
using Data.ValidationModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NewTree.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NewTree.razor"
using Data;

#line default
#line hidden
#nullable disable
    public partial class NewTree : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NewTree.razor"
       
    [Parameter]
    public object Parent { get; set; }

    private NewTreeModel NewTreeModel { get; set; } = new NewTreeModel();

    private bool NewTreeHasBeenCreated { get; set; } = false;
    private bool ErrorOccured { get; set; } = false;

    private void CreateNewTree()
    {
        if (ProjectsHandler.InsertProject(AccountHandler.User.Id, NewTreeModel.Name))
        {
            NewTreeHasBeenCreated = true;

            if (Parent is Pages.Trees)
            {
                Pages.Trees trees = (Pages.Trees)Parent;
                trees.Projects.Add(new Project()
                {
                    Name = NewTreeModel.Name,
                    DateCreated = DateTime.Now,
                    LastOpened = DateTime.Now
                });
                trees.Update();
            }

        }
        else
        {
            ErrorOccured = true;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProjectsHandler ProjectsHandler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AccountHandler AccountHandler { get; set; }
    }
}
#pragma warning restore 1591