// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\arthu\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\arthu\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\arthu\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\arthu\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\arthu\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\arthu\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\arthu\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\arthu\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\arthu\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\arthu\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\arthu\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\arthu\Projet-fullstack-dotnet\BlazorApp\Pages\Post.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/post")]
    public partial class Post : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\arthu\Projet-fullstack-dotnet\BlazorApp\Pages\Post.razor"
       
    Player player = new Player(0, "@name", "@firstname", 11);

    public async Task PostPlayer()

    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\arthu\Projet-fullstack-dotnet\BlazorApp\Pages\Post.razor"
                                       
        using var response = await Http.PostAsJsonAsync("https://localhost:5001/Player/post", player);
        Console.WriteLine(response.ToString());
    }
    public class Player
    {
        public int id { get; set; }

        public string name { get; set; }

        public string firstname { get; set; }

        public int number { get; set; }
        public Player(int id, string name, string firstname, int number)
        {
            this.id = id;
            this.name = name;
            this.firstname = firstname;
            this.number = number;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
