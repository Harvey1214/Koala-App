#pragma checksum "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91781ff6779078bdc4e914b64e6b7a45910eafee"
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
            __builder.OpenComponent<Havit.Blazor.Components.Web.Bootstrap.HxAlert>(0);
            __builder.AddAttribute(1, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Havit.Blazor.Components.Web.Bootstrap.ThemeColor>(
#nullable restore
#line 17 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
                        ThemeColor.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n            You have ");
                __builder2.AddMarkupContent(4, "<strong>successfuly shared</strong> ");
                __builder2.OpenElement(5, "i");
                __builder2.AddContent(6, 
#nullable restore
#line 18 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
                                                             ShareProject.Project.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(7, " with ");
                __builder2.OpenElement(8, "i");
                __builder2.AddContent(9, 
#nullable restore
#line 18 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
                                                                                                    ShareModel.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 20 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Havit.Blazor.Components.Web.Bootstrap.HxAlert>(10);
            __builder.AddAttribute(11, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Havit.Blazor.Components.Web.Bootstrap.ThemeColor>(
#nullable restore
#line 23 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
                        ThemeColor.Danger

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n            An ");
                __builder2.AddMarkupContent(14, "<strong>error has occured</strong>, please refresh the page or try again later\r\n        ");
            }
            ));
            __builder.CloseComponent();
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
            __builder.OpenElement(15, "h5");
            __builder.AddContent(16, "Share ");
            __builder.OpenElement(17, "i");
            __builder.AddContent(18, 
#nullable restore
#line 29 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
              ShareProject.Project.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(20);
            __builder.AddAttribute(21, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 31 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
                  ShareModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 31 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
                                              ShareThisProject

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(23, "class", "form-inline");
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(25);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(27);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n\r\n    ");
                __builder2.OpenComponent<Havit.Blazor.Components.Web.Bootstrap.HxInputText>(29);
                __builder2.AddAttribute(30, "Placeholder", "Email");
                __builder2.AddAttribute(31, "CssClass", "mb-0");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
                              ShareModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ShareModel.Email = __value, ShareModel.Email))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ShareModel.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n    \r\n    ");
                __builder2.OpenComponent<KoalaApp.Components.KoSubmit>(36);
                __builder2.AddAttribute(37, "Text", "Share");
                __builder2.AddAttribute(38, "CssClass", "mt-0 ml-1");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Pages\Share.razor"
       
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
