#pragma checksum "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\Servicos\agendamento_Servico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fa4519ded41b53a037964f6c84c18ad7624a688"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Servicos_agendamento_Servico), @"mvc.1.0.view", @"/Views/Servicos/agendamento_Servico.cshtml")]
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
#line 1 "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\_ViewImports.cshtml"
using Athletica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\_ViewImports.cshtml"
using Athletica.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\Servicos\agendamento_Servico.cshtml"
using Athletica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fa4519ded41b53a037964f6c84c18ad7624a688", @"/Views/Servicos/agendamento_Servico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5214e3272bdbea3c0925a3008d587618e2c4ebb", @"/Views/_ViewImports.cshtml")]
    public class Views_Servicos_agendamento_Servico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Servicos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/logo_athletica_sem_fundo-2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Minha Figura"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Agendamentos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FrmBuscarHorariosAgendados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fa4519ded41b53a037964f6c84c18ad7624a6886729", async() => {
                WriteLiteral(@"
        <meta charset=""UTF-8"" />
        <title>Servicos</title>
        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
        <link rel=""stylesheet"" type=""text/css"" href=""/css/style.css"" />
        <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fa4519ded41b53a037964f6c84c18ad7624a6888162", async() => {
                WriteLiteral("\r\n        <div id=\"resposta\" class=\"alert alert-success\" role=\"alert\" style=\"display : none; text-align: center;\">Agendamento feito com sucesso</div>\r\n        <div id=cale>\r\n        <h2>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4fa4519ded41b53a037964f6c84c18ad7624a6888616", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</h2>
        </div>
        <div class=""calendario"">
            <div class=""cal"">
                        <table border=""1"" style='width:100%'>
                        <!--
                                Tabela para organizar as informaçoes que irão ser trazida do Banco de dados
                            -->
                            
                            <tr>
                                <th>Serviço</th>
                                <th>Dia da semana</th>
                                <th>Horarios</th>
                                <th>Duracao</th>
                            </tr>
");
#nullable restore
#line 30 "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\Servicos\agendamento_Servico.cshtml"
                                 foreach (var servicos in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 34 "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\Servicos\agendamento_Servico.cshtml"
                                       Write(servicos.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 38 "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\Servicos\agendamento_Servico.cshtml"
                                       Write(servicos.Dias);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 42 "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\Servicos\agendamento_Servico.cshtml"
                                       Write(servicos.Horarios);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 46 "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\Servicos\agendamento_Servico.cshtml"
                                       Write(servicos.Duracao);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                    </tr>   \r\n");
#nullable restore
#line 49 "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\Servicos\agendamento_Servico.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                \r\n                        </table>\r\n                    \r\n                        <br>\r\n                        <h1>Agendamentos</h1>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fa4519ded41b53a037964f6c84c18ad7624a68813112", async() => {
                    WriteLiteral("                  \r\n                        <p>\r\n                            <label for=\"inputSelectServicos\">Serviços</label>\r\n                            <select id=\"inputSelectServicos\" name=\"servico\">\r\n                                \r\n");
#nullable restore
#line 60 "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\Servicos\agendamento_Servico.cshtml"
                                 foreach (var agenda in Model)
                                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fa4519ded41b53a037964f6c84c18ad7624a68813978", async() => {
                        WriteLiteral(" ");
#nullable restore
#line 62 "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\Servicos\agendamento_Servico.cshtml"
                                                           Write(agenda.Nome);

#line default
#line hidden
#nullable disable
                        WriteLiteral(" ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\Servicos\agendamento_Servico.cshtml"
                                       WriteLiteral(agenda.Id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\Servicos\agendamento_Servico.cshtml"
                                }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                                                
                            </select>
                        </p>
                        
                        <p>
                            <label for=""inputNome"">Nome da pessoa</label>
                            <input id=""inputNome"" type=""text"" name=""nome"" required=""required""/>
                        </p>

                        <p>
                            <label for=""inputData"">Data</label><br>
                            <input id=""inputData"" type=""date"" name=""data"" required=""required""/>
                        </p>

                        <p>
                            <label");
                    BeginWriteAttribute("for", " for=\"", 3685, "\"", 3691, 0);
                    EndWriteAttribute();
                    WriteLiteral(">Horarário de Início</label>\r\n                            <input id=\"inputHorarioInicio\" type=\"time\" name=\"horario_inicio\" required=\"required\"/>\r\n                        </p>\r\n\r\n                        <p>\r\n                            <label");
                    BeginWriteAttribute("for", " for=\"", 3933, "\"", 3939, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">Horário de Termino</label>
                            <input id=""inputHorarioFim"" type=""time"" name=""horario_fim"" required=""required""/>
                        </p>

                        <br>

                        <p>
                            <input type=""reset"" value=""Limpar"" />
                        </p>

                        <p>
                            <input type=""submit"" value=""Agendar"" id=""ado"" />
                        </p>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fa4519ded41b53a037964f6c84c18ad7624a68819756", async() => {
                    WriteLiteral("\r\n                            <input type=\"submit\" value=\"Ir ver meus horarios\"id=\"ador\"/>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <a href=\"/Cliente/Menu\" class=\"btn btn-primary \" id=\"adorf\">Voltar para o Menu </a>\r\n            </div>\r\n        </div>\r\n    <input type=\"text\" id=\"feedback\"");
                BeginWriteAttribute("value", " value=\"", 4844, "\"", 4869, 1);
#nullable restore
#line 104 "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\Servicos\agendamento_Servico.cshtml"
WriteAttributeValue("", 4852, ViewBag.Feedback, 4852, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display: none;\"/>              \r\n    ");
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
            WriteLiteral(@"
</html>
<script>
    window.addEventListener(""load"", inicia);

    function inicia ()
    {
        var feedback = document.getElementById(""feedback"").value;

     if (feedback == 1)
     {
         document.getElementById(""resposta"").style.display = ""block"";

         setTimeout(function() { document.getElementById(""resposta"").style.display = ""none"";}, 3000);
     }
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Servicos>> Html { get; private set; }
    }
}
#pragma warning restore 1591