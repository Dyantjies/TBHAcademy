#pragma checksum "C:\Users\koketso\Desktop\Project\Views\Marks\ListMarks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6387af8020020e1dcc226fa8bc901b1d4dd3b13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Marks_ListMarks), @"mvc.1.0.view", @"/Views/Marks/ListMarks.cshtml")]
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
#line 1 "C:\Users\koketso\Desktop\Project\Views\_ViewImports.cshtml"
using TBHAcademy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\koketso\Desktop\Project\Views\Marks\ListMarks.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\koketso\Desktop\Project\Views\Marks\ListMarks.cshtml"
using TBHAcademy.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\koketso\Desktop\Project\Views\Marks\ListMarks.cshtml"
using TBHAcademy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6387af8020020e1dcc226fa8bc901b1d4dd3b13", @"/Views/Marks/ListMarks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6dbcc57f67d04b7437938f6811bce6b62e099ff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Marks_ListMarks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TBHAcademy.Models.Mark_Capture>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddMark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Marks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateMark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary mx-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\koketso\Desktop\Project\Views\Marks\ListMarks.cshtml"
  
    ViewData["Title"] = "ListMarks1";
    Layout = "~/Views/Shared/_TutorLayoutcshtml.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"w-100 \" style=\"background: rgba(6, 73, 181,0.5)\">\r\n    <div class=\"pt-1 m-0 row\">\r\n        <h5 class=\"text-white text-center \">Capture Mark</h5>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6387af8020020e1dcc226fa8bc901b1d4dd3b135643", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n");
            WriteLiteral("\r\n<div>\r\n");
            WriteLiteral("   <div class=\"pl-3 pr-3\">\r\n        \r\n");
            WriteLiteral(@"           
        <table id=""myTable"" class=""table table-bordered table-hover "">
            <thead class=""thead-dark"">
                  <tr>
                        <th>Student </th>
                        <th>Module Code </th>
                     <th>Module Name </th>
                     <th>Assessment Description</th>
                     <th>Assessement Type</th>
                          <th>Date Of Assessment</th>
                     <th>Mark obtained(%)</th>
                      <th>Action</th>

                </tr>

            </thead>
            <tbody>


");
#nullable restore
#line 112 "C:\Users\koketso\Desktop\Project\Views\Marks\ListMarks.cshtml"
                         foreach (Capture_Mark_Display E in ViewBag.ProgressReport)
                        {
    

#line default
#line hidden
#nullable disable
            WriteLiteral("                             <tr>\r\n                                 <td>");
#nullable restore
#line 116 "C:\Users\koketso\Desktop\Project\Views\Marks\ListMarks.cshtml"
                                Write(E.TBHAcademyUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 116 "C:\Users\koketso\Desktop\Project\Views\Marks\ListMarks.cshtml"
                                                           Write(E.TBHAcademyUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                  <td>");
#nullable restore
#line 117 "C:\Users\koketso\Desktop\Project\Views\Marks\ListMarks.cshtml"
                                 Write(E.Modules.ModuleCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                  <td>");
#nullable restore
#line 118 "C:\Users\koketso\Desktop\Project\Views\Marks\ListMarks.cshtml"
                                 Write(E.Modules.ModuleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 3988, "\"", 3996, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 119 "C:\Users\koketso\Desktop\Project\Views\Marks\ListMarks.cshtml"
                                        Write(E.Mark_Capture.Assessment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                 <td>");
#nullable restore
#line 120 "C:\Users\koketso\Desktop\Project\Views\Marks\ListMarks.cshtml"
                                Write(E.Mark_Capture.Assessment_Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                  <td>");
#nullable restore
#line 121 "C:\Users\koketso\Desktop\Project\Views\Marks\ListMarks.cshtml"
                                 Write(E.Mark_Capture.DateOfAssessment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                               <td>");
#nullable restore
#line 122 "C:\Users\koketso\Desktop\Project\Views\Marks\ListMarks.cshtml"
                              Write(E.Mark_Capture.Mark_Percentage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                              <td>\r\n                                     <div class=\"card-footer bg-white\">\r\n                                         <div class=\"text-primary center\">\r\n                                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6387af8020020e1dcc226fa8bc901b1d4dd3b1310585", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 126 "C:\Users\koketso\Desktop\Project\Views\Marks\ListMarks.cshtml"
                                                                                               WriteLiteral(E.Mark_Capture.MarkID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6387af8020020e1dcc226fa8bc901b1d4dd3b1313117", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "C:\Users\koketso\Desktop\Project\Views\Marks\ListMarks.cshtml"
                                                                                          WriteLiteral(E.Mark_Capture.MarkID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                   </div>\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 133 "C:\Users\koketso\Desktop\Project\Views\Marks\ListMarks.cshtml"

                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 136 "C:\Users\koketso\Desktop\Project\Views\Marks\ListMarks.cshtml"
                 if (Model != null)
                {
                  
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </tbody>
        </table>
   </div>
</div>

<script type=""text/javascript"">
    function Confirmation(event, CourseId) {
        Swal.fire({
            title: 'Are you sure?',
            text: ""You want to deactivate this course ?"",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Confirm',
            preConfirm: false
        }).then((result) => {
            if (result.isConfirmed) {
                Swal.fire(
                    'Success!',
                    'Course Deactivated',
                    'success'
                ).then(result => {
                    document.querySelector(`#_${CourseId}`).submit();
                })
            }
        })
    }
</script>




















");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<TBHAcademyUser> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<TBHAcademyUser> SignInManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TBHAcademy.Models.Mark_Capture>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
