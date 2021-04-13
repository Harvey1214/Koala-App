#pragma checksum "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\SearchSort.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eac63962c9550f9bfb28d5ca0f3f86e308aaeecd"
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
#line 1 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\SearchSort.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\SearchSort.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
    public partial class SearchSort : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "search-sort");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "list-group search-sort-list");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "dropdown");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\SearchSort.razor"
                              ToggleDropdown

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "class", "btn btn-secondary dropdown-toggle");
            __builder.AddAttribute(9, "type", "button");
            __builder.AddAttribute(10, "id", "dropdownMenu2");
            __builder.AddAttribute(11, "data-toggle", "dropdown");
            __builder.AddAttribute(12, "aria-haspopup", "true");
            __builder.AddAttribute(13, "aria-expanded", "false");
            __builder.AddMarkupContent(14, "\r\n                Sort By\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "dropdown-menu");
            __builder.AddAttribute(18, "style", 
#nullable restore
#line 13 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\SearchSort.razor"
                                               dropdownOpenedStyle

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "aria-labelledby", "dropdownMenu2");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\SearchSort.razor"
                                  () => UpdateSort(SortBy.DUEDATE_HIGHTOLOW)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "class", "dropdown-item");
            __builder.AddAttribute(23, "type", "button");
            __builder.AddContent(24, "Due Date Desc");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\SearchSort.razor"
                                  () => UpdateSort(SortBy.DUEDATE_LOWTOHIGH)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "class", "dropdown-item");
            __builder.AddAttribute(29, "type", "button");
            __builder.AddContent(30, "Due Date Asc");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                <div class=\"dropdown-divider\"></div>\r\n                ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\SearchSort.razor"
                                  () => UpdateSort(SortBy.PRIORITY_HIGHTOLOW)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "class", "dropdown-item");
            __builder.AddAttribute(35, "type", "button");
            __builder.AddContent(36, "Priority Desc");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\SearchSort.razor"
                                  () => UpdateSort(SortBy.PRIORITY_LOWTOHIGH)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "class", "dropdown-item");
            __builder.AddAttribute(41, "type", "button");
            __builder.AddContent(42, "Priority Asc");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                <div class=\"dropdown-divider\"></div>\r\n                ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\SearchSort.razor"
                                  () => UpdateSort(SortBy.COMPLETEDDATE_HIGHTOLOW)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "class", "dropdown-item");
            __builder.AddAttribute(47, "type", "button");
            __builder.AddContent(48, "Completed Date Desc");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\SearchSort.razor"
                                  () => UpdateSort(SortBy.COMPLETEDDATE_LOWTOHIGH)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "class", "dropdown-item");
            __builder.AddAttribute(53, "type", "button");
            __builder.AddContent(54, "Completed Date Asc");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\SearchSort.razor"
         foreach (var twig in TwigsTempStorage.SortedTwigs)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\SearchSort.razor"
                              () => OpenForEditting(twig)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "type", "button");
            __builder.AddAttribute(58, "class", "list-group-item list-group-item-action");
            __builder.AddAttribute(59, "alt", 
#nullable restore
#line 26 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\SearchSort.razor"
                                                                                                                              GetTitle(twig)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(60, "title", 
#nullable restore
#line 26 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\SearchSort.razor"
                                                                                                                                                      GetTitle(twig)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(61, 
#nullable restore
#line 26 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\SearchSort.razor"
                                                                                                                                                                       twig.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\SearchSort.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\mikuh\source\repos\KoalaApp\KoalaApp\Shared\SearchSort.razor"
             
    private bool dropdownOpened;
    private string dropdownOpenedStyle
    {
        get
        {
            if (dropdownOpened) return "display: block;";
            return "display: none";
        }
    }

    private int sortByCount = 6;

    private void ToggleDropdown()
    {
        dropdownOpened = !dropdownOpened;
    }

    private void CloseDropdown()
    {
        dropdownOpened = false;
    }

    private void UpdateSort(SortBy sortBy)
    {
        TwigsTempStorage.SortBy = sortBy;
        TwigsTempStorage.Order();

        CloseDropdown();
    }

    protected override void OnInitialized()
    {
        TwigsTempStorage.SearchSort = this;
    }

    private string GetTitle(Twig twig)
    {
        if (twig == null) return "";

        string title = "";

        int maxLength = 50;

        if (twig.Description != null)
            if (maxLength < twig.Description.Length)
                title += $"{twig.Description.Substring(0, maxLength)}...{Environment.NewLine}";
            else
                title += $"{twig.Description}{Environment.NewLine}";

        title += $"Due Date: {twig.DueDate}{Environment.NewLine}";
        title += $"Priority: {twig.Priority}";

        return title;
    }

    private void OpenForEditting(Twig twig)
    {
        EditedTwig.Twig = twig;
        EditedTwig.NestedTwig = null;

        if (EditedTwig.Edit != null)
        {
            EditedTwig.Edit.Update();
        }
    }

    public void Update()
    {
        InvokeAsync(StateHasChanged);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EditedTwig EditedTwig { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TwigsTempStorage TwigsTempStorage { get; set; }
    }
}
#pragma warning restore 1591
