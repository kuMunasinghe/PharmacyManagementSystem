#pragma checksum "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\UserManagement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ea5f8a7825fafeb6475ba34820287774030a6cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserManagement_Index), @"mvc.1.0.view", @"/Views/UserManagement/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ea5f8a7825fafeb6475ba34820287774030a6cf", @"/Views/UserManagement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7646a9d3f6dbc3a97607785fcc1715c04f59c17b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_UserManagement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PMS.Models.Users>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\UserManagement\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutHome.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\UserManagement\Index.cshtml"
 if (TempData["Message"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n        <strong>SUCCESS</strong> ");
#nullable restore
#line 10 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\UserManagement\Index.cshtml"
                            Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n    </div>\r\n");
#nullable restore
#line 15 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\UserManagement\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3> 👤⚙️    Users</h3>\r\n<br/>\r\n<p>\r\n    ");
#nullable restore
#line 19 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\UserManagement\Index.cshtml"
Write(Html.ActionLink("➕ Create a User", "Create","UserManagement", null,new{@class="btn btn-info"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</p>
<div style=""overflow:scroll;"">
<table class=""table"">
    <thead>
        <tr>
            <th>
               ID
            </th>
            <th>
               First Name
            </th>
            <th>
               Last Name
            </th>
            <th>
              Email
            </th>
            <th>
             Password
            </th>
            <th>
             Mobile No:
            </th>
            <th>
               Address
            </th>
             <th>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 50 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\UserManagement\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\UserManagement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\UserManagement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.First_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\UserManagement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Last_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\UserManagement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                    ◾◾◾◾◾◾\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\UserManagement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\UserManagement\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                \r\n                ");
#nullable restore
#line 75 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\UserManagement\Index.cshtml"
           Write(Html.ActionLink("Edit","Edit","UserManagement", new { Id = item.Id},new { @class="btn btn-warning btn-sm"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 76 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\UserManagement\Index.cshtml"
           Write(Html.ActionLink("Delete","Delete","UserManagement", new { Id = item.Id},new { @class="btn btn-danger btn-sm " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 79 "C:\Users\kasun\OneDrive\Desktop\PharmacyManagementSystem\Views\UserManagement\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PMS.Models.Users>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591