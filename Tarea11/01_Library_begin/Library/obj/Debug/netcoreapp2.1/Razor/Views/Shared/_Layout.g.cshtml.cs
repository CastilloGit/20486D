#pragma checksum "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea11\01_Library_begin\Library\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03d8a782ceb3907bb9d7e54d90b48a40239619ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03d8a782ceb3907bb9d7e54d90b48a40239619ee", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/library-style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/node_modules/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/node_modules/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/node_modules/popper.js/dist/umd/popper.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/node_modules/bootstrap/dist/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 24, true);
            WriteLiteral("<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(24, 479, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5593ab1d7cf649dabd5d9e0beca9153c", async() => {
                BeginContext(30, 70, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>");
                EndContext();
                BeginContext(101, 13, false);
#line 6 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea11\01_Library_begin\Library\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(114, 13, true);
                WriteLiteral("</title>\n    ");
                EndContext();
                BeginContext(127, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fd7195ff381e4e66ab7096f89acb0426", async() => {
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
                BeginContext(183, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(188, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e050ae2e9cbe4c179c683e7ac0bf1279", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(272, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(277, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0f5996b56594c938ea8e4a5bb60c3c9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(341, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(346, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7e255d73d6a4a3eb7810d0c947fdc05", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(417, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(422, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64b2bdfed8774db0b555e455edc8f6b4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(495, 1, true);
                WriteLiteral("\n");
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
            BeginContext(503, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(504, 1489, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "647beb1552b14c7cb1aa6d80e4afb922", async() => {
                BeginContext(510, 269, true);
                WriteLiteral(@"
    <nav class=""navbar navbar-expand-md navbar-dark navbar-custom p-1"">
        <div class=""collapse navbar-collapse"" id=""nav-content"">
            <ul class=""navbar-nav"" id=""nav-content"">
                <li class=""nav-item"">
                    <a class=""nav-link""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 779, "\"", 817, 1);
#line 18 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea11\01_Library_begin\Library\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 786, Url.Action("Index", "Library"), 786, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(818, 153, true);
                WriteLiteral(">Library<span class=\"sr-only\">(current)</span></a>\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 971, "\"", 1019, 1);
#line 21 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea11\01_Library_begin\Library\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 978, Url.Action("GetBooksByGener", "Library"), 978, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1020, 39, true);
                WriteLiteral(">Our Books</a>\r\n                </li>\r\n");
                EndContext();
#line 23 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea11\01_Library_begin\Library\Views\Shared\_Layout.cshtml"
                 if (User.IsInRole("Administrator"))
                {

#line default
#line hidden
                BeginContext(1132, 86, true);
                WriteLiteral("                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1218, "\"", 1258, 1);
#line 26 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea11\01_Library_begin\Library\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1225, Url.Action("Index", "Librarian"), 1225, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1259, 48, true);
                WriteLiteral(">Workers Portal</a>\r\n                    </li>\r\n");
                EndContext();
#line 28 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea11\01_Library_begin\Library\Views\Shared\_Layout.cshtml"
                }

#line default
#line hidden
                BeginContext(1326, 16, true);
                WriteLiteral("                ");
                EndContext();
#line 29 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea11\01_Library_begin\Library\Views\Shared\_Layout.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
                BeginContext(1398, 86, true);
                WriteLiteral("                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1484, "\"", 1523, 1);
#line 32 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea11\01_Library_begin\Library\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1491, Url.Action("Logout", "Account"), 1491, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1524, 40, true);
                WriteLiteral(">Logout</a>\r\n                    </li>\r\n");
                EndContext();
#line 34 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea11\01_Library_begin\Library\Views\Shared\_Layout.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(1624, 86, true);
                WriteLiteral("                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1710, "\"", 1748, 1);
#line 38 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea11\01_Library_begin\Library\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1717, Url.Action("Login", "Account"), 1717, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1749, 39, true);
                WriteLiteral(">Login</a>\r\n                    </li>\r\n");
                EndContext();
#line 40 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea11\01_Library_begin\Library\Views\Shared\_Layout.cshtml"
                }

#line default
#line hidden
                BeginContext(1807, 117, true);
                WriteLiteral("            </ul>\n        </div>\n    </nav>\n    <h1 class=\"main-title\">Welcome to Our Library</h1>\n    <div>\n        ");
                EndContext();
                BeginContext(1925, 12, false);
#line 46 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea11\01_Library_begin\Library\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1937, 16, true);
                WriteLiteral("\n    </div>\n    ");
                EndContext();
                BeginContext(1954, 31, false);
#line 48 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea11\01_Library_begin\Library\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", false));

#line default
#line hidden
                EndContext();
                BeginContext(1985, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1993, 9, true);
            WriteLiteral("\n</html>\n");
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