#pragma checksum "/Users/ben/Documents/Projects/SpotifyApp/Views/Signin/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "286542d9a6878b70584a7fde49a6944c7dfeb71f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"286542d9a6878b70584a7fde49a6944c7dfeb71f", @"/Views/Signin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee383743a32161732a406b7d470eb0e0540c86eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Signin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/ben/Documents/Projects/SpotifyApp/Views/Signin/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 287, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Hello World, welcome to the singnin page</p>
</div>

<div class=""header event"">
    <h1 class=""title-header"">Events Page</h1>
    <input type=""button"" class=""btn btn-primary create-button"" value=""Sign into Spotify""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 329, "\"", 407, 2);
#line 12 "/Users/ben/Documents/Projects/SpotifyApp/Views/Signin/Index.cshtml"
WriteAttributeValue("", 339, "window.location.href='" + @Url.Action("Create", "Events") + "'", 339, 67, false);

#line default
#line hidden
            WriteAttributeValue("", 406, ";", 406, 1, true);
            EndWriteAttribute();
            BeginContext(408, 633, true);
            WriteLiteral(@" />
</div>

<div class=""Card-deck"">
    <div class=""col-sm-4"">
                <div class=""card text-center event-card"" style=""margin-bottom:25px"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Bloop</h5>
                        <div class=""description"">
                            <p class=""card-text""> This is the card info</p>
                        </div>
                    </div>
                    <div class=""card-footer text-muted"">
                        <h1>Date div</h1>
                        
                    </div>
                </div>
            </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591