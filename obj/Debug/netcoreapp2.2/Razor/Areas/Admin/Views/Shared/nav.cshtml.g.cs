#pragma checksum "C:\Users\husey\source\repos\LinkShortener\Areas\Admin\Views\Shared\nav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8cb894a28a081dde73807f5365a9c47e224852e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_nav), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/nav.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/nav.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_nav))]
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
#line 1 "C:\Users\husey\source\repos\LinkShortener\Areas\Admin\Views\_ViewImports.cshtml"
using LinkShortener;

#line default
#line hidden
#line 2 "C:\Users\husey\source\repos\LinkShortener\Areas\Admin\Views\_ViewImports.cshtml"
using LinkShortener.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8cb894a28a081dde73807f5365a9c47e224852e", @"/Areas/Admin/Views/Shared/nav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ff29dd782d6cf8cb37ef964f68d8cfa2ac8b538", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_nav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Payouts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 182, true);
            WriteLiteral("<nav class=\"col-md-2 d-none d-md-block bg-light sidebar\">\r\n    <div class=\"sidebar-sticky\">\r\n        <ul class=\"nav flex-column\">\r\n            <li class=\"nav-item\">\r\n                ");
            EndContext();
            BeginContext(182, 232, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8cb894a28a081dde73807f5365a9c47e224852e5363", async() => {
                BeginContext(267, 143, true);
                WriteLiteral("\r\n                    <span data-feather=\"home\"></span>\r\n                    Dashboard <span class=\"sr-only\">(current)</span>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(414, 72, true);
            WriteLiteral("\r\n            </li>\r\n            <li class=\"nav-item\">\r\n                ");
            EndContext();
            BeginContext(486, 179, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8cb894a28a081dde73807f5365a9c47e224852e7448", async() => {
                BeginContext(551, 110, true);
                WriteLiteral("\r\n                    <span data-feather=\"file\"></span>\r\n                    Payouts History\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(665, 2804, true);
            WriteLiteral(@"
            </li>
        </ul>
    </div>
</nav>




<!--<nav class=""col-md-2 d-none d-md-block bg-light sidebar"">
    <div class=""sidebar-sticky"">
        <ul class=""nav flex-column"">
            <li class=""nav-item"">
                <a class=""nav-link active"" href=""#"">
                    <span data-feather=""home""></span>
                    Dashboard <span class=""sr-only"">(current)</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"">
                    <span data-feather=""file""></span>
                    Orders
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"">
                    <span data-feather=""shopping-cart""></span>
                    Products
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"">
                    <span data-feather=""users""></span>
         ");
            WriteLiteral(@"           Customers
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"">
                    <span data-feather=""bar-chart-2""></span>
                    Reports
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"">
                    <span data-feather=""layers""></span>
                    Integrations
                </a>
            </li>
        </ul>

        <h6 class=""sidebar-heading d-flex justify-content-between align-items-center px-3 mt-4 mb-1 text-muted"">
            <span>Saved reports</span>
            <a class=""d-flex align-items-center text-muted"" href=""#"">
                <span data-feather=""plus-circle""></span>
            </a>
        </h6>
        <ul class=""nav flex-column mb-2"">
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"">
                    <span data-feather=""file-text""></span>
               ");
            WriteLiteral(@"     Current month
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"">
                    <span data-feather=""file-text""></span>
                    Last quarter
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"">
                    <span data-feather=""file-text""></span>
                    Social engagement
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"">
                    <span data-feather=""file-text""></span>
                    Year-end sale
                </a>
            </li>
        </ul>
    </div>
</nav>-->
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
