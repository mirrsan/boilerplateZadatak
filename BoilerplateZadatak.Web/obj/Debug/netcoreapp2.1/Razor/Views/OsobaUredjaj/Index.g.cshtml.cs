#pragma checksum "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\OsobaUredjaj\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb785db85ca9d7037bc950a48c5b8eaff6fd24aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OsobaUredjaj_Index), @"mvc.1.0.view", @"/Views/OsobaUredjaj/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OsobaUredjaj/Index.cshtml", typeof(AspNetCore.Views_OsobaUredjaj_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb785db85ca9d7037bc950a48c5b8eaff6fd24aa", @"/Views/OsobaUredjaj/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06a7219fb92c457721453365b56b37d9452bb9f6", @"/Views/_ViewImports.cshtml")]
    public class Views_OsobaUredjaj_Index : BoilerplateZadatak.Web.Views.BoilerplateZadatakRazorPage<BoilerplateZadatak.Web.Dto.OsobaUredjajModelDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\OsobaUredjaj\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 56, true);
            WriteLiteral("\r\n<h3>Osoba-Uredjaj i vreme koriscenja</h3>\r\n\r\n<hr/>\r\n\r\n");
            EndContext();
#line 10 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\OsobaUredjaj\Index.cshtml"
 foreach (var ou in Model.OsobaUredjaj)
{

#line default
#line hidden
            BeginContext(197, 12, true);
            WriteLiteral("    <h5>Ime:");
            EndContext();
            BeginContext(210, 12, false);
#line 12 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\OsobaUredjaj\Index.cshtml"
       Write(ou.Osoba.Ime);

#line default
#line hidden
            EndContext();
            BeginContext(222, 14, true);
            WriteLiteral(" <br/>Prezime:");
            EndContext();
            BeginContext(237, 16, false);
#line 12 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\OsobaUredjaj\Index.cshtml"
                                  Write(ou.Osoba.Prezime);

#line default
#line hidden
            EndContext();
            BeginContext(253, 18, true);
            WriteLiteral(" <br/>Kancelarija:");
            EndContext();
            BeginContext(272, 25, false);
#line 12 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\OsobaUredjaj\Index.cshtml"
                                                                     Write(ou.Osoba.Kancelarija.Opis);

#line default
#line hidden
            EndContext();
            BeginContext(297, 23, true);
            WriteLiteral("</h5>\r\n    <h5>Uredjaj:");
            EndContext();
            BeginContext(321, 16, false);
#line 13 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\OsobaUredjaj\Index.cshtml"
           Write(ou.Uredjaj.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(337, 19, true);
            WriteLiteral(" </h5>\r\n    <h5>Od:");
            EndContext();
            BeginContext(357, 20, false);
#line 14 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\OsobaUredjaj\Index.cshtml"
      Write(ou.PocetakKoriscenja);

#line default
#line hidden
            EndContext();
            BeginContext(377, 9, true);
            WriteLiteral(" <br/>Do:");
            EndContext();
            BeginContext(387, 17, false);
#line 14 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\OsobaUredjaj\Index.cshtml"
                                    Write(ou.KrajKoriscenja);

#line default
#line hidden
            EndContext();
            BeginContext(404, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
            BeginContext(416, 56, false);
#line 15 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\OsobaUredjaj\Index.cshtml"
Write(Html.ActionLink("Obrisi ", "ObrisiOU", new {Id = ou.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(479, 61, false);
#line 16 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\OsobaUredjaj\Index.cshtml"
Write(Html.ActionLink(" Izmeni ", "IzmenaInfoOU", new {Id = ou.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(547, 55, false);
#line 17 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\OsobaUredjaj\Index.cshtml"
Write(Html.ActionLink(" Detalji", "OuPoId", new {Id = ou.Id}));

#line default
#line hidden
            EndContext();
#line 17 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\OsobaUredjaj\Index.cshtml"
                                                            
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BoilerplateZadatak.Web.Dto.OsobaUredjajModelDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
