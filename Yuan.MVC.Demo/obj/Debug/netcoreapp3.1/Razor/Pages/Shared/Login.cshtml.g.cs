#pragma checksum "C:\Users\ayuan0105\Desktop\quickstart\Yuan.IdentityServer4.Demo\DiffAuthMode\yuan-demo-remix\Yuan.MVC.Demo\Pages\Shared\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "840ce460e58d915268852cddf829c30f50a763dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Yuan.MVC.Demo.Pages.Shared.Pages_Shared_Login), @"mvc.1.0.view", @"/Pages/Shared/Login.cshtml")]
namespace Yuan.MVC.Demo.Pages.Shared
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
#line 1 "C:\Users\ayuan0105\Desktop\quickstart\Yuan.IdentityServer4.Demo\DiffAuthMode\yuan-demo-remix\Yuan.MVC.Demo\Pages\_ViewImports.cshtml"
using Yuan.MVC.Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ayuan0105\Desktop\quickstart\Yuan.IdentityServer4.Demo\DiffAuthMode\yuan-demo-remix\Yuan.MVC.Demo\Pages\_ViewImports.cshtml"
using Yuan.MVC.Demo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ayuan0105\Desktop\quickstart\Yuan.IdentityServer4.Demo\DiffAuthMode\yuan-demo-remix\Yuan.MVC.Demo\Pages\Shared\Login.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"840ce460e58d915268852cddf829c30f50a763dd", @"/Pages/Shared/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f02fb7e6abcb99e695c208dd8c19de0480205a0d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Now that you are logging in, get your userInformation</h1>\r\n</div>\r\n<h2>Claims</h2>\r\n\r\n<dl>\r\n");
#nullable restore
#line 11 "C:\Users\ayuan0105\Desktop\quickstart\Yuan.IdentityServer4.Demo\DiffAuthMode\yuan-demo-remix\Yuan.MVC.Demo\Pages\Shared\Login.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dt>");
#nullable restore
#line 13 "C:\Users\ayuan0105\Desktop\quickstart\Yuan.IdentityServer4.Demo\DiffAuthMode\yuan-demo-remix\Yuan.MVC.Demo\Pages\Shared\Login.cshtml"
   Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd>");
#nullable restore
#line 14 "C:\Users\ayuan0105\Desktop\quickstart\Yuan.IdentityServer4.Demo\DiffAuthMode\yuan-demo-remix\Yuan.MVC.Demo\Pages\Shared\Login.cshtml"
   Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 15 "C:\Users\ayuan0105\Desktop\quickstart\Yuan.IdentityServer4.Demo\DiffAuthMode\yuan-demo-remix\Yuan.MVC.Demo\Pages\Shared\Login.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</dl>\r\n\r\n<h2>Properties</h2>\r\n\r\n<dl>\r\n");
#nullable restore
#line 21 "C:\Users\ayuan0105\Desktop\quickstart\Yuan.IdentityServer4.Demo\DiffAuthMode\yuan-demo-remix\Yuan.MVC.Demo\Pages\Shared\Login.cshtml"
     foreach (var prop in (await Context.AuthenticateAsync()).Properties.Items)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dt>");
#nullable restore
#line 23 "C:\Users\ayuan0105\Desktop\quickstart\Yuan.IdentityServer4.Demo\DiffAuthMode\yuan-demo-remix\Yuan.MVC.Demo\Pages\Shared\Login.cshtml"
   Write(prop.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd>");
#nullable restore
#line 24 "C:\Users\ayuan0105\Desktop\quickstart\Yuan.IdentityServer4.Demo\DiffAuthMode\yuan-demo-remix\Yuan.MVC.Demo\Pages\Shared\Login.cshtml"
   Write(prop.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 25 "C:\Users\ayuan0105\Desktop\quickstart\Yuan.IdentityServer4.Demo\DiffAuthMode\yuan-demo-remix\Yuan.MVC.Demo\Pages\Shared\Login.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</dl>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
