#pragma checksum "E:\HK2-1920\Framework\LIBRARY\Library\Library\Areas\Admin\Views\Assets\AddBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e905ca8afc4e69f1e880849b250aada4ebeef1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Assets_AddBook), @"mvc.1.0.view", @"/Areas/Admin/Views/Assets/AddBook.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e905ca8afc4e69f1e880849b250aada4ebeef1a", @"/Areas/Admin/Views/Assets/AddBook.cshtml")]
    public class Areas_Admin_Views_Assets_AddBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Data.Models.LibraryAsset>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Areas\Admin\Views\Assets\AddBook.cshtml"
  
    ViewData["Title"] = "AddBook";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""container"">
    <form method=""post"" action=""/Admin/Assets/Create"" enctype=""multipart/form-data"">

        <div class=""jumbotron"">
            <div class=""row"">
                <div class=""col-md-3"">
                    <div>
                        <label>Image: </label>
                        <input");
            BeginWriteAttribute("value", " value=\"", 471, "\"", 479, 0);
            EndWriteAttribute();
            WriteLiteral(@" ID=""ImageUrl"" asp-for=""ImageUrl"" Name=""ImageUrl""
                               class=""form-control"" type=""file"" />
                    </div>
                </div>
                <div class=""col-md-3"">
                    <label>Title: </label>
                    <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 773, "\"", 781, 0);
            EndWriteAttribute();
            WriteLiteral(" asp-for=\"Title\" Name=\"Title\" class=\"form-control\" placeholder=\"Romeo và Juliet\" />\r\n\r\n                    <label>Author</label>\r\n                    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 950, "\"", 958, 0);
            EndWriteAttribute();
            WriteLiteral(@" asp-for=""Author"" Name=""Author"" placeholder=""William Shakespeare"" class=""form-control"" />

                    <label>Status</label>

                    <select asp-for=""StatusId"" Name=""StatusId"" value=""2"" class=""form-control"">
                        <option value=""2"">Available</option>
                        <option value=""1"">Checked Out</option>
                        <option value=""3"">Lost</option>
                        <option value=""4"">On Hold</option>
                    </select>

                    <label>Location</label>
        
                    ");
#nullable restore
#line 39 "E:\HK2-1920\Framework\LIBRARY\Library\Library\Areas\Admin\Views\Assets\AddBook.cshtml"
               Write(Html.DropDownList("LocationId", (IEnumerable<SelectListItem>)ViewBag.branchList, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <label>Year</label>\r\n\r\n                    <input type=\"number\"");
            BeginWriteAttribute("value", " value=\"", 1745, "\"", 1753, 0);
            EndWriteAttribute();
            WriteLiteral(" asp-for=\"Year\" Name=\"Year\" placeholder=\"1597\" class=\"form-control\" min=\"0\" max=\"9999\" />\r\n\r\n                    <label>Number of copies</label>\r\n\r\n                    <input type=\"number\" placeholder=\"5\"");
            BeginWriteAttribute("value", " value=\"", 1958, "\"", 1966, 0);
            EndWriteAttribute();
            WriteLiteral(@" asp-for=""NumberOfCopies"" Name=""NumberOfCopies"" class=""form-control"" />
                    <br />
                </div>
                <div class=""col-md-6 detailInfo"">
                    <table>
                        <tr>

                            <td class=""itemLabel"">
                                <label>ISBN:</label>
                                <br />
                            </td>
                            <td class=""itemValue"">
                                <input type=""number""");
            BeginWriteAttribute("value", " value=\"", 2489, "\"", 2497, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""9788877547224"" name=""ISBN"" asp-for=""ISBN"" class=""form-control"" />
                                <br />
                            </td>

                        </tr>



                        <tr>
                            <td class=""itemLabel"">
                                <label>Call Number:</label>
                                <br />
                            </td>
                            <td class=""itemValue"">
                                <input name=""DeweyIndex"" asp-for=""DeweyIndex"" type=""text"" id=""txtDewey""
                                       class=""form-control"" placeholder=""796.175""");
            BeginWriteAttribute("value", " value=\"", 3149, "\"", 3157, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td class=""itemLabel"">

                                <label> Replacement Cost ($):</label>
                                <br />
                            </td>
                            <td class=""itemValue"">

                                <input name=""Cost"" type=""number"" id=""txtCost"" step=""0.01""
                                       class=""form-control"" value=""20"" />
                                <br />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-4""></div>
                <div class=""col-md-4"">
                    <p>
                        <input class=""btn btn-lg btn-info"" type=""submit"" value=""Save"" />
                    </p>
                </div>
 ");
            WriteLiteral("           </div>\r\n        </div>\r\n\r\n    </form>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Data.Models.LibraryAsset> Html { get; private set; }
    }
}
#pragma warning restore 1591
