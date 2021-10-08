#pragma checksum "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\DeletePlayer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cf551bb08ebe9c22f85e43c982d4593dd3512d9"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/deletePlayer")]
    public partial class DeletePlayer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"searchPlayer\"><h1>trouver un joueur avec son id</h1></div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "formId");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "formId1 ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "id");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "id", "floatingInput");
            __builder.AddAttribute(9, "placeholder", "Id du joueur");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\DeletePlayer.razor"
                                                                                                   id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => id = __value, id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "boutonsearchplayer");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\DeletePlayer.razor"
                                             DeletePlayerById

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "delete player");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\DeletePlayer.razor"
       
    public int id;

    protected async Task DeletePlayerById()
    {
        using var response = await Http.DeleteAsync("https://localhost:5001/Player/" + id);
    }

    public class Player
    {
        public int Id { get; set; }

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
