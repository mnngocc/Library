#pragma checksum "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95f1b7b048b56e9be2d1f752746eaa1b7b4de8c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Patron_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Patron/Detail.cshtml")]
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
#line 1 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
using Library.Models.Patron;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95f1b7b048b56e9be2d1f752746eaa1b7b4de8c7", @"/Areas/Admin/Views/Patron/Detail.cshtml")]
    public class Areas_Admin_Views_Patron_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Patron.PatronDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/Employee/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""header clearfix detailHeading"">
        <h2 class=""text-muted"">Patron Information</h2>
    </div>
    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div>
                    <h2>");
#nullable restore
#line 16 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                   Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                                    Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <div class=\"patronContact\">\r\n                        <div id=\"patronTel\">Library Card ID: ");
#nullable restore
#line 18 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                                                        Write(Model.LibraryCardId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div id=\"patronAddress\">Address: ");
#nullable restore
#line 19 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                                                    Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div id=\"patronTel\">Telephone: ");
#nullable restore
#line 20 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                                                  Write(Model.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div id=\"patronDate\">Member Since: ");
#nullable restore
#line 21 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                                                      Write(Model.MemberSince);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div id=\"patronLibrary\">Home Library: ");
#nullable restore
#line 22 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                                                         Write(Model.HomeLibrary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 23 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                         if (@Model.OverdueFees > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div id=\"patronHasFees\">Current Fees Due: $");
#nullable restore
#line 25 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                                                                  Write(Model.OverdueFees);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 26 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div id=\"patronNoFees\">No Fees Currently Due.</div>\r\n");
#nullable restore
#line 30 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <h4>Assets Currently Checked Out</h4>\r\n");
#nullable restore
#line 37 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                 if (@Model.AssetsCheckedOut.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"patronAssets\">\r\n                        <ul>\r\n");
#nullable restore
#line 41 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                             foreach (var checkout in @Model.AssetsCheckedOut)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    ");
#nullable restore
#line 44 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                               Write(checkout.LibraryAsset.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - (Library Asset ID: ");
#nullable restore
#line 44 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                                                                                 Write(checkout.LibraryAsset.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                                    <ul>\r\n                                        <li>\r\n                                            Since: ");
#nullable restore
#line 47 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                                              Write(checkout.Since);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </li>\r\n                                        <li>\r\n                                            Due: ");
#nullable restore
#line 50 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                                            Write(checkout.Until);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </li>\r\n                                    </ul>\r\n                                </li>\r\n");
#nullable restore
#line 54 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 57 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>No items currently checked out.</div>\r\n");
#nullable restore
#line 61 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n                <h4>Assets Currently On Hold</h4>\r\n");
#nullable restore
#line 67 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                 if (@Model.Holds.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"patronHolds\">\r\n                        <ul>\r\n");
#nullable restore
#line 71 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                             foreach (var hold in @Model.Holds)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 73 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                               Write(hold.LibraryAsset.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Placed ");
#nullable restore
#line 73 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                                                                 Write(hold.HoldPlaced.ToString("yy-dd-MM - HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 74 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 77 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>No items on hold.</div>\r\n");
#nullable restore
#line 81 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Patron.PatronDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
