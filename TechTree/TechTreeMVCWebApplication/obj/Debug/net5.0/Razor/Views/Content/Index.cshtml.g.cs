#pragma checksum "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Content\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "604891fb82f062410a3c928a158662d1862507b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content_Index), @"mvc.1.0.view", @"/Views/Content/Index.cshtml")]
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
#line 1 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\_ViewImports.cshtml"
using TechTreeMVCWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\_ViewImports.cshtml"
using TechTreeMVCWebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\_ViewImports.cshtml"
using TechTreeMVCWebApplication.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\_ViewImports.cshtml"
using TechTreeMVCWebApplication.Comparers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"604891fb82f062410a3c928a158662d1862507b3", @"/Views/Content/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5104202132c3d08d714c5a5c0170eff128c2f18d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Content_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TechTreeMVCWebApplication.Entities.Content>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>");
#nullable restore
#line 3 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Content\Index.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n");
#nullable restore
#line 5 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Content\Index.cshtml"
 if (Model.HTMLContent != null)
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\n        <div id=\"TextContent\" class=\"mt-3 col-md-10\"> \n            ");
#nullable restore
#line 9 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Content\Index.cshtml"
       Write(Html.Raw(Model.HTMLContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n");
#nullable restore
#line 12 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Content\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Content\Index.cshtml"
 if (Model.VideoLink != null)
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\n        <div class=\"mt-3 col-md-10\">\n            <div id=\"VideoContent\" class=\"video-container mt-3\">\n                <iframe width=\"550\" height=\"350\"");
            BeginWriteAttribute("src", " src=\"", 460, "\"", 482, 1);
#nullable restore
#line 18 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Content\Index.cshtml"
WriteAttributeValue("", 466, Model.VideoLink, 466, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 483, "\"", 501, 0);
            EndWriteAttribute();
            WriteLiteral(" frameborder=\"0\">\n\n                </iframe>\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 24 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Content\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TechTreeMVCWebApplication.Entities.Content> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
