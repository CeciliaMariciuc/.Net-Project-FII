#pragma checksum "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46a0249036c8b57a01911176bb9e43b18ca7872c"
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
#line 3 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Login.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" type=\"text/css\" href=\"../css/login.css\">\r\n\r\n");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "login-block");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-4 login-sec");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.AddMarkupContent(13, "<h2 class=\"text-center\">Login Now</h2>\r\n                ");
            __builder.OpenElement(14, "form");
            __builder.AddAttribute(15, "class", "login-form");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-group");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.AddMarkupContent(20, "<label for=\"exampleInputEmail\" class=\"text-uppercase\">Email</label>\r\n                        ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "text");
            __builder.AddAttribute(23, "id", "email");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "placeholder", "E-mail");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Login.razor"
                                      email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "form-group");
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.AddMarkupContent(33, "<label for=\"exampleInputPassword\" class=\"text-uppercase\">Password</label>\r\n                        ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "password");
            __builder.AddAttribute(36, "id", "password");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "placeholder", "password");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Login.razor"
                                      password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n                    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-check");
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.AddMarkupContent(46, "<label class=\"form-check-label\">\r\n                            <input type=\"checkbox\" class=\"form-check-input\">\r\n                            <small>Remember me</small>\r\n                        </label>\r\n\r\n                        ");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Login.razor"
                                          LoginUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "type", "submit");
            __builder.AddAttribute(50, "class", "btn btn-login float-right");
            __builder.AddAttribute(51, "value", "Login");
            __builder.AddAttribute(52, "disabled", 
#nullable restore
#line 28 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Login.razor"
                                                                                                                             isSubmitting

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n            ");
            __builder.AddMarkupContent(57, @"<div class=""col-md-8 banner-sec"">
                <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                    <div class=""carousel-inner"" role=""listbox"">
                        <div class=""carousel-item active"">
                            <img class=""d-block img-fluid"" src=""https://i.ibb.co/qRPSB9x/movie.jpg"" alt=""First slide"">
                            <div class=""carousel-caption d-none d-md-block"">
                                <div class=""banner-text"">
                                    <h2>Welcome to PLAYNET!</h2>
                                    <p>Login to see more features and have a great movie experince! You don't have an account yet? Don't miss out and go to our <a href=""/register"">register</a> page. </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 52 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Login.razor"
 if (loginResponse != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(61, "    ");
            __builder.AddMarkupContent(62, "<div class=\"login-response\">\r\n        You are now logged in! Welcome to PlayNet!\r\n    </div>\r\n");
#nullable restore
#line 57 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Login.razor"
}
else 

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Login.razor"
      if (loginFailed == true)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(63, "<div class=\"login-response\">\r\n    Please enter a correct username/email and password. Note that the password field is case-sensitive.\r\n</div>\r\n");
#nullable restore
#line 63 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Login.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Login.razor"
       
    private string email;
    private string password;
    private LoggedUser loginResponse = null;

    bool isSubmitting;
    private bool loginFailed = false;

    private async Task LoginUser()
    {
        isSubmitting = true;
        var loginUser = new User { Email = email, Password = password };
        var response = await Http.PostAsJsonAsync("https://localhost:44385/users/login", loginUser);

        if (response.IsSuccessStatusCode)
        {
            loginResponse = await response.Content.ReadFromJsonAsync<LoggedUser>();
            Console.WriteLine(loginResponse);
        }
        else
        {
            loginFailed = true;
            loginResponse = null;
        }
        isSubmitting = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591