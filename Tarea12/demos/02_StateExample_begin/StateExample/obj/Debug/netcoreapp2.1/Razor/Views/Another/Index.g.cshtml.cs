#pragma checksum "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\demos\02_StateExample_begin\StateExample\Views\Another\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afeb75e9bac910c700d4ad1058354b2384a381c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Another_Index), @"mvc.1.0.view", @"/Views/Another/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Another/Index.cshtml", typeof(AspNetCore.Views_Another_Index))]
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
#line 2 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\demos\02_StateExample_begin\StateExample\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afeb75e9bac910c700d4ad1058354b2384a381c3", @"/Views/Another/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39d6bc4fe82f08c03ac258dadd5f0b3e81a39c21", @"/Views/_ViewImports.cshtml")]
    public class Views_Another_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\demos\02_StateExample_begin\StateExample\Views\Another\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Another";

#line default
#line hidden
            BeginContext(83, 106, true);
            WriteLiteral("\n<div class=\"info-panel\">\r\n    <div>Number of times that this controller was visited during this session: ");
            EndContext();
            BeginContext(190, 32, false);
#line 8 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\demos\02_StateExample_begin\StateExample\Views\Another\Index.cshtml"
                                                                          Write(Context.Session.GetInt32("Home"));

#line default
#line hidden
            EndContext();
            BeginContext(222, 87, true);
            WriteLiteral("</div>\r\n    <div>Number of times that this controller was visited during this session: ");
            EndContext();
            BeginContext(310, 35, false);
#line 9 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\demos\02_StateExample_begin\StateExample\Views\Another\Index.cshtml"
                                                                          Write(Context.Session.GetInt32("Another"));

#line default
#line hidden
            EndContext();
            BeginContext(345, 70, true);
            WriteLiteral("</div>\r\n    <div>Number of times visited overall during this session: ");
            EndContext();
            BeginContext(416, 35, false);
#line 10 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\demos\02_StateExample_begin\StateExample\Views\Another\Index.cshtml"
                                                         Write(Context.Session.GetInt32("Overall"));

#line default
#line hidden
            EndContext();
            BeginContext(451, 15, true);
            WriteLiteral("</div>\r\n</div>\n");
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
