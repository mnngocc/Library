#pragma checksum "E:\HK2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\AddVideo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d378bc93d3ede89c876bf8901d83a995691abe0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Assets_AddVideo), @"mvc.1.0.view", @"/Areas/Admin/Views/Assets/AddVideo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d378bc93d3ede89c876bf8901d83a995691abe0e", @"/Areas/Admin/Views/Assets/AddVideo.cshtml")]
    public class Areas_Admin_Views_Assets_AddVideo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Data.Models.LibraryAsset>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\HK2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\AddVideo.cshtml"
  
    ViewData["Title"] = "AddBook";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""container"">
    <form method=""post"" action=""/Admin/Assets/CreateVideo"" enctype=""multipart/form-data"">

        <div class=""jumbotron"">
            <div class=""row"">
                <div class=""col-md-3"">
                    <div>
                        <label>Image: </label>
                        <input");
            BeginWriteAttribute("value", " value=\"", 476, "\"", 484, 0);
            EndWriteAttribute();
            WriteLiteral(@" ID=""ImageUrl"" asp-for=""ImageUrl"" Name=""ImageUrl""
                               class=""form-control"" type=""file"" />
                    </div>
                </div>
                <div class=""col-md-3"">
                    <label>Title: </label>
                    <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 778, "\"", 786, 0);
            EndWriteAttribute();
            WriteLiteral(" asp-for=\"Title\" Name=\"Title\" class=\"form-control\" placeholder=\"Romeo và Juliet\" />\r\n\r\n                    <label>Director</label>\r\n                    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 957, "\"", 965, 0);
            EndWriteAttribute();
            WriteLiteral(" asp-for=\"Director\" Name=\"Director\" placeholder=\"William Shakespeare\" class=\"form-control\" />\r\n\r\n                    <label>Type</label>\r\n\r\n                    <select asp-for=\"StatusId\" Name=\"StatusId\"");
            BeginWriteAttribute("value", " value=\"", 1168, "\"", 1176, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"">
                        <option value=""1"">Checked Out</option>
                        <option value=""2"">Available</option>
                        <option value=""3"">Lost</option>
                        <option value=""4"">On Hold</option>
                    </select>

                    <label>Year</label>

                    <input type=""number""");
            BeginWriteAttribute("value", " value=\"", 1560, "\"", 1568, 0);
            EndWriteAttribute();
            WriteLiteral(" asp-for=\"Year\" Name=\"Year\" placeholder=\"1597\" class=\"form-control\" min=\"0\" max=\"9999\" />\r\n\r\n                    <label>Number of copies</label>\r\n\r\n                    <input type=\"number\" placeholder=\"5\"");
            BeginWriteAttribute("value", " value=\"", 1773, "\"", 1781, 0);
            EndWriteAttribute();
            WriteLiteral(@" asp-for=""NumberOfCopies"" Name=""NumberOfCopies"" class=""form-control"" />
                    <br />
                </div>
                <div class=""col-md-6 detailInfo"">
                    <table>
                   
                        <tr>
                            <td class=""itemLabel"">

                                <label> Replacement Cost ($):</label>
                                <br />
                            </td>
                            <td class=""itemValue"">

                                <input name=""Cost"" type=""number"" id=""txtCost"" step=""0.01""
                                       class=""form-control"" value=""20"" />
                                <br />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-4""></div>
                <div class=""col-md-4"">
                    <p>
                        <i");
            WriteLiteral("nput class=\"btn btn-lg btn-info\" type=\"submit\" value=\"Save\" />\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </form>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Data.Models.LibraryAsset> Html { get; private set; }
    }
}
#pragma warning restore 1591
