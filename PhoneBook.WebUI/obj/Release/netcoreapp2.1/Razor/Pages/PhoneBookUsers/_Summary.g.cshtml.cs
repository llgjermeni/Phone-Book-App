#pragma checksum "C:\Users\User\source\repos\PhoneBook\PhoneBook.WebUI\Pages\PhoneBookUsers\_Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71d425dc895e6b9fe238406bda05b9ff6184b68e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PhoneBook.WebUI.Pages.PhoneBookUsers.Pages_PhoneBookUsers__Summary), @"mvc.1.0.view", @"/Pages/PhoneBookUsers/_Summary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/PhoneBookUsers/_Summary.cshtml", typeof(PhoneBook.WebUI.Pages.PhoneBookUsers.Pages_PhoneBookUsers__Summary))]
namespace PhoneBook.WebUI.Pages.PhoneBookUsers
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\User\source\repos\PhoneBook\PhoneBook.WebUI\Pages\_ViewImports.cshtml"
using PhoneBook.WebUI;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\PhoneBook\PhoneBook.WebUI\Pages\_ViewImports.cshtml"
using PhoneBook.DAL.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71d425dc895e6b9fe238406bda05b9ff6184b68e", @"/Pages/PhoneBookUsers/_Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4d0cdd3b19fac4a92eb97b3bd96fe4086c80668", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PhoneBookUsers__Summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PhoneUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(18, 148, true);
            WriteLiteral("<div class=\"panel panel-default\">\r\n    <div class=\"panel-heading\">\r\n        <h3>\r\n            <i class=\"glyphicon glyphicon-user\"></i>\r\n            ");
            EndContext();
            BeginContext(167, 15, false);
#line 6 "C:\Users\User\source\repos\PhoneBook\PhoneBook.WebUI\Pages\PhoneBookUsers\_Summary.cshtml"
       Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(182, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(185, 14, false);
#line 6 "C:\Users\User\source\repos\PhoneBook\PhoneBook.WebUI\Pages\PhoneBookUsers\_Summary.cshtml"
                         Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(199, 104, true);
            WriteLiteral("\r\n        </h3>\r\n    </div>\r\n\r\n    <div class=\"panel-body\">\r\n        <p class=\"text-info\">\r\n            ");
            EndContext();
            BeginContext(304, 15, false);
#line 12 "C:\Users\User\source\repos\PhoneBook\PhoneBook.WebUI\Pages\PhoneBookUsers\_Summary.cshtml"
       Write(Model.PhoneType);

#line default
#line hidden
            EndContext();
            BeginContext(319, 140, true);
            WriteLiteral("\r\n        </p>\r\n        <p class=\"text-primary\">\r\n            <i class=\"glyphicon glyphicon-earphone\"></i>\r\n            <abbr title=\"Phone\">");
            EndContext();
            BeginContext(460, 17, false);
#line 16 "C:\Users\User\source\repos\PhoneBook\PhoneBook.WebUI\Pages\PhoneBookUsers\_Summary.cshtml"
                           Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(477, 77, true);
            WriteLiteral("</abbr>\r\n        </p>\r\n    </div>\r\n    <div class=\"panel-footer\">\r\n\r\n        ");
            EndContext();
            BeginContext(554, 175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3f091499bc345a28b311ca4af7cf0da", async() => {
                BeginContext(654, 71, true);
                WriteLiteral("\r\n\r\n            <i class=\"glyphicon glyphicon-zoom-in\"></i>\r\n\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-phoneUserId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "C:\Users\User\source\repos\PhoneBook\PhoneBook.WebUI\Pages\PhoneBookUsers\_Summary.cshtml"
                      WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["phoneUserId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-phoneUserId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["phoneUserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(729, 12, true);
            WriteLiteral("\r\n\r\n        ");
            EndContext();
            BeginContext(741, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6cfd6bd9bc840bca1d7a612424521d4", async() => {
                BeginContext(839, 68, true);
                WriteLiteral("\r\n\r\n            <i class=\"glyphicon glyphicon-edit\"></i>\r\n\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-phoneUserId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "C:\Users\User\source\repos\PhoneBook\PhoneBook.WebUI\Pages\PhoneBookUsers\_Summary.cshtml"
                      WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["phoneUserId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-phoneUserId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["phoneUserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(911, 12, true);
            WriteLiteral("\r\n\r\n        ");
            EndContext();
            BeginContext(923, 173, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b40bf454a5b240c48d943c4dbd02b2dc", async() => {
                BeginContext(1023, 69, true);
                WriteLiteral("\r\n\r\n            <i class=\"glyphicon glyphicon-trash\"></i>\r\n\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-phoneUserId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\User\source\repos\PhoneBook\PhoneBook.WebUI\Pages\PhoneBookUsers\_Summary.cshtml"
                      WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["phoneUserId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-phoneUserId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["phoneUserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1096, 34, true);
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div>    \r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhoneUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
