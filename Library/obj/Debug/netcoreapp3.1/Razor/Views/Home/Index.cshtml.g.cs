#pragma checksum "E:\KH2-1920\Framework\Project\Library\Library\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "777659f7a43de18b79dc92de821ceec02a9b1221"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\KH2-1920\Framework\Project\Library\Library\Views\Home\Index.cshtml"
using Library.Areas.Admin.Models.Branches;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\KH2-1920\Framework\Project\Library\Library\Views\Home\Index.cshtml"
using Library.Models.Catalog;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"777659f7a43de18b79dc92de821ceec02a9b1221", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"987f9efd111bd4275f27aac3a5f9cd492d2329db", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Branch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "E:\KH2-1920\Framework\Project\Library\Library\Views\Home\Index.cshtml"
  
    ViewBag.Title = "LIBRARY";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"home-slider owl-carousel\">\r\n\r\n");
#nullable restore
#line 9 "E:\KH2-1920\Framework\Project\Library\Library\Views\Home\Index.cshtml"
     foreach (var branch in Model.Branches)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"slider-item\"");
            BeginWriteAttribute("style", " style=\"", 291, "\"", 344, 5);
            WriteAttributeValue("", 299, "background-image:", 299, 17, true);
            WriteAttributeValue(" ", 316, "url(\'..", 317, 8, true);
#nullable restore
#line 11 "E:\KH2-1920\Framework\Project\Library\Library\Views\Home\Index.cshtml"
WriteAttributeValue("", 324, branch.ImageURL, 324, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 340, "\')", 340, 2, true);
            WriteAttributeValue(" ", 342, ";", 343, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""container"">
                <div class=""row slider-text align-items-center justify-content-center"">
                    <div class=""col-lg-7 text-center col-sm-12 element-animate"">

                        <h1 class=""mb-4""><span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "777659f7a43de18b79dc92de821ceec02a9b12215460", async() => {
#nullable restore
#line 16 "E:\KH2-1920\Framework\Project\Library\Library\Views\Home\Index.cshtml"
                                                                                                                   Write(branch.Name);

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
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "E:\KH2-1920\Framework\Project\Library\Library\Views\Home\Index.cshtml"
                                                                                                WriteLiteral(branch.Id);

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
            WriteLiteral("</span></h1>\r\n                        <p class=\"mb-5 w-75\" style=\"background-color: rgba(0, 0, 0, 0.5); border-radius: 10px\">");
#nullable restore
#line 17 "E:\KH2-1920\Framework\Project\Library\Library\Views\Home\Index.cshtml"
                                                                                                          Write(branch.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 22 "E:\KH2-1920\Framework\Project\Library\Library\Views\Home\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</section>
<!-- END slider -->


<section class=""section bg-light"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-lg-4 element-animate "">
                <div class=""media block-6 d-block text-center"">
                    <div class=""icon mb-3""><span class=""ion-bookmark text-primary""></span></div>
                    
                    <div class=""media-body"">
                        <h3 class=""heading"">Automotive Parts</h3>
                        <p>Even the all-powerful Pointing has no control about the blind texts it is an almost unorthographic.</p>
                    </div>
                </div>

            </div>
            <div class=""col-md-6 col-lg-4 element-animate "">
                <div class=""media block-6 d-block text-center"">
                    <div class=""icon mb-3""><span class=""ion-heart text-primary""></span></div>
                    <div class=""media-body"">
                        <h3 class=""heading"">Maintenance Servi");
            WriteLiteral(@"ces</h3>
                        <p>Even the all-powerful Pointing has no control about the blind texts it is an almost unorthographic.</p>
                    </div>
                </div>

            </div>
            <div class=""col-md-6 col-lg-4 element-animate "">
                <div class=""media block-6 d-block text-center"">
                    <div class=""icon mb-3""><span class=""ion-leaf text-primary""></span></div>
                    <div class=""media-body"">
                        <h3 class=""heading"">Green Energy</h3>
                        <p>Even the all-powerful Pointing has no control about the blind texts it is an almost unorthographic.</p>
                    </div>
                </div>

            </div>
        </div>
    </div>
</section>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
