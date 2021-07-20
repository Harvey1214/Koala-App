#pragma checksum "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NewTree.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e7668b88979de1715886bf5e7da6ea8ffb87d70"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 7 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NewTree.razor"
 if (NewTreeHasBeenCreated)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"alert alert-success\">\r\n        The new tree has been <strong>created successfuly!</strong></div>");
#nullable restore
#line 12 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NewTree.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NewTree.razor"
 if (ErrorOccured)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"alert alert-danger\">\r\n        An <strong>error has occured</strong>, please refresh the page or try again later\r\n    </div>");
#nullable restore
#line 19 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NewTree.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<h5>New Tree</h5>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 23 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NewTree.razor"
                  NewTreeModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 23 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NewTree.razor"
                                                CreateNewTree

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "class", "form-inline");
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\r\n    ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group mb-2");
                __builder2.AddAttribute(14, "style", "margin-right:0.2rem");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "placeholder", "Name");
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NewTree.razor"
                                NewTreeModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewTreeModel.Name = __value, NewTreeModel.Name))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => NewTreeModel.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.OpenElement(22, "button");
                __builder2.AddAttribute(23, "type", "submit");
                __builder2.AddAttribute(24, "class", "btn" + " " + (
#nullable restore
#line 30 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NewTree.razor"
                                      UISettings.PrimaryButton

#line default
#line hidden
#nullable disable
                ) + " mb-2");
                __builder2.AddContent(25, "Create");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
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
