#pragma checksum "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "154f61961425f1fe7779da173b75dfed086b1b76"
// <auto-generated/>
#pragma warning disable 1591
namespace CRUDProject5.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\_Imports.razor"
using CRUDProject5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\_Imports.razor"
using CRUDProject5.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "b-3gfqja86bc");
            __builder.OpenComponent<CRUDProject5.Shared.Navbar>(2);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "page");
            __builder.AddAttribute(6, "b-3gfqja86bc");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "b-3gfqja86bc");
            __builder.AddContent(9, 
#nullable restore
#line 9 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
