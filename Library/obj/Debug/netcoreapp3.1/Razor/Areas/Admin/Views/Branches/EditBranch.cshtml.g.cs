#pragma checksum "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Branches\EditBranch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24df43a8e3815ce6a29271c06c0714cfeae8c526"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Branches_EditBranch), @"mvc.1.0.view", @"/Areas/Admin/Views/Branches/EditBranch.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24df43a8e3815ce6a29271c06c0714cfeae8c526", @"/Areas/Admin/Views/Branches/EditBranch.cshtml")]
    public class Areas_Admin_Views_Branches_EditBranch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Areas.Admin.Models.Branches.BranchDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Branches\EditBranch.cshtml"
  
    ViewData["Title"] = "EditBranch";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Edit Branch</h2>\r\n<div class=\"container\">\r\n    <form method=\"post\"");
            BeginWriteAttribute("action", " action=\"", 241, "\"", 282, 2);
            WriteAttributeValue("", 250, "/Admin/Branches/Update/", 250, 23, true);
#nullable restore
#line 10 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Branches\EditBranch.cshtml"
WriteAttributeValue("", 273, Model.Id, 273, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" enctype=\"multipart/form-data\">\r\n        <div class=\"jumbotron\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-3\">\r\n                    <div>\r\n                        <img class=\"detailImage\"");
            BeginWriteAttribute("src", " src=\"", 495, "\"", 516, 1);
#nullable restore
#line 15 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Branches\EditBranch.cshtml"
WriteAttributeValue("", 501, Model.ImageURL, 501, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div>
                        <input type=""file"" name=""ImageURL"" ></>
                    </div>
                </div>
                <div class=""col-md-3"">
                    <input type=""text"" style=""display:none"" name=""Id""");
            BeginWriteAttribute("value", " value=\"", 803, "\"", 820, 1);
#nullable restore
#line 22 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Branches\EditBranch.cshtml"
WriteAttributeValue("", 811, Model.Id, 811, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"></>\r\n                    <label>Name: </label>\r\n                    <input type=\"text\" name=\"Name\"");
            BeginWriteAttribute("value", " value=\"", 941, "\"", 960, 1);
#nullable restore
#line 24 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Branches\EditBranch.cshtml"
WriteAttributeValue("", 949, Model.Name, 949, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"></>\r\n                    <label>Address: </label>\r\n                    <input name=\"Address\" type=\"text\" id=\"txtAddress\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1124, "\"", 1146, 1);
#nullable restore
#line 26 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Branches\EditBranch.cshtml"
WriteAttributeValue("", 1132, Model.Address, 1132, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                    <label>Telephone</label>\r\n                    <input name=\"Telephone\" type=\"text\" id=\"txtTelephone\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1294, "\"", 1318, 1);
#nullable restore
#line 29 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Branches\EditBranch.cshtml"
WriteAttributeValue("", 1302, Model.Telephone, 1302, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></>\r\n\r\n                    <label>Description</label>\r\n                    <textarea name=\"Description\" rows=\"5\" type=\"text\" id=\"txtDescription\" class=\"form-control\">");
#nullable restore
#line 32 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Branches\EditBranch.cshtml"
                                                                                                          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n\r\n                    <label>Open Date</label>\r\n\r\n                    <input name=\"OpenDate\" type=\"date\" id=\"txtOpenDate\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1659, "\"", 1705, 1);
#nullable restore
#line 36 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Branches\EditBranch.cshtml"
WriteAttributeValue("", 1667, Model.OpenDate.ToString("yyyy-MM-dd"), 1667, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></>

                    <br />
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Areas.Admin.Models.Branches.BranchDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
