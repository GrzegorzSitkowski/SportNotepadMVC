#pragma checksum "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\ProfileUser\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d30a1f3f953a826437cba97a9ccb2441fda3bab6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProfileUser_Details), @"mvc.1.0.view", @"/Views/ProfileUser/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d30a1f3f953a826437cba97a9ccb2441fda3bab6", @"/Views/ProfileUser/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3b6ee8ce64e54d16b45460389e77d29fb403e4", @"/Views/_ViewImports.cshtml")]
    public class Views_ProfileUser_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SportNotepadMVC.Application.ViewModels.ProfileUser.ProfileUserDisplayVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\ProfileUser\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Profil</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            Imię i nazwisko\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\ProfileUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Wiek\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\ProfileUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Waga\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\ProfileUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral(" kg\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Rekord na 5km\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\ProfileUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pb5k));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Rekord na 10km\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\ProfileUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pb10k));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Rekord w półmaratonie\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\ProfileUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.PbHalfMarathon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Rekord w maratonie\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\ProfileUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.PbMarathon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Liczba zawodów\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 58 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\ProfileUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.CountCompetitions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
            WriteLiteral("    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 69 "C:\Users\sitko\OneDrive\Pulpit\Programowanie\SportNotepadMVC\SportNotepadMVC\SportNotepadMVC.Web\Views\ProfileUser\Details.cshtml"
Write(Html.ActionLink("Edytuj", "Edit", new { /* id = Model.PrimaryKey */ }, new {@class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SportNotepadMVC.Application.ViewModels.ProfileUser.ProfileUserDisplayVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
