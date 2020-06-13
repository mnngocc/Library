#pragma checksum "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditVideo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8971cf5a67ab6f4314350600d5abebdee0310247"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Assets_EditVideo), @"mvc.1.0.view", @"/Areas/Admin/Views/Assets/EditVideo.cshtml")]
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
#line 1 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditVideo.cshtml"
using Library.Models.Catalog;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8971cf5a67ab6f4314350600d5abebdee0310247", @"/Areas/Admin/Views/Assets/EditVideo.cshtml")]
    public class Areas_Admin_Views_Assets_EditVideo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Areas.Admin.Models.Assets.VideoDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditVideo.cshtml"
  
    ViewData["Title"] = "Edit Book";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Edit Video</h2>\r\n<div class=\"container\">\r\n    <form method=\"post\"");
            BeginWriteAttribute("action", " action=\"", 265, "\"", 314, 2);
            WriteAttributeValue("", 274, "/Admin/Assets/UpdateVideo/", 274, 26, true);
#nullable restore
#line 10 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditVideo.cshtml"
WriteAttributeValue("", 300, Model.AssetId, 300, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" enctype=\"multipart/form-data\">\r\n        <div class=\"jumbotron\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-3\">\r\n                    <div>\r\n                        <img class=\"detailImage\"");
            BeginWriteAttribute("src", " src=\"", 527, "\"", 548, 1);
#nullable restore
#line 15 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditVideo.cshtml"
WriteAttributeValue("", 533, Model.ImageUrl, 533, 15, false);

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
            BeginWriteAttribute("value", " value=\"", 825, "\"", 847, 1);
#nullable restore
#line 22 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditVideo.cshtml"
WriteAttributeValue("", 833, Model.AssetId, 833, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></>\r\n                    <label>Title: </label>\r\n                    <input name=\"Title\" type=\"text\" id=\"txtTitle\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 984, "\"", 1004, 1);
#nullable restore
#line 24 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditVideo.cshtml"
WriteAttributeValue("", 992, Model.Title, 992, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                    <label>Author</label>\r\n                    <input name=\"AuthorOrDirector\" type=\"text\" id=\"txtAuthor\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1153, "\"", 1184, 1);
#nullable restore
#line 27 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditVideo.cshtml"
WriteAttributeValue("", 1161, Model.AuthorOrDirector, 1161, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></>\r\n\r\n                    <label>Status</label>\r\n                    <input readonly type=\"text\" id=\"txtStatus\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1319, "\"", 1340, 1);
#nullable restore
#line 30 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditVideo.cshtml"
WriteAttributeValue("", 1327, Model.Status, 1327, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></>\r\n\r\n                    <label>Year</label>\r\n                    <input name=\"Year\" type=\"number\" id=\"txtYear\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1476, "\"", 1495, 1);
#nullable restore
#line 33 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditVideo.cshtml"
WriteAttributeValue("", 1484, Model.Year, 1484, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                           min=\"0\" max=\"9999\"></>\r\n\r\n                    <label>Number of copies</label>\r\n                    <input name=\"NumberOfCopies\" type=\"number\" id=\"txtNumOfCopies\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1707, "\"", 1736, 1);
#nullable restore
#line 37 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditVideo.cshtml"
WriteAttributeValue("", 1715, Model.NumberOfCopies, 1715, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

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
                                       class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2334, "\"", 2353, 1);
#nullable restore
#line 53 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\EditVideo.cshtml"
WriteAttributeValue("", 2342, Model.Cost, 2342, 11, false);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Areas.Admin.Models.Assets.VideoDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
