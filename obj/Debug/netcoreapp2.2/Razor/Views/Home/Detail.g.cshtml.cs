#pragma checksum "C:\Users\Jermaine Terry Jr\Documents\c_sharp\WeddingPlanner\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eed62b159292386a897a54d4669b34eccd28cbab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detail.cshtml", typeof(AspNetCore.Views_Home_Detail))]
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
#line 1 "C:\Users\Jermaine Terry Jr\Documents\c_sharp\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "C:\Users\Jermaine Terry Jr\Documents\c_sharp\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eed62b159292386a897a54d4669b34eccd28cbab", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Wedding>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 3, true);
            WriteLiteral(" \r\n");
            EndContext();
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Jermaine Terry Jr\Documents\c_sharp\WeddingPlanner\Views\Home\Detail.cshtml"
  foreach(var w in Model)
        {

#line default
#line hidden
            BeginContext(66, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(105, 11, false);
#line 7 "C:\Users\Jermaine Terry Jr\Documents\c_sharp\WeddingPlanner\Views\Home\Detail.cshtml"
               Write(w.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(116, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(122, 11, false);
#line 7 "C:\Users\Jermaine Terry Jr\Documents\c_sharp\WeddingPlanner\Views\Home\Detail.cshtml"
                                Write(w.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(133, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(161, 6, false);
#line 8 "C:\Users\Jermaine Terry Jr\Documents\c_sharp\WeddingPlanner\Views\Home\Detail.cshtml"
               Write(w.Date);

#line default
#line hidden
            EndContext();
            BeginContext(167, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(195, 10, false);
#line 9 "C:\Users\Jermaine Terry Jr\Documents\c_sharp\WeddingPlanner\Views\Home\Detail.cshtml"
               Write(w.MyGuests);

#line default
#line hidden
            EndContext();
            BeginContext(205, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(233, 9, false);
#line 10 "C:\Users\Jermaine Terry Jr\Documents\c_sharp\WeddingPlanner\Views\Home\Detail.cshtml"
               Write(w.Address);

#line default
#line hidden
            EndContext();
            BeginContext(242, 28, true);
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 13 "C:\Users\Jermaine Terry Jr\Documents\c_sharp\WeddingPlanner\Views\Home\Detail.cshtml"
        }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Wedding>> Html { get; private set; }
    }
}
#pragma warning restore 1591
