#pragma checksum "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33339bb96d480d80bf5d888f1cd6af4eefb26cae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Home\About.cshtml"
using BoilerplateZadatak.Web.Startup;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33339bb96d480d80bf5d888f1cd6af4eefb26cae", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06a7219fb92c457721453365b56b37d9452bb9f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : BoilerplateZadatak.Web.Views.BoilerplateZadatakRazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Home\About.cshtml"
  
    ViewBag.ActiveMenu = PageNames.About;

#line default
#line hidden
            BeginContext(85, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(91, 10, false);
#line 6 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Home\About.cshtml"
Write(L("About"));

#line default
#line hidden
            EndContext();
            BeginContext(101, 62, true);
            WriteLiteral("!</h2>\n\n<div class=\"row\">\n    <div class=\"col-lg-12\">\n        ");
            EndContext();
            BeginContext(164, 22, false);
#line 10 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Home\About.cshtml"
   Write(L("About_Description"));

#line default
#line hidden
            EndContext();
            BeginContext(186, 18, true);
            WriteLiteral("\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
