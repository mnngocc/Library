#pragma checksum "E:\HK2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ded271f2eb4c34c6dc56de78aa3b9606a9f6885e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded271f2eb4c34c6dc56de78aa3b9606a9f6885e", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
    public class Areas_Admin_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Assets/ListBook"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Assets/ListVideo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Statuses/ListStatus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ded271f2eb4c34c6dc56de78aa3b9606a9f6885e4741", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 175, "\"", 185, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""author"" content=""Dashboard"">
    <meta name=""keyword"" content=""Dashboard, Bootstrap, Admin, Template, Theme, Responsive, Fluid, Retina"">

    <title>Admin</title>

    <!-- Bootstrap core CSS -->
    <link href=""/Assets/admin/css/bootstrap.css"" rel=""stylesheet"">
    <!--external css-->
    <link href=""/Assets/admin/font-awesome/css/font-awesome.css"" rel=""stylesheet"" />
    <link rel=""stylesheet"" type=""text/css"" href=""/Assets/admin/css/zabuto_calendar.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/Assets/admin/js/gritter/css/jquery.gritter.css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""/Assets/admin/lineicons/style.css"">

    <!-- Custom styles for this template -->
    <link href=""/Assets/admin/css/style.css"" rel=""stylesheet"">
    <link href=""/Assets/admin/css/style-responsive.css"" rel=""stylesheet"">

    <script src=""/Assets/admin/js/chart-master/Chart.js""></script>
    <style>
        #assetsTable td {
            text-align: center;
            bord");
                WriteLiteral("er-bottom: 1px solid #ddd;\r\n        }\r\n    </style>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ded271f2eb4c34c6dc56de78aa3b9606a9f6885e6470", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ded271f2eb4c34c6dc56de78aa3b9606a9f6885e8356", async() => {
                WriteLiteral(@"
    <section id=""container"">
        <header class=""header black-bg"">
            <div class=""sidebar-toggle-box"">
                <div class=""fa fa-bars tooltips"" data-placement=""right"" data-original-title=""Toggle Navigation""></div>
            </div>
            <!--logo start-->
            <a href=""/Admin/Home/Index"" class=""logo""><b>ADMIN</b></a>
            <!--logo end-->
            <div class=""nav notify-row"" id=""top_menu"">
                <!--  notification start -->
                <ul class=""nav top-menu"">
                    <!-- settings start -->
                    <li class=""dropdown"">
                        <a data-toggle=""dropdown"" class=""dropdown-toggle"" href=""index.html#"">
                            <i class=""fa fa-tasks""></i>
                            <span class=""badge bg-theme"">4</span>
                        </a>
                        <ul class=""dropdown-menu extended tasks-bar"">
                           
                            <li>
                 ");
                WriteLiteral(@"               <p class=""green"">You have 4 pending tasks</p>
                            </li>
                            <li>
                                <a href=""index.html#"">
                                    <div class=""task-info"">
                                        <div class=""desc"">DashGum Admin Panel</div>
                                        <div class=""percent"">40%</div>
                                    </div>
                                    <div class=""progress progress-striped"">
                                        <div class=""progress-bar progress-bar-success"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 40%"">
                                            <span class=""sr-only"">40% Complete (success)</span>
                                        </div>
                                    </div>
                                </a>
                            </li>
                            <li>
                  ");
                WriteLiteral(@"              <a href=""index.html#"">
                                    <div class=""task-info"">
                                        <div class=""desc"">Database Update</div>
                                        <div class=""percent"">60%</div>
                                    </div>
                                    <div class=""progress progress-striped"">
                                        <div class=""progress-bar progress-bar-warning"" role=""progressbar"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 60%"">
                                            <span class=""sr-only"">60% Complete (warning)</span>
                                        </div>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <a href=""index.html#"">
                                    <div class=""task-info"">
                                        <div class=""de");
                WriteLiteral(@"sc"">Product Development</div>
                                        <div class=""percent"">80%</div>
                                    </div>
                                    <div class=""progress progress-striped"">
                                        <div class=""progress-bar progress-bar-info"" role=""progressbar"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 80%"">
                                            <span class=""sr-only"">80% Complete</span>
                                        </div>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <a href=""index.html#"">
                                    <div class=""task-info"">
                                        <div class=""desc"">Payments Sent</div>
                                        <div class=""percent"">70%</div>
                                    </div>
                     ");
                WriteLiteral(@"               <div class=""progress progress-striped"">
                                        <div class=""progress-bar progress-bar-danger"" role=""progressbar"" aria-valuenow=""70"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 70%"">
                                            <span class=""sr-only"">70% Complete (Important)</span>
                                        </div>
                                    </div>
                                </a>
                            </li>
                            <li class=""external"">
                                <a href=""#"">See All Tasks</a>
                            </li>
                        </ul>
                    </li>
                    <!-- settings end -->
                    <!-- inbox dropdown start-->
                    <li id=""header_inbox_bar"" class=""dropdown"">
                        <a data-toggle=""dropdown"" class=""dropdown-toggle"" href=""index.html#"">
                            <i class=""fa fa-envelope-o""></i>");
                WriteLiteral(@"
                            <span class=""badge bg-theme"">5</span>
                        </a>
                        <ul class=""dropdown-menu extended inbox"">
                      
                            <li>
                                <p class=""green"">You have 5 new messages</p>
                            </li>
                            <li>
                                <a href=""index.html#"">
                                    <span class=""photo""><img alt=""avatar"" src=""assets/img/ui-zac.jpg""></span>
                                    <span class=""subject"">
                                        <span class=""from"">Zac Snider</span>
                                        <span class=""time"">Just now</span>
                                    </span>
                                    <span class=""message"">
                                        Hi mate, how is everything?
                                    </span>
                                </a>
                ");
                WriteLiteral(@"            </li>
                            <li>
                                <a href=""index.html#"">
                                    <span class=""photo""><img alt=""avatar"" src=""assets/img/ui-divya.jpg""></span>
                                    <span class=""subject"">
                                        <span class=""from"">Divya Manian</span>
                                        <span class=""time"">40 mins.</span>
                                    </span>
                                    <span class=""message"">
                                        Hi, I need your help with this.
                                    </span>
                                </a>
                            </li>
                            <li>
                                <a href=""index.html#"">
                                    <span class=""photo""><img alt=""avatar"" src=""assets/img/ui-danro.jpg""></span>
                                    <span class=""subject"">
                           ");
                WriteLiteral(@"             <span class=""from"">Dan Rogers</span>
                                        <span class=""time"">2 hrs.</span>
                                    </span>
                                    <span class=""message"">
                                        Love your new Dashboard.
                                    </span>
                                </a>
                            </li>
                            <li>
                                <a href=""index.html#"">
                                    <span class=""photo""><img alt=""avatar"" src=""assets/img/ui-sherman.jpg""></span>
                                    <span class=""subject"">
                                        <span class=""from"">Dj Sherman</span>
                                        <span class=""time"">4 hrs.</span>
                                    </span>
                                    <span class=""message"">
                                        Please, answer asap.
                          ");
                WriteLiteral(@"          </span>
                                </a>
                            </li>
                            <li>
                                <a href=""index.html#"">See all messages</a>
                            </li>
                        </ul>
                    </li>
                    <!-- inbox dropdown end -->
                </ul>
                <!--  notification end -->
            </div>
            <div class=""top-menu"">
                <ul class=""nav pull-right top-menu"">
                    <li><a class=""logout"" href=""login.html"">Logout</a></li>
                </ul>
            </div>
        </header>
        <!--header end-->
        <!-- **********************************************************************************************************************************************************
        MAIN SIDEBAR MENU
        *************************************************************************************************************************************");
                WriteLiteral(@"********************** -->
        <!--sidebar start-->
        <aside>
            <div id=""sidebar"" class=""nav-collapse "">
                <h5 class=""centered"">ADMIN</h5>
                <!-- sidebar menu start-->
                <ul class=""sidebar-menu"" id=""nav-accordion"">

                    <li class=""mt"">
                        <a href=""/Admin/Home/Index"">
                            <i class=""fa fa-dashboard""></i>
                            <span>Dashboard</span>
                        </a>
                    </li>

                    <li class=""sub-menu"">

                        <a href=""javascript:;"">
                            <i class=""fa fa-desktop""></i>
                            <span>Assets Management</span>
                        </a>
                        <ul class=""sub"">
                            <li>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ded271f2eb4c34c6dc56de78aa3b9606a9f6885e19305", async() => {
                    WriteLiteral("Book Management");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </li>\r\n                            <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ded271f2eb4c34c6dc56de78aa3b9606a9f6885e20519", async() => {
                    WriteLiteral("Video Management");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</li>

                        </ul>
                    </li>

                    <li class=""sub-menu"">
                        <a href=""javascript:;"">
                            <i class=""fa fa-cogs""></i>
                            <span>Patrons Management</span>
                        </a>

                    </li>
                    <li class=""sub-menu"">
                        <a href=""#"">
                            <i class=""fa fa-book""></i>
                            <span>Branches Management</span>
                        </a>

                    </li>

                    <li class=""sub-menu"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ded271f2eb4c34c6dc56de78aa3b9606a9f6885e22340", async() => {
                    WriteLiteral("\r\n                            <i class=\"fa fa-book\"></i>\r\n                            <span>Statues Detail</span>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </li>

                    <li class=""sub-menu"">
                        <a href=""javascript:;"">
                            <i class="" fa fa-bar-chart-o""></i>
                            <span>Charts</span>
                        </a>

                    </li>

                </ul>
                <!-- sidebar menu end-->
            </div>
        </aside>
        <!--sidebar end-->
        <!-- **********************************************************************************************************************************************************
        MAIN CONTENT
        *********************************************************************************************************************************************************** -->
        <!--main content start-->
        <section id=""main-content"">
            <section class=""wrapper"">
                ");
#nullable restore
#line 264 "E:\HK2-1920\Framework\Project\Library\Library\Areas\Admin\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                
        </section>
    </section>

    <!--main content end-->
    <!--footer start-->
    <footer class=""site-footer"">
        <div class=""text-center"">
            Nhóm thực hiện: Mai Như Ngọc - Nguyễn Phi Yến - Trần Hữu Phát
        </div>
    </footer>
    <!--footer end-->
</section>

<!-- js placed at the end of the document so the pages load faster -->
<script src=""/Assets/admin/js/jquery.js""></script>
<script src=""/Assets/admin/js/jquery-1.8.3.min.js""></script>
<script src=""/Assets/admin/js/bootstrap.min.js""></script>
<script class=""include"" type=""text/javascript"" src=""/Assets/admin/js/jquery.dcjqaccordion.2.7.js""></script>
<script src=""/Assets/admin/js/jquery.scrollTo.min.js""></script>
<script src=""/Assets/admin/js/jquery.nicescroll.js"" type=""text/javascript""></script>
<script src=""/Assets/admin/js/jquery.sparkline.js""></script>


<!--common script for all pages-->
<script src=""/Assets/admin/js/common-scripts.js""></script>

<script type=""text/javascript"" ");
                WriteLiteral(@"src=""/Assets/admin/js/gritter/js/jquery.gritter.js""></script>
<script type=""text/javascript"" src=""/Assets/admin/js/gritter-conf.js""></script>

<!--script for this page-->
<script src=""/Assets/admin/js/sparkline-chart.js""></script>
<script src=""/Assets/admin/js/zabuto_calendar.js""></script>



<script type=""application/javascript"">
    $(document).ready(function () {
        $(""#date-popover"").popover({html: true, trigger: ""manual""});
        $(""#date-popover"").hide();
        $(""#date-popover"").click(function (e) {
            $(this).hide();
        });

        $(""#my-calendar"").zabuto_calendar({
            action: function () {
                return myDateFunction(this.id, false);
            },
            action_nav: function () {
                return myNavFunction(this.id);
            },
            ajax: {
                url: ""show_data.php?action=1"",
                modal: true
            },
            legend: [
                {type: ""text"", label: ""Special event""");
                WriteLiteral(@", badge: ""00""},
                {type: ""block"", label: ""Regular event"", }
            ]
        });
    });


    function myNavFunction(id) {
        $(""#date-popover"").hide();
        var nav = $(""#"" + id).data(""navigation"");
        var to = $(""#"" + id).data(""to"");
        console.log('nav ' + nav + ' to: ' + to.month + '/' + to.year);
    }
</script>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
