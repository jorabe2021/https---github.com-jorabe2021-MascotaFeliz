#pragma checksum "C:\Mascota\mascotafeliz.app\mascotafeliz.app.Frontend\Pages\Veterinarios\ConsultarVeterinario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3638c712d79debda0e118d0a911bb0fff74943e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Veterinarios.Pages_Veterinarios_ConsultarVeterinario), @"mvc.1.0.view", @"/Pages/Veterinarios/ConsultarVeterinario.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Veterinarios
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3638c712d79debda0e118d0a911bb0fff74943e1", @"/Pages/Veterinarios/ConsultarVeterinario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d90b2b40ba8c1257b37c8db6b0a6d90a6076caca", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Veterinarios_ConsultarVeterinario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\'general\'>\r\n  <div class=\'contenedor-titulo\'>\r\n    <h4>Detalle del Veterinario</h4>\r\n  </div>\r\n  <div class=\'formulario\' id=\'register-veterinario\'>\r\n    <input type=\'hidden\' name=\'id\' id=\'id\'");
            BeginWriteAttribute("value", " value=\'", 206, "\'", 235, 1);
#nullable restore
#line 6 "C:\Mascota\mascotafeliz.app\mascotafeliz.app.Frontend\Pages\Veterinarios\ConsultarVeterinario.cshtml"
WriteAttributeValue("", 214, Model.veterinario.Id, 214, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <input type=\'text\' name=\'identificacion\' id=\'identificacion\' class=\'form-veterinario\' placeholder=\'Ingrese Identificacion\'");
            BeginWriteAttribute("value", "value= \'", 365, "\'", 400, 1);
#nullable restore
#line 7 "C:\Mascota\mascotafeliz.app\mascotafeliz.app.Frontend\Pages\Veterinarios\ConsultarVeterinario.cshtml"
WriteAttributeValue("", 373, Model.dueno.Identificacion, 373, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <input type=\'text\' name=\'nombres\' id=\'nombres\' class=\'form-veterinario\' placeholder=\' Nombres\'");
            BeginWriteAttribute("value", "value= \'", 502, "\'", 530, 1);
#nullable restore
#line 8 "C:\Mascota\mascotafeliz.app\mascotafeliz.app.Frontend\Pages\Veterinarios\ConsultarVeterinario.cshtml"
WriteAttributeValue("", 510, Model.dueno.Nombres, 510, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n    <input type=\'text\' name=\'apellidos\' id=\'apellidos\' class=\'form-veterinario\' placeholder=\'Apellidos\'");
            BeginWriteAttribute("value", "value= \'", 646, "\'", 676, 1);
#nullable restore
#line 9 "C:\Mascota\mascotafeliz.app\mascotafeliz.app.Frontend\Pages\Veterinarios\ConsultarVeterinario.cshtml"
WriteAttributeValue("", 654, Model.dueno.Apellidos, 654, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("disabled>\r\n    <input type=\'text\' name=\'direccion\' id=\'direccion\' class=\'form-veterinario\' placeholder=\' Direccion\'");
            BeginWriteAttribute("value", "value= \'", 792, "\'", 822, 1);
#nullable restore
#line 10 "C:\Mascota\mascotafeliz.app\mascotafeliz.app.Frontend\Pages\Veterinarios\ConsultarVeterinario.cshtml"
WriteAttributeValue("", 800, Model.dueno.Direccion, 800, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("disabled>\r\n    <input type=\'tel\' name=\'telefono\' id=\'telefono\' class=\'form-veterinario\' placeholder=\'Telefono\'");
            BeginWriteAttribute("value", "value= \'", 933, "\'", 962, 1);
#nullable restore
#line 11 "C:\Mascota\mascotafeliz.app\mascotafeliz.app.Frontend\Pages\Veterinarios\ConsultarVeterinario.cshtml"
WriteAttributeValue("", 941, Model.dueno.Telefono, 941, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("disabled>\r\n    <input type=\'number\' name=\'tarjeta_profesional\' id=\'tarjeta_profesional\' class=\'form-veterinario\' placeholder=\' Tarjeta Profesional\'");
            BeginWriteAttribute("value", "value= \'", 1110, "\'", 1150, 2);
#nullable restore
#line 12 "C:\Mascota\mascotafeliz.app\mascotafeliz.app.Frontend\Pages\Veterinarios\ConsultarVeterinario.cshtml"
WriteAttributeValue("", 1118, Model.dueno.Tarjeta, 1118, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1138, "Profesional", 1139, 12, true);
            EndWriteAttribute();
            WriteLiteral("disabled> \r\n  </div>\r\n</section>");
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
