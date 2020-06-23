#pragma checksum "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a2e691dde1a85305b6c70f70e6359d8f679540b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Assets_EditBook), @"mvc.1.0.view", @"/Areas/Admin/Views/Assets/EditBook.cshtml")]
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
#line 1 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditBook.cshtml"
using Library.Models.Catalog;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a2e691dde1a85305b6c70f70e6359d8f679540b", @"/Areas/Admin/Views/Assets/EditBook.cshtml")]
    public class Areas_Admin_Views_Assets_EditBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Areas.Admin.Models.Assets.BookDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditBook.cshtml"
  
    ViewData["Title"] = "Edit Book";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Edit Book</h2>\r\n<div class=\"container\">\r\n    <form method=\"post\"");
            BeginWriteAttribute("action", " action=\"", 263, "\"", 307, 2);
            WriteAttributeValue("", 272, "/Admin/Assets/Update/", 272, 21, true);
#nullable restore
#line 10 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditBook.cshtml"
WriteAttributeValue("", 293, Model.AssetId, 293, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" enctype=\"multipart/form-data\">\r\n        <div class=\"jumbotron\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-3\">\r\n                    <div>\r\n                        <img class=\"detailImage\"");
            BeginWriteAttribute("src", " src=\"", 520, "\"", 541, 1);
#nullable restore
#line 15 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditBook.cshtml"
WriteAttributeValue("", 526, Model.ImageUrl, 526, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div>
                        <input type=""file"" name=""ImageUrl""></>
                    </div>
                </div>
                <div class=""col-md-3"">
                    <input type=""text"" hidden name=""AssetId""");
            BeginWriteAttribute("value", " value=\"", 818, "\"", 840, 1);
#nullable restore
#line 22 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditBook.cshtml"
WriteAttributeValue("", 826, Model.AssetId, 826, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></>\r\n                    <label>Title: </label>\r\n                    <input name=\"Title\" type=\"text\" id=\"txtTitle\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 977, "\"", 997, 1);
#nullable restore
#line 24 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditBook.cshtml"
WriteAttributeValue("", 985, Model.Title, 985, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                    <label>Author</label>\r\n                    <input name=\"AuthorOrDirector\" type=\"text\" id=\"txtAuthor\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1146, "\"", 1177, 1);
#nullable restore
#line 27 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditBook.cshtml"
WriteAttributeValue("", 1154, Model.AuthorOrDirector, 1154, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></>\r\n\r\n                    <label>Status</label>\r\n                    <input readonly type=\"text\" id=\"txtStatus\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1312, "\"", 1333, 1);
#nullable restore
#line 30 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditBook.cshtml"
WriteAttributeValue("", 1320, Model.Status, 1320, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></>\r\n\r\n                    <label>Year</label>\r\n                    <input name=\"Year\" type=\"number\" id=\"txtYear\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1469, "\"", 1488, 1);
#nullable restore
#line 33 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditBook.cshtml"
WriteAttributeValue("", 1477, Model.Year, 1477, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                           min=""0"" max=""9999""></>

                    
                    <br />
                </div>
                <div class=""col-md-6 detailInfo"">
                    <table>
                        <tr>
                            <td class=""itemLabel"">
                                <label>ISBN:</label>
                                <br />
                            </td>
                            <td class=""itemValue"">
                                <input readonly type=""number"" id=""txtISBN""
                                       class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2096, "\"", 2115, 1);
#nullable restore
#line 48 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditBook.cshtml"
WriteAttributeValue("", 2104, Model.ISBN, 2104, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                <br />
                            </td>
                            
                        </tr>
                        <tr>
                            <td class=""itemLabel"">
                                <label>Call Number:</label>
                                <br />
                            </td>
                            <td class=""itemValue"">
                                <input name=""Dewey"" type=""text"" id=""txtDewey""
                                       class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2665, "\"", 2685, 1);
#nullable restore
#line 60 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditBook.cshtml"
WriteAttributeValue("", 2673, Model.Dewey, 2673, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td class=""itemLabel"">

                                <label> Replacement Cost ($):</label>
                                <br />
                            </td>
                            <td class=""itemValue"">

                                <input name=""Cost"" type=""number"" id=""txtCost"" step=""0.01""
                                       class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 3231, "\"", 3250, 1);
#nullable restore
#line 73 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditBook.cshtml"
WriteAttributeValue("", 3239, Model.Cost, 3239, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                <br />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
            <div class=""row"">

                <div class=""col-md-4"">
                    <p>
                        <input class=""btn btn-lg btn-info"" type=""submit"" value=""Save"" />
                    </p>
                </div>
            </div>
        </div>

    </form>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Areas.Admin.Models.Assets.BookDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
