#pragma checksum "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\Shared\BoxItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74fb75a03355be78453bb6e17332fa112523277d"
// <auto-generated/>
#pragma warning disable 1591
namespace intern_sycare.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\_Imports.razor"
using intern_sycare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\_Imports.razor"
using intern_sycare.Shared;

#line default
#line hidden
#nullable disable
    public partial class BoxItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "box_container");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "h2");
            __builder.AddContent(4, " ");
            __builder.AddContent(5, 
#nullable restore
#line 3 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\Shared\BoxItem.razor"
          Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "p");
            __builder.AddContent(9, " ");
            __builder.AddContent(10, 
#nullable restore
#line 4 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\Shared\BoxItem.razor"
         Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\Shared\BoxItem.razor"
       
    [Parameter]
    public string Title { get; set; }
    [Parameter]
    public string Description { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591