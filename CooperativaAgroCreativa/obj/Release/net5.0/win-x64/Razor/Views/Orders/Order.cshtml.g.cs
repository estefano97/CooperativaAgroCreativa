#pragma checksum "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "060f204e02c0ca339be452cb17e35870c95c82ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Order), @"mvc.1.0.view", @"/Views/Orders/Order.cshtml")]
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
#line 1 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Order.cshtml"
using CooperativaAgroCreativa.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Order.cshtml"
using CooperativaAgroCreativa.Models.DB;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"060f204e02c0ca339be452cb17e35870c95c82ce", @"/Views/Orders/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3774771a83eb64203d53d5675dc55c6a9b96377c", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 3rem 15rem; width: 25rem;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/logo-coopeagro.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Order.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"es\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "060f204e02c0ca339be452cb17e35870c95c82ce6824", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "060f204e02c0ca339be452cb17e35870c95c82ce7086", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "060f204e02c0ca339be452cb17e35870c95c82ce8968", async() => {
                WriteLiteral("\r\n    <h1 class=\"text-center\">Orden de pedido realizada con éxito</h1>\r\n    <div class=\"my-4 mx-3\">\r\n        <p><b>Fecha y hora de compra:</b> ");
#nullable restore
#line 15 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Order.cshtml"
                                     Write(Context.Items["Hour"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p><b>Id de compra:</b> ");
#nullable restore
#line 16 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Order.cshtml"
                           Write(Context.Items["Id"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p><b>Correo:</b> ");
#nullable restore
#line 17 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Order.cshtml"
                     Write(Context.Items["Mail"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p><b>Celular:</b> ");
#nullable restore
#line 18 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Order.cshtml"
                      Write(Context.Items["Phone"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p><b>Usuario solicitante:</b> ");
#nullable restore
#line 19 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Order.cshtml"
                                  Write(Context.Items["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
    </div>
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
#line 32 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Order.cshtml"
         foreach (var producto in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td> ");
#nullable restore
#line 35 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Order.cshtml"
                Write(producto.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 36 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Order.cshtml"
                Write(producto.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 37 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Order.cshtml"
                Write(producto.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                <td> ¢");
#nullable restore
#line 38 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Order.cshtml"
                 Write(producto.UnityPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                <td> ¢");
#nullable restore
#line 39 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Order.cshtml"
                  Write(Int32.Parse(producto.UnityPrice) * producto.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Order.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"4\"><h3>Monto a pagar:</h3></td>\r\n                <td class=\"text-center\"><h3>¢");
#nullable restore
#line 46 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Order.cshtml"
                                        Write(Context.Items["TotalPrice"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3></td>\r\n            </tr>\r\n        </tfoot>\r\n        </table>\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "060f204e02c0ca339be452cb17e35870c95c82ce13954", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "060f204e02c0ca339be452cb17e35870c95c82ce15840", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "060f204e02c0ca339be452cb17e35870c95c82ce16884", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "060f204e02c0ca339be452cb17e35870c95c82ce17928", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 55 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Order.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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