#pragma checksum "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a50c957e4228cbd218662a7551a10ffd15920901"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 3 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
using TechTreeMVCWebApplication.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a50c957e4228cbd218662a7551a10ffd15920901", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5104202132c3d08d714c5a5c0170eff128c2f18d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryDetailsModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CategoriesToUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Content", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DefaultHomePageContentPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_UserLoginPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_UserRegistrationPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n\n");
#nullable restore
#line 6 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 11 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
 if (Model.GroupedCategoryItemsByCategoryModels != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\n        <div class=\"col-md-6\">\n            <h2>Your Courses</h2>\n        </div>\n        <div class=\"col-md-6 text-right\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a50c957e4228cbd218662a7551a10ffd159209017618", async() => {
                WriteLiteral("Choose Courses");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n");
#nullable restore
#line 22 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
     if (Model.GroupedCategoryItemsByCategoryModels.Count() > 0)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row mt-3\">\n            <div class=\"col-md-12\">\n\n");
#nullable restore
#line 28 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
                 foreach (var cat in Model.GroupedCategoryItemsByCategoryModels)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card mt-2\">\n                        <h4 class=\"card-header text-secondary bg-white\" style=\"cursor:pointer\" data-toggle=\"collapse\" data-target=\"#collapse_");
#nullable restore
#line 31 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
                                                                                                                                        Write(cat.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 913, "\"", 945, 2);
            WriteAttributeValue("", 929, "collapse_", 929, 9, true);
#nullable restore
#line 31 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
WriteAttributeValue("", 938, cat.Id, 938, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            ");
#nullable restore
#line 32 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
                       Write(cat.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </h4>\n                        <div");
            BeginWriteAttribute("id", " id=\"", 1045, "\"", 1066, 2);
            WriteAttributeValue("", 1050, "collapse_", 1050, 9, true);
#nullable restore
#line 34 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
WriteAttributeValue("", 1059, cat.Id, 1059, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1106, "\"", 1138, 2);
            WriteAttributeValue("", 1122, "collapse_", 1122, 9, true);
#nullable restore
#line 34 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
WriteAttributeValue("", 1131, cat.Id, 1131, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <hr />\n");
#nullable restore
#line 36 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
                             foreach (var item in cat.Items)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"mt-2\">\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1358, "\"", 1384, 1);
#nullable restore
#line 39 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
WriteAttributeValue("", 1364, item.MediaImagePath, 1364, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"100\" class=\"img-thumbnail float-left mr-2\" />\n                                    <h5 class=\"card-title mt-2\">\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a50c957e4228cbd218662a7551a10ffd1592090113462", async() => {
#nullable restore
#line 41 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
                                                                                                                                                    Write(item.CategoryItemTitle);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-CategoryItemId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
                                                                                                                       WriteLiteral(item.CategoryItemId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CategoryItemId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-CategoryItemId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CategoryItemId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </h5>\n                                    <p class=\"card-text text-dark mt-2\">\n                                        ");
#nullable restore
#line 44 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
                                   Write(item.CategoryItemDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </p>\n                                </div>\n");
#nullable restore
#line 47 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\n                    </div>\n");
#nullable restore
#line 50 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n");
#nullable restore
#line 54 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4 class=\"mt-2 text-warning\">You are currently not matched with any courses</h4>\n");
#nullable restore
#line 58 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a50c957e4228cbd218662a7551a10ffd1592090118527", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 63 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Categories;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 64 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n<div class=\"modal fade\" id=\"UserLoginModal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalLabel\" aria-hidden=\"true\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a50c957e4228cbd218662a7551a10ffd1592090120567", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 70 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new LoginModel
        {
            Email = String.Empty,
            Password = String.Empty,
            RememberMe = false
        };

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n<div class=\"modal fade\" id=\"UserRegistrationModal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalLabel\" aria-hidden=\"true\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a50c957e4228cbd218662a7551a10ffd1592090122485", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 79 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new RegistrationModel
        {
            Email = String.Empty,
            Password = String.Empty,
            ConfirmPassword = String.Empty,
            FirstName = String.Empty,
            LastName = String.Empty,
            PhoneNumber = String.Empty,
            Address1 = String.Empty,
            Address2 = String.Empty,
            PostCode = String.Empty,
            AcceptUserAgreement = false
        };

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 96 "C:\Users\MATTER\Downloads\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication-main\TechTreeMVCWebApplication\Views\Home\Index.cshtml"
      
        await Html.RenderPartialAsync("_AuthScriptsPartial");
        await Html.RenderPartialAsync("_ValidationScriptsPartial");

    

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryDetailsModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
