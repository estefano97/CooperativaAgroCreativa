#pragma checksum "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\SubmitOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d0284f584613a9d3c5c7ce82838bd09bda9f2a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_SubmitOrder), @"mvc.1.0.view", @"/Views/Orders/SubmitOrder.cshtml")]
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
#line 1 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\SubmitOrder.cshtml"
using CooperativaAgroCreativa.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\SubmitOrder.cshtml"
using CooperativaAgroCreativa.Models.DB;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0284f584613a9d3c5c7ce82838bd09bda9f2a6", @"/Views/Orders/SubmitOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3774771a83eb64203d53d5675dc55c6a9b96377c", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_SubmitOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Orders/Finished"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\SubmitOrder.cshtml"
  
    ViewData["Title"] = "Ordenes";
    ViewData["Ordenar"] = "my-buttonActive";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n<h1 class=\"text-center my-4\">Productos agregados</h1>\r\n  \r\n");
#nullable restore
#line 11 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\SubmitOrder.cshtml"
 if(ViewBag.HayValores)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div>
        <table class=""table my-tableResponsive table-bordered""  style=""text-align: right;"">
        <thead>
          <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Talla</th>
            <th scope=""col"">Cantidad agregada</th>
            <th scope=""col"">Precio unidad</th>
            <th scope=""col"">Precio total por producto</th>
          </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 25 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\SubmitOrder.cshtml"
         foreach (var producto in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td> ");
#nullable restore
#line 28 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\SubmitOrder.cshtml"
                Write(producto.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 29 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\SubmitOrder.cshtml"
                Write(producto.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 30 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\SubmitOrder.cshtml"
                Write(producto.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ¢");
#nullable restore
#line 31 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\SubmitOrder.cshtml"
                 Write(producto.UnityPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ¢");
#nullable restore
#line 32 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\SubmitOrder.cshtml"
                  Write(Int32.Parse(producto.UnityPrice) * producto.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\SubmitOrder.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"4\"><h3>Cantidad a pagar:</h3></td>\r\n                <td class=\"text-center\"><h3>¢");
#nullable restore
#line 39 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\SubmitOrder.cshtml"
                                        Write(ViewData["TotalPrice"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3></td>
            </tr>
        </tfoot>
        </table>
        <div class=""my-SubmitOrderContainer"">
            <p class=""text-center"">Al dar click en este boton se generara tu orden de compra en un pdf, la cual debes llevar a la sucursal más cercana de la Cooperativa AgroCreativa.</p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d0284f584613a9d3c5c7ce82838bd09bda9f2a68336", async() => {
                WriteLiteral("\r\n                <input type=\"submit\" class=\"My-buttonProducts\" value=\"Generar Pedido\" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        </div>\r\n");
#nullable restore
#line 50 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\SubmitOrder.cshtml"
    } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <p class=\"text-center\">Todavía no creaste ninguna orden de compra!, para agregar productos, da <a href=\"/Products/Index\">click aquí</a></p>\r\n    </div>\r\n");
#nullable restore
#line 54 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\SubmitOrder.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
