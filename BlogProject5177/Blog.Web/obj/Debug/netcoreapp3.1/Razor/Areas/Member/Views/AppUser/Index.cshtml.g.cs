#pragma checksum "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Areas\Member\Views\AppUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b573047a3f34de94413fb5bbe478f7b76d22802b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_AppUser_Index), @"mvc.1.0.view", @"/Areas/Member/Views/AppUser/Index.cshtml")]
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
#line 1 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Areas\Member\Views\_ViewImports.cshtml"
using Blog.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Areas\Member\Views\_ViewImports.cshtml"
using Blog.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Areas\Member\Views\_ViewImports.cshtml"
using Blog.Web.Models.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Areas\Member\Views\_ViewImports.cshtml"
using Blog.Web.Models.VMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Areas\Member\Views\_ViewImports.cshtml"
using Blog.Web.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Areas\Member\Views\_ViewImports.cshtml"
using Blog.Model.Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Areas\Member\Views\_ViewImports.cshtml"
using Blog.Web.Areas.Member.Models.VMs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b573047a3f34de94413fb5bbe478f7b76d22802b", @"/Areas/Member/Views/AppUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96673e2a16f23a09f3fe6a799f84c44c45f9c101", @"/Areas/Member/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_Views_AppUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\n    <div id=\"Dv_Articles\" class=\"col-lg-8\"> \n        ");
#nullable restore
#line 3 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Areas\Member\Views\AppUser\Index.cshtml"
   Write(await Component.InvokeAsync("Articles",new{categoryId=(int)ViewBag.CategoryId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div id=\"Dv_Categories\" class=\"col-lg-4\">\n        <div class=\"mb-5\">\n            ");
#nullable restore
#line 7 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Areas\Member\Views\AppUser\Index.cshtml"
       Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"mb-5\">\n            ");
#nullable restore
#line 10 "C:\Users\berk\Desktop\BlogProject5177\Blog.Web\Areas\Member\Views\AppUser\Index.cshtml"
       Write(await Component.InvokeAsync("FollowCategoryList",new{CategoryAppUserId=ViewBag.CategoryAppUserId.ToString()}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        \n    </div>\n</div>");
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
