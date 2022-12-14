#pragma checksum "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\Retail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3075229df13b65de7fb66172a4aeac47d2b264f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Retail_Index), @"mvc.1.0.view", @"/Views/Retail/Index.cshtml")]
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
#line 1 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\_ViewImports.cshtml"
using PMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\_ViewImports.cshtml"
using PMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3075229df13b65de7fb66172a4aeac47d2b264f8", @"/Views/Retail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7646a9d3f6dbc3a97607785fcc1715c04f59c17b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Retail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PMS.Models.Retail>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\Retail\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutHome.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>🏥 Retail Pharamacy</h4>\r\n<br />\r\n<p>This page contains the details of retailers in PMS.</p>\r\n<hr />\r\n<br />\r\n<p>\r\n    ");
#nullable restore
#line 14 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\Retail\Index.cshtml"
Write(Html.ActionLink("+🏥 Add Retailer", "Create","Retail", null,new{@class="btn btn-info"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
#nullable restore
#line 16 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\Retail\Index.cshtml"
 if (TempData["Message"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info alert-dismissible fade show\" role=\"alert\">\r\n        <strong>Alert ❗</strong> ");
#nullable restore
#line 19 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\Retail\Index.cshtml"
                            Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n    </div>\r\n");
#nullable restore
#line 24 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\Retail\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table"">
    <thead>
        <tr>
            <th>
                ID
            </th>
            <th>
                Retailer Name
            </th>
            <th>
                Type
            </th>
            <th>
                Tel:
            </th>
            <th>
              Address
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 47 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\Retail\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\Retail\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\Retail\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\Retail\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\Retail\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\Retail\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n               ");
#nullable restore
#line 65 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\Retail\Index.cshtml"
          Write(Html.ActionLink("Edit","Edit","Retail", new { Id = item.Id},new { @class="btn btn-warning btn-sm"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 66 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\Retail\Index.cshtml"
           Write(Html.ActionLink("Delete","Delete","Retail", new { Id = item.Id},new { @class="btn btn-danger btn-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 69 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\Retail\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PMS.Models.Retail>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
