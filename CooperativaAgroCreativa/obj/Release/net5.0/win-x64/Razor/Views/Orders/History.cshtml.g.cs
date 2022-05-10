#pragma checksum "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61f70a59d92946470bd7f3d4ad21d18b6f622fc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_History), @"mvc.1.0.view", @"/Views/Orders/History.cshtml")]
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
#line 1 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\History.cshtml"
using CooperativaAgroCreativa.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\History.cshtml"
using CooperativaAgroCreativa.Models.DB;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f70a59d92946470bd7f3d4ad21d18b6f622fc3", @"/Views/Orders/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3774771a83eb64203d53d5675dc55c6a9b96377c", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OrdersCreated>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\History.cshtml"
  
    ViewData["Title"] = "Historial";
    ViewData["Ordenar"] = "my-buttonActive";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"my-4 text-center\">Compras realizadas</h1>\r\n<div>\r\n");
#nullable restore
#line 10 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\History.cshtml"
     if(Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table my-tableResponsive table-bordered""  style=""text-align: right;"">
        <thead>
          <tr>
            <th scope=""col"">Fecha</th>
            <th scope=""col"">Id compra</th>
            <th scope=""col"">Status</th>
            <th scope=""col"">Acciones</th>
          </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\History.cshtml"
         foreach (var orden in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td> ");
#nullable restore
#line 25 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\History.cshtml"
                Write(orden.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 26 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\History.cshtml"
                Write(orden.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 27 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\History.cshtml"
                 if(orden.IsAcepted == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"color:orange;\">Pendiente</td>\r\n");
#nullable restore
#line 29 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\History.cshtml"
                } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"color:green;\">Aceptada</td>\r\n");
#nullable restore
#line 31 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\History.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td> <a");
            BeginWriteAttribute("href", " href=\"", 1014, "\"", 1047, 2);
            WriteAttributeValue("", 1021, "/Orders/Finished/", 1021, 17, true);
#nullable restore
#line 32 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\History.cshtml"
WriteAttributeValue("", 1038, orden.Id, 1038, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ver Comprobante</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\History.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        </table>\r\n");
#nullable restore
#line 37 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\History.cshtml"
    } else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5 style=\"color: gray;\" class=\"my-3 text-center\">Todavía no realizas ninguna  compra!</h5>\r\n");
#nullable restore
#line 40 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\History.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OrdersCreated>> Html { get; private set; }
    }
}
#pragma warning restore 1591