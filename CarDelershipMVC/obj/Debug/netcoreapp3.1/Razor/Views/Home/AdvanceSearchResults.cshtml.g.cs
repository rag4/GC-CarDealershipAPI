#pragma checksum "C:\Users\RAMON\source\repos\CarDealershipAPI\CarDelershipMVC\Views\Home\AdvanceSearchResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bc1c1a94fd711b69bbed398b0a2750c91bc4845"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AdvanceSearchResults), @"mvc.1.0.view", @"/Views/Home/AdvanceSearchResults.cshtml")]
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
#line 1 "C:\Users\RAMON\source\repos\CarDealershipAPI\CarDelershipMVC\Views\_ViewImports.cshtml"
using CarDelershipMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RAMON\source\repos\CarDealershipAPI\CarDelershipMVC\Views\_ViewImports.cshtml"
using CarDelershipMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bc1c1a94fd711b69bbed398b0a2750c91bc4845", @"/Views/Home/AdvanceSearchResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea608647a97f1a0e4b1e8ae294a36db8c34bb0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AdvanceSearchResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cars>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    table {
        font-family: arial, sans-serif;
        border-collapse: collapse;
        width: 100%;
    }

    td, th {
        border: 1px solid #dddddd;
        text-align: left;
        padding: 8px;
    }

    tr:nth-child(even) {
        background-color: #dddddd;
    }
</style>
<table>
    <tr>
        <th>Make</th>
        <th>Model</th>
        <th>Year</th>
        <th>Color</th>
    </tr>
");
#nullable restore
#line 26 "C:\Users\RAMON\source\repos\CarDealershipAPI\CarDelershipMVC\Views\Home\AdvanceSearchResults.cshtml"
     foreach (Cars c in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\RAMON\source\repos\CarDealershipAPI\CarDelershipMVC\Views\Home\AdvanceSearchResults.cshtml"
           Write(c.make);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\RAMON\source\repos\CarDealershipAPI\CarDelershipMVC\Views\Home\AdvanceSearchResults.cshtml"
           Write(c.model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 31 "C:\Users\RAMON\source\repos\CarDealershipAPI\CarDelershipMVC\Views\Home\AdvanceSearchResults.cshtml"
            Write(c.year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\RAMON\source\repos\CarDealershipAPI\CarDelershipMVC\Views\Home\AdvanceSearchResults.cshtml"
           Write(c.color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\RAMON\source\repos\CarDealershipAPI\CarDelershipMVC\Views\Home\AdvanceSearchResults.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cars>> Html { get; private set; }
    }
}
#pragma warning restore 1591