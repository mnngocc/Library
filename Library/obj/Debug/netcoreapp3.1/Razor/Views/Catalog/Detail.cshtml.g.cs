#pragma checksum "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e016f4937d7faaddcc951f3cc0cb4ee30a63835"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Detail), @"mvc.1.0.view", @"/Views/Catalog/Detail.cshtml")]
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
#line 1 "E:\KH2-1920\Framework\Project\Library\Library\Views\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\KH2-1920\Framework\Project\Library\Library\Views\_ViewImports.cshtml"
using Library.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
using Library.Models.Catalog;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e016f4937d7faaddcc951f3cc0cb4ee30a63835", @"/Views/Catalog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Catalog.AssetDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Hold", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
  
    ViewBag.Title = @Model.Title;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div class=""container"">
        <div class=""header clearfix detailHeading"">
            
        </div>
        <br />
        <br />
        <br />
        <div class=""jumbotron"">
            <div class=""row"">
                <div class=""col-md-4"">
                    <div>
                        <img class=""detailImage""");
            BeginWriteAttribute("src", " src=\"", 513, "\"", 534, 1);
#nullable restore
#line 21 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
WriteAttributeValue("", 519, Model.ImageUrl, 519, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 300px; \" />\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-4\">\r\n                    <strong style=\"font-size:30px\" id=\"itemTitle\">");
#nullable restore
#line 26 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
                                                             Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                    <p id=\"itemAuthor\">");
#nullable restore
#line 27 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
                                  Write(Model.AuthorOrDirector);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p id=\"itemStatus\">Status: ");
#nullable restore
#line 28 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
                                          Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p id=\"itemType\">Type: ");
#nullable restore
#line 29 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
                                      Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p id=\"itemLocation\">Last Location: ");
#nullable restore
#line 30 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
                                                   Write(Model.CurrentLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 31 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
                     if (Model.Status == "Checked Out")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p id=\"itemPatron\">Checked Out By: ");
#nullable restore
#line 33 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
                                                      Write(Model.PatronName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 34 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 36 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
                     if (@Model.Status != "Lost")
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
                         if (@Model.Status == "Available")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p style=\"color:green\"><strong>Available for Checking Out</strong></p>\r\n");
#nullable restore
#line 41 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
                         if (@Model.Status == "Checked Out")
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e016f4937d7faaddcc951f3cc0cb4ee30a638359223", async() => {
                WriteLiteral("Place Hold");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
                                                                                                                            WriteLiteral(Model.AssetId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n");
#nullable restore
#line 47 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
                         


                    }

                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <strong style=\"color:darkred\">This item has been lost. It cannot be checked out.</strong>\r\n");
#nullable restore
#line 55 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
                        
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""col-md-4 detailInfo"">
                    <table>

                        <tr>
                            <td class=""itemLabel"">Replacement Cost: </td>
                            <td class=""itemValue"">$");
#nullable restore
#line 64 "E:\KH2-1920\Framework\Project\Library\Library\Views\Catalog\Detail.cshtml"
                                              Write(Model.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n<hr />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Catalog.AssetDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
