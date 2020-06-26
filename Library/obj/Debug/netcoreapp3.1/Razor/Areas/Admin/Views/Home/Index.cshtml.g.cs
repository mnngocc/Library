#pragma checksum "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5da8b88377920e4cce6b64573d9a14583fc01f84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5da8b88377920e4cce6b64573d9a14583fc01f84", @"/Areas/Admin/Views/Home/Index.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Home.HomeDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewBag.Title = "index";
    Layout = "~/Areas/admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-9 main-chart"">

        <div class=""row mtbox"">
            <div class=""col-md-2 col-sm-2 col-md-offset-1 box0"">
                <div class=""box1"">
                    <img src=""https://img.icons8.com/dusk/64/000000/book.png"" />
                    <h3>");
#nullable restore
#line 15 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.NumBook);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n                <p>");
#nullable restore
#line 17 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Home\Index.cshtml"
              Write(Model.NumBook);

#line default
#line hidden
#nullable disable
            WriteLiteral(" books in your library!</p>\r\n            </div>\r\n            <div class=\"col-md-2 col-sm-2 box0\">\r\n                <div class=\"box1\">\r\n                    <img src=\"https://img.icons8.com/dusk/64/000000/video-file.png\" />\r\n                    <h3>");
#nullable restore
#line 22 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.NumVideo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n                <p>");
#nullable restore
#line 24 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Home\Index.cshtml"
              Write(Model.NumVideo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" videos in your library!.</p>\r\n            </div>\r\n            <div class=\"col-md-2 col-sm-2 box0\">\r\n                <div class=\"box1\">\r\n                    <img src=\"https://img.icons8.com/dusk/64/000000/reading.png\" />\r\n                    <h3>");
#nullable restore
#line 29 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.NumPatron);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n                <p>You have ");
#nullable restore
#line 31 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Home\Index.cshtml"
                       Write(Model.NumPatron);

#line default
#line hidden
#nullable disable
            WriteLiteral(" patrons</p>\r\n            </div>\r\n            <div class=\"col-md-2 col-sm-2 box0\">\r\n                <div class=\"box1\">\r\n                    <img src=\"https://img.icons8.com/dusk/64/000000/soccer-yellow-card.png\" />\r\n                    <h3>");
#nullable restore
#line 36 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.TotalCheckout);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n                <p>More than ");
#nullable restore
#line 38 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Home\Index.cshtml"
                        Write(Model.TotalCheckout);

#line default
#line hidden
#nullable disable
            WriteLiteral(" checkouts</p>\r\n            </div>\r\n            <div class=\"col-md-2 col-sm-2 box0\">\r\n                <div class=\"box1\">\r\n                    <img src=\"https://img.icons8.com/dusk/64/000000/library.png\" />\r\n                    <h3>");
#nullable restore
#line 43 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.NumBranch);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n                <p>");
#nullable restore
#line 45 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Home\Index.cshtml"
              Write(Model.NumBranch);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" branches! </p>
            </div>

        </div><!-- /row mt -->


        <div class=""row mt"">
            <!-- SERVER STATUS PANELS -->
          

            <div class=""col-md-4 col-sm-4 mb"">
                <div class=""white-panel pn"">
                    <div class=""white-header"">
                        <h5>TOP BRANCH</h5>
                    </div>
                    <p><img src=""https://img.icons8.com/dusk/64/000000/library.png"" width=""100""></p>
                    <br />
                    <p><b>");
