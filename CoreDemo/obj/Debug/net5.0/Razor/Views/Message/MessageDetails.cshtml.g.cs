#pragma checksum "C:\Users\User\Desktop\SOFTWARE\ASP.NET\CoreDemo\CoreDemo\Views\Message\MessageDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "148dcf613efcb3ee09d90c99b0c834f83acde63b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_MessageDetails), @"mvc.1.0.view", @"/Views/Message/MessageDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"148dcf613efcb3ee09d90c99b0c834f83acde63b", @"/Views/Message/MessageDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Message_MessageDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Message2>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\SOFTWARE\ASP.NET\CoreDemo\CoreDemo\Views\Message\MessageDetails.cshtml"
  
    ViewData["Title"] = "MessageDetails";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Mesaj Detay Sayfası</h1>\r\n");
#nullable restore
#line 8 "C:\Users\User\Desktop\SOFTWARE\ASP.NET\CoreDemo\CoreDemo\Views\Message\MessageDetails.cshtml"
Write(Html.Label("Mesaj ID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\User\Desktop\SOFTWARE\ASP.NET\CoreDemo\CoreDemo\Views\Message\MessageDetails.cshtml"
Write(Html.TextBoxFor(x=>x.MessageID, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 11 "C:\Users\User\Desktop\SOFTWARE\ASP.NET\CoreDemo\CoreDemo\Views\Message\MessageDetails.cshtml"
Write(Html.Label("Mesaj Başlığı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\User\Desktop\SOFTWARE\ASP.NET\CoreDemo\CoreDemo\Views\Message\MessageDetails.cshtml"
Write(Html.TextBoxFor(x=>x.Subject, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 14 "C:\Users\User\Desktop\SOFTWARE\ASP.NET\CoreDemo\CoreDemo\Views\Message\MessageDetails.cshtml"
Write(Html.Label("Mesaj İçeriği"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\User\Desktop\SOFTWARE\ASP.NET\CoreDemo\CoreDemo\Views\Message\MessageDetails.cshtml"
Write(Html.TextAreaFor(x=>x.MessageDetails, 10, 3, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Message2> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
