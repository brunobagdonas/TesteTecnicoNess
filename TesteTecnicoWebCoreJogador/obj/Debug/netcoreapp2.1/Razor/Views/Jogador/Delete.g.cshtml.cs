#pragma checksum "C:\Users\dell\source\repos\TesteWebCoreJogadorSolution\TesteTecnicoWebCoreJogador\Views\Jogador\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60f71650fc31aff79c26cc41bb7d76f84d2fb4ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jogador_Delete), @"mvc.1.0.view", @"/Views/Jogador/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Jogador/Delete.cshtml", typeof(AspNetCore.Views_Jogador_Delete))]
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
#line 1 "C:\Users\dell\source\repos\TesteWebCoreJogadorSolution\TesteTecnicoWebCoreJogador\Views\_ViewImports.cshtml"
using TesteTecnicoWebCoreJogador;

#line default
#line hidden
#line 2 "C:\Users\dell\source\repos\TesteWebCoreJogadorSolution\TesteTecnicoWebCoreJogador\Views\_ViewImports.cshtml"
using TesteTecnicoWebCoreJogador.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60f71650fc31aff79c26cc41bb7d76f84d2fb4ee", @"/Views/Jogador/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce3502a37ea7c42bb6fa7c6db7ea57cc5865fa00", @"/Views/_ViewImports.cshtml")]
    public class Views_Jogador_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TesteTecnicoWebCoreJogador.Models.Jogador>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/small-business.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo-corinthians.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\dell\source\repos\TesteWebCoreJogadorSolution\TesteTecnicoWebCoreJogador\Views\Jogador\Delete.cshtml"
  
    ViewBag.Title = "Delete";

#line default
#line hidden
            BeginContext(90, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(119, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7912857eec4649418755e6ff1d44136d", async() => {
                BeginContext(125, 48, true);
                WriteLiteral("\r\n\r\n    <title>Demitir jogador</title>\r\n\r\n\r\n    ");
                EndContext();
                BeginContext(173, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3734f617a284485b8df0ab66942c7e6", async() => {
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
                EndContext();
                BeginContext(223, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(229, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ef0999376b5c462cb03ecbc50b50d912", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(284, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(295, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(299, 1723, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d031e32539ef4efeb1b0c47960914e9c", async() => {
                BeginContext(305, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(313, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "16795a28fd0a48a586463ba02e897df3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(356, 142, true);
                WriteLiteral("<h2>Demitir jogador</h2>\r\n\r\n    <h3>Tem certeza que deseja demitir o jogador?</h3>\r\n    <div>\r\n        <div>\r\n            <hr />\r\n            ");
                EndContext();
                BeginContext(498, 1427, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "430995e767684e60b2263a222de6159e", async() => {
                    BeginContext(524, 98, true);
                    WriteLiteral("\r\n                <dl class=\"dl-horizontal\">\r\n\r\n                    <dt>\r\n                        ");
                    EndContext();
                    BeginContext(623, 45, false);
#line 32 "C:\Users\dell\source\repos\TesteWebCoreJogadorSolution\TesteTecnicoWebCoreJogador\Views\Jogador\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.IdJogador));

#line default
#line hidden
                    EndContext();
                    BeginContext(668, 79, true);
                    WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                    EndContext();
                    BeginContext(748, 41, false);
#line 35 "C:\Users\dell\source\repos\TesteWebCoreJogadorSolution\TesteTecnicoWebCoreJogador\Views\Jogador\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.IdJogador));

#line default
#line hidden
                    EndContext();
                    BeginContext(789, 79, true);
                    WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
                    EndContext();
                    BeginContext(869, 40, false);
#line 38 "C:\Users\dell\source\repos\TesteWebCoreJogadorSolution\TesteTecnicoWebCoreJogador\Views\Jogador\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
                    EndContext();
                    BeginContext(909, 79, true);
                    WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                    EndContext();
                    BeginContext(989, 36, false);
#line 41 "C:\Users\dell\source\repos\TesteWebCoreJogadorSolution\TesteTecnicoWebCoreJogador\Views\Jogador\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
                    EndContext();
                    BeginContext(1025, 79, true);
                    WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
                    EndContext();
                    BeginContext(1105, 41, false);
#line 44 "C:\Users\dell\source\repos\TesteWebCoreJogadorSolution\TesteTecnicoWebCoreJogador\Views\Jogador\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Idade));

#line default
#line hidden
                    EndContext();
                    BeginContext(1146, 79, true);
                    WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                    EndContext();
                    BeginContext(1226, 37, false);
#line 47 "C:\Users\dell\source\repos\TesteWebCoreJogadorSolution\TesteTecnicoWebCoreJogador\Views\Jogador\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Idade));

#line default
#line hidden
                    EndContext();
                    BeginContext(1263, 79, true);
                    WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
                    EndContext();
                    BeginContext(1343, 48, false);
#line 50 "C:\Users\dell\source\repos\TesteWebCoreJogadorSolution\TesteTecnicoWebCoreJogador\Views\Jogador\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.NumeroCamisa));

#line default
#line hidden
                    EndContext();
                    BeginContext(1391, 79, true);
                    WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                    EndContext();
                    BeginContext(1471, 44, false);
#line 53 "C:\Users\dell\source\repos\TesteWebCoreJogadorSolution\TesteTecnicoWebCoreJogador\Views\Jogador\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.NumeroCamisa));

#line default
#line hidden
                    EndContext();
                    BeginContext(1515, 79, true);
                    WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
                    EndContext();
                    BeginContext(1595, 48, false);
#line 56 "C:\Users\dell\source\repos\TesteWebCoreJogadorSolution\TesteTecnicoWebCoreJogador\Views\Jogador\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.GolsMarcados));

#line default
#line hidden
                    EndContext();
                    BeginContext(1643, 79, true);
                    WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                    EndContext();
                    BeginContext(1723, 44, false);
#line 59 "C:\Users\dell\source\repos\TesteWebCoreJogadorSolution\TesteTecnicoWebCoreJogador\Views\Jogador\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.GolsMarcados));

#line default
#line hidden
                    EndContext();
                    BeginContext(1767, 151, true);
                    WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n                <input type=\"submit\" value=\"Demitir\" class=\"btn btn-default\" /> |\r\n\r\n\r\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1925, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1939, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a9cb3a3a1f0441bb51e336721bc6279", async() => {
                    BeginContext(1961, 20, true);
                    WriteLiteral("Retorna para a Lista");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1985, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(2022, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TesteTecnicoWebCoreJogador.Models.Jogador> Html { get; private set; }
    }
}
#pragma warning restore 1591
