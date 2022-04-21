#pragma checksum "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf7b1a8670a0e8e555ef11867762e5b58305fe9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_Index), @"mvc.1.0.view", @"/Views/Administrator/Index.cshtml")]
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
#line 1 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml"
using CooperativaAgroCreativa.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf7b1a8670a0e8e555ef11867762e5b58305fe9d", @"/Views/Administrator/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3774771a83eb64203d53d5675dc55c6a9b96377c", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Administrator/ConfirmUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Administrator/DeleteUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml"
  
    ViewData["Title"] = "Usuarios Solicitantes";
    ViewData["Usuarios"] = "my-buttonActive";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">Usuarios registrados</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml"
 if (Model.Any()) {

    foreach (var user in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card mb-3\">\r\n            <div class=\"card-header\">\r\n                User Id: ");
#nullable restore
#line 16 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml"
                    Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <p><b>Nombre:</b> ");
#nullable restore
#line 19 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml"
                             Write(user.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><b>Rol solicitado:</b> ");
#nullable restore
#line 20 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml"
                                     Write(user.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"my-UserCardButtons\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf7b1a8670a0e8e555ef11867762e5b58305fe9d6416", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 762, "\"", 778, 1);
#nullable restore
#line 24 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml"
WriteAttributeValue("", 770, user.Id, 770, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"role\"");
                BeginWriteAttribute("value", " value=\"", 836, "\"", 854, 1);
#nullable restore
#line 25 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml"
WriteAttributeValue("", 844, user.Role, 844, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"submit\" value=\"Confirmar\"/>\r\n                ");
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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf7b1a8670a0e8e555ef11867762e5b58305fe9d8951", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1070, "\"", 1086, 1);
#nullable restore
#line 29 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml"
WriteAttributeValue("", 1078, user.Id, 1078, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"role\"");
                BeginWriteAttribute("value", " value=\"", 1144, "\"", 1162, 1);
#nullable restore
#line 30 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml"
WriteAttributeValue("", 1152, user.Role, 1152, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"submit\" value=\"Eliminar\"/>\r\n                ");
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
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 36 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml"
    }

} else {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            No hay solicitudes de usuarios!\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 47 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h2 class=""text-center my-4 my-TableNotMobile"">Usuarios activos</h2>
<table class=""table table-bordered my-TableNotMobile"" style=""text-align: right;"">
    <thead>
        <tr>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">Correo</th>
            <th scope=""col"">Dirección</th>
            <th scope=""col"">Telefono</th>
            <th scope=""col"">Rol</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 60 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml"
     foreach(ApplicationUser userComplete in ViewBag.UsuariosCompleto)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td scope=\"row\">");
#nullable restore
#line 63 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml"
                       Write(userComplete.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 64 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml"
           Write(userComplete.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 65 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml"
           Write(userComplete.Direction);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 66 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml"
           Write(userComplete.Movil);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 67 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml"
           Write(userComplete.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 69 "C:\Users\kali_\source\repos\CooperativaAgroCreativa\CooperativaAgroCreativa\Views\Administrator\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
