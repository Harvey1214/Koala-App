#pragma checksum "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d186c417f6973e0bc65497b08051ad8af469b120"
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
#line 1 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
using Data;

#line default
#line hidden
#nullable disable
    public partial class NestedStructure : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
                  AddTwig

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "class", "btn btn-outline-success");
            __builder.AddContent(3, "Add Twig");
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
 if (TwigsTempStorage.Twigs != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
     foreach (var twig in TwigsTempStorage.Twigs)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<KoalaApp.Shared.NestedTwig>(4);
            __builder.AddAttribute(5, "Twig", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DataAccessLibrary.Twig>(
#nullable restore
#line 13 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
                           twig

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "NestedStructure", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<KoalaApp.Shared.NestedStructure>(
#nullable restore
#line 13 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
                                                   this

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 14 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
       
    [Parameter]
    public int ProjectId { get; set; }

    private void AddTwig()
    {
        Twig twig = new Twig()
        {
            ProjectId = ProjectId,
            Title = "New Twig",
            DueDate = DateTime.Now.AddYears(100),
            Priority = 0,
            Description = "",
            State = State.NOTSTARTED
        };

        TwigsHandler.InsertTwig(ProjectId);

        twig.Id = TwigsHandler.GetLastId();

        TwigsTempStorage.Twigs.Add(twig);

        Update();
    }

    public void Update()
    {
        InvokeAsync(StateHasChanged);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TwigsHandler TwigsHandler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TwigsTempStorage TwigsTempStorage { get; set; }
    }
}
#pragma warning restore 1591
