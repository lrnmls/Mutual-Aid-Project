#pragma checksum "C:\Users\Lauren Miles\OneDrive\Projects\EFCorePractice\EFCorePractice\Views\User\ViewUserDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42fbe9b02a9a7036943bae2f34d1ad84e23e8dfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ViewUserDetails), @"mvc.1.0.view", @"/Views/User/ViewUserDetails.cshtml")]
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
#line 1 "C:\Users\Lauren Miles\OneDrive\Projects\EFCorePractice\EFCorePractice\Views\_ViewImports.cshtml"
using EFCorePractice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lauren Miles\OneDrive\Projects\EFCorePractice\EFCorePractice\Views\_ViewImports.cshtml"
using EFCorePractice.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42fbe9b02a9a7036943bae2f34d1ad84e23e8dfa", @"/Views/User/ViewUserDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f1eb9388c7e025847297f2b41da3764cb4949ad", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ViewUserDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lauren Miles\OneDrive\Projects\EFCorePractice\EFCorePractice\Views\User\ViewUserDetails.cshtml"
  
    ViewData["Title"] = "View Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>User Details</h1>
<table>
    <thead>
        <tr>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Email</th>
            <th>Phone Number</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>");
#nullable restore
#line 18 "C:\Users\Lauren Miles\OneDrive\Projects\EFCorePractice\EFCorePractice\Views\User\ViewUserDetails.cshtml"
           Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\Lauren Miles\OneDrive\Projects\EFCorePractice\EFCorePractice\Views\User\ViewUserDetails.cshtml"
           Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Lauren Miles\OneDrive\Projects\EFCorePractice\EFCorePractice\Views\User\ViewUserDetails.cshtml"
           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Lauren Miles\OneDrive\Projects\EFCorePractice\EFCorePractice\Views\User\ViewUserDetails.cshtml"
           Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591