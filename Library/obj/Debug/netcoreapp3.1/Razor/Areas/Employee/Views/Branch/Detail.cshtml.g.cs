#pragma checksum "E:\KH2-1920\Framework\Project\Library\Library\Areas\Employee\Views\Branch\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "badf0f58b3a584db4ce0d7bf10ba8324ea7afc4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Employee_Views_Branch_Detail), @"mvc.1.0.view", @"/Areas/Employee/Views/Branch/Detail.cshtml")]
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
#line 1 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Employee\Views\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Employee\Views\_ViewImports.cshtml"
using Library.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Employee\Views\Branch\Detail.cshtml"
using Library.Models.Branch;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"badf0f58b3a584db4ce0d7bf10ba8324ea7afc4b", @"/Areas/Employee/Views/Branch/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Areas/Employee/Views/_ViewImports.cshtml")]
    public class Areas_Employee_Views_Branch_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Branch.BranchDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Employee\Views\Branch\Detail.cshtml"
  
    ViewBag.Title = @Model.BranchName + " Branch";
    Layout = "~/Areas/Employee/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    \r\n    <div class=\"jumbotron\">\r\n        <div class=\"row\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 306, "\"", 327, 1);
#nullable restore
#line 13 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Employee\Views\Branch\Detail.cshtml"
WriteAttributeValue("", 312, Model.ImageUrl, 312, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width:300px; max-height: 450px\" />\r\n        </div>\r\n        <div class=\"row\">\r\n            <h2>");
#nullable restore
#line 16 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Employee\Views\Branch\Detail.cshtml"
           Write(Model.BranchName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"row branchInfo\">\r\n            <div class=\"col-md-8\">\r\n                <div>\r\n\r\n                    <div class=\"branchContact\">\r\n                        <div id=\"branchAddress\">Address: ");
#nullable restore
#line 23 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Employee\Views\Branch\Detail.cshtml"
                                                    Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div id=\"branchTel\">Telephone: ");
#nullable restore
#line 24 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Employee\Views\Branch\Detail.cshtml"
                                                  Write(Model.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div id=\"branchDescription\">\r\n                        <p class=\"caption\">");
#nullable restore
#line 27 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Employee\Views\Branch\Detail.cshtml"
                                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                    <div id=\"branchHours\">\r\n                        <ul>\r\n");
#nullable restore
#line 32 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Employee\Views\Branch\Detail.cshtml"
                             foreach (var day in @Model.HoursOpen)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 34 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Employee\Views\Branch\Detail.cshtml"
                               Write(day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 35 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Employee\Views\Branch\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 detailInfo"">
                <table>
                    <tr>
                        <td class=""itemLabel"">Date Opened: </td>
                        <td class=""itemValue"">");
#nullable restore
#line 44 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Employee\Views\Branch\Detail.cshtml"
                                         Write(Model.BranchOpenedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"itemLabel\">Number Of Patrons: </td>\r\n                        <td class=\"itemValue\">");
#nullable restore
#line 48 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Employee\Views\Branch\Detail.cshtml"
                                         Write(Model.NumberOfPatrons);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"itemLabel\">Number of Assets: </td>\r\n                        <td class=\"itemValue\">");
#nullable restore
#line 52 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Employee\Views\Branch\Detail.cshtml"
                                         Write(Model.NumberOfAssets);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"itemLabel\">Value of Assets: </td>\r\n                        <td class=\"itemValue\">$");
#nullable restore
#line 56 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Employee\Views\Branch\Detail.cshtml"
                                          Write(Model.TotalAssetValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Branch.BranchDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
