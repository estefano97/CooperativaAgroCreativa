#pragma checksum "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfb359653d6bdbfe786c7edf4286ddb02bf73fee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
#line 1 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Index.cshtml"
using CooperativaAgroCreativa.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Index.cshtml"
using CooperativaAgroCreativa.Models.DB;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfb359653d6bdbfe786c7edf4286ddb02bf73fee", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3774771a83eb64203d53d5675dc55c6a9b96377c", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Orders/RestProductOrder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Orders/AddProductOrder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Index.cshtml"
  
    ViewData["Title"] = "Ordenes";
    ViewData["Ordenar"] = "my-buttonActive";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1 class=\"text-center my-3\">Orden De Pedido</h1>\r\n    <a href=\"/Orders/History\">Ver Registro De Pedidos</a>\r\n");
#nullable restore
#line 11 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Index.cshtml"
 if(ViewBag.HayValores) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"my-ProductOrderContainer\">\r\n");
#nullable restore
#line 13 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Index.cshtml"
         foreach (var producto in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"my-ProductCardOrder\">\r\n            <div class=\"my-ProductCardOrderText\">\r\n                <p>Id Del Producto: <b>");
#nullable restore
#line 17 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Index.cshtml"
                                  Write(producto.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b></p>\r\n                <p>Talla: <b>");
#nullable restore
#line 18 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Index.cshtml"
                        Write(producto.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b></p>\r\n                <p>Precio: <b>");
#nullable restore
#line 19 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Index.cshtml"
                         Write(producto.UnityPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ¢</b> </p>\r\n                <p>Cantidad Agregada: <b>");
#nullable restore
#line 20 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Index.cshtml"
                                    Write(producto.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Unidades</b></p>\r\n                <div class=\"my-ProductCardOrderButtons\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfb359653d6bdbfe786c7edf4286ddb02bf73fee7206", async() => {
                WriteLiteral("\r\n                        <input name=\"Redirect\" type=\"hidden\" value=\"Orders\" />\r\n                        <input name=\"Id\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=", 1063, "", 1082, 1);
#nullable restore
#line 24 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Index.cshtml"
WriteAttributeValue("", 1070, producto.Id, 1070, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input name=\"Talla\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=", 1144, "", 1172, 1);
#nullable restore
#line 25 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Index.cshtml"
WriteAttributeValue("", 1151, producto.Description, 1151, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <button class=\"my-RestButton\" type=\"submit\"> <i class=\"fa-solid fa-minus\"></i> </button>\r\n                    ");
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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfb359653d6bdbfe786c7edf4286ddb02bf73fee9902", async() => {
                WriteLiteral("\r\n                        <input name=\"Redirect\" type=\"hidden\" value=\"Orders\" />\r\n                        <input name=\"Id\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=", 1529, "", 1548, 1);
#nullable restore
#line 30 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Index.cshtml"
WriteAttributeValue("", 1536, producto.Id, 1536, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input name=\"Talla\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=", 1610, "", 1638, 1);
#nullable restore
#line 31 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Index.cshtml"
WriteAttributeValue("", 1617, producto.Description, 1617, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <button class=\"my-AddButton\" type=\"submit\"><i class=\"fa-solid fa-plus\"></i></button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"my-ProductCardOrderImg\">\r\n                <img");
            BeginWriteAttribute("src", " src=", 1896, "", 1916, 1);
#nullable restore
#line 37 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Index.cshtml"
WriteAttributeValue("", 1901, producto.Image, 1901, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Product\" />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 40 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <h3 class=\"text-center my-2\">Total De Orden De Pedido: $<span>");
#nullable restore
#line 42 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Index.cshtml"
                                                             Write(ViewData["TotalPrice"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".00</span></h3>\r\n");
            WriteLiteral("    <div class=\"my-buttonOrderContainer\">\r\n        <a href=\"/Orders/SubmitOrder\" class=\"my-4 My-buttonProducts\">Ordenar Pedido</a>\r\n    </div>\r\n");
#nullable restore
#line 47 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Index.cshtml"
} else {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <p class=\"text-center\">No agregaste ningun producto!, para agregar productos, da <a href=\"/Products/Index\">click aquí</a></p>\r\n    </div>\r\n");
#nullable restore
#line 51 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Orders\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
