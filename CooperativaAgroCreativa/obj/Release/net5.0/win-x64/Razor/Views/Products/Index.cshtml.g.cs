#pragma checksum "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deaaecd0fd17373de5111fa7813e485c5a52098a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Products\Index.cshtml"
using CooperativaAgroCreativa.Models.DB;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deaaecd0fd17373de5111fa7813e485c5a52098a", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3774771a83eb64203d53d5675dc55c6a9b96377c", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Pequeña", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Mediana", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Grande", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Extra grande", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Orders/AddProductOrder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Products\Index.cshtml"
  
    ViewData["Productos"] = "my-buttonActive";
    ViewData["Title"] = "Productos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"My-ProductsContainer\">\r\n    <h1 class=\"text-center my-4\">Catálogo de productos</h1>\r\n    <div>\r\n");
#nullable restore
#line 11 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Products\Index.cshtml"
     foreach (var producto in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"My-ProductsItems\">\r\n       <div class=\"My-ProducstItems-Left\">\r\n           <h2 class=\"text-center\">Código producto: ");
#nullable restore
#line 15 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Products\Index.cshtml"
                                               Write(producto.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n           <div class=\"My-ProducstItems-Left_text\">\r\n               <p class=\"My-ProductsTextTitle\"><b>Descripción</b></p>\r\n               <p>");
#nullable restore
#line 18 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Products\Index.cshtml"
             Write(producto.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deaaecd0fd17373de5111fa7813e485c5a52098a7065", async() => {
                WriteLiteral("\r\n               <div class=\"My-ProductsTextInfo\">\r\n                   <p><b>Cantidad disponible:</b> ");
#nullable restore
#line 21 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Products\Index.cshtml"
                                             Write(producto.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                   \r\n");
#nullable restore
#line 23 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Products\Index.cshtml"
                    if(producto.Sizes == 0) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                       <p><b>Talla:</b> <select name=\"Talla\">\r\n                       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deaaecd0fd17373de5111fa7813e485c5a52098a8107", async() => {
                    WriteLiteral("Pequeña");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deaaecd0fd17373de5111fa7813e485c5a52098a9354", async() => {
                    WriteLiteral("Mediana");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deaaecd0fd17373de5111fa7813e485c5a52098a10601", async() => {
                    WriteLiteral("Grande");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deaaecd0fd17373de5111fa7813e485c5a52098a11848", async() => {
                    WriteLiteral("Extra Grande");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                   </select></p>\r\n");
#nullable restore
#line 30 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Products\Index.cshtml"
                   } else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                       <input type=\"hidden\" name=\"Talla\" value=\"No aplica\"/>\r\n                       <p style=\"color: gray;\">Talla no aplicable</p>\r\n");
#nullable restore
#line 33 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Products\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
                WriteLiteral("               </div>\r\n               <div class=\"My-ProductsTextFooter\">\r\n                   <h2>¢<span>");
#nullable restore
#line 36 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Products\Index.cshtml"
                         Write(producto.UnityPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></h2>\r\n                   \r\n                       <input name=\"Id\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=", 1679, "", 1698, 1);
#nullable restore
#line 38 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Products\Index.cshtml"
WriteAttributeValue("", 1686, producto.Id, 1686, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                       <button class=\"My-buttonProducts text-center\" type=\"submit\">Agregar <i class=\"fa-solid fa-cart-plus\"></i></button>\r\n               </div>\r\n               ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n           </div>\r\n       </div>\r\n       <div class=\"My-ProducstItems-Right\">\r\n           <img");
            BeginWriteAttribute("src", " src=", 1983, "", 2003, 1);
#nullable restore
#line 45 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Products\Index.cshtml"
WriteAttributeValue("", 1988, producto.Image, 1988, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n       </div>\r\n    </div>\r\n");
#nullable restore
#line 48 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Products\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
