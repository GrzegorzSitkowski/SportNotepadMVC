#pragma checksum "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Goal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5545a38203897950095bc439ddebfcca1dce5ad2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Goal_Index), @"mvc.1.0.view", @"/Views/Goal/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5545a38203897950095bc439ddebfcca1dce5ad2", @"/Views/Goal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3b6ee8ce64e54d16b45460389e77d29fb403e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Goal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SportNotepadMVC.Application.ViewModels.Goal.ListGoalForListVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Goal\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Plany/Cele</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5545a38203897950095bc439ddebfcca1dce5ad23875", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Data
            </th>
            <th>
                Nazwa
            </th>
            <th>
                Dystans
            </th>
            <th>
                Czas
            </th>
            <th>
                Opłacone?
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 34 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Goal\Index.cshtml"
 foreach (var item in Model.Goals) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Goal\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Goal\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Goal\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Distance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Goal\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Goal\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Paid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Goal\Index.cshtml"
           Write(Html.ActionLink("Edytuj", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 53 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Goal\Index.cshtml"
           Write(Html.ActionLink("Szczegóły", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 54 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Goal\Index.cshtml"
           Write(Html.ActionLink("Usuń", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\Goal\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SportNotepadMVC.Application.ViewModels.Goal.ListGoalForListVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
