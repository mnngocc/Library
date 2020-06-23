#pragma checksum "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\ListVideo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f768991f561e80f8ebb44bf91abe47fd9f062592"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Assets_ListVideo), @"mvc.1.0.view", @"/Areas/Admin/Views/Assets/ListVideo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f768991f561e80f8ebb44bf91abe47fd9f062592", @"/Areas/Admin/Views/Assets/ListVideo.cshtml")]
    public class Areas_Admin_Views_Assets_ListVideo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\ListVideo.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<link href=\"//maxcdn.bootstrapcdn.com/font-awesome/4.1.0/css/font-awesome.min.css\" stype=\"style/css\" rel=\"stylesheet\">\r\n<link href=\"https://fonts.googleapis.com/css?family=Coda\" rel=\"stylesheet\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f768991f561e80f8ebb44bf91abe47fd9f0625923859", async() => {
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
        List videos
    </h3>
    <br />
    <a class=""btn btn-lg btn-success"" role=""button"" href=""/Admin/Assets/AddVideo"" >Add a new video</a>
    <br />
    <br />
    <div id=""assetsTable"">
        <table class=""table table-condensed"" id="" catalogIndexTable"">
            <thead>
                <tr>
                    <th>Image</th>
                    <th>Title</th>
                    <th>Author</th>
                    <th>Location</th>
                   
                    <th>Year</th>
                    <th>Cost</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 35 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\ListVideo.cshtml"
                 foreach (var asset in Model.Videos)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"assetRow\">\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1142, "\"", 1150, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1182, "\"", 1222, 2);
            WriteAttributeValue("", 1189, "/Admin/Assets/EditVideo/", 1189, 24, true);
#nullable restore
#line 40 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\ListVideo.cshtml"
WriteAttributeValue("", 1213, asset.Id, 1213, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1258, "\"", 1279, 1);
#nullable restore
#line 41 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\ListVideo.cshtml"
WriteAttributeValue("", 1264, asset.ImageURL, 1264, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"imageCell\" />\r\n                        </a>\r\n\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1385, "\"", 1393, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 46 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\ListVideo.cshtml"
                   Write(asset.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1485, "\"", 1493, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 49 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\ListVideo.cshtml"
                   Write(asset.AuthorOrDirector);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1596, "\"", 1604, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 52 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\ListVideo.cshtml"
                   Write(asset.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    \r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1721, "\"", 1729, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 56 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\ListVideo.cshtml"
                   Write(asset.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1820, "\"", 1828, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 59 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\ListVideo.cshtml"
                   Write(asset.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1919, "\"", 1927, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a class=\"btn btn-lg btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1987, "\"", 2024, 2);
            WriteAttributeValue("", 1994, "/Admin/Assets/Delete/", 1994, 21, true);
#nullable restore
#line 62 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\ListVideo.cshtml"
WriteAttributeValue("", 2015, asset.Id, 2015, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 65 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Assets\ListVideo.cshtml"
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
