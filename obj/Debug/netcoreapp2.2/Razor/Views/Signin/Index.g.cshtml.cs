#pragma checksum "/Users/ben/Documents/Projects/SpotifyApp/Views/Signin/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83cd37e71ff68a638140f0c0b766b3e717d746f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Signin_Index), @"mvc.1.0.view", @"/Views/Signin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Signin/Index.cshtml", typeof(AspNetCore.Views_Signin_Index))]
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
#line 1 "/Users/ben/Documents/Projects/SpotifyApp/Views/_ViewImports.cshtml"
using SpotifyApp;

#line default
#line hidden
#line 2 "/Users/ben/Documents/Projects/SpotifyApp/Views/_ViewImports.cshtml"
using SpotifyApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83cd37e71ff68a638140f0c0b766b3e717d746f8", @"/Views/Signin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee383743a32161732a406b7d470eb0e0540c86eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Signin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SpotifyApp.Models.Spotify>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/ben/Documents/Projects/SpotifyApp/Views/Signin/Index.cshtml"
  
    ViewData["Title"] = "Your Home Page";

#line default
#line hidden
            BeginContext(80, 148, true);
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome</h1>\n    <p>Hello World, welcome to the singnin page</p>\n    <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 228, "\"", 256, 1);
#line 9 "/Users/ben/Documents/Projects/SpotifyApp/Views/Signin/Index.cshtml"
WriteAttributeValue("", 235, Model.getSigninUrl(), 235, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(257, 211, true);
            WriteLiteral(" role=\"button\"></a>Give Spotify Info</a> \n</div>\n\n<div class=\"header event\">\n    <h1 class=\"title-header\">Events Page</h1>\n    <input type=\"button\" class=\"btn btn-primary create-button\" value=\"Sign into Spotify\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 468, "\"", 546, 2);
#line 14 "/Users/ben/Documents/Projects/SpotifyApp/Views/Signin/Index.cshtml"
WriteAttributeValue("", 478, "window.location.href='" + @Url.Action("Create", "Events") + "'", 478, 67, false);

#line default
#line hidden
            WriteAttributeValue("", 545, ";", 545, 1, true);
            EndWriteAttribute();
            BeginContext(547, 37, true);
            WriteLiteral(" />\n</div>\n\n<div class = \"\"></div>\n\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SpotifyApp.Models.Spotify> Html { get; private set; }
    }
}
#pragma warning restore 1591
