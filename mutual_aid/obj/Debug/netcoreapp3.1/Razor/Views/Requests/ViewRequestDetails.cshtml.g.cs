#pragma checksum "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07199cde03d6361f64867d607358adda14dc5ac1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Requests_ViewRequestDetails), @"mvc.1.0.view", @"/Views/Requests/ViewRequestDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07199cde03d6361f64867d607358adda14dc5ac1", @"/Views/Requests/ViewRequestDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6058ff2f1b4eeca5d40c1aa9235af95168511ef2", @"/Views/_ViewImports.cshtml")]
    public class Views_Requests_ViewRequestDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Request>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "requestId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Requests", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewRequests", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AcceptedRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
  
    ViewData["Title"] = "RequestDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-info\">\r\n    <h2>Request Information</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07199cde03d6361f64867d607358adda14dc5ac16021", async() => {
                WriteLiteral("\r\n        <h4>\r\n            Requester\'s Information<br />\r\n            <br />\r\n            Name: ");
#nullable restore
#line 12 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
             Write(Model.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 12 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
                              Write(Model.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            Phone Number: ");
#nullable restore
#line 13 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
                     Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            Email: ");
#nullable restore
#line 14 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
              Write(Model.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            County: ");
#nullable restore
#line 15 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
               Write(Model.County);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n        </h4>\r\n\r\n        <table class=\"request\">\r\n            <tr>\r\n                <th>Request #</th>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
               Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Request Date</th>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
               Write(Model.Date.Date.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Toilet Paper</th>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
               Write(Model.ToiletPaper);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Paper Towels</th>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
               Write(Model.PaperTowels);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Hand Soap</th>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
               Write(Model.HandSoap);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Shampoo</th>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
               Write(Model.Shampoo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Conditioner</th>\r\n                <td>");
#nullable restore
#line 45 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
               Write(Model.Conditioner);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Toothpaste</th>\r\n                <td>");
#nullable restore
#line 49 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
               Write(Model.Toothpaste);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Disinfectant</th>\r\n                <td>");
#nullable restore
#line 53 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
               Write(Model.Disinfectant);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Dairy</th>\r\n                <td>");
#nullable restore
#line 57 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
               Write(Model.Dairy);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Bread</th>\r\n                <td>");
#nullable restore
#line 61 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
               Write(Model.Bread);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Cereal</th>\r\n                <td>");
#nullable restore
#line 65 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
               Write(Model.Cereal);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Pantry Items</th>\r\n                <td>");
#nullable restore
#line 69 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
               Write(Model.Pantry);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Produce</th>\r\n                <td>");
#nullable restore
#line 73 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
               Write(Model.Produce);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Canned Food</th>\r\n                <td>");
#nullable restore
#line 77 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
               Write(Model.CannedFood);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Meat</th>\r\n                <td>");
#nullable restore
#line 81 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
               Write(Model.Meat);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Seafood</th>\r\n                <td>");
#nullable restore
#line 85 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
               Write(Model.Seafood);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Allergies</th>\r\n                <td>");
#nullable restore
#line 89 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
               Write(Model.Allergens);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n        <input type=\"submit\" value=\"Accept Request\" class=\"btn btn-primary\" />\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "07199cde03d6361f64867d607358adda14dc5ac114436", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 93 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Requests\ViewRequestDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07199cde03d6361f64867d607358adda14dc5ac116451", async() => {
                    WriteLiteral("Back to Request");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
