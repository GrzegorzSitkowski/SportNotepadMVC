#pragma checksum "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Training\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a73b25a7ebf85b5be33218fbe240b28d161d83dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Training_Details), @"mvc.1.0.view", @"/Views/Training/Details.cshtml")]
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
#line 1 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\_ViewImports.cshtml"
using SportNotepadMVC.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\_ViewImports.cshtml"
using SportNotepadMVC.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a73b25a7ebf85b5be33218fbe240b28d161d83dd", @"/Views/Training/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3b6ee8ce64e54d16b45460389e77d29fb403e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Training_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SportNotepadMVC.Application.ViewModels.Training.TrainingDetailsVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Training\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Szczegóły</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n           Id\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Training\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Data\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Training\Details.cshtml"
       Write(Model.Date.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Dystans\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Training\Details.cshtml"
       Write(Html.DisplayFor(model => model.Distance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Wynik\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Training\Details.cshtml"
       Write(Html.DisplayFor(model => model.Result));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Średnie tempo\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Training\Details.cshtml"
       Write(Html.DisplayFor(model => model.AveragePace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Miejsce\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Training\Details.cshtml"
       Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n           Komentarz\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Training\Details.cshtml"
       Write(Html.DisplayFor(model => model.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 57 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Training\Details.cshtml"
Write(Html.ActionLink("Edytuj", "Edit", new {  id = Model.Id  }, new {@class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a73b25a7ebf85b5be33218fbe240b28d161d83dd7785", async() => {
                WriteLiteral("Wróć do listy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SportNotepadMVC.Application.ViewModels.Training.TrainingDetailsVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
