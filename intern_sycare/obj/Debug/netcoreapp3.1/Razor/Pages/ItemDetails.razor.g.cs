#pragma checksum "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\Pages\ItemDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "313d7b63ca9fd0c5cd922b866f1defcecf644a6b"
// <auto-generated/>
#pragma warning disable 1591
namespace intern_sycare.Pages
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
#nullable restore
#line 2 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\Pages\ItemDetails.razor"
using Project.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/itemdetails/{text}")]
    public partial class ItemDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "section_itemdetails");
            __builder.AddMarkupContent(2, "\r\n\r\n    \r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"top_area\">\r\n        <span id=\"left_arrow\"> &#8592; </span>\r\n        <span id=\"left_arrow_text\"> Item Details </span>\r\n    </div>\r\n\r\n\r\n");
#nullable restore
#line 14 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\Pages\ItemDetails.razor"
     if(item_to_vew != null){


#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "item_list_container");
            __builder.AddMarkupContent(7, "\r\n\r\n        ");
            __builder.OpenElement(8, "figure");
            __builder.AddAttribute(9, "class", "middle_side");
            __builder.AddAttribute(10, "id", "itd_item_name");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.AddMarkupContent(12, "<span class=\"label\"> Item Name </span>\r\n            ");
            __builder.OpenElement(13, "span");
            __builder.AddAttribute(14, "class", "text");
            __builder.AddContent(15, " ");
            __builder.AddContent(16, 
#nullable restore
#line 20 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\Pages\ItemDetails.razor"
                                 item_to_vew.name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n        ");
            __builder.OpenElement(20, "figure");
            __builder.AddAttribute(21, "class", "middle_side");
            __builder.AddAttribute(22, "id", "itd_item_category");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.AddMarkupContent(24, "<span class=\"label\"> Item Category </span>\r\n            ");
            __builder.OpenElement(25, "span");
            __builder.AddAttribute(26, "class", "text");
            __builder.AddContent(27, " ");
            __builder.AddContent(28, 
#nullable restore
#line 25 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\Pages\ItemDetails.razor"
                                 item_to_vew.item_category

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        \r\n        ");
            __builder.OpenElement(32, "figure");
            __builder.AddAttribute(33, "class", "middle_side");
            __builder.AddAttribute(34, "id", "itd_item_quantity");
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.AddMarkupContent(36, "<span class=\"label\"> Item Quantity </span>\r\n            ");
            __builder.OpenElement(37, "span");
            __builder.AddAttribute(38, "class", "text");
            __builder.AddContent(39, " ");
            __builder.AddContent(40, 
#nullable restore
#line 30 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\Pages\ItemDetails.razor"
                                 item_to_vew.quantity

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(41, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        \r\n        ");
            __builder.OpenElement(44, "figure");
            __builder.AddAttribute(45, "class", "middle_side");
            __builder.AddAttribute(46, "id", "itd_unit");
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.AddMarkupContent(48, "<span class=\"label\"> Unit </span>\r\n            ");
            __builder.OpenElement(49, "span");
            __builder.AddAttribute(50, "class", "text");
            __builder.AddContent(51, " ");
            __builder.AddContent(52, 
#nullable restore
#line 35 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\Pages\ItemDetails.razor"
                                 item_to_vew.item_unit

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(53, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        \r\n        ");
            __builder.OpenElement(56, "figure");
            __builder.AddAttribute(57, "class", "middle_side");
            __builder.AddAttribute(58, "id", "itd_net_amount");
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.AddMarkupContent(60, "<span class=\"label\"> Net Amount </span>\r\n            ");
            __builder.OpenElement(61, "span");
            __builder.AddAttribute(62, "class", "text");
            __builder.AddContent(63, "  ");
            __builder.AddContent(64, 
#nullable restore
#line 40 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\Pages\ItemDetails.razor"
                                  item_to_vew.net_amount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(65, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n        \r\n        ");
            __builder.OpenElement(68, "figure");
            __builder.AddAttribute(69, "class", "middle_side");
            __builder.AddAttribute(70, "id", "itd_tax");
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.AddMarkupContent(72, "<span class=\"label\"> Tax % </span>\r\n            ");
            __builder.OpenElement(73, "span");
            __builder.AddAttribute(74, "class", "text");
            __builder.AddContent(75, " ");
            __builder.AddContent(76, 
#nullable restore
#line 45 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\Pages\ItemDetails.razor"
                                 item_to_vew.tax

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(77, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n        \r\n        ");
            __builder.AddMarkupContent(80, "<figure class=\"middle_side\" id=\"itd_unit\">\r\n            <span class=\"label\"> Unit </span>\r\n            <span class=\"text\"> 1 </span>\r\n        </figure>\r\n        \r\n        ");
            __builder.OpenElement(81, "figure");
            __builder.AddAttribute(82, "class", "middle_side");
            __builder.AddAttribute(83, "id", "itd_discount");
            __builder.AddMarkupContent(84, "\r\n            ");
            __builder.AddMarkupContent(85, "<span class=\"label\"> Discount % </span>\r\n            ");
            __builder.OpenElement(86, "span");
            __builder.AddAttribute(87, "class", "text");
            __builder.AddContent(88, " ");
            __builder.AddContent(89, 
#nullable restore
#line 55 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\Pages\ItemDetails.razor"
                                 item_to_vew.discount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(90, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n        \r\n        ");
            __builder.OpenElement(93, "figure");
            __builder.AddAttribute(94, "class", "middle_side");
            __builder.AddAttribute(95, "id", "itd_gross_amount");
            __builder.AddMarkupContent(96, "\r\n            ");
            __builder.AddMarkupContent(97, "<span class=\"label\"> Gross Amount </span>\r\n            ");
            __builder.OpenElement(98, "span");
            __builder.AddAttribute(99, "class", "text");
            __builder.AddContent(100, " ");
            __builder.AddContent(101, 
#nullable restore
#line 60 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\Pages\ItemDetails.razor"
                                 item_to_vew.gross_amount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(102, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n        \r\n        ");
            __builder.OpenElement(105, "figure");
            __builder.AddAttribute(106, "class", "bottom_side");
            __builder.AddAttribute(107, "id", "itd_description");
            __builder.AddMarkupContent(108, "\r\n\r\n            ");
            __builder.AddMarkupContent(109, "<span class=\"label\"> Description </span>\r\n            ");
            __builder.OpenElement(110, "span");
            __builder.AddAttribute(111, "id", "description_text");
            __builder.AddMarkupContent(112, "\r\n\r\n                ");
            __builder.OpenElement(113, "strong");
            __builder.AddContent(114, " ");
            __builder.AddContent(115, 
#nullable restore
#line 68 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\Pages\ItemDetails.razor"
                          item_to_vew.description

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(116, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, " \r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n");
#nullable restore
#line 74 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\Pages\ItemDetails.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(121, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\pc\Desktop\Lehn\intern_sycare\intern_sycare\Pages\ItemDetails.razor"
      
    [Parameter]
    public string Text {get;set;}
    Item item_to_vew = null;

    protected override void OnInitialized(){
        Text = Text ?? "1";
        item_to_vew = _idatahander.GetItem(Text);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Project.Handler.IDataHandler _idatahander { get; set; }
    }
}
#pragma warning restore 1591
