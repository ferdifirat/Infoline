#pragma checksum "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\UsersAnswers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5726968d724f56b199ab8beca42ff8d2691239b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UsersAnswers), @"mvc.1.0.view", @"/Views/User/UsersAnswers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/UsersAnswers.cshtml", typeof(AspNetCore.Views_User_UsersAnswers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5726968d724f56b199ab8beca42ff8d2691239b7", @"/Views/User/UsersAnswers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"158414330f79f50cb4f63f1bc77a22475de9b4da", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UsersAnswers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Infoline.Api.ViewModels.UsersAnswersViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\UsersAnswers.cshtml"
  
    ViewData["Title"] = "UsersAnswers";

#line default
#line hidden
            BeginContext(102, 311, true);
            WriteLiteral(@"
<div class=""row"">
    <table class=""table"">
        <thead>
            <tr>
                <th>Kullanıcı Adı</th>
                <th>Soru</th>
                <th>Cevap</th>
                <th>Cevaplanma Tarihi</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 18 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\UsersAnswers.cshtml"
             foreach (var item in Model.UsersAnswers)
            {

#line default
#line hidden
            BeginContext(483, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(522, 13, false);
#line 21 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\UsersAnswers.cshtml"
               Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(535, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(563, 17, false);
#line 22 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\UsersAnswers.cshtml"
               Write(item.QuestionText);

#line default
#line hidden
            EndContext();
            BeginContext(580, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(608, 15, false);
#line 23 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\UsersAnswers.cshtml"
               Write(item.AnswerText);

#line default
#line hidden
            EndContext();
            BeginContext(623, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(651, 15, false);
#line 24 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\UsersAnswers.cshtml"
               Write(item.AnswerDate);

#line default
#line hidden
            EndContext();
            BeginContext(666, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 26 "D:\GithubNew\Infoline\Infoline.Api\Infoline.Api\Views\User\UsersAnswers.cshtml"
            }

#line default
#line hidden
            BeginContext(707, 42, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Infoline.Api.ViewModels.UsersAnswersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591