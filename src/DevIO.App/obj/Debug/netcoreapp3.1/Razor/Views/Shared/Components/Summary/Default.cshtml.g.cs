#pragma checksum "C:\Users\Rodrigo\Documents\cursos\desenvolvedorIO\02_dominando_ASPdotNET_MVC_Core\10_DesenvolvendoAppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "361216cc1621e540d19b397503d3e3c92153ff91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Summary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Summary/Default.cshtml")]
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
#line 1 "C:\Users\Rodrigo\Documents\cursos\desenvolvedorIO\02_dominando_ASPdotNET_MVC_Core\10_DesenvolvendoAppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\_ViewImports.cshtml"
using DevIO.App;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361216cc1621e540d19b397503d3e3c92153ff91", @"/Views/Shared/Components/Summary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b042e5fc3232b5e5435141a47b6f7f1bfc6439c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Summary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-top: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Rodrigo\Documents\cursos\desenvolvedorIO\02_dominando_ASPdotNET_MVC_Core\10_DesenvolvendoAppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml"
 if (ViewData.ModelState.ErrorCount > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"padding-top: 15px;\"></div>\r\n");
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">x</button>\r\n        <h3 id=\"msgRetorno\" style=\"padding-top: 20px;\">Ops! Algo deu errado :(</h3>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "361216cc1621e540d19b397503d3e3c92153ff914517", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 8 "C:\Users\Rodrigo\Documents\cursos\desenvolvedorIO\02_dominando_ASPdotNET_MVC_Core\10_DesenvolvendoAppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 10 "C:\Users\Rodrigo\Documents\cursos\desenvolvedorIO\02_dominando_ASPdotNET_MVC_Core\10_DesenvolvendoAppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\Rodrigo\Documents\cursos\desenvolvedorIO\02_dominando_ASPdotNET_MVC_Core\10_DesenvolvendoAppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml"
 if (!string.IsNullOrEmpty(ViewBag.Sucesso))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"padding-top: 15px;\"></div>\r\n");
            WriteLiteral("    <div id=\"msg_box\" class=\"alert alert-success\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">x</button>\r\n        <h3 id=\"msgRetorno\">");
#nullable restore
#line 18 "C:\Users\Rodrigo\Documents\cursos\desenvolvedorIO\02_dominando_ASPdotNET_MVC_Core\10_DesenvolvendoAppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml"
                       Write(ViewBag.Sucesso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Users\Rodrigo\Documents\cursos\desenvolvedorIO\02_dominando_ASPdotNET_MVC_Core\10_DesenvolvendoAppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\Rodrigo\Documents\cursos\desenvolvedorIO\02_dominando_ASPdotNET_MVC_Core\10_DesenvolvendoAppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml"
 if (TempData["Sucesso"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"padding-top: 15px;\"></div>\r\n");
            WriteLiteral("    <div id=\"msg_box\" class=\"alert alert-success\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">x</button>\r\n        <h4 id=\"msgRetorno\">");
#nullable restore
#line 28 "C:\Users\Rodrigo\Documents\cursos\desenvolvedorIO\02_dominando_ASPdotNET_MVC_Core\10_DesenvolvendoAppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml"
                       Write(Html.Raw(TempData["Sucesso"].ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n");
#nullable restore
#line 30 "C:\Users\Rodrigo\Documents\cursos\desenvolvedorIO\02_dominando_ASPdotNET_MVC_Core\10_DesenvolvendoAppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591