#nullable restore
#line 62 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Home\Index.cshtml"
                     Write(Model.TopBranchName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></p>

                    <div class=""row"">
                        <div class=""col-md-12"">

                            <p></p>
                        </div>

                    </div>
                </div>
                </div><!-- /col-md-4 -->


            <div class=""col-md-4 col-sm-4 mb"">
                <div class=""white-panel pn"">
                    <div class=""white-header"">
                        <h5>TOP ASSET</h5>
                    </div>
                    <div class=""row"">
                        <div class=""col-sm-6 col-xs-6 goleft"">
                            <p><i class=""fa fa-heart""></i>");
#nullable restore
#line 82 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Home\Index.cshtml"
                                                     Write(Model.TopAssetName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"col-sm-6 col-xs-6\"></div>\r\n                    </div>\r\n                    <div class=\"centered\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 3259, "\"", 3283, 1);
#nullable restore
#line 87 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 3265, Model.TopAssetImg, 3265, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""max-width: 100px; max-height: 140px"">
                    </div>
                </div>
            </div><!-- /col-md-4 -->

            <div class=""col-md-4 mb"">
                <!-- WHITE PANEL - TOP USER -->
                <div class=""white-panel pn"">
                    <div class=""white-header"">
                        <h5>TOP PATRON</h5>
                    </div>
                    <p><img src=""https://img.icons8.com/dusk/64/000000/reading.png"" class=""img-circle"" width=""80""></p>
                    <p><b>");
#nullable restore
#line 99 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Home\Index.cshtml"
                     Write(Model.PatronName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-12\">\r\n                            <p class=\"small mt\">MEMBER SINCE</p>\r\n                            <p>");
#nullable restore
#line 103 "E:\KH2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Home\Index.cshtml"
                          Write(Model.MemberSince);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>

                    </div>
                </div>
            </div><!-- /col-md-4 -->
        </div><!-- /row -->
        <div class=""row mt"">
            <!--CUSTOM CHART START -->
            <div class=""border-head"">
                <h3>VISITS</h3>
            </div>
            <div class=""custom-bar-chart"">
                <ul class=""y-axis"">
                    <li><span>10.000</span></li>
                    <li><span>8.000</span></li>
                    <li><span>6.000</span></li>
                    <li><span>4.000</span></li>
                    <li><span>2.000</span></li>
                    <li><span>0</span></li>
                </ul>
                <div class=""bar"">
                    <div class=""title"">JAN</div>
                    <div class=""value tooltips"" data-original-title=""8.500"" data-toggle=""tooltip"" data-placement=""top"">85%</div>
                </div>
                <div class=""bar "">
                    <div class=""t");
            WriteLiteral(@"itle"">FEB</div>
                    <div class=""value tooltips"" data-original-title=""5.000"" data-toggle=""tooltip"" data-placement=""top"">50%</div>
                </div>
                <div class=""bar "">
                    <div class=""title"">MAR</div>
                    <div class=""value tooltips"" data-original-title=""6.000"" data-toggle=""tooltip"" data-placement=""top"">60%</div>
                </div>
                <div class=""bar "">
                    <div class=""title"">APR</div>
                    <div class=""value tooltips"" data-original-title=""4.500"" data-toggle=""tooltip"" data-placement=""top"">45%</div>
                </div>
                <div class=""bar"">
                    <div class=""title"">MAY</div>
                    <div class=""value tooltips"" data-original-title=""3.200"" data-toggle=""tooltip"" data-placement=""top"">32%</div>
                </div>
                <div class=""bar "">
                    <div class=""title"">JUN</div>
                    <div class=""value tooltips"" ");
            WriteLiteral(@"data-original-title=""6.200"" data-toggle=""tooltip"" data-placement=""top"">62%</div>
                </div>
                <div class=""bar"">
                    <div class=""title"">JUL</div>
                    <div class=""value tooltips"" data-original-title=""7.500"" data-toggle=""tooltip"" data-placement=""top"">75%</div>
                </div>
            </div>
            <!--custom chart end-->
        </div><!-- /row -->

    </div><!-- /col-lg-9 END SECTION MIDDLE -->
    <!-- **********************************************************************************************************************************************************
    RIGHT SIDEBAR CONTENT
    *********************************************************************************************************************************************************** -->

    
</div><! --/row -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Home.HomeDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
