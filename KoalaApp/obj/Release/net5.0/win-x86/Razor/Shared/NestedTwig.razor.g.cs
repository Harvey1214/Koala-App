#pragma checksum "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9c09ca67b1b1bfd41e0c5ae9c7b13bfe26d7055"
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
#nullable restore
#line 9 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor"
 if (Twig.Display) 
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "noOverflow" + " " + (
#nullable restore
#line 11 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor"
                            block

#line default
#line hidden
#nullable disable
            ) + " twig");
            __builder.AddAttribute(2, "style", "margin-left:" + (
#nullable restore
#line 11 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor"
                                                            margin

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor"
                       OpenForEditting

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ondblclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor"
                                                     AddTwig

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "class", "card" + " " + (
#nullable restore
#line 12 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor"
                                                                           cardStyle

#line default
#line hidden
#nullable disable
            ) + " mb-3" + " noOverflow");
            __builder.AddAttribute(7, "style", "width: 18rem;margin-left:0px;cursor:pointer;");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.OpenElement(10, "h5");
            __builder.AddAttribute(11, "class", "card-title noBottomPaddingMargin block");
            __builder.AddContent(12, 
#nullable restore
#line 14 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor"
                                                                    Twig.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor"
                 if (hasChildren)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor"
                     if (Twig.ShowChildren)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn floatRight");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor"
                                                                 Collapse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(16, "<span class=\"oi oi-arrow-bottom\"></span>");
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn floatRight");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor"
                                                                 Collapse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "<span class=\"oi oi-arrow-top\"></span>");
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\NestedTwig.razor"
}

#line default
#line hidden
#nullable disable
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
