#pragma checksum "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57e1950245f85d398eeca1228dc6635b76fee0dd"
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
#line 3 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Register.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" type=\"text/css\" href=\"../css/register.css\">\r\n\r\n");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "register-block");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-4 register-sec");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.AddMarkupContent(13, "<h2 class=\"text-center\">Register as a PlatNet-ter Now</h2>\r\n                ");
            __builder.OpenElement(14, "form");
            __builder.AddAttribute(15, "class", "register-form");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-group");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.AddMarkupContent(20, "<label for=\"exampleInputFirstName\" class=\"text-uppercase\">First Name</label>\r\n                        ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "text");
            __builder.AddAttribute(23, "id", "firstname");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "placeholder", "First Name");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Register.razor"
                                      firstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstName = __value, firstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "form-group");
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.AddMarkupContent(33, "<label for=\"exampleInputLastNme\" class=\"text-uppercase\">Last Name</label>\r\n                        ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "text");
            __builder.AddAttribute(36, "id", "lastname");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "placeholder", "Last Name");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Register.razor"
                                      lastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastName = __value, lastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-group");
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.AddMarkupContent(46, "<label for=\"exampleInputEmail\" class=\"text-uppercase\">Email</label>\r\n                        ");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "type", "text");
            __builder.AddAttribute(49, "id", "email");
            __builder.AddAttribute(50, "class", "form-control");
            __builder.AddAttribute(51, "placeholder", "E-mail");
            __builder.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Register.razor"
                                      email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "form-group");
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.AddMarkupContent(59, "<label for=\"exampleInputPassword\" class=\"text-uppercase\">Password</label>\r\n                        ");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "type", "password");
            __builder.AddAttribute(62, "id", "password");
            __builder.AddAttribute(63, "class", "form-control");
            __builder.AddAttribute(64, "placeholder", "password");
            __builder.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Register.razor"
                                      password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n\r\n                    ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "form-check");
            __builder.AddMarkupContent(71, "\r\n\r\n                        ");
            __builder.OpenElement(72, "input");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Register.razor"
                                          AddUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "type", "submit");
            __builder.AddAttribute(75, "class", "btn btn-login float-right");
            __builder.AddAttribute(76, "value", "Register");
            __builder.AddAttribute(77, "disabled", 
#nullable restore
#line 33 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Register.razor"
                                                                                                                              isSubmitting

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n\r\n            ");
            __builder.AddMarkupContent(82, @"<div class=""col-md-8 banner-sec"">
                <img src=""https://i.ibb.co/6s19zXR/movies.jpg"" alt=""First slide"">

                <div class=""banner-text"">
                    <h2>PLAYNET REGISTER!</h2>
                    <p>We can't wait to have you in our community as a member. Join now for more features! </p>
                </div>

            </div>
        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n\r\n");
#nullable restore
#line 53 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Register.razor"
 if (registerResponse != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(86, "    ");
            __builder.AddMarkupContent(87, "<div class=\"register-response\">\r\n        Your registration was successful, please go to the login page to acces the account. Thank you for joining PlayNet!\r\n    </div>\r\n");
#nullable restore
#line 58 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Register.razor"
}
else 

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Register.razor"
      if (usedEmail == true)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(88, "<div class=\"register-response\">\r\n    This email address is already used by another user!\r\n</div>\r\n");
#nullable restore
#line 64 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Register.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\Teodora\Desktop\poiect net\.Net-Project-FII\FE\FE\Pages\Register.razor"
       
    private string firstName;
    private string lastName;
    private string email;
    private string password;

    private User registerResponse = null;
    bool isSubmitting;
    private bool usedEmail = false;

    private async Task AddUser()
    {
        isSubmitting = true;
        var addUser = new User { FirstName = firstName, LastName = lastName, Email = email, Password = password };
        var response = await Http.PostAsJsonAsync("https://localhost:44385/users/register", addUser);

        if (response.IsSuccessStatusCode)
        {
            registerResponse = await response.Content.ReadFromJsonAsync<User>();
        }
        else
        {
            usedEmail = true;
            registerResponse = null;
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