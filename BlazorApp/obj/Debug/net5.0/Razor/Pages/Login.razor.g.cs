#pragma checksum "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3421f01c6ad6af7af2dbcc43569498e7fb009c88"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"login\"><h1>Create an account</h1></div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "formulaire");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-floating");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "login");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "id", "floatingPassword");
            __builder.AddAttribute(9, "placeholder", "login");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\Login.razor"
                                                                                                  login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => login = __value, login));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-floating");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "password");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "id", "floatingPassword");
            __builder.AddAttribute(19, "placeholder", "password");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\Login.razor"
                                                                                                        password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-floating");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "password");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "id", "floatingPassword");
            __builder.AddAttribute(29, "placeholder", "confirm password");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\Login.razor"
                                                                                                                confirm_password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => confirm_password = __value, confirm_password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "logbutton");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn btn-primary");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\Login.razor"
                                                  PostUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Inscription");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\Login.razor"
     if (bool_create_user == true)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "<h1>User cree</h1>");
#nullable restore
#line 24 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\Login.razor"
        }
        else if (bool_create_user == false)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(40, "<h1>les mots de passes saisies sont diff??rents</h1>");
#nullable restore
#line 28 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\Login.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\Login.razor"
       
    public string login;
    public string password;
    public string confirm_password;
    public bool bool_create_user = false;


    public async Task PostUser()
    {
        User user = new User(login, password);
        if(password == confirm_password)
        {
            bool_create_user = true;
            using var response = await Http.PostAsJsonAsync("https://localhost:5001/User", user);
        }
        else
        {
            bool_create_user = false;
        }
    }
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
