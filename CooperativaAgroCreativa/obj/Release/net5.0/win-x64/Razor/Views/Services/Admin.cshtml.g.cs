#pragma checksum "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Services\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e78d9bf5ad2b35f06eccf321aad5dc03e0e5f63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Admin), @"mvc.1.0.view", @"/Views/Services/Admin.cshtml")]
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
#nullable restore
#line 1 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\_ViewImports.cshtml"
using CooperativaAgroCreativa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\_ViewImports.cshtml"
using CooperativaAgroCreativa.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Services\Admin.cshtml"
using CooperativaAgroCreativa.Models.DB;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e78d9bf5ad2b35f06eccf321aad5dc03e0e5f63", @"/Views/Services/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3774771a83eb64203d53d5675dc55c6a9b96377c", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Service>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Services\Admin.cshtml"
  
    ViewData["Productos"] = "my-buttonActive";
    ViewData["Title"] = "Servicos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h1 class=""text-center my-4"">Catálogo de servicios</h1>
    <div style=""display: flex; align-items: center; justify-content: center; margin: 1rem auto;"">
        <a class=""btn btn-primary"" style=""font-size: 1.25rem;"" href=""/Services/Create"">Agregar servicio</a>
    </div>
    <div class=""container"">
  <div class=""row"">
    <div class=""col-12"">
        <table class=""table table-bordered""  style=""text-align: right;"">
        <thead>
          <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Título</th>
            <th scope=""col"">Precio</th>
            <th scope=""col"">Actions</th>
          </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 26 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Services\Admin.cshtml"
     foreach (var producto in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <th scope=\"row\">");
#nullable restore
#line 29 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Services\Admin.cshtml"
                   Write(producto.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 30 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Services\Admin.cshtml"
         if(producto.Title.Length > 45) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 31 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Services\Admin.cshtml"
           Write(producto.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 32 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Services\Admin.cshtml"
        } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 33 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Services\Admin.cshtml"
           Write(producto.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 34 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Services\Admin.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>¢");
#nullable restore
#line 35 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Services\Admin.cshtml"
        Write(producto.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1178, "\"", 1212, 2);
            WriteAttributeValue("", 1185, "/Services/Edit/", 1185, 15, true);
#nullable restore
#line 37 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Services\Admin.cshtml"
WriteAttributeValue("", 1200, producto.Id, 1200, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Editar <i class=\"fas fa-edit\"></i></a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1292, "\"", 1328, 2);
            WriteAttributeValue("", 1299, "/Services/Delete/", 1299, 17, true);
#nullable restore
#line 38 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Services\Admin.cshtml"
WriteAttributeValue("", 1316, producto.Id, 1316, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Eliminar <i class=\"far fa-trash-alt\"></i></a>\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 41 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Services\Admin.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n      </table>\r\n    </div>\r\n  </div>\r\n</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591
