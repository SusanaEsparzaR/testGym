#pragma checksum "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\_HomeMemberList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe4878d1415d373abaa5b6dd585f5b6e6b7ab969"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HomeMemberList), @"mvc.1.0.view", @"/Views/Shared/_HomeMemberList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4878d1415d373abaa5b6dd585f5b6e6b7ab969", @"/Views/Shared/_HomeMemberList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__HomeMemberList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GymManager.Core.Members.Member>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\">\r\n  <thead>\r\n    <tr>\r\n      <th scope=\"col\">First Name</th>\r\n      <th scope=\"col\">Last Name</th>\r\n      <th scope=\"col\">Birthday</th>\r\n      <th scope=\"col\">Email</th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
#nullable restore
#line 13 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\_HomeMemberList.cshtml"
     foreach(var member in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 16 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\_HomeMemberList.cshtml"
                           Write(member.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\_HomeMemberList.cshtml"
               Write(member.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\_HomeMemberList.cshtml"
               Write(member.BirthDay.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\_HomeMemberList.cshtml"
               Write(member.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 21 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\_HomeMemberList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GymManager.Core.Members.Member>> Html { get; private set; }
    }
}
#pragma warning restore 1591