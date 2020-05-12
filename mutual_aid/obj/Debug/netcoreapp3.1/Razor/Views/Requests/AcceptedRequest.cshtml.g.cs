#pragma checksum "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "793c155351baa7ff1ca5332e14d0219c72506bb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Requests_AcceptedRequest), @"mvc.1.0.view", @"/Views/Requests/AcceptedRequest.cshtml")]
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
#line 1 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"793c155351baa7ff1ca5332e14d0219c72506bb7", @"/Views/Requests/AcceptedRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6058ff2f1b4eeca5d40c1aa9235af95168511ef2", @"/Views/_ViewImports.cshtml")]
    public class Views_Requests_AcceptedRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Request>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
  
    ViewData["Title"] = "AcceptedRequest";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"page-info\">\r\n        <p>\r\n            Thank you for accepting this request.\r\n            You will be emailed a summary of the order and your requester\'s information.\r\n            Please get in contact with ");
#nullable restore
#line 10 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                                  Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" for a plan of delivery.\r\n            We appreciate your help within the community!\r\n        </p>\r\n\r\n        <h2>Summary:</h2>\r\n");
            WriteLiteral("                <h4>\r\n                    Requester\'s Information<br />\r\n                    <br />\r\n                    Name: ");
#nullable restore
#line 19 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                     Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 19 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                                      Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    Phone Number: ");
#nullable restore
#line 20 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                             Write(Regex.Replace(Model.PhoneNumber, @"(\d{3})(\d{3})(\d{4})", "($1) $2-$3"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    Email: ");
#nullable restore
#line 21 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                      Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    County: ");
#nullable restore
#line 22 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                       Write(Model.County);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                </h4>\r\n");
            WriteLiteral("            <table class=\"request\">\r\n                <tr>\r\n                    <th>Request #:</th>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Request Date:</th>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                   Write(Model.Date.Date.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Status:</th>\r\n                    <td>Accepted ");
#nullable restore
#line 36 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                            Write(Model.AcceptedDate.Date.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Toilet Paper</th>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                   Write(Model.ToiletPaper);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Paper Towels</th>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                   Write(Model.PaperTowels);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Hand Soap</th>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                   Write(Model.HandSoap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Shampoo</th>\r\n                    <td>");
#nullable restore
#line 52 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                   Write(Model.Shampoo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Conditioner</th>\r\n                    <td>");
#nullable restore
#line 56 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                   Write(Model.Conditioner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Toothpaste</th>\r\n                    <td>");
#nullable restore
#line 60 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                   Write(Model.Toothpaste);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Disinfectant</th>\r\n                    <td>");
#nullable restore
#line 64 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                   Write(Model.Disinfectant);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Dairy</th>\r\n                    <td>");
#nullable restore
#line 68 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                   Write(Model.Dairy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Bread</th>\r\n                    <td>");
#nullable restore
#line 72 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                   Write(Model.Bread);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Cereal</th>\r\n                    <td>");
#nullable restore
#line 76 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                   Write(Model.Cereal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Pantry Items</th>\r\n                    <td>");
#nullable restore
#line 80 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                   Write(Model.Pantry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Produce</th>\r\n                    <td>");
#nullable restore
#line 84 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                   Write(Model.Produce);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Canned Food</th>\r\n                    <td>");
#nullable restore
#line 88 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                   Write(Model.CannedFood);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Meat</th>\r\n                    <td>");
#nullable restore
#line 92 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                   Write(Model.Meat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Seafood</th>\r\n                    <td>");
#nullable restore
#line 96 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                   Write(Model.Seafood);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Allergies</th>\r\n                    <td>");
#nullable restore
#line 100 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\AcceptedRequest.cshtml"
                   Write(Model.Allergens);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </table>\r\n");
            WriteLiteral("    </div>\r\n");
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
