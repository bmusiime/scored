#pragma checksum "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "401063304bb1753a8bb06be8dfa9f12bbaa906ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Retro_Report), @"mvc.1.0.view", @"/Views/Retro/Report.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Retro/Report.cshtml", typeof(AspNetCore.Views_Retro_Report))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"401063304bb1753a8bb06be8dfa9f12bbaa906ce", @"/Views/Retro/Report.cshtml")]
    public class Views_Retro_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Scored.ViewModels.RetroViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(56, 276, true);
            WriteLiteral(@"
    <h2 class=""mbr-section-title mbr-fonts-style align-center pb-3 display-2"">
        Retro Notes
    </h2>
    <h3 class=""mbr-section-subtitle mbr-fonts-style align-center pb-5 mbr-light display-5"">
        Review and Edit
    </h3>
    <div class=""table-wrapper"">
");
            EndContext();
#line 11 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Report.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
            BeginContext(377, 454, true);
            WriteLiteral(@"        <div class=""container"">
            <div class=""row search"">
                <div class=""col-md-6""></div>
                <div class=""col-md-6"">
                    <div class=""dataTables_filter"">
                        <label class=""searchInfo mbr-fonts-style display-7"">Search:</label>
                        <input class=""form-control input-sm"">
                    </div>
                </div>
            </div>
        </div>
");
            EndContext();
#line 24 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Report.cshtml"
        }

#line default
#line hidden
            BeginContext(842, 274, true);
            WriteLiteral(@"        <div class=""container scroll"">
            <table class=""table isSearch"" cellspacing=""0"">
                <thead>
                    <tr class=""table-heads "">
                        <th class=""head-item mbr-fonts-style display-7"">
                            ");
            EndContext();
            BeginContext(1117, 45, false);
#line 30 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Report.cshtml"
                       Write(Html.DisplayNameFor(model => model.RetroDate));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 135, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th class=\"head-item mbr-fonts-style display-7\">\r\n                            ");
            EndContext();
            BeginContext(1298, 41, false);
#line 33 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Report.cshtml"
                       Write(Html.DisplayNameFor(model => model.Level));

#line default
#line hidden
            EndContext();
            BeginContext(1339, 135, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th class=\"head-item mbr-fonts-style display-7\">\r\n                            ");
            EndContext();
            BeginContext(1475, 54, false);
#line 36 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Report.cshtml"
                       Write(Html.DisplayNameFor(model => model.SelectedSkillTitle));

#line default
#line hidden
            EndContext();
            BeginContext(1529, 135, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th class=\"head-item mbr-fonts-style display-7\">\r\n                            ");
            EndContext();
            BeginContext(1665, 60, false);
#line 39 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Report.cshtml"
                       Write(Html.DisplayNameFor(model => model.SelectedSkillDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1725, 254, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th class=\"head-item mbr-fonts-style display-7\">\r\n                            Action\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n\r\n");
            EndContext();
#line 48 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Report.cshtml"
                     foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2048, 100, true);
            WriteLiteral("                    <tr>\r\n\r\n                        <td class=\"body-item mbr-fonts-style display-7\">");
            EndContext();
            BeginContext(2149, 44, false);
#line 52 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Report.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.RetroDate));

#line default
#line hidden
            EndContext();
            BeginContext(2193, 79, true);
            WriteLiteral("</td>\r\n                        <td class=\"body-item mbr-fonts-style display-7\">");
            EndContext();
            BeginContext(2273, 40, false);
#line 53 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Report.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.Level));

#line default
#line hidden
            EndContext();
            BeginContext(2313, 79, true);
            WriteLiteral("</td>\r\n                        <td class=\"body-item mbr-fonts-style display-7\">");
            EndContext();
            BeginContext(2393, 53, false);
#line 54 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Report.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.SelectedSkillTitle));

#line default
#line hidden
            EndContext();
            BeginContext(2446, 79, true);
            WriteLiteral("</td>\r\n                        <td class=\"body-item mbr-fonts-style display-7\">");
            EndContext();
            BeginContext(2526, 59, false);
#line 55 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Report.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.SelectedSkillDescription));

#line default
#line hidden
            EndContext();
            BeginContext(2585, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2651, 53, false);
#line 57 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Report.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", new { id = item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(2704, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 60 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Report.cshtml"
            }

#line default
#line hidden
            BeginContext(2779, 76, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Scored.ViewModels.RetroViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
