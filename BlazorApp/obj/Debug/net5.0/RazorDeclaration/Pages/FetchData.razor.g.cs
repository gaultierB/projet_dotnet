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
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\FetchData.razor"
       
    private Player[] teams;
    protected override async Task OnInitializedAsync()
    {
        teams = await Http.GetFromJsonAsync<Player[]>("https://localhost:5001/Player/GetBdd");
    }

    public class Player
    {
        public int Id { get; set;}

        public string Name { get; set; }

        public string Firstname { get; set; }

        public int Number { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
