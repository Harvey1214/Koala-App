#pragma checksum "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\Sidebar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a36a31fa7ee6484555b432e8080cc8135210ebaf"
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
#line 1 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\Sidebar.razor"
using Data;

#line default
#line hidden
#nullable disable
    public partial class Sidebar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Havit.Blazor.Components.Web.Bootstrap.HxSidebar>(0);
            __builder.AddAttribute(1, "CssClass", "sticky-top");
            __builder.AddAttribute(2, "HeaderTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Havit.Blazor.Components.Web.Bootstrap.HxSidebarBrand>(3);
                __builder2.AddAttribute(4, "BrandName", "Koala");
                __builder2.AddAttribute(5, "BrandNameShort", "KO");
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(6, "ItemsTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Havit.Blazor.Components.Web.Bootstrap.HxSidebarItem>(7);
                __builder2.AddAttribute(8, "Text", "Home");
                __builder2.AddAttribute(9, "Href", "/");
                __builder2.AddAttribute(10, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Havit.Blazor.Components.Web.IconBase>(
#nullable restore
#line 10 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\Sidebar.razor"
                                                  BootstrapIcon.House

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 11 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\Sidebar.razor"
         if (AccountHandler.User == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Havit.Blazor.Components.Web.Bootstrap.HxSidebarItem>(11);
                __builder2.AddAttribute(12, "Text", "Login");
                __builder2.AddAttribute(13, "Href", "/login");
                __builder2.AddAttribute(14, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Havit.Blazor.Components.Web.IconBase>(
#nullable restore
#line 13 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\Sidebar.razor"
                                                            BootstrapIcon.BoxArrowInRight

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 14 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\Sidebar.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Havit.Blazor.Components.Web.Bootstrap.HxSidebarItem>(15);
                __builder2.AddAttribute(16, "Text", "Log Out");
                __builder2.AddAttribute(17, "Href", "/login?logout=true");
                __builder2.AddAttribute(18, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Havit.Blazor.Components.Web.IconBase>(
#nullable restore
#line 17 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\Sidebar.razor"
                                                                          BootstrapIcon.BoxArrowLeft

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenComponent<Havit.Blazor.Components.Web.Bootstrap.HxSidebarItem>(20);
                __builder2.AddAttribute(21, "Text", "Trees");
                __builder2.AddAttribute(22, "Href", "/trees");
                __builder2.AddAttribute(23, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Havit.Blazor.Components.Web.IconBase>(
#nullable restore
#line 18 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\Sidebar.razor"
                                                            BootstrapIcon.Tree

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 19 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\Sidebar.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\Sidebar.razor"
       
    protected override void OnInitialized()
    {
        AccountHandler.NavMenu = this;
    }

    public void Update()
    {
        InvokeAsync(StateHasChanged);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AccountHandler AccountHandler { get; set; }
    }
}
#pragma warning restore 1591