#pragma checksum "C:\Users\Cody\Desktop\BCC_Project\BCC_MVC\Views\MovieListing\MovieInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cf319b7c0a470f3e38ad0e6dbff38aa21af6476"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieListing_MovieInfo), @"mvc.1.0.view", @"/Views/MovieListing/MovieInfo.cshtml")]
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
#line 1 "C:\Users\Cody\Desktop\BCC_Project\BCC_MVC\Views\_ViewImports.cshtml"
using BCC_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cody\Desktop\BCC_Project\BCC_MVC\Views\_ViewImports.cshtml"
using BCC_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cf319b7c0a470f3e38ad0e6dbff38aa21af6476", @"/Views/MovieListing/MovieInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e43e5f01c3e42dfe9bfeb6b840c1cf91178131e8", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieListing_MovieInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <table class=\"justify-content-md-center\">\r\n        <tr>\r\n            <td>Title:</td>\r\n            <td>");
#nullable restore
#line 7 "C:\Users\Cody\Desktop\BCC_Project\BCC_MVC\Views\MovieListing\MovieInfo.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Description:</td>\r\n            <td>");
#nullable restore
#line 11 "C:\Users\Cody\Desktop\BCC_Project\BCC_MVC\Views\MovieListing\MovieInfo.cshtml"
           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 341, "\"", 366, 1);
#nullable restore
#line 15 "C:\Users\Cody\Desktop\BCC_Project\BCC_MVC\Views\MovieListing\MovieInfo.cshtml"
WriteAttributeValue("", 347, Model.ThumbnailRef, 347, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n        </tr>\r\n    </table>\r\n    \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
