#pragma checksum "C:\Users\User\source\repos\PhoneBook\PhoneBook.WebUI\Pages\PhoneBookUsers\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caee6dbc4ebf86c589999ab912867db9fbfc5dd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PhoneBook.WebUI.Pages.PhoneBookUsers.Pages_PhoneBookUsers_Detail), @"mvc.1.0.razor-page", @"/Pages/PhoneBookUsers/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/PhoneBookUsers/Detail.cshtml", typeof(PhoneBook.WebUI.Pages.PhoneBookUsers.Pages_PhoneBookUsers_Detail), @"{phoneUserId:int}")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{phoneUserId:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caee6dbc4ebf86c589999ab912867db9fbfc5dd6", @"/Pages/PhoneBookUsers/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4d0cdd3b19fac4a92eb97b3bd96fe4086c80668", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PhoneBookUsers_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\User\source\repos\PhoneBook\PhoneBook.WebUI\Pages\PhoneBookUsers\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(126, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(133, 25, false);
#line 7 "C:\Users\User\source\repos\PhoneBook\PhoneBook.WebUI\Pages\PhoneBookUsers\Detail.cshtml"
Write(Model.PhoneUser.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(158, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(160, 24, false);
#line 7 "C:\Users\User\source\repos\PhoneBook\PhoneBook.WebUI\Pages\PhoneBookUsers\Detail.cshtml"
                          Write(Model.PhoneUser.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(184, 28, true);
            WriteLiteral("</h2>\r\n\r\n\r\n<div>\r\n\r\n    Id: ");
            EndContext();
            BeginContext(213, 18, false);
#line 12 "C:\Users\User\source\repos\PhoneBook\PhoneBook.WebUI\Pages\PhoneBookUsers\Detail.cshtml"
   Write(Model.PhoneUser.Id);

#line default
#line hidden
            EndContext();
            BeginContext(231, 39, true);
            WriteLiteral("\r\n\r\n</div>\r\n\r\n<div>\r\n\r\n    Phone Type: ");
            EndContext();
            BeginContext(271, 25, false);
#line 18 "C:\Users\User\source\repos\PhoneBook\PhoneBook.WebUI\Pages\PhoneBookUsers\Detail.cshtml"
           Write(Model.PhoneUser.PhoneType);

#line default
#line hidden
            EndContext();
            BeginContext(296, 39, true);
            WriteLiteral("\r\n\r\n</div>\r\n<div>\r\n\r\n    Phone Number: ");
            EndContext();
            BeginContext(336, 27, false);
#line 23 "C:\Users\User\source\repos\PhoneBook\PhoneBook.WebUI\Pages\PhoneBookUsers\Detail.cshtml"
             Write(Model.PhoneUser.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(363, 18, true);
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(381, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2d4e137089b474a99cb6f7916631cee", async() => {
                BeginContext(426, 9, true);
                WriteLiteral("All Users");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(439, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhoneBook.WebUI.Pages.PhoneBookUsers.DetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PhoneBook.WebUI.Pages.PhoneBookUsers.DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PhoneBook.WebUI.Pages.PhoneBookUsers.DetailModel>)PageContext?.ViewData;
        public PhoneBook.WebUI.Pages.PhoneBookUsers.DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
