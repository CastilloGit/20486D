#pragma checksum "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea14\lab\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b695ffe081d7aa45e3786450e167e4730db2317"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aquarium_Details), @"mvc.1.0.view", @"/Views/Aquarium/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Aquarium/Details.cshtml", typeof(AspNetCore.Views_Aquarium_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b695ffe081d7aa45e3786450e167e4730db2317", @"/Views/Aquarium/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Aquarium_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Underwater.Models.Fish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea14\lab\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(71, 125, true);
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"photo-index-card-details\">\r\n        <h3 class=\"display-picture-title\">\r\n            ");
            EndContext();
            BeginContext(197, 44, false);
#line 10 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea14\lab\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
       Write(Html.DisplayFor(modelItem => modelItem.Name));

#line default
#line hidden
            EndContext();
            BeginContext(241, 17, true);
            WriteLiteral("\r\n        </h3>\r\n");
            EndContext();
#line 12 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea14\lab\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
         if (Model.ImageName != null)
        {
            

#line default
#line hidden
#line 14 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea14\lab\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
             if (Model.ImageURL != null)
            {

#line default
#line hidden
            BeginContext(365, 95, true);
            WriteLiteral("                <div class=\"photo-display\">\r\n                    <img class=\"photo-display-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 460, "\"", 481, 1);
#line 17 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea14\lab\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
WriteAttributeValue("", 466, Model.ImageURL, 466, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(482, 29, true);
            WriteLiteral(" />\r\n                </div>\r\n");
            EndContext();
#line 19 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea14\lab\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(559, 95, true);
            WriteLiteral("                <div class=\"photo-display\">\r\n                    <img class=\"photo-display-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 654, "\"", 722, 1);
#line 23 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea14\lab\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
WriteAttributeValue("", 660, Url.Action("GetImage", "Aquarium", new { Id = Model.FishId }), 660, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(723, 29, true);
            WriteLiteral(" />\r\n                </div>\r\n");
            EndContext();
#line 25 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea14\lab\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
            }

#line default
#line hidden
#line 25 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea14\lab\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
             
        }

#line default
#line hidden
            BeginContext(778, 70, true);
            WriteLiteral("        <div>\r\n            <p class=\"display-label\">\r\n                ");
            EndContext();
            BeginContext(849, 50, false);
#line 29 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea14\lab\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ScientificName));

#line default
#line hidden
            EndContext();
            BeginContext(899, 95, true);
            WriteLiteral("\r\n            </p>\r\n            <br />\r\n            <p class=\"display-field\">\r\n                ");
            EndContext();
            BeginContext(995, 46, false);
#line 33 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea14\lab\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
           Write(Html.DisplayFor(model => model.ScientificName));

#line default
#line hidden
            EndContext();
            BeginContext(1041, 106, true);
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <div>\r\n            <p class=\"display-label\">\r\n                ");
            EndContext();
            BeginContext(1148, 46, false);
#line 38 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea14\lab\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CommonName));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 95, true);
            WriteLiteral("\r\n            </p>\r\n            <br />\r\n            <p class=\"display-field\">\r\n                ");
            EndContext();
            BeginContext(1290, 42, false);
#line 42 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea14\lab\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
           Write(Html.DisplayFor(model => model.CommonName));

#line default
#line hidden
            EndContext();
            BeginContext(1332, 110, true);
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <div>\r\n            <button class=\"btn btn-secondary\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1442, "\"", 1500, 3);
            WriteAttributeValue("", 1452, "location.href=\'", 1452, 15, true);
#line 46 "C:\Users\jcarl\source\repos\CastilloGit\20486D\Tarea14\lab\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
WriteAttributeValue("", 1467, Url.Action("Index", "Aquarium"), 1467, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 1499, "\'", 1499, 1, true);
            EndWriteAttribute();
            BeginContext(1501, 50, true);
            WriteLiteral(">Back</button>\r\n        </div>\r\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Underwater.Models.Fish> Html { get; private set; }
    }
}
#pragma warning restore 1591
