#pragma checksum "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "753b6b10250e1289278453ed6a98ed3220cb8a33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Branch_Detail), @"mvc.1.0.view", @"/Views/Branch/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"753b6b10250e1289278453ed6a98ed3220cb8a33", @"/Views/Branch/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Branch_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Areas.Admin.Models.Branches.BranchDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Branch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml"
  
    ViewBag.Title = "@Model.Branch";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <section class=\"home-slider owl-carousel\">\r\n       \r\n            <div class=\"slider-item\"");
            BeginWriteAttribute("style", " style=\"", 251, "\"", 301, 5);
            WriteAttributeValue("", 259, "background-image:", 259, 17, true);
            WriteAttributeValue(" ", 276, "url(\'", 277, 6, true);
#nullable restore
#line 10 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml"
WriteAttributeValue("", 282, Model.ImageURL, 282, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 297, "\')", 297, 2, true);
            WriteAttributeValue(" ", 299, ";", 300, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""container"">
                    <div class=""row slider-text align-items-center justify-content-center"">
                        <div class=""col-lg-7 text-center col-sm-12 element-animate"">

                            <h1 class=""mb-4""><span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "753b6b10250e1289278453ed6a98ed3220cb8a335649", async() => {
#nullable restore
#line 15 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml"
                                                                                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span></h1>\r\n                            <p class=\"mb-5 w-75\" style=\"background-color: rgba(0, 0, 0, 0.5); border-radius: 10px\">");
#nullable restore
#line 16 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml"
                                                                                                              Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
            </div>       
    </section>

    <section class=""section bg-light"">
        <div class=""container"">
            <div class=""row element-animate""> <h2 style=""color: #fd5f00"">");
#nullable restore
#line 25 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml"
                                                                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></div>\r\n            <div class=\"row branchInfo\">\r\n                <div class=\"col-md-8  element-animate\">\r\n                    <div>\r\n                        <div class=\"branchContact\">\r\n                            <div id=\"branchAddress\">Address: ");
#nullable restore
#line 30 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml"
                                                        Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div id=\"branchTel\">Telephone: ");
#nullable restore
#line 31 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml"
                                                      Write(Model.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div id=\"branchDescription\">\r\n                            <p class=\"caption\">");
#nullable restore
#line 34 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml"
                                          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n\r\n                        <div id=\"branchHours\">\r\n                            <ul>\r\n");
#nullable restore
#line 39 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml"
                                 foreach (var day in @Model.HoursOpen)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
#nullable restore
#line 41 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml"
                                   Write(day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 42 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4 detailInfo  element-animate"">
                    <table>
                        <tr>
                            <td class=""itemLabel"">Date Opened: </td>
                            <td class=""itemValue"">");
#nullable restore
#line 51 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml"
                                             Write(Model.BranchOpenedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td class=\"itemLabel\">Number Of Patrons: </td>\r\n                            <td class=\"itemValue\">");
#nullable restore
#line 55 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml"
                                             Write(Model.NumberOfPatrons);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td class=\"itemLabel\">Number of Assets: </td>\r\n                            <td class=\"itemValue\">");
#nullable restore
#line 59 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml"
                                             Write(Model.NumberOfAssets);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td class=\"itemLabel\">Value of Assets: </td>\r\n                            <td class=\"itemValue\">$");
#nullable restore
#line 63 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml"
                                              Write(Model.TotalAssetValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n            <div class=\"row element-animate\"><h5 style=\"color: #fd5f00\">List asset</h5></div>\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 70 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml"
                 foreach (var title in @Model.AssetsTitle)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 col-lg-3 element-animate \"> \r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "753b6b10250e1289278453ed6a98ed3220cb8a3313110", async() => {
#nullable restore
#line 74 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml"
                                                                      Write(title.Key);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml"
                             WriteLiteral(title.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 76 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Views\Branch\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Areas.Admin.Models.Branches.BranchDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
