#pragma checksum "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b73f36c6a39b2624e95ccc039476ed6b2559ad6f"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "margin-bottom:" + " 1rem;" + " display:" + " " + (
#nullable restore
#line 7 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
                                           visible

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-outline-info");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
                                                   AddTwig

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Add twig");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "block SmallerPage");
            __builder.AddAttribute(9, "style", "display:" + " " + (
#nullable restore
#line 11 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
                                                visible

#line default
#line hidden
#nullable disable
            ) + ";");
#nullable restore
#line 12 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
     if (TwigsTempStorage.Twigs != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
         foreach (var twig in TwigsTempStorage.OrderedTwigs)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<KoalaApp.Shared.NestedTwig>(10);
            __builder.AddAttribute(11, "Twig", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DataAccessLibrary.Twig>(
#nullable restore
#line 16 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
                               twig

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "NestedStructure", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<KoalaApp.Shared.NestedStructure>(
#nullable restore
#line 16 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
                                                       this

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(13, (__value) => {
#nullable restore
#line 16 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
                                                                   AddNestedTwigToList = (KoalaApp.Shared.NestedTwig)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 17 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
       
    [Parameter]
    public bool Visible { get; set; } = true;

    private string visible
    {
        get
        {
            if (Visible) return "block";
            return "none";
        }
    }

    [Parameter]
    public int ProjectId { get; set; }

    [Parameter]
    public Project Project { get; set; }

    private List<NestedTwig> NestedTwigs = new List<NestedTwig>();
    private NestedTwig AddNestedTwigToList
    {
        set
        {
            NestedTwigs.Add(value);
        }
    }

    protected override void OnInitialized()
    {
        TwigsTempStorage.NestedStructure = this;
    }

    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            TwigsTempStorage.Order();
        }
    }

    public void UpdateAll()
    {
        foreach (var twig in NestedTwigs)
        {
            twig.Update();
        }
    }

    private void AddTwig()
    {
        // insert the new twig into the database
        TwigsHandler.InsertTwig(ProjectId);

        // add the new twig to the GUI
        int newTwigId = TwigsHandler.GetLastId();
        TwigsTempStorage.Twigs.Add(
            new Twig()
            {
                Id = newTwigId,
                ProjectId = ProjectId,
                ParentId = null,
                Title = "",
                DueDate = DateTime.Now,
                Priority = 0,
                Description = "",
                State = State.NOTSTARTED,
                AbsoluteLevel = 0,
                RelativeLevel = 0
            });

        // sort twigs and update nested structure
        TwigsTempStorage.Order();

        TwigsTempStorage.OpenForEdittingId = newTwigId;
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
