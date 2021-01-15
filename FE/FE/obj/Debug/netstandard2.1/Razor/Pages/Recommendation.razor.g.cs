#pragma checksum "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65a46cb5a80869e842cd31a138f118fdfd07a21a"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
using System.Net.Http.Formatting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
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
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" type=\"text/css\" href=\"../css/recommendation3.css\">\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n");
            __builder.AddMarkupContent(4, "<div class=\"title\">\r\n    <br>\r\n    <h1>\r\n        Recommendation\r\n        <br>\r\n    </h1>\r\n</div>\r\n\r\n<br>\r\n<br>\r\n<br>\r\n");
            __builder.AddMarkupContent(5, "<div class=\"banner\">\r\n    <p>\r\n        These are our recommendations base on your movie preferences.<br>\r\n        Keep watching and rating movies to help improving our predictions!\r\n    </p>\r\n</div>\r\n");
            __builder.OpenElement(6, "form");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
                                    GetTopUserRecommendation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "value", "Make predictions based on my preferences");
            __builder.AddAttribute(12, "disabled", 
#nullable restore
#line 29 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
                                                                                                                          isLoading

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 31 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
 if (top10_user_predictions.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "predictions-response");
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 34 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
         foreach (var prediction in top10_user_predictions)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "movie-card");
            __builder.AddAttribute(21, "style", "width: 18rem;");
            __builder.AddMarkupContent(22, "\r\n                <img class=\"card-img-top\" src=\"https://s.studiobinder.com/wp-content/uploads/2017/12/Movie-Poster-Template-Dark-with-Image.jpg?x81279\" alt=\"Card image cap\">\r\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "card-body");
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "h5");
            __builder.AddAttribute(27, "class", "movie-title");
            __builder.AddContent(28, 
#nullable restore
#line 38 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
                                             prediction.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    <br>\r\n                    <br>\r\n                    ");
            __builder.OpenElement(30, "p");
            __builder.AddAttribute(31, "class", "movie-info");
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.AddContent(33, 
#nullable restore
#line 42 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
                         prediction.Genres

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(34, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 47 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 49 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(40, "<div class=\"banner\">\r\n    <p>\r\n        Here you can find the highest rated movies we have on our website!<br>\r\n        We continue to update our database so check it out again later!\r\n    </p>\r\n</div>\r\n");
            __builder.OpenElement(41, "form");
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "button");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
                                    GetTopRatedMovies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "value", "See Top 10 Movies By Rating");
            __builder.AddAttribute(47, "disabled", 
#nullable restore
#line 57 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
                                                                                                      isLoading

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n");
#nullable restore
#line 60 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
 if (top10_rating_predictions.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "predictions-response");
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 63 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
         foreach (var movie in top10_rating_predictions)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "movie-card");
            __builder.AddAttribute(56, "style", "width: 18rem;");
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.OpenElement(58, "img");
            __builder.AddAttribute(59, "class", "card-img-top");
            __builder.AddAttribute(60, "src", 
#nullable restore
#line 65 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
                                                movie.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(61, "alt", "Card image cap");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "card-body");
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.OpenElement(66, "h5");
            __builder.AddAttribute(67, "class", "movie-title");
            __builder.AddContent(68, 
#nullable restore
#line 67 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
                                             movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                    <br>\r\n                    <br>\r\n                    ");
            __builder.OpenElement(70, "p");
            __builder.AddAttribute(71, "class", "movie-info");
            __builder.AddMarkupContent(72, "\r\n                        ");
            __builder.AddContent(73, 
#nullable restore
#line 71 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
                         movie.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 75 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
#nullable restore
#line 77 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(80, "\r\n");
            __builder.AddMarkupContent(81, "<div class=\"banner\">\r\n    <p>\r\n        Below we have the most popular movies according to our users ratings.<br>\r\n        Click the button to see the list!\r\n    </p>\r\n</div>\r\n");
            __builder.OpenElement(82, "form");
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.OpenElement(84, "input");
            __builder.AddAttribute(85, "type", "button");
            __builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
                                    GetTopPopularMovies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "value", "See Top 10 Movies By Popularity");
            __builder.AddAttribute(88, "disabled", 
#nullable restore
#line 86 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
                                                                                                            isLoading

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n\r\n");
#nullable restore
#line 90 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
 if (top10_popular_predictions.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "    ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "rating-response");
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 93 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
         foreach (var movie in top10_popular_predictions)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(96, "            ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "movie-card");
            __builder.AddAttribute(99, "style", "width: 18rem;");
            __builder.AddMarkupContent(100, "\r\n                ");
            __builder.OpenElement(101, "img");
            __builder.AddAttribute(102, "class", "card-img-top");
            __builder.AddAttribute(103, "src", 
#nullable restore
#line 96 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
                                                movie.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(104, "alt", "Card image cap");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "card-body");
            __builder.AddMarkupContent(108, "\r\n                    ");
            __builder.OpenElement(109, "h5");
            __builder.AddAttribute(110, "class", "movie-title");
            __builder.AddContent(111, 
#nullable restore
#line 98 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
                                             movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                    <br>\r\n                    <br>\r\n                    ");
            __builder.OpenElement(113, "p");
            __builder.AddAttribute(114, "class", "movie-info");
            __builder.AddMarkupContent(115, "\r\n                        ");
            __builder.AddContent(116, 
#nullable restore
#line 102 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
                         movie.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(117, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n");
#nullable restore
#line 106 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(121, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n");
#nullable restore
#line 108 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(123, "<br>\r\n<br>\r\n<br>\r\n<br>");
        }
        #pragma warning restore 1998
#nullable restore
#line 117 "C:\Users\Teodora\Desktop\.Net-Project-FII\FE\FE\Pages\Recommendation.razor"
       
    private int user;
    private bool isLoading;
    List<MoviePrediction>
    top10_user_predictions = new List<MoviePrediction>
        ();
    List<Movie>
        top10_rating_predictions = new List<Movie>
            ();
    List<Movie>
        top10_popular_predictions = new List<Movie>
            ();

    protected override async Task OnInitializedAsync() => await GetMostSimilarUser();

    private async Task GetMostSimilarUser()
    {
        isLoading = true;
        List<UserImdbRating>
            _ratings = new List<UserImdbRating>
                ();
        List<GeneralRating>
            mapped_ratings = new List<GeneralRating>
                ();
        string userId = await localStore.GetItemAsync<string>
            ("userId");
        string token = await localStore.GetItemAsync<string>
            ("token");

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