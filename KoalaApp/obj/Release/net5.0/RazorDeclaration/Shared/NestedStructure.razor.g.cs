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
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedStructure.razor"
       
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

    /*
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

        TwigsTempStorage.Order();

        Update();
    }
    */

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
                Title = "New Twig",
                DueDate = DateTime.Now,
                Priority = 0,
                Description = "",
                State = State.NOTSTARTED,
                AbsoluteLevel = 0,
                RelativeLevel = 0
            });

        // sort twigs and update nested structure
        TwigsTempStorage.Order();
        return;
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