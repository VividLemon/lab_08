#pragma checksum "C:\Users\Issayah\source\repos\Lab_06\Views\Shared\Videos\CommentCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a339f4ae00b761c6ed49e8df90a892011605156a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Videos_CommentCard), @"mvc.1.0.view", @"/Views/Shared/Videos/CommentCard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Videos/CommentCard.cshtml", typeof(AspNetCore.Views_Shared_Videos_CommentCard))]
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
#line 1 "C:\Users\Issayah\source\repos\Lab_06\Views\_ViewImports.cshtml"
using Lab_06.Models;

#line default
#line hidden
#line 2 "C:\Users\Issayah\source\repos\Lab_06\Views\_ViewImports.cshtml"
using Lab_06.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a339f4ae00b761c6ed49e8df90a892011605156a", @"/Views/Shared/Videos/CommentCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be54a8cf7bc0908edf71ad219ea0c0826817c83a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Videos_CommentCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab_06.Models.Comment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(160, 93, true);
            WriteLiteral("<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            ");
            EndContext();
            BeginContext(254, 10, false);
#line 10 "C:\Users\Issayah\source\repos\Lab_06\Views\Shared\Videos\CommentCard.cshtml"
       Write(Model.Text);

#line default
#line hidden
            EndContext();
            BeginContext(264, 86, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div>\r\n            From: ");
            EndContext();
            BeginContext(351, 15, false);
#line 15 "C:\Users\Issayah\source\repos\Lab_06\Views\Shared\Videos\CommentCard.cshtml"
             Write(Model.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(366, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab_06.Models.Comment> Html { get; private set; }
    }
}
#pragma warning restore 1591