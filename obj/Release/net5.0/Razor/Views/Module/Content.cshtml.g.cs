#pragma checksum "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2276ddb38fcc160809c92299283d94dac8e93747"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Module_Content), @"mvc.1.0.view", @"/Views/Module/Content.cshtml")]
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
#line 1 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
using TBHAcademy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2276ddb38fcc160809c92299283d94dac8e93747", @"/Views/Module/Content.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6dbcc57f67d04b7437938f6811bce6b62e099ff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Module_Content : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Quiz", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create_Quiz", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Attempt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-ID", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "#", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "#", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("Update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
  
    ViewData["Title"] = @ViewBag.Tittle;
    Layout = ViewBag.Layout;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!------------------------------------------------- Header --------------------------------------------------------------------------------------->
<div class=""w-100 "" style=""background: rgba(6, 73, 181,0.5)"">
    <div class=""pt-1 m-0 row"">
        <h5 class=""text-white text-center "">");
#nullable restore
#line 10 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                       Write(ViewBag.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 13 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
 if (Layout == "~/Views/Shared/_TutorLayoutcshtml.cshtml")

{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container mt-3\">\r\n        <button type=\"button\" id=\"Add\" class=\"btn btn-primary\" data-bs-toggle=\"modal\" data-bs-target=\"#myModal\">\r\n            Add new Content\r\n        </button>\r\n\r\n    </div>\r\n");
#nullable restore
#line 22 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script defer>
    $(document).ready(function() {
        $('#ActiveBody').load(""/Module/Upload1"");
        $('#Attempt').load(""/Module/Attempt"");
        $('#SubBody').load(""/Module/Submit"");
        $('#UploadBody').load(""/Module/Upload"");
        $(""#Add"").click(function() {
            $('#Display').load(""/Module/Add"");
        });
    });
</script>
<!--Quizes button-->
<div id=""QuizesButton"" class=""w-100"">
    <button type=""button"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#staticBackdrop"">Active Quizes</button> <button type=""button"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#Sub"">Active Submissions</button>

    <div class=""modal fade"" id=""staticBackdrop"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""QuizModal"" aria-hidden=""true"">
        <div class=""modal-dialog modal-lg  modal-dialog-scrollable"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 clas");
            WriteLiteral("s=\"modal-title\" id=\"QuizModal\">Active Quizes</h4>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2276ddb38fcc160809c92299283d94dac8e937478527", async() => {
                WriteLiteral("Create New Quiz");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""modal-body"">
                    <div id=""QmodalBody"" class=""w-100"">
                        <div class=""table-responsive"">
                            <table class=""table text-start align-middle table-borderless table-hover mb-0"">

                                <thead class=""table-light"">
                                    <tr>
                                        <th>Quize Name</th>
                                        <th>Active Date</th>
                                        <th>Due Date&Time</th>
                                        <th></th>

                                    </tr>
                                </thead>
                                <tbody>

                                    <tr>
                                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2276ddb38fcc160809c92299283d94dac8e9374710838", async() => {
                WriteLiteral("Quize 1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2276ddb38fcc160809c92299283d94dac8e9374712843", async() => {
                WriteLiteral("21 October 2022 23:55");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2276ddb38fcc160809c92299283d94dac8e9374714862", async() => {
                WriteLiteral("22 October 2022 23:55");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</td>

                                        <td>
                                            <div id=""Attempt"">
                                            </div>
                                        </td>
                                    </tr>



                                    <tr>
                                    </tr>

                                </tbody>



                            </table>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>


                </div>
            </div>
        </div>
    </div>
</div>
<!--Active Sudmibbion-->
<div class=""modal fade"" id=""Sub"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""Submodal"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg  modal-dialog-scrollable"">
        <div class=""modal-");
            WriteLiteral(@"content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""QuizModal"">Active Assignmnets</h4>
                <button type=""button"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#Asignmnet"">Create New Assignmnet</button>
            </div>
            <div class=""modal-body"">
                <div id=""ActiveBody"" class=""w-100"">
                    
                    
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>


            </div>
        </div>
    </div>
</div>
</div>
<!--Submission Modal-->
 <div class=""modal fade"" id=""Upload"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""QuizModal"" aria-hidden=""true"">
        <div class=""modal-dialog modal-lg  modal-dialog-scrollable"">
            <div class=""modal-content"">
                <div class=""modal-header"">
      ");
            WriteLiteral(@"              <h4 class=""modal-title"" id=""QuizModal"">Upload Your Assignment</</h4>
                </div>
                <div class=""modal-body"">
                    <div id=""SubBody"" class=""w-100"">
                        
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>


                </div>
            </div>
        </div>
    </div>
    <!--Create Assignmenet-->
    <div class=""modal fade"" id=""Asignmnet"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""QuizModal"" aria-hidden=""true"">
        <div class=""modal-dialog modal-lg  modal-dialog-scrollable"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"" id=""QuizModal"">Create New Assignmnet</</h4>
                </div>
                <div class=""modal-body"">
                ");
            WriteLiteral(@"    <div id=""UploadBody"" class=""w-100"">
                       
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>


                </div>
            </div>
        </div>
    </div>
<!-- The Modal -->
<div class=""modal"" id=""myModal"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <!-- Modal body -->
            <div class=""modal-body"">
                <div id=""Display""></div>
            </div>
            <!-- Modal footer -->
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" data-bs-dismiss=""modal"">Cancel</button>
            </div>

        </div>
    </div>
</div>
<di>

</di>
<!--Displaying the conetne-->
<div id=""accordion"" class=""pt-2 ml-2 mr-2"">
");
#nullable restore
#line 179 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
     if (ViewBag.Bool != null)
    {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 181 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
     foreach (Content item in ViewBag.Content)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>\r\n        <a href=\"#\">\r\n            ");
#nullable restore
#line 185 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n    </h2>\r\n    <div>\r\n        <div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 191 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.TopicDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 194 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.DocumentDescription1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n            </div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 198 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.Document1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n            </div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 202 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.DocumentDescription2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n            </div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 206 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.Document2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n            </div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 210 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.DocumentDescription3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n            </div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 214 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.Document3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n            </div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 218 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.DocumentDescription4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n            </div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 222 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.Document5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n            </div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 226 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.DocumentDescription5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n            </div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 230 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.LinkDescription1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n            </div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 234 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.Link1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n            </div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 238 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.LinkDescription1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n            </div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 242 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.Link2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n            </div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 246 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.LinkDescription2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n            </div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 250 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.Link3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n            </div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 254 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.LinkDescription3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n            </div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 258 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.Link4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n            </div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 262 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.LinkDescription5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n            </div>\r\n            <div class=\"pb-2 fw-bold\">\r\n                <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 266 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                            Write(item.Link2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n");
#nullable restore
#line 268 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
             if (Layout == "~/Views/Shared/_TutorLayoutcshtml.cshtml")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"modal-footer\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2276ddb38fcc160809c92299283d94dac8e9374729671", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 271 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
                                                       WriteLiteral(item.ContentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                <button type=\"button\" class=\"btn btn-outline-danger text-mute\" data-dismiss=\"modal\">Delete</button>\r\n\r\n            </div>\r\n");
#nullable restore
#line 277 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 281 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 282 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
     

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>No Content uploaded yet, Please be patient</h3>\r\n");
#nullable restore
#line 288 "C:\Users\koketso\Desktop\Project\Views\Module\Content.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
