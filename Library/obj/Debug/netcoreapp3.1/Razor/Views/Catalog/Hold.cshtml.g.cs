#pragma checksum "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Catalog\Hold.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24a6f20e2a69cd442648a07753ba160a09885179"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Hold), @"mvc.1.0.view", @"/Views/Catalog/Hold.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\_ViewImports.cshtml"
using Library.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Catalog\Hold.cshtml"
using Library.Models.CheckoutModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24a6f20e2a69cd442648a07753ba160a09885179", @"/Views/Catalog/Hold.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Hold : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.CheckoutModels.CheckoutModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Catalog\Hold.cshtml"
  
    ViewData["Title"] = "Hold";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2>Hold</h2>
<div class=""container"">
    <div class=""header clearfix detailHeading"">
        <h2 class=""text-muted"">Place Hold on Library Item</h2>
    </div>

    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div>
                    <p id=""itemTitle"">");
#nullable restore
#line 18 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Catalog\Hold.cshtml"
                                 Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <img class=\"detailImage\"");
            BeginWriteAttribute("src", " src=\"", 594, "\"", 615, 1);
#nullable restore
#line 19 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Catalog\Hold.cshtml"
WriteAttributeValue("", 600, Model.ImageUrl, 600, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
            WriteLiteral("            <div class=\"col-md-9\">\r\n                <p>There are currently ");
#nullable restore
#line 26 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Catalog\Hold.cshtml"
                                  Write(Model.HoldCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" holds in the queue for this item.</p>\r\n");
#nullable restore
#line 28 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Catalog\Hold.cshtml"
                 using (Html.BeginForm("PlaceHold", "Catalog", FormMethod.Post))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Catalog\Hold.cshtml"
               Write(Html.HiddenFor(a => a.AssetId));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <strong>Please insert a Library Card ID.</strong>\r\n                        \r\n                        ");
#nullable restore
#line 34 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Catalog\Hold.cshtml"
                   Write(Html.TextBoxFor(a => a.LibraryCardId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </div>\r\n                    <br />\r\n                    <div>\r\n                        <button type=\"submit\" class=\"btn btn-info btn-lg\">Place Hold</button>\r\n                    </div>\r\n");
#nullable restore
#line 41 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Catalog\Hold.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.CheckoutModels.CheckoutModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
