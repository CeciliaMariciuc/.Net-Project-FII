#pragma checksum "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\MovieCatalog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "055980f1cd4f99f71f2eab215b63c01b9d85814b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FE.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\_Imports.razor"
using FE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\_Imports.razor"
using FE.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\MovieCatalog.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies")]
    public partial class MovieCatalog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\MovieCatalog.razor"
           

        private List<Movie> _movies = new List<Movie>();
        private string searchTitle = "";
        private string sort = "Title";
        private string sort_order = "1";
        private string genre = "";
        private bool isLoaded;
        Movie movie = new Movie();

        protected override async Task OnInitializedAsync() => await GetMovies();

        private async Task GetMovies()
        {
            isLoaded = false;
            _movies = await Http.GetFromJsonAsync<List<Movie>>("https://localhost:44385/movies");
            isLoaded = true;
        }

        private async Task GetFilteredMovies()
        {
            isLoaded = false;
            _movies = await Http.GetFromJsonAsync<List<Movie>>("https://localhost:44385/movies/query?title=" + searchTitle + "&genre=" + genre + "&sort=" + sort + "&sort_order=" + sort_order);
            isLoaded = true;
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591