#pragma checksum "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Ratings .razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42a13add88b39fc279dce586524728158b964598"
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
#line 1 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\_Imports.razor"
using FE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\_Imports.razor"
using FE.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Ratings .razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Ratings .razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Ratings .razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Ratings .razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ratings")]
    public partial class Ratings_ : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Ratings .razor"
       

    private List<Movie> movies = new List<Movie>();

    private async Task GetMovies() => movies = await Http.GetFromJsonAsync<List<Movie>>("https://localhost:44385/movies");

    List<RatingEntry> _ratings = new List<RatingEntry>();
    private bool isLoaded;
    private Movie chosenMovie;
    private string chosenMovieTitle;
    private int chosenRating;
    private int updateRating = 0;
    private string insertRequestMessage;

    bool isSubmitting;


    protected override async Task OnInitializedAsync()
    {
        await GetMovies();
        await GetUserRatings();
    }

    private void SetChosenRating(int rating)
    {
        chosenRating = rating;
        Console.WriteLine(chosenRating);
    }

    private async Task InsertRating()
    {
        isSubmitting = true;
        string userId = await localStore.GetItemAsync<string>("userId");
        string token = await localStore.GetItemAsync<string>("token");
        Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        try
        {
            chosenMovie = await Http.GetFromJsonAsync<Movie>("https://localhost:44385/movies/title/" + chosenMovieTitle);
            RatingEntry ratingEntry = new RatingEntry
            {
                UserId = userId,
                MovieId = chosenMovie.Id,
                UserRating = chosenRating,
                Rated = chosenMovie.Rating,
                MovieTitle = chosenMovie.Title,
                Votes = chosenMovie.Votes
            };
            var response = await Http.PostAsJsonAsync("https://localhost:44385/rating", ratingEntry);
            insertRequestMessage = "The rating was added to your list!";
        }
        catch(Exception ex)
        {
            insertRequestMessage = "This movie wasn't found in our database! Check on the 'Movies' page to see the title available on our website!";
        }
        await GetUserRatings();
        isSubmitting = false;
    }

    private async Task DeleteRating(RatingEntry rating)
    {
        string userId = await localStore.GetItemAsync<string>("userId");
        string token = await localStore.GetItemAsync<string>("token");
        Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        await Http.DeleteAsync("https://localhost:44385/rating/"+ rating.Id);
        _ratings.Remove(rating);
    }

    private async Task UpdateRating(RatingEntry rating)
    {
        string userId = await localStore.GetItemAsync<string>("userId");
        string token = await localStore.GetItemAsync<string>("token");
        Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        RatingEntry updatedRatingEntry = rating;
        updatedRatingEntry.UserRating = updateRating;
        var response = await Http.PutAsJsonAsync("https://localhost:44385/rating/" + rating.Id, updatedRatingEntry);
        _ratings[_ratings.FindIndex(r => r.Equals(rating))] = updatedRatingEntry;
    }

    private async Task GetUserRatings()
    {
        isLoaded = false;
        string userId = await localStore.GetItemAsync<string>("userId");
        string token = await localStore.GetItemAsync<string>("token");

        Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        _ratings = await Http.GetFromJsonAsync<List<RatingEntry>>("https://localhost:44385/rating/user/" + userId);
        isLoaded = true;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStore { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591