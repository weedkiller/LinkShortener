#pragma checksum "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "722b2d680300d24753c840600d1076a9d3ce19b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Dashboard/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Dashboard/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Dashboard_Views_Home_Index))]
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
#line 1 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\_ViewImports.cshtml"
using LinkShortener;

#line default
#line hidden
#line 2 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\_ViewImports.cshtml"
using LinkShortener.Models;

#line default
#line hidden
#line 1 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"722b2d680300d24753c840600d1076a9d3ce19b3", @"/Areas/Dashboard/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ff29dd782d6cf8cb37ef964f68d8cfa2ac8b538", @"/Areas/Dashboard/Views/_ViewImports.cshtml")]
    public class Areas_Dashboard_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LinkShortener.Models.Link>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/dashboard.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/dashboard.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("exclude", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Octicons.TagHelper.OcticonTagHelper __Octicons_TagHelper_OcticonTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(82, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
  
    ViewData["Title"] = Localizer["Dashboard"];

#line default
#line hidden
            BeginContext(180, 126, true);
            WriteLiteral("\r\n\r\n<div class=\"d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pb-2 mb-3 border-bottom\">\r\n    <h1>");
            EndContext();
            BeginContext(307, 22, false);
#line 12 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
   Write(Localizer["Dashboard"]);

#line default
#line hidden
            EndContext();
            BeginContext(329, 342, true);
            WriteLiteral(@"</h1>
    <div class=""btn-toolbar mb-2 mb-md-0"">
        <div class=""dropdown"">
            <a class=""btn btn-secondary dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <span data-feather=""calendar""></span>
                <span id=""ddText"">");
            EndContext();
            BeginContext(672, 22, false);
#line 17 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
                             Write(Localizer["This hour"]);

#line default
#line hidden
            EndContext();
            BeginContext(694, 168, true);
            WriteLiteral("</span>\r\n            </a>\r\n\r\n            <div class=\"dropdown-menu\" aria-labelledby=\"dropdownMenuLink\">\r\n                <a class=\"dropdown-item\" href=\"#\" data-val=\"1\">");
            EndContext();
            BeginContext(863, 22, false);
#line 21 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
                                                          Write(Localizer["This hour"]);

#line default
#line hidden
            EndContext();
            BeginContext(885, 69, true);
            WriteLiteral("</a>\r\n                <a class=\"dropdown-item\" href=\"#\" data-val=\"2\">");
            EndContext();
            BeginContext(955, 21, false);
#line 22 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
                                                          Write(Localizer["This day"]);

#line default
#line hidden
            EndContext();
            BeginContext(976, 69, true);
            WriteLiteral("</a>\r\n                <a class=\"dropdown-item\" href=\"#\" data-val=\"3\">");
            EndContext();
            BeginContext(1046, 22, false);
#line 23 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
                                                          Write(Localizer["This week"]);

#line default
#line hidden
            EndContext();
            BeginContext(1068, 69, true);
            WriteLiteral("</a>\r\n                <a class=\"dropdown-item\" href=\"#\" data-val=\"4\">");
            EndContext();
            BeginContext(1138, 23, false);
#line 24 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
                                                          Write(Localizer["This month"]);

#line default
#line hidden
            EndContext();
            BeginContext(1161, 69, true);
            WriteLiteral("</a>\r\n                <a class=\"dropdown-item\" href=\"#\" data-val=\"5\">");
            EndContext();
            BeginContext(1231, 22, false);
#line 25 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
                                                          Write(Localizer["This year"]);

#line default
#line hidden
            EndContext();
            BeginContext(1253, 64, true);
            WriteLiteral("</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
            EndContext();
#line 31 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
  
    foreach (var link in Model)
    {

#line default
#line hidden
            BeginContext(1361, 41, true);
            WriteLiteral("        <canvas class=\"my-4 w-100 d-none\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1402, "", 1428, 1);
#line 34 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
WriteAttributeValue("", 1406, "chartHour"+link.Id, 1406, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1428, 94, true);
            WriteLiteral(" data-loaded=\"0\" width=\"900\" height=\"380\"></canvas>\r\n        <canvas class=\"my-4 w-100 d-none\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1522, "", 1547, 1);
#line 35 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
WriteAttributeValue("", 1526, "chartDay"+link.Id, 1526, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1547, 94, true);
            WriteLiteral(" data-loaded=\"0\" width=\"900\" height=\"380\"></canvas>\r\n        <canvas class=\"my-4 w-100 d-none\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1641, "", 1667, 1);
#line 36 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
WriteAttributeValue("", 1645, "chartWeek"+link.Id, 1645, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1667, 94, true);
            WriteLiteral(" data-loaded=\"0\" width=\"900\" height=\"380\"></canvas>\r\n        <canvas class=\"my-4 w-100 d-none\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1761, "", 1788, 1);
#line 37 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
WriteAttributeValue("", 1765, "chartMonth"+link.Id, 1765, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1788, 94, true);
            WriteLiteral(" data-loaded=\"0\" width=\"900\" height=\"380\"></canvas>\r\n        <canvas class=\"my-4 w-100 d-none\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1882, "", 1908, 1);
#line 38 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
WriteAttributeValue("", 1886, "chartYear"+link.Id, 1886, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1908, 53, true);
            WriteLiteral(" data-loaded=\"0\" width=\"900\" height=\"380\"></canvas>\r\n");
            EndContext();
#line 39 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1971, 504, true);
            WriteLiteral(@"<canvas class=""my-4 w-100"" id=""chartHour"" data-loaded=""1"" width=""900"" height=""380""></canvas>
<canvas class=""my-4 w-100 d-none"" id=""chartDay"" data-loaded=""1"" width=""900"" height=""380""></canvas>
<canvas class=""my-4 w-100 d-none"" id=""chartWeek"" data-loaded=""1"" width=""900"" height=""380""></canvas>
<canvas class=""my-4 w-100 d-none"" id=""chartMonth"" data-loaded=""1"" width=""900"" height=""380""></canvas>
<canvas class=""my-4 w-100 d-none"" id=""chartYear"" data-loaded=""1"" width=""900"" height=""380""></canvas>

<h2>");
            EndContext();
            BeginContext(2476, 18, false);
#line 47 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
Write(Localizer["Links"]);

#line default
#line hidden
            EndContext();
            BeginContext(2494, 192, true);
            WriteLiteral("</h2>\r\n<div class=\"w-100\">\r\n<table id=\"links\" style=\"table-layout:fixed\" class=\"w-100 table table-striped table-borderless table-primary table-sm\">\r\n    <thead>\r\n        <tr>\r\n            <th>");
            EndContext();
            BeginContext(2687, 22, false);
#line 52 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
           Write(Localizer["Short url"]);

#line default
#line hidden
            EndContext();
            BeginContext(2709, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(2733, 16, false);
#line 53 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
           Write(Localizer["Url"]);

#line default
#line hidden
            EndContext();
            BeginContext(2749, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(2773, 24, false);
#line 54 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
           Write(Localizer["Impressions"]);

#line default
#line hidden
            EndContext();
            BeginContext(2797, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(2821, 18, false);
#line 55 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
           Write(Localizer["Stats"]);

#line default
#line hidden
            EndContext();
            BeginContext(2839, 49, true);
            WriteLiteral("</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 59 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
           foreach (var link in Model)
            {

#line default
#line hidden
            BeginContext(2943, 69, true);
            WriteLiteral("                <tr>\r\n                    <td>https://localhost:5001/");
            EndContext();
            BeginContext(3013, 7, false);
#line 62 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
                                          Write(link.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3020, 64, true);
            WriteLiteral("</td>\r\n                    <td style=\"overflow-wrap:break-word\">");
            EndContext();
            BeginContext(3085, 12, false);
#line 63 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
                                                    Write(link.FullUrl);

#line default
#line hidden
            EndContext();
            BeginContext(3097, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3129, 17, false);
#line 64 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
                   Write(link.Clicks.Count);

#line default
#line hidden
            EndContext();
            BeginContext(3146, 38, true);
            WriteLiteral("</td>\r\n                    <td><button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3184, "\"", 3214, 3);
            WriteAttributeValue("", 3194, "getChart(\'", 3194, 10, true);
#line 65 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
WriteAttributeValue("", 3204, link.Id, 3204, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3212, "\')", 3212, 2, true);
            EndWriteAttribute();
            BeginContext(3215, 23, true);
            WriteLiteral(" class=\"btn btn-light\">");
            EndContext();
            BeginContext(3238, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("octicon", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "722b2d680300d24753c840600d1076a9d3ce19b316890", async() => {
            }
            );
            __Octicons_TagHelper_OcticonTagHelper = CreateTagHelper<global::Octicons.TagHelper.OcticonTagHelper>();
            __tagHelperExecutionContext.Add(__Octicons_TagHelper_OcticonTagHelper);
#line 65 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
__Octicons_TagHelper_OcticonTagHelper.Symbol = global::Octicons.TagHelper.OcticonSymbol.Graph;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("symbol", __Octicons_TagHelper_OcticonTagHelper.Symbol, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3272, 39, true);
            WriteLiteral("</button></td>\r\n                </tr>\r\n");
            EndContext();
#line 67 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(3337, 36, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3390, 102, true);
                WriteLiteral("\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.3/Chart.min.js\"></script>\r\n    ");
                EndContext();
                BeginContext(3492, 132, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "722b2d680300d24753c840600d1076a9d3ce19b318945", async() => {
                    BeginContext(3527, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(3537, 67, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "722b2d680300d24753c840600d1076a9d3ce19b319365", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 77 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3604, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3624, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3630, 136, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "722b2d680300d24753c840600d1076a9d3ce19b322616", async() => {
                    BeginContext(3665, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(3675, 71, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "722b2d680300d24753c840600d1076a9d3ce19b323036", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 80 "C:\Users\husey\source\repos\LinkShortener\Areas\Dashboard\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3746, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Exclude = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3766, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LinkShortener.Models.Link>> Html { get; private set; }
    }
}
#pragma warning restore 1591
