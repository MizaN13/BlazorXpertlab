#pragma checksum "I:\XpertLab\BlazorXpertlab\BlazorAppXpertlab\BlazorAppXpertlab\Client\Pages\Logout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a20b1f801dca95460f037ccb8eef050d5f07c698"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppXpertlab.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "I:\XpertLab\BlazorXpertlab\BlazorAppXpertlab\BlazorAppXpertlab\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "I:\XpertLab\BlazorXpertlab\BlazorAppXpertlab\BlazorAppXpertlab\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "I:\XpertLab\BlazorXpertlab\BlazorAppXpertlab\BlazorAppXpertlab\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "I:\XpertLab\BlazorXpertlab\BlazorAppXpertlab\BlazorAppXpertlab\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "I:\XpertLab\BlazorXpertlab\BlazorAppXpertlab\BlazorAppXpertlab\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "I:\XpertLab\BlazorXpertlab\BlazorAppXpertlab\BlazorAppXpertlab\Client\_Imports.razor"
using BlazorAppXpertlab.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "I:\XpertLab\BlazorXpertlab\BlazorAppXpertlab\BlazorAppXpertlab\Client\_Imports.razor"
using BlazorAppXpertlab.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "I:\XpertLab\BlazorXpertlab\BlazorAppXpertlab\BlazorAppXpertlab\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "I:\XpertLab\BlazorXpertlab\BlazorAppXpertlab\BlazorAppXpertlab\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "I:\XpertLab\BlazorXpertlab\BlazorAppXpertlab\BlazorAppXpertlab\Client\_Imports.razor"
using BlazorAppXpertlab.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "I:\XpertLab\BlazorXpertlab\BlazorAppXpertlab\BlazorAppXpertlab\Client\_Imports.razor"
using BlazorAppXpertlab.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/logout")]
    public partial class Logout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "I:\XpertLab\BlazorXpertlab\BlazorAppXpertlab\BlazorAppXpertlab\Client\Pages\Logout.razor"
       

    protected override async Task OnInitializedAsync()
    {
        await AuthService.Logout();
        NavigationManager.NavigateTo("/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
    }
}
#pragma warning restore 1591
