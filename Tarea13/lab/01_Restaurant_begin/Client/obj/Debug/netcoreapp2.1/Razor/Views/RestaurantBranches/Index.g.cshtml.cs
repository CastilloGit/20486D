#pragma checksum "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea13\lab\01_Restaurant_begin\Client\Views\RestaurantBranches\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72b9e97c00f55e9caebd8a276f2338a25089b41e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RestaurantBranches_Index), @"mvc.1.0.view", @"/Views/RestaurantBranches/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RestaurantBranches/Index.cshtml", typeof(AspNetCore.Views_RestaurantBranches_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72b9e97c00f55e9caebd8a276f2338a25089b41e", @"/Views/RestaurantBranches/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_RestaurantBranches_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Client.Models.RestaurantBranch>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("photo-display-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/table-setting.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea13\lab\01_Restaurant_begin\Client\Views\RestaurantBranches\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(90, 157, true);
            WriteLiteral("\n<h2 class=\"title\">\n    <span class=\"span-col-f\">Dive into Our</span>\n    <span class=\"span-col-s\">Restaurant Branches</span>\n</h2>\n\n<div class=\"container\">\n");
            EndContext();
#line 13 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea13\lab\01_Restaurant_begin\Client\Views\RestaurantBranches\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(286, 95, true);
            WriteLiteral("        <div class=\"photo-index-card\">\n            <div class=\"image-wrapper\">\n                ");
            EndContext();
            BeginContext(381, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f756973affe442bbbaeb1bf42b38d2d3", async() => {
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
            BeginContext(447, 88, true);
            WriteLiteral("\n            </div>\n            <div class=\"display-picture-title\">\n                <h6>");
            EndContext();
            BeginContext(536, 39, false);
#line 20 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea13\lab\01_Restaurant_begin\Client\Views\RestaurantBranches\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(575, 26, true);
            WriteLiteral("</h6>\n                <h6>");
            EndContext();
            BeginContext(602, 41, false);
#line 21 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea13\lab\01_Restaurant_begin\Client\Views\RestaurantBranches\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Street));

#line default
#line hidden
            EndContext();
            BeginContext(643, 26, true);
            WriteLiteral("</h6>\n                <h6>");
            EndContext();
            BeginContext(670, 46, false);
#line 22 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea13\lab\01_Restaurant_begin\Client\Views\RestaurantBranches\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(716, 40, true);
            WriteLiteral("</h6>\n            </div>\n        </div>\n");
            EndContext();
#line 25 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea13\lab\01_Restaurant_begin\Client\Views\RestaurantBranches\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(762, 8, true);
            WriteLiteral("</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Client.Models.RestaurantBranch>> Html { get; private set; }
    }
}
#pragma warning restore 1591
