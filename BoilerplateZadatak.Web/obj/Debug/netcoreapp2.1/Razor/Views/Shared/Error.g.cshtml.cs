#pragma checksum "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9dcf21abcaa76f24bc7cd305a263cf96fc16eb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Shared\Error.cshtml"
using Abp.Collections.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9dcf21abcaa76f24bc7cd305a263cf96fc16eb3", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06a7219fb92c457721453365b56b37d9452bb9f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : BoilerplateZadatak.Web.Views.BoilerplateZadatakRazorPage<Abp.Web.Mvc.Models.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Shared\Error.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(99, 172, true);
            WriteLiteral("<div class=\"row\">\n    <section class=\"col-lg-12\">\n        <div class=\"panel panel-warning\">\n            <div class=\"panel-heading\">\n                <h3 class=\"panel-title\">");
            EndContext();
            BeginContext(272, 23, false);
#line 10 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Shared\Error.cshtml"
                                   Write(Model.ErrorInfo.Message);

#line default
#line hidden
            EndContext();
            BeginContext(295, 102, true);
            WriteLiteral("</h3>\n            </div>\n            <div class=\"panel-body\">\n                <p>\n                    ");
            EndContext();
            BeginContext(399, 98, false);
#line 14 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Shared\Error.cshtml"
                Write(!string.IsNullOrEmpty(Model.ErrorInfo.Details) ? Model.ErrorInfo.Details : Model.ErrorInfo.Message);

#line default
#line hidden
            EndContext();
            BeginContext(498, 22, true);
            WriteLiteral("\n                </p>\n");
            EndContext();
#line 17 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Shared\Error.cshtml"
                 if (!Model.ErrorInfo.ValidationErrors.IsNullOrEmpty())
                {

#line default
#line hidden
            BeginContext(655, 25, true);
            WriteLiteral("                    <ul>\n");
            EndContext();
#line 20 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Shared\Error.cshtml"
                         foreach (var validationError in Model.ErrorInfo.ValidationErrors)
                        {

#line default
#line hidden
            BeginContext(797, 65, true);
            WriteLiteral("                            <li>\n                                ");
            EndContext();
            BeginContext(863, 23, false);
#line 23 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Shared\Error.cshtml"
                           Write(validationError.Message);

#line default
#line hidden
            EndContext();
            BeginContext(886, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 24 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Shared\Error.cshtml"
                                 if (validationError.Members != null && validationError.Members.Any())
                                {
                                    

#line default
#line hidden
            BeginContext(1066, 1, true);
            WriteLiteral("(");
            EndContext();
            BeginContext(1068, 42, false);
#line 26 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Shared\Error.cshtml"
                                      Write(string.Join(", ", validationError.Members));

#line default
#line hidden
            EndContext();
            BeginContext(1110, 1, true);
            WriteLiteral(")");
            EndContext();
#line 26 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Shared\Error.cshtml"
                                                                                              
                                }

#line default
#line hidden
            BeginContext(1153, 34, true);
            WriteLiteral("                            </li>\n");
            EndContext();
#line 29 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Shared\Error.cshtml"
                        }

#line default
#line hidden
            BeginContext(1213, 26, true);
            WriteLiteral("                    </ul>\n");
            EndContext();
#line 31 "C:\VS_project\BoilerplateZadatak\4.0.0\src\BoilerplateZadatak.Web\Views\Shared\Error.cshtml"
                }

#line default
#line hidden
            BeginContext(1257, 56, true);
            WriteLiteral("            </div>\n        </div>\n    </section>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abp.Web.Mvc.Models.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
