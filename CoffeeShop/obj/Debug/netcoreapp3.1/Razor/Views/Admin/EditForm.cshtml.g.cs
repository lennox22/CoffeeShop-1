#pragma checksum "C:\Users\lbrown4\dev\Week 10\DevBuildLab10_2\CoffeeShop\Views\Admin\EditForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2fae6ce70818ada237188ded7c3ed017ba350dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditForm), @"mvc.1.0.view", @"/Views/Admin/EditForm.cshtml")]
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
#line 1 "C:\Users\lbrown4\dev\Week 10\DevBuildLab10_2\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lbrown4\dev\Week 10\DevBuildLab10_2\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2fae6ce70818ada237188ded7c3ed017ba350dd", @"/Views/Admin/EditForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0280a23aa28fddc99a39f5869bf0f0a5a4076c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lbrown4\dev\Week 10\DevBuildLab10_2\CoffeeShop\Views\Admin\EditForm.cshtml"
  
    ViewData["Title"] = "EditForm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Users\lbrown4\dev\Week 10\DevBuildLab10_2\CoffeeShop\Views\Admin\EditForm.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2fae6ce70818ada237188ded7c3ed017ba350dd4117", async() => {
                WriteLiteral("\r\n    <input type=\"submit\" /><br /><br />\r\n    <table>\r\n        <tbody>\r\n            <tr>\r\n                <td>Name: </td>\r\n                <td><input type=\"text\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 325, "\"", 344, 1);
#nullable restore
#line 15 "C:\Users\lbrown4\dev\Week 10\DevBuildLab10_2\CoffeeShop\Views\Admin\EditForm.cshtml"
WriteAttributeValue("", 333, Model.Name, 333, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required/></td>\r\n            </tr>\r\n            <tr>\r\n                <td>Price: </td>\r\n                <td><input type=\"text\" name=\"Price\"");
                BeginWriteAttribute("value", " value=\"", 485, "\"", 505, 1);
#nullable restore
#line 19 "C:\Users\lbrown4\dev\Week 10\DevBuildLab10_2\CoffeeShop\Views\Admin\EditForm.cshtml"
WriteAttributeValue("", 493, Model.Price, 493, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required/></td>\r\n            </tr>\r\n            <tr>\r\n                <td>Description: </td>\r\n                <td><input type=\"text\" name=\"Description\"");
                BeginWriteAttribute("value", " value=\"", 658, "\"", 684, 1);
#nullable restore
#line 23 "C:\Users\lbrown4\dev\Week 10\DevBuildLab10_2\CoffeeShop\Views\Admin\EditForm.cshtml"
WriteAttributeValue("", 666, Model.Description, 666, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required/></td>\r\n            </tr>\r\n            <tr>\r\n                <td>Category: </td>\r\n                <td>\r\n                    <select id=\"category\" name=\"category\" required>\r\n");
#nullable restore
#line 29 "C:\Users\lbrown4\dev\Week 10\DevBuildLab10_2\CoffeeShop\Views\Admin\EditForm.cshtml"
                     foreach (product prod in ViewBag.categories)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2fae6ce70818ada237188ded7c3ed017ba350dd6528", async() => {
#nullable restore
#line 31 "C:\Users\lbrown4\dev\Week 10\DevBuildLab10_2\CoffeeShop\Views\Admin\EditForm.cshtml"
                                                  Write(prod.category);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\lbrown4\dev\Week 10\DevBuildLab10_2\CoffeeShop\Views\Admin\EditForm.cshtml"
                           WriteLiteral(prod.category);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\lbrown4\dev\Week 10\DevBuildLab10_2\CoffeeShop\Views\Admin\EditForm.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </select>\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n    <br /><br />\r\n    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1214, "\"", 1231, 1);
#nullable restore
#line 40 "C:\Users\lbrown4\dev\Week 10\DevBuildLab10_2\CoffeeShop\Views\Admin\EditForm.cshtml"
WriteAttributeValue("", 1222, Model.id, 1222, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1232, "\"", 1248, 1);
#nullable restore
#line 40 "C:\Users\lbrown4\dev\Week 10\DevBuildLab10_2\CoffeeShop\Views\Admin\EditForm.cshtml"
WriteAttributeValue("", 1239, Model.id, 1239, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"submit\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 128, "/admin/edit/", 128, 12, true);
#nullable restore
#line 9 "C:\Users\lbrown4\dev\Week 10\DevBuildLab10_2\CoffeeShop\Views\Admin\EditForm.cshtml"
AddHtmlAttributeValue("", 140, Model.id, 140, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<product> Html { get; private set; }
    }
}
#pragma warning restore 1591
