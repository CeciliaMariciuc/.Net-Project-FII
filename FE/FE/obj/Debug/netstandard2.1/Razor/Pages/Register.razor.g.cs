#pragma checksum "C:\Teddy\NET\PROIECT\FE\FE\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b946178852e3e690768839b505a9aee1b2b29333"
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
#line 1 "C:\Teddy\NET\PROIECT\FE\FE\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Teddy\NET\PROIECT\FE\FE\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Teddy\NET\PROIECT\FE\FE\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Teddy\NET\PROIECT\FE\FE\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Teddy\NET\PROIECT\FE\FE\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Teddy\NET\PROIECT\FE\FE\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Teddy\NET\PROIECT\FE\FE\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Teddy\NET\PROIECT\FE\FE\_Imports.razor"
using FE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Teddy\NET\PROIECT\FE\FE\_Imports.razor"
using FE.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Teddy\NET\PROIECT\FE\FE\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Teddy\NET\PROIECT\FE\FE\Pages\Register.razor"
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
            __builder.OpenElement(0, "html");
            __builder.AddMarkupContent(1, "\r\n");
            __builder.AddMarkupContent(2, "<head>\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"../css/register.css\">\r\n    <h1>Register</h1>\r\n    <p>Please fill in this form to create an account.</p>\r\n    <hr>\r\n</head>\r\n");
            __builder.OpenElement(3, "body");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<label for=\"psw\"><b>First Name</b></label>\r\n    ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "id", "firstname");
            __builder.AddAttribute(9, "class", "fadeIn second");
            __builder.AddAttribute(10, "name", "login");
            __builder.AddAttribute(11, "placeholder", "First Name");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Teddy\NET\PROIECT\FE\FE\Pages\Register.razor"
                  firstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstName = __value, firstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.AddMarkupContent(15, "<label for=\"psw\"><b>Last Name</b></label>\r\n    ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "id", "lastname");
            __builder.AddAttribute(19, "class", "fadeIn second");
            __builder.AddAttribute(20, "name", "login");
            __builder.AddAttribute(21, "placeholder", "Last Name");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Teddy\NET\PROIECT\FE\FE\Pages\Register.razor"
                  lastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastName = __value, lastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.AddMarkupContent(25, "<label for=\"psw\"><b>Email</b></label>\r\n    ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "text");
            __builder.AddAttribute(28, "id", "email");
            __builder.AddAttribute(29, "class", "fadeIn second");
            __builder.AddAttribute(30, "name", "login");
            __builder.AddAttribute(31, "placeholder", "E-mail");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Teddy\NET\PROIECT\FE\FE\Pages\Register.razor"
                  email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.AddMarkupContent(35, "<label for=\"psw\"><b>Password</b></label>\r\n    ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "text");
            __builder.AddAttribute(38, "id", "password");
            __builder.AddAttribute(39, "class", "fadeIn third");
            __builder.AddAttribute(40, "name", "login");
            __builder.AddAttribute(41, "placeholder", "password");
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Teddy\NET\PROIECT\FE\FE\Pages\Register.razor"
                  password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n    ");
            __builder.AddMarkupContent(45, "<label for=\"psw-repeat\"><b>Repeat Password</b></label>\r\n    ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "type", "password");
            __builder.AddAttribute(48, "placeholder", "Repeat Password");
            __builder.AddAttribute(49, "name", "psw-repeat");
            __builder.AddAttribute(50, "id", "psw-repeat");
            __builder.AddAttribute(51, "required", true);
            __builder.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Teddy\NET\PROIECT\FE\FE\Pages\Register.razor"
                  password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.OpenElement(55, "input");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Teddy\NET\PROIECT\FE\FE\Pages\Register.razor"
                      AddUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "type", "submit");
            __builder.AddAttribute(58, "class", "fadeIn fourth");
            __builder.AddAttribute(59, "value", "Register");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    <hr>\r\n\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Teddy\NET\PROIECT\FE\FE\Pages\Register.razor"
           
        private string firstName;
        private string lastName;
        private string email;
        private string password;

        private async Task AddUser()
        {
            var addUser = new User { FirstName = firstName, LastName = lastName, Email = email, Password = password };
            await Http.PostAsJsonAsync("https://localhost:44385/users", addUser);
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
