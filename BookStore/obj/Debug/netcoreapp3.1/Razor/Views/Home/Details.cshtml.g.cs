#pragma checksum "C:\Users\Chant\source\repos\BookStore\BookStore\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f05b0670ac58d7d935076ff2463010c21174bace"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\Chant\source\repos\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Chant\source\repos\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Chant\source\repos\BookStore\BookStore\Views\Home\Details.cshtml"
using BookStore.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f05b0670ac58d7d935076ff2463010c21174bace", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ad2232b60c18355d1b72e2ff9366751045b67", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("trash"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Trash.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex align-items-center justify-content-between  py-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Chant\source\repos\BookStore\BookStore\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Book details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Page Header -->
<!-- Breadcrumb -->
<div class=""breadcrumb-bar"">
    <div class=""container-fluid"">
        <div class=""row align-items-center"">
            <div class=""col-md-12 col-12"">
                <nav aria-label=""breadcrumb"" class=""page-breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f05b0670ac58d7d935076ff2463010c21174bace6637", async() => {
                WriteLiteral("SBX Book library");
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
            WriteLiteral(@"</li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Details</li>
                    </ol>
                </nav>
                <h2 class=""breadcrumb-title"">Book Details</h2>
            </div>
        </div>
    </div>
</div>
<!-- /Breadcrumb -->

<div class=""container py-5"">
    <div class=""col-md-12"">
        <div class=""card "">
            <div class=""card-header"">
                <h4 class=""card-title"">Details</h4>
            </div>
            <div class=""card-body "">
                <div class=""d-flex flex-column flex-sm-row  justify-content-start align-items-sm-center pb-4"">
                    <div class=""d-flex align-items-center px-0 BoxExHome"">
                        <img class=""img-thumbnail details""");
            BeginWriteAttribute("src", " src=\"", 1291, "\"", 1341, 1);
#nullable restore
#line 36 "C:\Users\Chant\source\repos\BookStore\BookStore\Views\Home\Details.cshtml"
WriteAttributeValue("", 1297, Url.Content("~/images/Covers/"+Model.Cover), 1297, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1342, "\"", 1369, 3);
            WriteAttributeValue("", 1348, "Cover", 1348, 5, true);
            WriteAttributeValue(" ", 1353, "of", 1354, 3, true);
#nullable restore
#line 36 "C:\Users\Chant\source\repos\BookStore\BookStore\Views\Home\Details.cshtml"
WriteAttributeValue(" ", 1356, Model.Title, 1357, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1370, "\"", 1399, 3);
            WriteAttributeValue("", 1378, "Cover", 1378, 5, true);
            WriteAttributeValue(" ", 1383, "of", 1384, 3, true);
#nullable restore
#line 36 "C:\Users\Chant\source\repos\BookStore\BookStore\Views\Home\Details.cshtml"
WriteAttributeValue(" ", 1386, Model.Title, 1387, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"px-3 col\">\r\n                        <h4>");
#nullable restore
#line 39 "C:\Users\Chant\source\repos\BookStore\BookStore\Views\Home\Details.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <h5>");
#nullable restore
#line 40 "C:\Users\Chant\source\repos\BookStore\BookStore\Views\Home\Details.cshtml"
                       Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f05b0670ac58d7d935076ff2463010c21174bace10553", async() => {
                WriteLiteral("\r\n                            <h5 class=\"mb-0 \">");
#nullable restore
#line 42 "C:\Users\Chant\source\repos\BookStore\BookStore\Views\Home\Details.cshtml"
                                         Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                            <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 1833, "\"", 1850, 1);
#nullable restore
#line 43 "C:\Users\Chant\source\repos\BookStore\BookStore\Views\Home\Details.cshtml"
WriteAttributeValue("", 1841, Model.Id, 1841, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <button type=\"submit\" class=\"btn danger\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f05b0670ac58d7d935076ff2463010c21174bace11636", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>

                    

                </div>
                <hr style=""background:#999; width: 100%;"" />


                <div class=""row"">
                    <div class=""card-header col-md-12"">
                        <h4>History</h4>
                    </div>
                    <div class=""card col-md-6"">
                        <div class=""card-header"">
                            <h5>BORROW</h5>
                        </div>
                        <div class=""card-body"">
");
#nullable restore
#line 63 "C:\Users\Chant\source\repos\BookStore\BookStore\Views\Home\Details.cshtml"
                             foreach (var i in Model.HistListB)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h6");
            BeginWriteAttribute("class", " class=\"", 2692, "\"", 2700, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 65 "C:\Users\Chant\source\repos\BookStore\BookStore\Views\Home\Details.cshtml"
                                        Write(i.FormattedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 66 "C:\Users\Chant\source\repos\BookStore\BookStore\Views\Home\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>

                    </div>

                    <div class=""card col-md-6"">
                        <div class=""card-header"">
                            <h5>RETURN</h5>
                        </div>
                        <div class=""card-body"">
");
#nullable restore
#line 76 "C:\Users\Chant\source\repos\BookStore\BookStore\Views\Home\Details.cshtml"
                             foreach (var i in Model.HistListR)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h6");
            BeginWriteAttribute("class", " class=\"", 3177, "\"", 3185, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 78 "C:\Users\Chant\source\repos\BookStore\BookStore\Views\Home\Details.cshtml"
                                        Write(i.FormattedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 79 "C:\Users\Chant\source\repos\BookStore\BookStore\Views\Home\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
