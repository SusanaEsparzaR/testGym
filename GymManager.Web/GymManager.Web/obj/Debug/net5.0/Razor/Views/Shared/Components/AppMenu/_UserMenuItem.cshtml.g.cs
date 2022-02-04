#pragma checksum "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a354842091afd936e75a4b4e8d178751600ae797"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AppMenu__UserMenuItem), @"mvc.1.0.view", @"/Views/Shared/Components/AppMenu/_UserMenuItem.cshtml")]
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
#line 1 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
using GymManager.Core.Navigation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a354842091afd936e75a4b4e8d178751600ae797", @"/Views/Shared/Components/AppMenu/_UserMenuItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AppMenu__UserMenuItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GymManager.Web.Models.UserMenuItemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
  

    var orderedChildMenuItems = Model.MenuItem.Items.OrderBy(x => x.Order);


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
 if (Model.MenuItem.Items.Count < 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item\">\r\n        <a href=\"#\"");
            BeginWriteAttribute("class", " class=\"", 268, "\"", 363, 3);
            WriteAttributeValue("", 276, "nav-link", 276, 8, true);
            WriteAttributeValue(" ", 284, "font-exo", 285, 9, true);
#nullable restore
#line 14 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue(" ", 293, Model.MenuItem.IsMenuActive(Model.CurrentPageName) ? "active" : "", 294, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                                                                                Write(Model.MenuItem.IsMenuActive(Model.CurrentPageName) ? "aria-current=\"page\"" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 14 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                                                                                                                                                                    Write(Model.MenuItem.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </li>\r\n");
#nullable restore
#line 16 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
}
else
{
    string currentElementId = "menu-" + new Random().Next();

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item dropdown\">\r\n        <a");
            BeginWriteAttribute("class", " class=\"", 614, "\"", 716, 3);
            WriteAttributeValue("", 622, "nav-link", 622, 8, true);
            WriteAttributeValue(" ", 630, "dropdown-toggle", 631, 16, true);
#nullable restore
#line 21 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue(" ", 646, Model.MenuItem.IsMenuActive(Model.CurrentPageName) ? "active" : "", 647, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"#\"");
            BeginWriteAttribute("id", " id=\"", 726, "\"", 748, 1);
#nullable restore
#line 21 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 731, currentElementId, 731, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">");
#nullable restore
#line 21 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                                                                                                                                                                               Write(Model.MenuItem.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <ul class=\"dropdown-menu\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 882, "\"", 917, 1);
#nullable restore
#line 22 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 900, currentElementId, 900, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 23 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
             foreach(var subMenu in Model.MenuItem.Items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1039, "\"", 1058, 1);
#nullable restore
#line 25 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 1046, subMenu.Url, 1046, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                            Write(subMenu.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 26 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </li>\r\n");
#nullable restore
#line 29 "C:\Users\Susana\source\repos\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GymManager.Web.Models.UserMenuItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
