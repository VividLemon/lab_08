#pragma checksum "C:\Users\Issayah\source\repos\Lab_06\Views\Comments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be8e90e86314f4f2aca60c040f2bc1958828c731"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comments_Index), @"mvc.1.0.view", @"/Views/Comments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comments/Index.cshtml", typeof(AspNetCore.Views_Comments_Index))]
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
#line 3 "C:\Users\Issayah\source\repos\Lab_06\Views\_ViewImports.cshtml"
using Lab_06.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be8e90e86314f4f2aca60c040f2bc1958828c731", @"/Views/Comments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d34a844f9111a989f7cb56cfcd06ae29ffa6533b", @"/Views/_ViewImports.cshtml")]
    public class Views_Comments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab_06.Models.Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Issayah\source\repos\Lab_06\Views\Comments\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(86, 102, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(189, 40, false);
#line 12 "C:\Users\Issayah\source\repos\Lab_06\Views\Comments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(229, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(285, 45, false);
#line 15 "C:\Users\Issayah\source\repos\Lab_06\Views\Comments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(330, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(386, 45, false);
#line 18 "C:\Users\Issayah\source\repos\Lab_06\Views\Comments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(431, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 23 "C:\Users\Issayah\source\repos\Lab_06\Views\Comments\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(526, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(575, 39, false);
#line 26 "C:\Users\Issayah\source\repos\Lab_06\Views\Comments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Text));

#line default
#line hidden
            EndContext();
            BeginContext(614, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(670, 44, false);
#line 29 "C:\Users\Issayah\source\repos\Lab_06\Views\Comments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(714, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(770, 44, false);
#line 32 "C:\Users\Issayah\source\repos\Lab_06\Views\Comments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UpdatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(814, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 35 "C:\Users\Issayah\source\repos\Lab_06\Views\Comments\Index.cshtml"
}

#line default
#line hidden
            BeginContext(853, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab_06.Models.Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
