#pragma checksum "C:\Users\bthornhill\source\repos\demos\BlazorDemoApp\BlazorDemo\BlazorDemo.Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c9866314ecb2d044bf533a1445b5533d1b8fb41"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDemo.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\bthornhill\source\repos\demos\BlazorDemoApp\BlazorDemo\BlazorDemo.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\bthornhill\source\repos\demos\BlazorDemoApp\BlazorDemo\BlazorDemo.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\bthornhill\source\repos\demos\BlazorDemoApp\BlazorDemo\BlazorDemo.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "C:\Users\bthornhill\source\repos\demos\BlazorDemoApp\BlazorDemo\BlazorDemo.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\bthornhill\source\repos\demos\BlazorDemoApp\BlazorDemo\BlazorDemo.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\bthornhill\source\repos\demos\BlazorDemoApp\BlazorDemo\BlazorDemo.Client\_Imports.razor"
using BlazorDemo.Client;

#line default
#line hidden
#line 7 "C:\Users\bthornhill\source\repos\demos\BlazorDemoApp\BlazorDemo\BlazorDemo.Client\_Imports.razor"
using BlazorDemo.Client.Shared;

#line default
#line hidden
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 28 "C:\Users\bthornhill\source\repos\demos\BlazorDemoApp\BlazorDemo\BlazorDemo.Client\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591