#pragma checksum "E:\HK2-1920\Framework\LIBRARY\Library\Library\Areas\Admin\Views\Branches\ListBranch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83a846685607035c2ec3e15b98b71a4bd3e1f4cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Branches_ListBranch), @"mvc.1.0.view", @"/Areas/Admin/Views/Branches/ListBranch.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83a846685607035c2ec3e15b98b71a4bd3e1f4cd", @"/Areas/Admin/Views/Branches/ListBranch.cshtml")]
    public class Areas_Admin_Views_Branches_ListBranch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Areas\Admin\Views\Branches\ListBranch.cshtml"
  
    ViewData["Title"] = "Branches";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<link href=\"//maxcdn.bootstrapcdn.com/font-awesome/4.1.0/css/font-awesome.min.css\" stype=\"style/css\" rel=\"stylesheet\">\r\n<link href=\"https://fonts.googleapis.com/css?family=Coda\" rel=\"stylesheet\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "83a846685607035c2ec3e15b98b71a4bd3e1f4cd3879", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div id=""assets"">
    <h3>
        List branches
    </h3>
    <br />
    <a class=""btn btn-lg btn-success"" href=""/Admin/Branches/AddBranch"">New branch</a>
    <br />
    <br />
    <br />
    <div id=""assetsTable"">
        <table class=""table table-condensed"" id="" catalogIndexTable"">
            <thead>
                <tr>
                    <th>ImageURL</th>
                    <th>Name</th>
                    <th>Address</th>
                    <th>Telephone</th>
                    <th>Description</th>
                    <th>Open date</th>

                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 35 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Areas\Admin\Views\Branches\ListBranch.cshtml"
                 foreach (var item in Model.Branches)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"assetRow\">\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1137, "\"", 1145, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1177, "\"", 1219, 2);
            WriteAttributeValue("", 1184, "/Admin/Branches/EditBranch/", 1184, 27, true);
#nullable restore
#line 40 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Areas\Admin\Views\Branches\ListBranch.cshtml"
WriteAttributeValue("", 1211, item.Id, 1211, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1255, "\"", 1275, 1);
#nullable restore
#line 41 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Areas\Admin\Views\Branches\ListBranch.cshtml"
WriteAttributeValue("", 1261, item.ImageURL, 1261, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"imageCell\" />\r\n                        </a>\r\n\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1381, "\"", 1389, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 46 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Areas\Admin\Views\Branches\ListBranch.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1479, "\"", 1487, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 49 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Areas\Admin\Views\Branches\ListBranch.cshtml"
                   Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1580, "\"", 1588, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 52 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Areas\Admin\Views\Branches\ListBranch.cshtml"
                   Write(item.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1683, "\"", 1691, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 55 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Areas\Admin\Views\Branches\ListBranch.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1788, "\"", 1796, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 58 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Areas\Admin\Views\Branches\ListBranch.cshtml"
                   Write(item.OpenDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1890, "\"", 1898, 0);
            EndWriteAttribute();
            WriteLiteral(" >\r\n                        <a class=\"btn btn-lg btn-danger\" align-item=\"center\"");
            BeginWriteAttribute("href", "\r\n                           href=\"", 1979, "\"", 2045, 2);
            WriteAttributeValue("", 2014, "/Admin/Branches/Delete/", 2014, 23, true);
#nullable restore
#line 62 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Areas\Admin\Views\Branches\ListBranch.cshtml"
WriteAttributeValue("", 2037, item.Id, 2037, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 65 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Areas\Admin\Views\Branches\ListBranch.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
