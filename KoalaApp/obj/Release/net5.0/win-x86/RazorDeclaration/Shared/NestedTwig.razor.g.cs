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
#line 1 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor"
using Data.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor"
using Data;

#line default
#line hidden
#nullable disable
    public partial class NestedTwig : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor"
       
    [Parameter]
    public Twig Twig { get; set; }

    [Parameter]
    public NestedStructure NestedStructure { get; set; }

    private string block = "";

    private string margin
    {
        get
        {
            float result = Twig.AbsoluteLevel * UISettings.MarginMultiplier;
            return $"{result}rem";
        }
    }
    private string cardStyle
    {
        get
        {
            string style = "";
            style = UISettings.LevelStyles[Twig.RelativeLevel];

            return style;
        }
    }

    private bool hasChildren
    {
        get
        {
            bool children = false;

            foreach (var twig in TwigsTempStorage.Twigs)
            {
                if (twig.ParentId.HasValue)
                {
                    if (twig.ParentId.Value == Twig.Id)
                    {
                        children = true;
                        break;
                    }
                }
            }

            return children;
        }
    }

    protected override void OnInitialized()
    {
        Update();
    }

    private void Collapse()
    {
        Twig.ShowChildren = !Twig.ShowChildren;
        TwigsTempStorage.Order();

        TwigsHandler.UpdateTwigShowChildren(Twig);
    }

    private void OpenForEditting()
    {
        EditedTwig.Twig = Twig;
        EditedTwig.NestedTwig = this;

        if (EditedTwig.Edit != null)
        {
            EditedTwig.Edit.Update();
        }
    }

    public void Update()
    {
        if (NestedStructure.Project.ShowCompleted == false)
        {
            if (Twig.State == State.COMPLETED)
            {
                Twig.Display = false;
                InvokeAsync(StateHasChanged);
                return;
            }

            var parent = TwigsTempStorage.Twigs.Where(o => o.Id == Twig.ParentId);

            if (parent != null)
                if (parent.Count() == 1)
                {
                    if (parent.First().Display == false)
                    {
                        Twig.Display = false;
                    }
                }
        }

        InvokeAsync(StateHasChanged);
    }

    private void AddTwig()
    {
        for (int i = 0; i < TwigsTempStorage.Twigs.Count; i++)
        {
            if (TwigsTempStorage.Twigs[i].Id == Twig.Id)
            {
                // insert the new twig into the database
                TwigsHandler.InsertTwig(NestedStructure.ProjectId, Twig.Id);

                // add the new twig to the GUI
                int newTwigId = TwigsHandler.GetLastId();
                TwigsTempStorage.Twigs.Insert(i + 1,
                    new Twig()
                    {
                        Id = newTwigId,
                        ProjectId = NestedStructure.ProjectId,
                        ParentId = Twig.Id,
                        Title = "New Twig",
                        DueDate = DateTime.Now,
                        Priority = 0,
                        Description = "",
                        State = State.NOTSTARTED,
                        AbsoluteLevel = Twig.AbsoluteLevel + 1,
                        RelativeLevel = GetNextRelativeLevel()
                    });

                // sort twigs and update nested structure
                TwigsTempStorage.Order();
                return;
            }
        }
    }

    private int GetNextRelativeLevel()
    {
        int nextRelativeLevel = Twig.RelativeLevel + 1;
        if (nextRelativeLevel >= UISettings.LevelStyles.Length)
        {
            nextRelativeLevel = 0;
        }

        return nextRelativeLevel;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EditedTwig EditedTwig { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TwigsHandler TwigsHandler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TwigsTempStorage TwigsTempStorage { get; set; }
    }
}
#pragma warning restore 1591
