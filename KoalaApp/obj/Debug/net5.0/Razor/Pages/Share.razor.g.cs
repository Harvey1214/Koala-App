#pragma checksum "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a0a7f1bc237ad7eaca121f806a3d17e58a2cba9"
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
#line 3 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
using Data.ValidationModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/share")]
    public partial class Share : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 13 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
 if (success.HasValue)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
     if (success.Value)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-success");
            __builder.AddMarkupContent(2, "\r\n            You have ");
            __builder.AddMarkupContent(3, "<strong>successfuly shared</strong> ");
            __builder.OpenElement(4, "i");
            __builder.AddContent(5, 
#nullable restore
#line 18 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
                                                             ShareProject.Project.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(6, " with ");
            __builder.OpenElement(7, "i");
            __builder.AddContent(8, 
#nullable restore
#line 18 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
                                                                                                    ShareModel.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "<div class=\"alert alert-danger\">\r\n            An <strong>error has occured</strong>, please refresh the page or try again later\r\n        </div>");
#nullable restore
#line 26 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
     
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "h5");
            __builder.AddContent(11, "Share ");
            __builder.OpenElement(12, "i");
            __builder.AddContent(13, 
#nullable restore
#line 29 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
              ShareProject.Project.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(15);
            __builder.AddAttribute(16, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 31 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
                  ShareModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 31 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
                                              ShareThisProject

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(18, "class", "form-inline");
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(20);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(22);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n\r\n    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group mb-2");
                __builder2.AddAttribute(26, "style", "margin-right:0.2rem");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "placeholder", "Email");
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
                                ShareModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ShareModel.Email = __value, ShareModel.Email))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ShareModel.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n    ");
                __builder2.AddMarkupContent(34, "<button type=\"submit\" class=\"btn btn-primary mb-2\">Share</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
       
    private ShareModel ShareModel { get; set; } = new ShareModel();

    private bool? success = null;

    private void ShareThisProject()
    {
        var users = UsersHandler.GetUsers(ShareModel.Email).ToList();

        if (users == null) return;
        if (users.Count != 1) return;

        success = ShareHandler.Share(ShareProject.Project.Id, users.First().Id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AccountHandler AccountHandler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ShareProject ShareProject { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ShareHandler ShareHandler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UsersHandler UsersHandler { get; set; }
    }
}
#pragma warning restore 1591
