#pragma checksum "C:\Mascota\mascotafeliz.app\mascotafeliz.app.Frontend\Pages\Duenos\ConsultarDueno.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "728a4de6211077cba00870e1e8a74cf1b1e66593"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Duenos.Pages_Duenos_ConsultarDueno), @"mvc.1.0.razor-page", @"/Pages/Duenos/ConsultarDueno.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Duenos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Mascota\mascotafeliz.app\mascotafeliz.app.Frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"728a4de6211077cba00870e1e8a74cf1b1e66593", @"/Pages/Duenos/ConsultarDueno.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d90b2b40ba8c1257b37c8db6b0a6d90a6076caca", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Duenos_ConsultarDueno : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\'general\'>\r\n\r\n   <div class=\'contenedor-titulo\'>\r\n    <h4>Detalle del Propietario</h4>\r\n  </div>\r\n\r\n  <div class=\'formulario\' id=\'register-dueno\'>\r\n    <input type=\'hidden\' name=\'id\' id=\'id\'");
            BeginWriteAttribute("value", " value=\'", 279, "\'", 302, 1);
#nullable restore
#line 12 "C:\Mascota\mascotafeliz.app\mascotafeliz.app.Frontend\Pages\Duenos\ConsultarDueno.cshtml"
WriteAttributeValue("", 287, Model.dueno.Id, 287, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    \r\n    <input type=\'text\' name=\'nombre\' id=\'nombre\' class=\'form-dueno\' placeholder=\'Nombre\'");
            BeginWriteAttribute("value", " value=\'", 400, "\'", 427, 1);
#nullable restore
#line 14 "C:\Mascota\mascotafeliz.app\mascotafeliz.app.Frontend\Pages\Duenos\ConsultarDueno.cshtml"
WriteAttributeValue("", 408, Model.dueno.Nombre, 408, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n    <input type=\'text\' name=\'apellidos\' id=\'apellidos\' class=\'form-dueno\' placeholder=\'Apellidos\'");
            BeginWriteAttribute("value", " value=\'", 537, "\'", 567, 1);
#nullable restore
#line 15 "C:\Mascota\mascotafeliz.app\mascotafeliz.app.Frontend\Pages\Duenos\ConsultarDueno.cshtml"
WriteAttributeValue("", 545, Model.dueno.Apellidos, 545, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n    <input type=\'text\' name=\'direccion\' id=\'direccion\' class=\'form-dueno\' placeholder=\'Direccion\'");
            BeginWriteAttribute("value", " value=\'", 677, "\'", 707, 1);
#nullable restore
#line 16 "C:\Mascota\mascotafeliz.app\mascotafeliz.app.Frontend\Pages\Duenos\ConsultarDueno.cshtml"
WriteAttributeValue("", 685, Model.dueno.Direccion, 685, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n    <input type=\'tel\' name=\'telefono\' id=\'telefono\' class=\'form-dueno\' placeholder=\'Telefono\'");
            BeginWriteAttribute("value", " value=\'", 813, "\'", 842, 1);
#nullable restore
#line 17 "C:\Mascota\mascotafeliz.app\mascotafeliz.app.Frontend\Pages\Duenos\ConsultarDueno.cshtml"
WriteAttributeValue("", 821, Model.dueno.Telefono, 821, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n    <input type=\'email\' name=\'correo\' id=\'correo\' class=\'form-dueno\' placeholder=\'Correo\'");
            BeginWriteAttribute("value", " value=\'", 944, "\'", 971, 1);
#nullable restore
#line 18 "C:\Mascota\mascotafeliz.app\mascotafeliz.app.Frontend\Pages\Duenos\ConsultarDueno.cshtml"
WriteAttributeValue("", 952, Model.dueno.Correo, 952, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n  \r\n    <div class=\'volver\'>\r\n     <a href=\'ListarDueno\'><i class=\"fa-solid fa-backward\">Volver</i></a>\r\n    </div>\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.ConsultarDuenoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ConsultarDuenoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ConsultarDuenoModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.ConsultarDuenoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
