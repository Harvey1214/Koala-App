#pragma checksum "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\Dropzone.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64f4f4a049818f14a55e80a4770db4a05f4f0a14"
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
#line 1 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\Dropzone.razor"
using Data;

#line default
#line hidden
#nullable disable
    public partial class Dropzone : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "ondragover", "event.preventDefault();");
            __builder.AddAttribute(3, "ondragstart", "event.dataTransfer.setData(\'\', event.target.id);");
            __builder.AddAttribute(4, "ondrop", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\Dropzone.razor"
                                                                                                                               OnDrop

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.AddContent(7, 
#nullable restore
#line 7 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\Dropzone.razor"
         text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\Dropzone.razor"
       
    private string text = "Drop here";

    private void OnDrop()
    {
        if (DragAndDropContainer.TransportedTwig == null) return;

        text = DragAndDropContainer.TransportedTwig.Title;

        InvokeAsync(StateHasChanged);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DragAndDropContainer DragAndDropContainer { get; set; }
    }
}
#pragma warning restore 1591
