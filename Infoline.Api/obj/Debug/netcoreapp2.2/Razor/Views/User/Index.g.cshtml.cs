#pragma checksum "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f29eacf5594d69f50c84f4436005a4a6074bc39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
#line 1 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\_ViewImports.cshtml"
using Infoline.Api;

#line default
#line hidden
#line 2 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\_ViewImports.cshtml"
using Infoline.Api.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f29eacf5594d69f50c84f4436005a4a6074bc39", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"158414330f79f50cb4f63f1bc77a22475de9b4da", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Infoline.Api.ViewModels.UserInfoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Users";

#line default
#line hidden
            BeginContext(91, 890, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""row"">
            <div class=""col-md-12"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th scope=""col"">Cinsiyet </th>
                            <th scope=""col"">Telefon </th>
                            <th scope=""col"">Email </th>
                            <th scope=""col"">Kullanıcı Adı</th>
                            <th scope=""col"">Adı </th>
                            <th scope=""col"">Soyadı </th>
                            <th scope=""col"">Yaşı  </th>
                            <th scope=""col"">Şehir </th>
                            <th scope=""col"">Posta Kodu</th>
                            <th scope=""col"">Aksiyon</th>

                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 27 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\Index.cshtml"
                         foreach (var item in Model.Users)
                        {

#line default
#line hidden
            BeginContext(1068, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1139, 11, false);
#line 30 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\Index.cshtml"
                               Write(item.gender);

#line default
#line hidden
            EndContext();
            BeginContext(1150, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1194, 9, false);
#line 31 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\Index.cshtml"
                               Write(item.cell);

#line default
#line hidden
            EndContext();
            BeginContext(1203, 44, true);
            WriteLiteral(" </td>\r\n                                <td>");
            EndContext();
            BeginContext(1248, 10, false);
#line 32 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\Index.cshtml"
                               Write(item.email);

#line default
#line hidden
            EndContext();
            BeginContext(1258, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1302, 13, false);
#line 33 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\Index.cshtml"
                               Write(item.username);

#line default
#line hidden
            EndContext();
            BeginContext(1315, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1359, 10, false);
#line 34 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\Index.cshtml"
                               Write(item.first);

#line default
#line hidden
            EndContext();
            BeginContext(1369, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1413, 9, false);
#line 35 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\Index.cshtml"
                               Write(item.last);

#line default
#line hidden
            EndContext();
            BeginContext(1422, 44, true);
            WriteLiteral(" </td>\r\n                                <td>");
            EndContext();
            BeginContext(1467, 8, false);
#line 36 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\Index.cshtml"
                               Write(item.age);

#line default
#line hidden
            EndContext();
            BeginContext(1475, 45, true);
            WriteLiteral("  </td>\r\n                                <td>");
            EndContext();
            BeginContext(1521, 9, false);
#line 37 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\Index.cshtml"
                               Write(item.city);

#line default
#line hidden
            EndContext();
            BeginContext(1530, 44, true);
            WriteLiteral(" </td>\r\n                                <td>");
            EndContext();
            BeginContext(1575, 13, false);
#line 38 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\Index.cshtml"
                               Write(item.postcode);

#line default
#line hidden
            EndContext();
            BeginContext(1588, 81, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1669, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f29eacf5594d69f50c84f4436005a4a6074bc399083", async() => {
                BeginContext(1761, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\Index.cshtml"
                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1771, 78, true);
            WriteLiteral("\r\n\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 44 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1876, 112, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Infoline.Api.ViewModels.UserInfoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
