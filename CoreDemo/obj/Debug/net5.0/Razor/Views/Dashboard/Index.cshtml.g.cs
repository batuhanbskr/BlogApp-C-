#pragma checksum "C:\Users\User\Desktop\SOFTWARE\ASP.NET\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e65d535409dd994cbd4895b0e6ff23bbda3ca37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\SOFTWARE\ASP.NET\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\SOFTWARE\ASP.NET\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e65d535409dd994cbd4895b0e6ff23bbda3ca37", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Desktop\SOFTWARE\ASP.NET\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e65d535409dd994cbd4895b0e6ff23bbda3ca373442", async() => {
                WriteLiteral(@"
            <div class=""page-header"">
                <h3 class=""page-title"">
                    <span class=""page-title-icon bg-gradient-primary text-white mr-2"">
                        <i class=""mdi mdi-home""></i>
                    </span> Dashboard
                </h3>
            </div>
            <div class=""row"">
                <div class=""col-md-4 stretch-card grid-margin"">
                    <div class=""card bg-gradient-danger card-img-holder text-white"">
                        <div class=""card-body"">
                            <img src=""/writer/assets/images/dashboard/circle.svg"" class=""card-img-absolute"" alt=""circle-image"" />
                            <h4 class=""font-weight-normal mb-3"">
                                Toplam Blog Sayısı <i class=""mdi mdi-chart-line mdi-24px float-right""></i>
                            </h4>
                            <h2 class=""mb-5"">");
#nullable restore
#line 24 "C:\Users\User\Desktop\SOFTWARE\ASP.NET\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
                                        Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
                            <h6 class=""card-text"">Core 5.0 Proje</h6>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4 stretch-card grid-margin"">
                    <div class=""card bg-gradient-info card-img-holder text-white"">
                        <div class=""card-body"">
                            <img src=""/writer/assets/images/dashboard/circle.svg"" class=""card-img-absolute"" alt=""circle-image"" />
                            <h4 class=""font-weight-normal mb-3"">
                                Sizin Blog Sayınız <i class=""mdi mdi-bookmark-outline mdi-24px float-right""></i>
                            </h4>
                            <h2 class=""mb-5"">");
#nullable restore
#line 36 "C:\Users\User\Desktop\SOFTWARE\ASP.NET\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
                                        Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
                    <h6 class=""card-text"">Core 5.0 Proje</h6>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4 stretch-card grid-margin"">
                    <div class=""card bg-gradient-success card-img-holder text-white"">
                        <div class=""card-body"">
                            <img src=""/writer/assets/images/dashboard/circle.svg"" class=""card-img-absolute"" alt=""circle-image"" />
                            <h4 class=""font-weight-normal mb-3"">
                                Toplam Kategori Sayısı <i class=""mdi mdi-diamond mdi-24px float-right""></i>
                            </h4>
                            <h2 class=""mb-5"">");
#nullable restore
#line 48 "C:\Users\User\Desktop\SOFTWARE\ASP.NET\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
                                        Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                    <h6 class=\"card-text\">Core 5.0 Proje</h6>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            ");
#nullable restore
#line 54 "C:\Users\User\Desktop\SOFTWARE\ASP.NET\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
       Write(await Component.InvokeAsync("BlogListDashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 55 "C:\Users\User\Desktop\SOFTWARE\ASP.NET\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
       Write(await Component.InvokeAsync("WriterAboutOnDashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 56 "C:\Users\User\Desktop\SOFTWARE\ASP.NET\CoreDemo\CoreDemo\Views\Dashboard\Index.cshtml"
       Write(await Component.InvokeAsync("CategoryListDashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
