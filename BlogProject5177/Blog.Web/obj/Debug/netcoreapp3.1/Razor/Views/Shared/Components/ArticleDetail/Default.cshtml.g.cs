#pragma checksum "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa17f13a93b8108c1df49e5adcf427fca6e3fe57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ArticleDetail_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ArticleDetail/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\_ViewImports.cshtml"
using Blog.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\_ViewImports.cshtml"
using Blog.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\_ViewImports.cshtml"
using Blog.Web.Models.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\_ViewImports.cshtml"
using Blog.Web.Models.VMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\_ViewImports.cshtml"
using Blog.Model.Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\_ViewImports.cshtml"
using Blog.Model.Entities.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa17f13a93b8108c1df49e5adcf427fca6e3fe57", @"/Views/Shared/Components/ArticleDetail/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00ddb0e0fd04ad0ac41a887c4d1878ae147edab7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ArticleDetail_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Article>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("15"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cols", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("readonly", new global::Microsoft.AspNetCore.Html.HtmlString("readonly"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToLike", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container mt-5\">\n    <div class=\"row\">\n        <div class=\"col-lg-8 offset-2\"> \n            <article> \n                <header class=\"mb-4\"> \n                    <h1 class=\"fw-bolder mb-1\">");
#nullable restore
#line 8 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
                                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1> \n                    <div class=\"row text-muted fst-italic mb-2\">\n                        <div class=\"col-md-6\">\n                            Yayınlanma Tarihi , ");
#nullable restore
#line 11 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
                                           Write(Model.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                        <div class=\"col-md-6\">\n                            <span class=\"float-right\">  Okunma Süresi , ");
#nullable restore
#line 14 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
                                                                   Write(Model.ReadTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" dk</span>\n                        </div>\n                    </div> \n");
#nullable restore
#line 17 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
                     foreach (var category in Model.ArticleCategories.Select(x => x.Category))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"badge bg-secondary text-decoration-none link-light\" href=\"#!\">");
#nullable restore
#line 19 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
                                                                                           Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n");
#nullable restore
#line 20 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </header> \n                <figure class=\"mb-4\"><img class=\"img-fluid rounded\"");
            BeginWriteAttribute("src", " src=\"", 1036, "\"", 1058, 1);
#nullable restore
#line 22 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
WriteAttributeValue("", 1042, Model.ImagePath, 1042, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"...\" /></figure> \n                <section class=\"mb-2\">\n                    <div class=\"form-group\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa17f13a93b8108c1df49e5adcf427fca6e3fe5710310", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 25 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Content);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa17f13a93b8108c1df49e5adcf427fca6e3fe5711789", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 26 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Content);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </section>\n                <div class=\"row mb-5\">\n                    <div class=\"col-md-6\">\n                        <span class=\"text-muted fst-italic mb-2\">Okunma Sayısı, ");
#nullable restore
#line 31 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
                                                                           Write(Model.ReadCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    </div>\n");
#nullable restore
#line 33 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
                     if (ViewBag.Sayfa == "user")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-6\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa17f13a93b8108c1df49e5adcf427fca6e3fe5714531", async() => {
                WriteLiteral("\n                                <input type=\"hidden\" name=\"AppUserID\"");
                BeginWriteAttribute("value", " value=\"", 1890, "\"", 1923, 1);
#nullable restore
#line 37 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
WriteAttributeValue("", 1898, ViewBag.CurrentAppUserID, 1898, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                <input type=\"hidden\" name=\"ArticleID\"");
                BeginWriteAttribute("value", " value=\"", 1997, "\"", 2014, 1);
#nullable restore
#line 38 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
WriteAttributeValue("", 2005, Model.ID, 2005, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n");
#nullable restore
#line 39 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
                                 if (Model.Likes.Any(x => x.AppUserID == ViewBag.CurrentAppUserID))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <input type=""hidden"" name=""Type"" value=""cancel"" />
                                    <button type=""submit"" class=""btn btn-warning float-right"">
                                        Beğeni Geri Al
                                        <span class=""badge badge-dark badge-pill"">");
#nullable restore
#line 44 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
                                                                             Write(Model.Likes.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                                    </button>\n");
#nullable restore
#line 46 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        <input type=""hidden"" name=""Type"" value=""like"" />
                                        <button type=""submit"" class=""btn btn-danger float-right"">
                                            Beğen <span class=""badge badge-dark badge-pill"">");
#nullable restore
#line 52 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
                                                                                       Write(Model.Likes.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                                        </button>\n                                    ");
#nullable restore
#line 54 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
                                           
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n");
#nullable restore
#line 58 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </article>\n");
#nullable restore
#line 61 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
             if (ViewBag.Sayfa == "user")
            { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                <section class=\"mb-5\">\n                    <div class=\"card bg-light\">\n                        <div class=\"card-body\"> \n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa17f13a93b8108c1df49e5adcf427fca6e3fe5720415", async() => {
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <textarea name=""Text"" class=""form-control"" rows=""4"" placeholder=""Yorum Yaz..""></textarea>
                                    <input type=""hidden"" name=""AppUserID""");
                BeginWriteAttribute("value", " value=\"", 3797, "\"", 3830, 1);
#nullable restore
#line 69 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
WriteAttributeValue("", 3805, ViewBag.CurrentAppUserID, 3805, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                    <input type=\"hidden\" name=\"ArticleID\"");
                BeginWriteAttribute("value", " value=\"", 3908, "\"", 3925, 1);
#nullable restore
#line 70 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
WriteAttributeValue("", 3916, Model.ID, 3916, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                </div>
                                <div class=""form-group mt-2"">
                                    <input type=""submit"" class=""btn btn-success"" value=""Gönder"" />
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  \n");
#nullable restore
#line 76 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
                             foreach (var comment in Model.Comments)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"d-flex\">\n                                    <div class=\"ms-3\">\n                                        <div class=\"fw-bold\">");
#nullable restore
#line 80 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
                                                        Write(comment.Appuser.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                                        ");
#nullable restore
#line 81 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
                                   Write(comment.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </div>\n                                </div>\n");
#nullable restore
#line 84 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\n                    </div>\n                </section>\n");
#nullable restore
#line 88 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Views\Shared\Components\ArticleDetail\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div> \n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Article> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591