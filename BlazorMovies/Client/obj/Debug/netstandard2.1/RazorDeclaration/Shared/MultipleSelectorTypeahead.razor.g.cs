#pragma checksum "D:\My Projects\GitRepo\BlazorMovies\BlazorMovies\Client\Shared\MultipleSelectorTypeahead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a61ccfa06305b13f5e00d556058e45de1b70a57"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorMovies.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\My Projects\GitRepo\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\My Projects\GitRepo\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\My Projects\GitRepo\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\My Projects\GitRepo\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\My Projects\GitRepo\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\My Projects\GitRepo\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\My Projects\GitRepo\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\My Projects\GitRepo\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\My Projects\GitRepo\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
    public partial class MultipleSelectorTypeahead<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "D:\My Projects\GitRepo\BlazorMovies\BlazorMovies\Client\Shared\MultipleSelectorTypeahead.razor"
       
    [Parameter] public List<T> SelectedElements { get; set; } = new List<T>();
    [Parameter] public Func<string, Task<IEnumerable<T>>> SearchMethod { get; set; }
    [Parameter] public RenderFragment<T> MyResultTemplate { get; set; }
    [Parameter] public RenderFragment<T> MyListTemplate { get; set; }
    T draggedItem;

    private void SelectedElement(T item)
    {
        if (!SelectedElements.Any(x => x.Equals(item)))
        {
            SelectedElements.Add(item);
        }
    }

    private void HandleDragStart(T item)
    {
        draggedItem = item;
    }

    private void HandleDragOver(T item)
    {
        if (!item.Equals(draggedItem))
        {
            var dragElementIndex = SelectedElements.IndexOf(draggedItem);
            var elementIndex = SelectedElements.IndexOf(item);
            SelectedElements[elementIndex] = draggedItem;
            SelectedElements[dragElementIndex] = item;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591