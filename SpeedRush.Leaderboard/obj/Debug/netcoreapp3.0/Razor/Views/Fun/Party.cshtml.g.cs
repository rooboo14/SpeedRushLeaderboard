#pragma checksum "C:\Users\andre\source\repos\SpeedRush\SpeedRush.Leaderboard\Views\Fun\Party.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5487e4a7dfaa3d993ca82e76e54ef3cb6d81641c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fun_Party), @"mvc.1.0.view", @"/Views/Fun/Party.cshtml")]
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
#line 1 "C:\Users\andre\source\repos\SpeedRush\SpeedRush.Leaderboard\Views\_ViewImports.cshtml"
using SpeedRush.Leaderboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andre\source\repos\SpeedRush\SpeedRush.Leaderboard\Views\_ViewImports.cshtml"
using SpeedRush.Leaderboard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5487e4a7dfaa3d993ca82e76e54ef3cb6d81641c", @"/Views/Fun/Party.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23b7c03aca58b1566290134d22a9745c8c9dc241", @"/Views/_ViewImports.cshtml")]
    public class Views_Fun_Party : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\andre\source\repos\SpeedRush\SpeedRush.Leaderboard\Views\Fun\Party.cshtml"
  
    ViewData["Title"] = "Party";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Party</h1>\r\n\r\n<div class=\"text-center\">\r\n    <h3 class=\"display-4\">Party Time</h3>\r\n    <p>We love having parties because a party is so much fun!</p>\r\n</div>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\andre\source\repos\SpeedRush\SpeedRush.Leaderboard\Views\Fun\Party.cshtml"
  
    for (var i = 10; i > 0; i--)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\andre\source\repos\SpeedRush\SpeedRush.Leaderboard\Views\Fun\Party.cshtml"
   Write(Html.Raw("<div class='text-center'>Time till party: " + i + " seconds!</div>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\andre\source\repos\SpeedRush\SpeedRush.Leaderboard\Views\Fun\Party.cshtml"
                                                                                       ;
    }


#line default
#line hidden
#nullable disable
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
