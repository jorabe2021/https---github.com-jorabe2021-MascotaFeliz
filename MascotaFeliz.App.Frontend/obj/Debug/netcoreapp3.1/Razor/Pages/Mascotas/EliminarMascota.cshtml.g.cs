#pragma checksum "C:\Mascota\mascotafeliz.app\mascotafeliz.app.Frontend\Pages\Mascotas\EliminarMascota.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "334a57a0841927e5dd2dd3ef60ee6daefc953b5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Mascotas.Pages_Mascotas_EliminarMascota), @"mvc.1.0.razor-page", @"/Pages/Mascotas/EliminarMascota.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Mascotas
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"334a57a0841927e5dd2dd3ef60ee6daefc953b5c", @"/Pages/Mascotas/EliminarMascota.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d90b2b40ba8c1257b37c8db6b0a6d90a6076caca", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Mascotas_EliminarMascota : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class='general'>
  <div class='contenedor-titulo'>
    <h4>Eliminar Mascota</h4>
  </div>
  <div class='formulario' id='register-mascota'>
    <input type='hidden' name='id' id='id' class='form-mascota' placeholder='Ingrese Id'>
    <input type='text' name='identificacion' id='identificacion' class='form-mascota' placeholder='Ingrese Identificacion'>
    <input type='submit' value='Eliminar'>
    
  </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.EliminarMascotaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.EliminarMascotaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.EliminarMascotaModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.EliminarMascotaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591