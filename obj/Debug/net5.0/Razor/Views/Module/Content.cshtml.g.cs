#pragma checksum "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dfd98586b16689dd5c9667473c97df9191c5f42"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dfd98586b16689dd5c9667473c97df9191c5f42", @"/Views/Module/Content.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6dbcc57f67d04b7437938f6811bce6b62e099ff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Module_Content : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TBHAcademy.Models.Content>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "#", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "#", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("Update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
  
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
#line 11 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                       Write(ViewBag.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 14 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
 if(Layout == "~/Views/Shared/_TutorLayoutcshtml.cshtml"){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container mt-3"">
  <button type=""button"" id=""Add"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#myModal"">
    Add new Content
  </button>

</div>
<script defer>
$(document).ready(function() {
    $(""#Add"").click(function() {
        $('#Display').load(""/Module/Add"");
    });
});
</script>
");
#nullable restore
#line 28 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

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
<!--Displaying the conetne-->
<div id=""accordion"" class=""pt-2"">
");
#nullable restore
#line 49 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
     if(ViewBag.Bool != null)
    {
         

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
          foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <h2>\r\n            <a href=\"#\">\r\n                ");
#nullable restore
#line 55 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n        </h2>\r\n        <div>\r\n            <div>\r\n                <div class=\"pb-2 fw-bold\">\r\n                  <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 61 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                              Write(item.TopicDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n                <div class=\"pb-2 fw-bold\">\r\n                    <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 64 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                                Write(item.DocumentDescription1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                </div>\r\n                <div class=\"pb-2 fw-bold\">\r\n                   <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 68 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                               Write(item.Document1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                </div>\r\n                <div class=\"pb-2 fw-bold\">\r\n                    <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 72 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                                Write(item.DocumentDescription2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                </div>\r\n                <div class=\"pb-2 fw-bold\">\r\n                   <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 76 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                               Write(item.Document2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                </div>\r\n                <div class=\"pb-2 fw-bold\">\r\n                    <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 80 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                                Write(item.DocumentDescription3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                </div>\r\n                <div class=\"pb-2 fw-bold\">\r\n                   <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 84 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                               Write(item.Document3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                </div>\r\n                 <div class=\"pb-2 fw-bold\">\r\n                    <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 88 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                                Write(item.DocumentDescription4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                </div>\r\n                <div class=\"pb-2 fw-bold\">\r\n                   <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 92 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                               Write(item.Document5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                </div>\r\n                 <div class=\"pb-2 fw-bold\">\r\n                    <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 96 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                                Write(item.DocumentDescription5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                </div>\r\n                <div class=\"pb-2 fw-bold\">\r\n                   <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 100 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                               Write(item.LinkDescription1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                </div>\r\n                 <div class=\"pb-2 fw-bold\">\r\n                    <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 104 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                                Write(item.Link1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                </div>\r\n                         <div class=\"pb-2 fw-bold\">\r\n                   <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 108 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                               Write(item.LinkDescription1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                </div>\r\n                 <div class=\"pb-2 fw-bold\">\r\n                    <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 112 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                                Write(item.Link2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                </div>\r\n                         <div class=\"pb-2 fw-bold\">\r\n                   <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 116 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                               Write(item.LinkDescription2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                </div>\r\n                 <div class=\"pb-2 fw-bold\">\r\n                    <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 120 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                                Write(item.Link3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                </div>\r\n                           <div class=\"pb-2 fw-bold\">\r\n                   <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 124 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                               Write(item.LinkDescription3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                </div>\r\n                 <div class=\"pb-2 fw-bold\">\r\n                    <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 128 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                                Write(item.Link4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                </div>\r\n                           <div class=\"pb-2 fw-bold\">\r\n                   <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 132 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                               Write(item.LinkDescription5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                </div>\r\n                 <div class=\"pb-2 fw-bold\">\r\n                    <a class=\"text-primary\" href=\"#\">");
#nullable restore
#line 136 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                                Write(item.Link2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n");
#nullable restore
#line 138 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                 if(Layout == "~/Views/Shared/_TutorLayoutcshtml.cshtml")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"modal-footer\">\r\n                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dfd98586b16689dd5c9667473c97df9191c5f4215719", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 141 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                                                                  WriteLiteral(item.ContentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                \r\n                      <button type=\"button\" class=\"btn btn-outline-danger text-mute\" data-dismiss=\"modal\">Delete</button>\r\n\r\n                  </div>\r\n");
#nullable restore
#line 146 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 150 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
        
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 151 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
         
        
    }
   else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>No Content uploaded yet, Please be patient</h3>\r\n");
#nullable restore
#line 157 "C:\Users\Ernest\3D Objects\Project 2022\Views\Module\Content.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n   \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TBHAcademy.Models.Content>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
