#pragma checksum "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aeb331af2d832f77ecb01777ff6de8c478bace5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aeb331af2d832f77ecb01777ff6de8c478bace5b", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7843f84891c411c0e4fedafaf356c3e4c5c0909", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Trividi_Booking.Models.BookingDetails>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/myaccount.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteBooking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/noti.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/header.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
  
    ViewData["Title"] = "My Account Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.0/css/all.min.css""
    integrity=""sha512-xh6O/CkQoPOWDdYTDqeRdPCVd1SpvCA9XXcUnZS2FmJNp1coAFzvtCN9BmamE+4aHK8yyUHUSCcJHgXloTyT2A==""
    crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
<link rel=""stylesheet"" href=""https://fonts.googleapis.com/icon?family=Material+Icons"">
");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aeb331af2d832f77ecb01777ff6de8c478bace5b7366", async() => {
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
            WriteLiteral(@"
<div class=""container"">
    <div class=""info-container"">
        <div class=""title"">Order Information
            <h3>Update your info and find out how it's used.</h3>
        </div>
        <div class=""user-detail"">
            <div class=""infor"">
                <span class=""details"">Fullname: <p>");
#nullable restore
#line 21 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                                              Write(ViewBag.Account.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></span>\r\n            </div>\r\n            <div class=\"infor\">\r\n                <span class=\"details\">Username: <p>");
#nullable restore
#line 24 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                                              Write(ViewBag.Account.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></span>\r\n            </div>\r\n            <div class=\"infor\">\r\n                <span class=\"details\">Email: <p>");
#nullable restore
#line 27 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                                                 if(ViewBag.Account.Email==null){Output.Write("You should add your email!");} else{

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                                                                                                                              Write(ViewBag.Account.Email);

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                                                                                                                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </span>\r\n            </div>\r\n            <div class=\"infor\">\r\n                <span class=\"details\">Phone: <p>");
#nullable restore
#line 31 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                                                 if(ViewBag.Account.Phone==null){Output.Write("You should add your phone!");} else{

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                                                                                                                              Write(ViewBag.Account.Phone);

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                                                                                                                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></span>\r\n            </div>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeb331af2d832f77ecb01777ff6de8c478bace5b11846", async() => {
                WriteLiteral("Edit Profile");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>

        </div>
    </div>
</div>

<!-- table -->

<div id=""yourbooking"" class=""container margin-bottom"">
    <h1 class=""heading"">
        <span>M</span>
        <span>y</span>
        <span class=""space""></span>
        <span>B</span>
        <span>o</span>
        <span>o</span>
        <span>k</span>
        <span>i</span>
        <span>n</span>
        <span>g</span>
    </h1>
    <ul class=""responsive-table"">
        <li class=""table-header"">
            <div class=""col col-l"">Location</div>
            <div class=""col col-l"">Room name</div>
            <div class=""col col-xs"">Amount</div>
            <div class=""col col-m"">Day Start</div>
            <div class=""col col-m"">Day End</div>
            <div class=""col col-s"">Total Cost</div>
            <div class=""col col-xs"">Status</div>
            <div class=""col col-xs"">Action</div>
        </li>

");
#nullable restore
#line 68 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"table-row\">\r\n                <div class=\"col col-l\" data-label=\"Location\">");
#nullable restore
#line 71 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                                                        Write(item.Hotel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"col col-l align-center\" data-label=\"Room name\">");
#nullable restore
#line 72 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                                                                      Write(item.RoomDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"col col-xs align-center\" data-label=\"Amount\"> ");
#nullable restore
#line 73 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                                                                     Write(item.NumberOfRooms);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"col col-m align-center\" data-label=\"Day Start\">");
#nullable restore
#line 74 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                                                                      Write(item.DateStart);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"col col-m align-center\" data-label=\"Day End\">");
#nullable restore
#line 75 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                                                                    Write(item.DateEnd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"col col-s align-center\" data-label=\"Total Cost\">");
#nullable restore
#line 76 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                                                                       Write(item.TotalCosts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 77 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                 if (@item.Confirm == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col col-xs align-center\" data-label=\"Status\"><a href=\"#\" class=\"badge badge-confirm\">confirm</a>\r\n                    </div>\r\n");
#nullable restore
#line 81 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col col-xs align-center\" data-label=\"Status\"><a href=\"#\"\r\n                            class=\"badge badge-updating\">updating</a></div>\r\n");
#nullable restore
#line 86 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col col-xs align-center\" data-label=\"\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeb331af2d832f77ecb01777ff6de8c478bace5b17900", async() => {
                WriteLiteral("\r\n                        <i class=\"icon material-icons\" data-toggle=\"tooltip\" title=\"Delete\">\r\n                            &#xE872;\r\n                        </i>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                                                                         WriteLiteral(item.IdBooking);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n            </li>\r\n");
#nullable restore
#line 97 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n    </ul>\r\n</div>\r\n");
#nullable restore
#line 101 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
 if(ViewBag.Show != null){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""noti open close-btn"">
    <div class="" noti-container"">
        <div class=""noti-heading"">
            <h3 class=""heading"">Welcome to Trividi website booking</h3>
            <div class=""close-btn""><i class=""fas fa-times""></i></div>
        </div>
        <div class=""noti-body"">
            <p class=""message mt-12"">Your booking has been successful!</p>
            <span class=""message mt-12""> Your account has been created: </span>
            <p><span class=""label mt-12"">Username:</span>");
#nullable restore
#line 111 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                                                    Write(ViewBag.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><span class=\"label\">Password: </span>");
#nullable restore
#line 112 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
                                               Write(ViewBag.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"edit-btn\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeb331af2d832f77ecb01777ff6de8c478bace5b22371", async() => {
                WriteLiteral("Edit Profile");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 119 "D:\Documents\1.FPT\FA22\PRN211\Project\Trividi_Booking\Views\User\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeb331af2d832f77ecb01777ff6de8c478bace5b24161", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeb331af2d832f77ecb01777ff6de8c478bace5b25261", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Trividi_Booking.Models.BookingDetails>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
