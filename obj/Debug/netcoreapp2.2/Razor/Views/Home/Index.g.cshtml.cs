#pragma checksum "C:\Coding Dojo\C#_stack\ASP.NET Core\ASP MVC II\Dojodachi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2553053f8fa77af13569e8d568ad36213245eb16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Coding Dojo\C#_stack\ASP.NET Core\ASP MVC II\Dojodachi\Views\_ViewImports.cshtml"
using Dojodachi;

#line default
#line hidden
#line 2 "C:\Coding Dojo\C#_stack\ASP.NET Core\ASP MVC II\Dojodachi\Views\_ViewImports.cshtml"
using Dojodachi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2553053f8fa77af13569e8d568ad36213245eb16", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f823666e3659d58cebeb316cce4284db07d26c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dojodachi.Models.Dachi>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/bunny.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2553053f8fa77af13569e8d568ad36213245eb164648", async() => {
                BeginContext(37, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(43, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2553053f8fa77af13569e8d568ad36213245eb165031", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(91, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(100, 197, true);
            WriteLiteral("\r\n<div>\r\n    <div class=\"row mt-5\">\r\n        <div class=\"col\"></div>\r\n        <div class=\"col-8\">\r\n            <header>\r\n                <ul class=\"text-center\">\r\n                    <li>Fullness: ");
            EndContext();
            BeginContext(298, 16, false);
#line 11 "C:\Coding Dojo\C#_stack\ASP.NET Core\ASP MVC II\Dojodachi\Views\Home\Index.cshtml"
                             Write(ViewBag.Fullness);

#line default
#line hidden
            EndContext();
            BeginContext(314, 42, true);
            WriteLiteral("</li>\r\n                    <li>Happiness: ");
            EndContext();
            BeginContext(357, 17, false);
#line 12 "C:\Coding Dojo\C#_stack\ASP.NET Core\ASP MVC II\Dojodachi\Views\Home\Index.cshtml"
                              Write(ViewBag.Happiness);

#line default
#line hidden
            EndContext();
            BeginContext(374, 38, true);
            WriteLiteral("</li>\r\n                    <li>Meals: ");
            EndContext();
            BeginContext(413, 13, false);
#line 13 "C:\Coding Dojo\C#_stack\ASP.NET Core\ASP MVC II\Dojodachi\Views\Home\Index.cshtml"
                          Write(ViewBag.Meals);

#line default
#line hidden
            EndContext();
            BeginContext(426, 39, true);
            WriteLiteral("</li>\r\n                    <li>Energy: ");
            EndContext();
            BeginContext(466, 14, false);
#line 14 "C:\Coding Dojo\C#_stack\ASP.NET Core\ASP MVC II\Dojodachi\Views\Home\Index.cshtml"
                           Write(ViewBag.Energy);

#line default
#line hidden
            EndContext();
            BeginContext(480, 386, true);
            WriteLiteral(@"</li>
                </ul>
            </header>
        </div>
        <div class=""col""></div>
    </div>
    <div class=""row"">
        <div class=""col""></div>
        <div class=""col-7"">
            <div class=""main_box m-3 p-3"">
                <div class=""row"">
                    <div class=""col""></div>
                    <div class=""col"">
                        ");
            EndContext();
            BeginContext(866, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2553053f8fa77af13569e8d568ad36213245eb169295", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(900, 220, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col\"></div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col\">\r\n                        <p class=\"text-center\">");
            EndContext();
            BeginContext(1121, 15, false);
#line 33 "C:\Coding Dojo\C#_stack\ASP.NET Core\ASP MVC II\Dojodachi\Views\Home\Index.cshtml"
                                          Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1136, 884, true);
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div> 
        </div>
        <div class=""col""></div>
    </div>
    <div class=""row"">
        <div class=""col""></div>
        <div class=""col-8"">
            <div class=""text-center"">
                <a href=""/feed"">
                    <button class=""btn btn-primary mx-3 px-4"">Feed</button>
                </a>
                <a href=""/play"">
                    <button class=""btn btn-success mx-3 px-4"">Play</button>
                </a>
                <a href=""/work"">
                    <button class=""btn btn-danger mx-3 px-4"">Work</button>
                </a>
                <a href=""/sleep"">
                    <button class=""btn btn-warning mx-3 px-4"">Sleep</button>
                </a>
            </div>
        </div>
        <div class=""col""></div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dojodachi.Models.Dachi> Html { get; private set; }
    }
}
#pragma warning restore 1591