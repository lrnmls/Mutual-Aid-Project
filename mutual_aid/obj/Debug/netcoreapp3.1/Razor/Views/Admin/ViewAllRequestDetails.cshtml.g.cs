#pragma checksum "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7405eeaba5ed30c997cedcf3316a26dd9814e39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ViewAllRequestDetails), @"mvc.1.0.view", @"/Views/Admin/ViewAllRequestDetails.cshtml")]
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
#line 1 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\_ViewImports.cshtml"
using mutual_aid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\_ViewImports.cshtml"
using mutual_aid.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7405eeaba5ed30c997cedcf3316a26dd9814e39", @"/Views/Admin/ViewAllRequestDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6058ff2f1b4eeca5d40c1aa9235af95168511ef2", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ViewAllRequestDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Request>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewAllRequests", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
  
    ViewData["Title"] = "ViewAllRequestDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-info\">\r\n    <h2>Request Information</h2>\r\n    <h4>\r\n        Requester\'s Information<br />\r\n        <br />\r\n        Name: ");
#nullable restore
#line 12 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
         Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 12 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
                          Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        Phone Number: ");
#nullable restore
#line 13 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
                 Write(Regex.Replace(Model.PhoneNumber, @"(\d{3})(\d{3})(\d{4})", "($1) $2-$3"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        Email: ");
#nullable restore
#line 14 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
          Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        County: ");
#nullable restore
#line 15 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
           Write(Model.County);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    </h4>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
     if (Model.IsAccepted == 1 && Model.IsCompleted == 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"request\">\r\n            <tr>\r\n                <th>Request #:</th>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Request Date:</th>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Date.Date.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Status:</th>\r\n                <td>Completed ");
#nullable restore
#line 31 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
                         Write(Model.CompletedDate.Date.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Toilet Paper</th>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.ToiletPaper);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Paper Towels</th>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.PaperTowels);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Hand Soap</th>\r\n                <td>");
#nullable restore
#line 43 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.HandSoap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Shampoo</th>\r\n                <td>");
#nullable restore
#line 47 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Shampoo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Conditioner</th>\r\n                <td>");
#nullable restore
#line 51 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Conditioner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Toothpaste</th>\r\n                <td>");
#nullable restore
#line 55 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Toothpaste);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Disinfectant</th>\r\n                <td>");
#nullable restore
#line 59 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Disinfectant);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Dairy</th>\r\n                <td>");
#nullable restore
#line 63 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Dairy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Bread</th>\r\n                <td>");
#nullable restore
#line 67 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Bread);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Cereal</th>\r\n                <td>");
#nullable restore
#line 71 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Cereal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Pantry Items</th>\r\n                <td>");
#nullable restore
#line 75 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Pantry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Produce</th>\r\n                <td>");
#nullable restore
#line 79 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Produce);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Canned Food</th>\r\n                <td>");
#nullable restore
#line 83 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.CannedFood);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Meat</th>\r\n                <td>");
#nullable restore
#line 87 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Meat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Seafood</th>\r\n                <td>");
#nullable restore
#line 91 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Seafood);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Allergies</th>\r\n                <td>");
#nullable restore
#line 95 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Allergens);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n");
#nullable restore
#line 98 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
    }
    else if (Model.IsAccepted == 1 && Model.IsCompleted == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"request\">\r\n            <tr>\r\n                <th>Request #:</th>\r\n                <td>");
#nullable restore
#line 104 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Request Date:</th>\r\n                <td>");
#nullable restore
#line 108 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Date.Date.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Status:</th>\r\n                <td>Accepted ");
#nullable restore
#line 112 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
                        Write(Model.AcceptedDate.Date.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Toilet Paper</th>\r\n                <td>");
#nullable restore
#line 116 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.ToiletPaper);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Paper Towels</th>\r\n                <td>");
#nullable restore
#line 120 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.PaperTowels);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Hand Soap</th>\r\n                <td>");
#nullable restore
#line 124 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.HandSoap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Shampoo</th>\r\n                <td>");
#nullable restore
#line 128 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Shampoo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Conditioner</th>\r\n                <td>");
#nullable restore
#line 132 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Conditioner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Toothpaste</th>\r\n                <td>");
#nullable restore
#line 136 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Toothpaste);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Disinfectant</th>\r\n                <td>");
#nullable restore
#line 140 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Disinfectant);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Dairy</th>\r\n                <td>");
#nullable restore
#line 144 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Dairy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Bread</th>\r\n                <td>");
#nullable restore
#line 148 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Bread);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Cereal</th>\r\n                <td>");
#nullable restore
#line 152 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Cereal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Pantry Items</th>\r\n                <td>");
#nullable restore
#line 156 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Pantry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Produce</th>\r\n                <td>");
#nullable restore
#line 160 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Produce);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Canned Food</th>\r\n                <td>");
#nullable restore
#line 164 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.CannedFood);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Meat</th>\r\n                <td>");
#nullable restore
#line 168 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Meat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Seafood</th>\r\n                <td>");
#nullable restore
#line 172 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Seafood);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Allergies</th>\r\n                <td>");
#nullable restore
#line 176 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Allergens);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n");
#nullable restore
#line 179 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"request\">\r\n            <tr>\r\n                <th>Request #:</th>\r\n                <td>");
#nullable restore
#line 185 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Request Date:</th>\r\n                <td>");
#nullable restore
#line 189 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Date.Date.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Status:</th>\r\n                <td>Pending</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Toilet Paper</th>\r\n                <td>");
#nullable restore
#line 197 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.ToiletPaper);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Paper Towels</th>\r\n                <td>");
#nullable restore
#line 201 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.PaperTowels);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Hand Soap</th>\r\n                <td>");
#nullable restore
#line 205 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.HandSoap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Shampoo</th>\r\n                <td>");
#nullable restore
#line 209 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Shampoo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Conditioner</th>\r\n                <td>");
#nullable restore
#line 213 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Conditioner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Toothpaste</th>\r\n                <td>");
#nullable restore
#line 217 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Toothpaste);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Disinfectant</th>\r\n                <td>");
#nullable restore
#line 221 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Disinfectant);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Dairy</th>\r\n                <td>");
#nullable restore
#line 225 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Dairy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Bread</th>\r\n                <td>");
#nullable restore
#line 229 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Bread);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Cereal</th>\r\n                <td>");
#nullable restore
#line 233 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Cereal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Pantry Items</th>\r\n                <td>");
#nullable restore
#line 237 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Pantry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Produce</th>\r\n                <td>");
#nullable restore
#line 241 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Produce);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Canned Food</th>\r\n                <td>");
#nullable restore
#line 245 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.CannedFood);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Meat</th>\r\n                <td>");
#nullable restore
#line 249 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Meat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Seafood</th>\r\n                <td>");
#nullable restore
#line 253 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Seafood);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Allergies</th>\r\n                <td>");
#nullable restore
#line 257 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
               Write(Model.Allergens);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n");
#nullable restore
#line 260 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequestDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7405eeaba5ed30c997cedcf3316a26dd9814e3927197", async() => {
                WriteLiteral("Back to Requests");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Request> Html { get; private set; }
    }
}
#pragma warning restore 1591