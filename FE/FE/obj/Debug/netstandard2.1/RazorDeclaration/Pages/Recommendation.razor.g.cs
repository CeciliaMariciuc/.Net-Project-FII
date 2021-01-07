#pragma checksum "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Recommendation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5dfe32f6ee4c6c5096b5ec572649635951152c6"
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
#line 3 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
using System.Net.Http.Formatting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
using Models.Ratings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
using Models.Recommendations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/recommendation")]
    public partial class Recommendation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
       
    private int user;
    private bool isLoading;
    List<MoviePrediction> top10_user_predictions = new List<MoviePrediction>();
    List<Movie> top10_rating_predictions = new List<Movie>();
    List<Movie> top10_popular_predictions = new List<Movie>();

    protected override async Task OnInitializedAsync() => await GetMostSimilarUser();

    private async Task GetMostSimilarUser()
    {
        isLoading = true;
        List<UserImdbRating> _ratings = new List<UserImdbRating>();
        List<GeneralRating> mapped_ratings = new List<GeneralRating>();
        string userId = await localStore.GetItemAsync<string>("userId");
        string token = await localStore.GetItemAsync<string>("token");

        Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        _ratings = await Http.GetFromJsonAsync<List<UserImdbRating>>("https://localhost:44385/rating/user-mapped/" + userId);

        var response_mapping = await Http.PostAsJsonAsync("https://localhost:44385/movieprediction/map-movies", _ratings);

        mapped_ratings = await response_mapping.Content.ReadAsAsync<List<GeneralRating>>();

        var response_getuser = await Http.PostAsJsonAsync("https://localhost:44385/movieprediction/similar-user", mapped_ratings);
        user = await response_getuser.Content.ReadAsAsync<int>();
        isLoading = false;
    }

    private async Task GetTopUserRecommendation()
    {
        MovieData movieData = new MovieData
        {
            UserId = user
        };

        string token = await localStore.GetItemAsync<string>("token");
        Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        var response_prediction = await Http.PostAsJsonAsync("https://localhost:44385/movieprediction", movieData);
        top10_user_predictions = await response_prediction.Content.ReadAsAsync<List<MoviePrediction>>();
    }


    private async Task GetTopRatedMovies()
    {
        top10_rating_predictions = await Http.GetFromJsonAsync<List<Movie>>("https://localhost:44385/movies/top10");
    }

    private async Task GetTopPopularMovies()
    {
        List<string> top10_ids = await Http.GetFromJsonAsync<List<string>>("https://localhost:44385/rating/top10-popular");
        var response_top10 = await Http.PostAsJsonAsync("https://localhost:44385/movies/ids", top10_ids);
        top10_popular_predictions = await response_top10.Content.ReadAsAsync<List<Movie>>();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStore { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591