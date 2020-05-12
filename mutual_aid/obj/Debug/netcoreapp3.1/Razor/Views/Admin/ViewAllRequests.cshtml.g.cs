#pragma checksum "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da4c06b43fb9bbb8539f6c9e173a17d1836071c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ViewAllRequests), @"mvc.1.0.view", @"/Views/Admin/ViewAllRequests.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da4c06b43fb9bbb8539f6c9e173a17d1836071c1", @"/Views/Admin/ViewAllRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6058ff2f1b4eeca5d40c1aa9235af95168511ef2", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ViewAllRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Request>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "requestId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewAllRequestDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
  
    ViewData["Title"] = "ViewAllRequests";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-info\">\r\n    <h2>View All Requests</h2>\r\n    <p>");
#nullable restore
#line 8 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
  Write(TempData["NoRequests"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 9 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
     foreach (Request request in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
         if (request.IsAccepted == 1 && request.IsCompleted == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4>\r\n                Requester Name: ");
#nullable restore
#line 14 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
                           Write(request.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 14 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
                                              Write(request.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                Request #: ");
#nullable restore
#line 15 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
                      Write(request.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                Request Date: ");
#nullable restore
#line 16 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
                         Write(request.Date.Date.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                Status: Completed <br />\r\n                County: ");
#nullable restore
#line 18 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
                   Write(request.County);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            </h4>\r\n");
#nullable restore
#line 20 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
        }
        else if (request.IsAccepted == 1 && request.IsCompleted == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4>\r\n                Requester Name: ");
#nullable restore
#line 24 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
                           Write(request.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 24 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
                                              Write(request.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                Request #: ");
#nullable restore
#line 25 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
                      Write(request.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                Request Date: ");
#nullable restore
#line 26 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
                         Write(request.Date.Date.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                Status: Accepted- pending completion <br />\r\n                County: ");
#nullable restore
#line 28 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
                   Write(request.County);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            </h4>\r\n");
#nullable restore
#line 30 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4>\r\n                Requester Name: ");
#nullable restore
#line 34 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
                           Write(request.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 34 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
                                              Write(request.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                Request #: ");
#nullable restore
#line 35 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
                      Write(request.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                Request Date: ");
#nullable restore
#line 36 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
                         Write(request.Date.Date.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                Status: Pending <br />\r\n                County: ");
#nullable restore
#line 38 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
                   Write(request.County);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            </h4>\r\n");
#nullable restore
#line 40 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da4c06b43fb9bbb8539f6c9e173a17d1836071c111707", async() => {
                WriteLiteral("\r\n            <input type=\"submit\" value=\"View Details\" class=\"btn btn-primary\" />\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "da4c06b43fb9bbb8539f6c9e173a17d1836071c112068", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 43 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => request.Id);

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
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\lrnml\Documents\Projects\mutual_aid\mutual_aid\Views\Admin\ViewAllRequests.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Request>> Html { get; private set; }
    }
}
#pragma warning restore 1591