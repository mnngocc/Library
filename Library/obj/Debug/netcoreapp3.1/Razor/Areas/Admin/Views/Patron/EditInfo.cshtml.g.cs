#pragma checksum "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\EditInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efbc4f16791a9bee1e2a79f459537959d4a5c32c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Patron_EditInfo), @"mvc.1.0.view", @"/Areas/Admin/Views/Patron/EditInfo.cshtml")]
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
#line 7 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\EditInfo.cshtml"
using Library.Models.Patron;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efbc4f16791a9bee1e2a79f459537959d4a5c32c", @"/Areas/Admin/Views/Patron/EditInfo.cshtml")]
    public class Areas_Admin_Views_Patron_EditInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PatronDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\EditInfo.cshtml"
  
    ViewData["Title"] = "EditInfo";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"jumbotron\">\r\n\r\n        <div class=\"row\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 264, "\"", 272, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h2 class=\"text-muted\">Edit Information</h2>\r\n                <h4 class=\"text-muted\">(User ID: ");
#nullable restore
#line 16 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\EditInfo.cshtml"
                                            Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h4>\r\n            </div>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efbc4f16791a9bee1e2a79f459537959d4a5c32c4579", async() => {
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    <label>Library Card ID: </label>\r\n                    <input type=\"text\" readonly");
                BeginWriteAttribute("value", " value=\"", 713, "\"", 741, 1);
#nullable restore
#line 23 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\EditInfo.cshtml"
WriteAttributeValue("", 721, Model.LibraryCardId, 721, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" Name=\"LibraryCardId\" class=\"form-control\" required />\r\n                    <label>First Name: </label>\r\n                    <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 885, "\"", 909, 1);
#nullable restore
#line 25 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\EditInfo.cshtml"
WriteAttributeValue("", 893, Model.FirstName, 893, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" Name=\"FirstName\" class=\"form-control\" required />\r\n\r\n                    <label>Last Name: </label>\r\n                    <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1050, "\"", 1073, 1);
#nullable restore
#line 28 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\EditInfo.cshtml"
WriteAttributeValue("", 1058, Model.LastName, 1058, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" Name=\"LastName\" class=\"form-control\" required />\r\n\r\n                    <label>Email</label>\r\n                    <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1207, "\"", 1227, 1);
#nullable restore
#line 31 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\EditInfo.cshtml"
WriteAttributeValue("", 1215, Model.Email, 1215, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" Name=\"Email\" id=\"email\" class=\"form-control\" required />\r\n\r\n                    <br />\r\n                </div>\r\n\r\n                <div class=\"col-md-4\">\r\n                    <label>Telephone Number</label>\r\n                    <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1474, "\"", 1498, 1);
#nullable restore
#line 38 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\EditInfo.cshtml"
WriteAttributeValue("", 1482, Model.Telephone, 1482, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" Name=\"Telephone\"  class=\"form-control\" required />\r\n\r\n                    <label>Address: </label>\r\n                    <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1638, "\"", 1660, 1);
#nullable restore
#line 41 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\EditInfo.cshtml"
WriteAttributeValue("", 1646, Model.Address, 1646, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" Name=\"Address\" class=\"form-control\" required />\r\n\r\n                    <label>Date of birth: </label>\r\n\r\n                    <input type=\"date\"");
                BeginWriteAttribute("value", " value=\"", 1805, "\"", 1854, 1);
#nullable restore
#line 45 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\EditInfo.cshtml"
WriteAttributeValue("", 1813, Model.DateOfBirth.ToString("yyyy-MM-dd"), 1813, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"  Name=""DateOfBirth"" class=""form-control"" required />
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-3""></div>
                <div class=""col-md-4"">
                    <p>
                        <input class=""btn btn-lg btn-info"" type=""submit"" id=""submit"" value=""Save"" />
                    </p>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 476, "~/Admin/Patron/Update/", 476, 22, true);
#nullable restore
#line 19 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Patron\EditInfo.cshtml"
AddHtmlAttributeValue("", 498, Model.Id, 498, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PatronDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
