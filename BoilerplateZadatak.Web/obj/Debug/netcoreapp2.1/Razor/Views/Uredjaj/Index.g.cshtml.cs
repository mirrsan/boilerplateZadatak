#pragma checksum "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Uredjaj\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "611b54dbdbc15b8c17869149e5bc53e22a797dbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Uredjaj_Index), @"mvc.1.0.view", @"/Views/Uredjaj/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Uredjaj/Index.cshtml", typeof(AspNetCore.Views_Uredjaj_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"611b54dbdbc15b8c17869149e5bc53e22a797dbd", @"/Views/Uredjaj/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06a7219fb92c457721453365b56b37d9452bb9f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Uredjaj_Index : BoilerplateZadatak.Web.Views.BoilerplateZadatakRazorPage<BoilerplateZadatak.Web.Dto.UredjajModelDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Uredjaj\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewBag.ActiveMenu = "Uredjaj";

#line default
#line hidden
            BeginContext(129, 31, true);
            WriteLiteral("\r\n<h2>Uredjaj</h2>\r\n\r\n<hr/>\r\n\r\n");
            EndContext();
#line 11 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Uredjaj\Index.cshtml"
 foreach (var evo in Model.Uredjaj)
{

#line default
#line hidden
            BeginContext(200, 8, true);
            WriteLiteral("    <h5>");
            EndContext();
            BeginContext(209, 9, false);
#line 13 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Uredjaj\Index.cshtml"
   Write(evo.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(218, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
            BeginContext(230, 62, false);
#line 14 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Uredjaj\Index.cshtml"
Write(Html.ActionLink("Obrisi ", "ObrisiUredjaj", new {Id = evo.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(299, 67, false);
#line 15 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Uredjaj\Index.cshtml"
Write(Html.ActionLink(" Izmeni ", "IzmenaInfoUredjaj", new {Id = evo.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(373, 61, false);
#line 16 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Uredjaj\Index.cshtml"
Write(Html.ActionLink(" Detalji", "UredjajPoId", new {Id = evo.Id}));

#line default
#line hidden
            EndContext();
#line 16 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Uredjaj\Index.cshtml"
                                                                  
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BoilerplateZadatak.Web.Dto.UredjajModelDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
