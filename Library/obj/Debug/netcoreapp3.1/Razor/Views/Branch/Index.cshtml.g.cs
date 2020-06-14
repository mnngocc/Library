#pragma checksum "E:\KH2-1920\Framework\Project\Library\Library\Views\Branch\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "310b298b9944d8c1141395daa2f4da8e70fe97f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Branch_Index), @"mvc.1.0.view", @"/Views/Branch/Index.cshtml")]
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
#line 1 "E:\KH2-1920\Framework\Project\Library\Library\Views\Branch\Index.cshtml"
using Library.Models.Branch;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"310b298b9944d8c1141395daa2f4da8e70fe97f5", @"/Views/Branch/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"987f9efd111bd4275f27aac3a5f9cd492d2329db", @"/Views/_ViewImports.cshtml")]
    public class Views_Branch_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Branch.BranchIndexModel>
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
#line 3 "E:\KH2-1920\Framework\Project\Library\Library\Views\Branch\Index.cshtml"
  
    ViewBag.Title = "Branch Index";
    Layout = "~/Areas/Employee/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h3>Branch Index</h3>
<div id=""branchIndex"">
    <table class=""mdl-data-table mdl-js-data-table mdl-data-table--selectable mdl-shadow--2dp customTable"" id=""branchIndexTable"">
        <thead>
            <tr>
                <th>Branch Name</th>
                <th>Open Now</th>
                <th>Number Of Assets</th>
                <th>Number of Patrons</th>
          
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "E:\KH2-1920\Framework\Project\Library\Library\Views\Branch\Index.cshtml"
             foreach (var branch in Model.Branches)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"strongTd\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "310b298b9944d8c1141395daa2f4da8e70fe97f54868", async() => {
#nullable restore
#line 23 "E:\KH2-1920\Framework\Project\Library\Library\Views\Branch\Index.cshtml"
                                                                                                         Write(branch.BranchName);

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
#line 23 "E:\KH2-1920\Framework\Project\Library\Library\Views\Branch\Index.cshtml"
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
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "E:\KH2-1920\Framework\Project\Library\Library\Views\Branch\Index.cshtml"
               Write(branch.IsOpen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "E:\KH2-1920\Framework\Project\Library\Library\Views\Branch\Index.cshtml"
               Write(branch.NumberOfAssets);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "E:\KH2-1920\Framework\Project\Library\Library\Views\Branch\Index.cshtml"
               Write(branch.NumberOfPatrons);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n            </tr>\r\n");
#nullable restore
#line 29 "E:\KH2-1920\Framework\Project\Library\Library\Views\Branch\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Branch.BranchIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
