#pragma checksum "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\Agendamentos\Agenda.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "353222cd3f80ffd0a35d81e6b03b68ac662aa27e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agendamentos_Agenda), @"mvc.1.0.view", @"/Views/Agendamentos/Agenda.cshtml")]
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
#line 1 "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\Agendamentos\Agenda.cshtml"
using Athletica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"353222cd3f80ffd0a35d81e6b03b68ac662aa27e", @"/Views/Agendamentos/Agenda.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5214e3272bdbea3c0925a3008d587618e2c4ebb", @"/Views/_ViewImports.cshtml")]
    public class Views_Agendamentos_Agenda : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Agendamentos>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "353222cd3f80ffd0a35d81e6b03b68ac662aa27e3445", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\" />\r\n    <title></title>\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"/css/style.css\" />\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "353222cd3f80ffd0a35d81e6b03b68ac662aa27e4631", async() => {
                WriteLiteral(@"
    <!--<div class=""botoes"">
        <div class=""imagem_agenda"">
            <img src=""logo_athletica_sem_fundo-2.png"" alt=""Minha Figura"" width=""250px"" height=""150px"">
        </div> -->    
    </div>

        <table border=""1"" style='width:50%'>
            
                        Tabela para organizar as informaçoes que irão ser trazida do Banco de dados
                    
            <tr>
                <th>Id</th>
                <th>Nome</th>
");
                WriteLiteral("            </tr>\r\n\r\n");
#nullable restore
#line 28 "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\Agendamentos\Agenda.cshtml"
             foreach (var agenda in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\Agendamentos\Agenda.cshtml"
                   Write(agenda.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 35 "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\Agendamentos\Agenda.cshtml"
                   Write(agenda.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>   \r\n");
#nullable restore
#line 38 "C:\Users\Familiaa\Downloads\Inter\Inter\Athletica\Views\Agendamentos\Agenda.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("    \r\n        </table> \r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Agendamentos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
