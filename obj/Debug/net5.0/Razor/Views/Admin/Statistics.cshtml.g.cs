#pragma checksum "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\Admin\Statistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0960a4bb031936456beea128e548ce1ee1a001db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Statistics), @"mvc.1.0.view", @"/Views/Admin/Statistics.cshtml")]
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
#line 1 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\_ViewImports.cshtml"
using Trividi_Booking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\_ViewImports.cshtml"
using Trividi_Booking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0960a4bb031936456beea128e548ce1ee1a001db", @"/Views/Admin/Statistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7843f84891c411c0e4fedafaf356c3e4c5c0909", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Statistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Statistic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dashboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("menu__item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HotelManagement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AccountManagement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Statistics", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\Admin\Statistics.cshtml"
  
    ViewData["Title"] = "Statistics";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.0/css/all.min.css""
    integrity=""sha512-xh6O/CkQoPOWDdYTDqeRdPCVd1SpvCA9XXcUnZS2FmJNp1coAFzvtCN9BmamE+4aHK8yyUHUSCcJHgXloTyT2A==""
    crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
<link rel=""stylesheet"" href=""https://cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css"" />
");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0960a4bb031936456beea128e548ce1ee1a001db7216", async() => {
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
                WriteLiteral("\r\n</script>\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"menu\">\r\n    <ul class=\"menu__bar\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0960a4bb031936456beea128e548ce1ee1a001db8530", async() => {
                WriteLiteral("\r\n            <li>Hotel Management</li>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0960a4bb031936456beea128e548ce1ee1a001db10029", async() => {
                WriteLiteral("\r\n            <li>Account Management</li>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <a class=""menu__item selected"" href=""#"">
            <li>statistics</li>
        </a>
    </ul>
</div>

<div class=""card-container"">
    <div class=""card card-orange"">
        <div class=""card__heading"">
            <div class=""card__content"">
                <h3 class=""card__number"">");
#nullable restore
#line 33 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\Admin\Statistics.cshtml"
                                    Write(Model.sumTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                <p class=""card__details"">all profits</p>
            </div>
            <div class=""card__icon""><i class=""fa-solid fa-money-bill-trend-up""></i></div>
        </div>
        <div class=""line""></div>
        <div class=""card__footer"">
            <i class=""fa-regular fa-clock""></i>
            <p class=""card_time"">update: ");
#nullable restore
#line 41 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\Admin\Statistics.cshtml"
                                    Write(ViewBag.time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"card card-green\">\r\n        <div class=\"card__heading\">\r\n            <div class=\"card__content\">\r\n                <h3 class=\"card__number\">");
#nullable restore
#line 48 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\Admin\Statistics.cshtml"
                                    Write(Model.numberBooking);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                <p class=""card__details"">all bookings</p>
            </div>
            <div class=""card__icon""><i class=""fa-solid fa-rectangle-list""></i></div>
        </div>
        <div class=""line""></div>
        <div class=""card__footer"">
            <i class=""fa-regular fa-clock""></i>
            <p class=""card_time"">update: ");
#nullable restore
#line 56 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\Admin\Statistics.cshtml"
                                    Write(ViewBag.time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"card card-red\">\r\n        <div class=\"card__heading\">\r\n            <div class=\"card__content\">\r\n                <h3 class=\"card__number\">$");
#nullable restore
#line 63 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\Admin\Statistics.cshtml"
                                     Write(Model.sumTotalToday);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                <p class=""card__details"">Day's profits</p>
            </div>
            <div class=""card__icon""><i class=""fa-solid fa-money-bill-trend-up""></i></div>
        </div>
        <div class=""line""></div>
        <div class=""card__footer"">
            <i class=""fa-regular fa-clock""></i>
            <p class=""card_time""> update: ");
#nullable restore
#line 71 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\Admin\Statistics.cshtml"
                                     Write(ViewBag.time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"card card-blue\">\r\n        <div class=\"card__heading\">\r\n            <div class=\"card__content\">\r\n                <h3 class=\"card__number\">");
#nullable restore
#line 78 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\Admin\Statistics.cshtml"
                                    Write(Model.numberBookingToday);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                <p class=""card__details"">Day's bookings</p>
            </div>
            <div class=""card__icon""><i class=""fa-solid fa-rectangle-list""></i></div>
        </div>
        <div class=""line""></div>
        <div class=""card__footer"">
            <i class=""fa-regular fa-clock""></i>
            <p class=""card_time""> update: ");
#nullable restore
#line 86 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\Admin\Statistics.cshtml"
                                     Write(ViewBag.time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0960a4bb031936456beea128e548ce1ee1a001db16064", async() => {
                WriteLiteral("\r\n    <input type=\"date\" class=\"search-bar\" name=\"timeS\" required>\r\n    <input id=\"year\" type=\"date\" class=\"search-bar\" name=\"timeE\" required>\r\n    <input type=\"submit\" value=\"View\" class=\"btn\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 97 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\Admin\Statistics.cshtml"
 if (@ViewBag.Err != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"field-text-error\">\r\n        <p>");
#nullable restore
#line 100 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\Admin\Statistics.cshtml"
      Write(ViewBag.Err);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 102 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\Admin\Statistics.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"content\" style=\"margin: 3rem 15% 40rem;\">\r\n    <table id=\"example\" class=\"display\"");
            BeginWriteAttribute("style", " style=\"", 3814, "\"", 3822, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <thead>
            <tr>
                <th class=""align-center"">Time</th>
                <th class=""align-center"">Number of Books</th>
                <th class=""align-center"">Dollar</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 116 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\Admin\Statistics.cshtml"
             foreach (var item in ViewBag.list)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"align-center\">");
#nullable restore
#line 119 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\Admin\Statistics.cshtml"
                                        Write(item.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"align-center\">");
#nullable restore
#line 120 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\Admin\Statistics.cshtml"
                                        Write(item.numberBook);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"align-center\">");
#nullable restore
#line 121 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\Admin\Statistics.cshtml"
                                        Write(item.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 124 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\Admin\Statistics.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n<script src=\"https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js\"></script>\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'#example\').DataTable();\r\n    });\r\n</script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Statistic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591