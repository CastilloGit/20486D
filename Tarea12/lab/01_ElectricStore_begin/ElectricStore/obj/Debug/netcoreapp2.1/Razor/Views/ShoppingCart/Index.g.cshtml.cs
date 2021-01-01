#pragma checksum "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\lab\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a33fe79681038f03a7ef1e11e0cd72b4b082eec3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShoppingCart/Index.cshtml", typeof(AspNetCore.Views_ShoppingCart_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a33fe79681038f03a7ef1e11e0cd72b4b082eec3", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ElectricStore.Models.SessionStateViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\lab\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(88, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\lab\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(111, 22, true);
            WriteLiteral("    <h2 class=\"title\">");
            EndContext();
            BeginContext(134, 18, false);
#line 8 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\lab\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
                 Write(Model.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(152, 26, true);
            WriteLiteral("\'s Selected Products</h2>\n");
            EndContext();
            BeginContext(179, 33, true);
            WriteLiteral("    <div class=\"page-container\">\n");
            EndContext();
#line 11 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\lab\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
         foreach (var item in Model.SelectedProducts)
        {

#line default
#line hidden
            BeginContext(276, 72, true);
            WriteLiteral("            <div class=\"item\">\n                <h3>\n                    ");
            EndContext();
            BeginContext(349, 46, false);
#line 15 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\lab\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(395, 23, true);
            WriteLiteral("\n                </h3>\n");
            EndContext();
#line 17 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\lab\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
                 if (item.PhotoFileName != null)
                {

#line default
#line hidden
            BeginContext(485, 54, true);
            WriteLiteral("                    <div>\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 539, "\"", 609, 1);
#line 20 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\lab\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 545, Url.Action("GetImage", "Products", new { productId = item.Id }), 545, 64, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(610, 31, true);
            WriteLiteral(" />\n                    </div>\n");
            EndContext();
#line 22 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\lab\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(659, 70, true);
            WriteLiteral("                <div>\n                    <p>\n                        ");
            EndContext();
            BeginContext(730, 42, false);
#line 25 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\lab\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
                   Write(Html.DisplayFor(model => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(772, 74, true);
            WriteLiteral("\n                    </p>\n                    <p>\n                        ");
            EndContext();
            BeginContext(847, 36, false);
#line 28 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\lab\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
                   Write(Html.DisplayFor(model => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(883, 68, true);
            WriteLiteral("\n                    </p>\n                </div>\n            </div>\n");
            EndContext();
#line 32 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\lab\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(961, 58, true);
            WriteLiteral("    </div>\n    <h5 class=\"title\">\n        <span>Thank you ");
            EndContext();
            BeginContext(1020, 18, false);
#line 35 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\lab\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
                   Write(Model.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(1038, 84, true);
            WriteLiteral("</span>\n        <span>for your order, we will contact you shortly.</span>\n    </h5>\n");
            EndContext();
#line 38 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\lab\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1131, 239, true);
            WriteLiteral("    <div class=\"title Secondary-heading\">\n        <p>Sorry, we don\'t have any information yet</p>\n        <p>Please go to the <span class=\"span-col-s\">Shopping List page</span></p>\n        <p>and select the wanted products.</p>\n    </div>\n");
            EndContext();
#line 46 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\lab\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1372, 62, true);
            WriteLiteral("    <button type=\"button\" id=\"btnChat\" class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1434, "\"", 1495, 3);
            WriteAttributeValue("", 1444, "location.href=\'", 1444, 15, true);
#line 47 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea12\lab\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 1459, Url.Action("Chat", "ShoppingCart"), 1459, 35, false);

#line default
#line hidden
            WriteAttributeValue("", 1494, "\'", 1494, 1, true);
            EndWriteAttribute();
            BeginContext(1496, 40, true);
            WriteLiteral(">Chat with Online Visitors</button>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ElectricStore.Models.SessionStateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
