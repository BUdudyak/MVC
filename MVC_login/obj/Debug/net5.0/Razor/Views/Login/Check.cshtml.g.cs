#pragma checksum "D:\Git\MVC\MVC_login\Views\Login\Check.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e150f228c8b8fc33aab0259d382571966314dd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Check), @"mvc.1.0.view", @"/Views/Login/Check.cshtml")]
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
#line 1 "D:\Git\MVC\MVC_login\Views\_ViewImports.cshtml"
using MVC_login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Git\MVC\MVC_login\Views\_ViewImports.cshtml"
using MVC_login.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e150f228c8b8fc33aab0259d382571966314dd5", @"/Views/Login/Check.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34758e2d115a97679c3e6b3e6bcba518d397c4e3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_Check : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC_login.Models.UserModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Git\MVC\MVC_login\Views\Login\Check.cshtml"
  Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Git\MVC\MVC_login\Views\Login\Check.cshtml"
 if (Model.IsLogged)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Git\MVC\MVC_login\Views\Login\Check.cshtml"
     if (Model.IsAdmin)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>You are Chad</h1>\r\n");
#nullable restore
#line 9 "D:\Git\MVC\MVC_login\Views\Login\Check.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>You are Normie</h1>\r\n");
#nullable restore
#line 13 "D:\Git\MVC\MVC_login\Views\Login\Check.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Git\MVC\MVC_login\Views\Login\Check.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>You are mistake</h1>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 256, "\"", 292, 1);
#nullable restore
#line 18 "D:\Git\MVC\MVC_login\Views\Login\Check.cshtml"
WriteAttributeValue("", 263, Url.Action("Index", "Login"), 263, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Please back to log in again</a>\r\n");
#nullable restore
#line 19 "D:\Git\MVC\MVC_login\Views\Login\Check.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC_login.Models.UserModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
