#pragma checksum "C:\Users\Ernest\3D Objects\Project 2022\Views\Hod\Assign.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "760660006d1372a816944fd79b96ce3e1ce2d1e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hod_Assign), @"mvc.1.0.view", @"/Views/Hod/Assign.cshtml")]
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
#line 1 "C:\Users\Ernest\3D Objects\Project 2022\Views\_ViewImports.cshtml"
using TBHAcademy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ernest\3D Objects\Project 2022\Views\_ViewImports.cshtml"
using TBHAcademy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"760660006d1372a816944fd79b96ce3e1ce2d1e9", @"/Views/Hod/Assign.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6dbcc57f67d04b7437938f6811bce6b62e099ff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Hod_Assign : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TBHAcademy.Models.TutorModule>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Activities", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Hod", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info ml-1 mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ernest\3D Objects\Project 2022\Views\Hod\Assign.cshtml"
  
    ViewData["Title"] = "Assign";
    Layout = "_HodLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"w-100 mb-2  \" style=\"background: rgba(6, 73, 181,0.5)\">\r\n    <div class=\"pt-1 m-0 row\">\r\n        <h5 class=\"text-white text-center \">");
#nullable restore
#line 9 "C:\Users\Ernest\3D Objects\Project 2022\Views\Hod\Assign.cshtml"
                                       Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    </div>\r\n</div>\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 14 "C:\Users\Ernest\3D Objects\Project 2022\Views\Hod\Assign.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>\r\n            <a href=\"#\">\r\n                ");
#nullable restore
#line 18 "C:\Users\Ernest\3D Objects\Project 2022\Views\Hod\Assign.cshtml"
           Write(item.ModulesTM.ModuleCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 18 "C:\Users\Ernest\3D Objects\Project 2022\Views\Hod\Assign.cshtml"
                                        Write(item.ModulesTM.ModuleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n        </h2>\r\n    <div class=\"pb-2 fw-bold\">\r\n                    Module Name:  <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 22 "C:\Users\Ernest\3D Objects\Project 2022\Views\Hod\Assign.cshtml"
                                                              Write(item.ModulesTM.ModuleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n                <div class=\"pb-2 fw-bold\">\r\n                    Module Code: <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 25 "C:\Users\Ernest\3D Objects\Project 2022\Views\Hod\Assign.cshtml"
                                                             Write(item.ModulesTM.ModuleCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>

                </div>
                <div class=""pb-2 fw-bold"">
                    Module Description  : <a class=""text-primary"" href=""#"">None</a>
                </div>
                <div class=""pb-2 fw-bold"">
                    Tutor  : <a class=""text-primary"" href=""#"">");
#nullable restore
#line 32 "C:\Users\Ernest\3D Objects\Project 2022\Views\Hod\Assign.cshtml"
                                                         Write(item.UserTM.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 32 "C:\Users\Ernest\3D Objects\Project 2022\Views\Hod\Assign.cshtml"
                                                                               Write(item.UserTM.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n                <div class=\"pb-2 fw-bold\">\r\n                    Course Name: <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 35 "C:\Users\Ernest\3D Objects\Project 2022\Views\Hod\Assign.cshtml"
                                                             Write(item.CourseTM.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n                <div class=\"pb-2 fw-bold\">\r\n                    Course Description: <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 38 "C:\Users\Ernest\3D Objects\Project 2022\Views\Hod\Assign.cshtml"
                                                                    Write(item.CourseTM.CourseDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n");
#nullable restore
#line 42 "C:\Users\Ernest\3D Objects\Project 2022\Views\Hod\Assign.cshtml"
                        

}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "760660006d1372a816944fd79b96ce3e1ce2d1e98330", async() => {
                WriteLiteral("Back To Activities");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TBHAcademy.Models.TutorModule>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
