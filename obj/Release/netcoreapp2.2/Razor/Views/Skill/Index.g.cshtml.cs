#pragma checksum "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Skill/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c23e235574b731dacda9aa5c459c29cb5a55d929"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_Index), @"mvc.1.0.view", @"/Views/Skill/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Skill/Index.cshtml", typeof(AspNetCore.Views_Skill_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23e235574b731dacda9aa5c459c29cb5a55d929", @"/Views/Skill/Index.cshtml")]
    public class Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Scored.ViewModels.SkillViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 2 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Skill/Index.cshtml"
      
        ViewBag.Title = "Scored : Skills list";
    

#line default
#line hidden
            BeginContext(118, 43, true);
            WriteLiteral("    <h2>Skills List</h2>\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(162, 58, false);
#line 7 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Skill/Index.cshtml"
   Write(Html.ActionLink("Add a new skill to the system", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(220, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 9 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Skill/Index.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
            BeginContext(270, 13, true);
            WriteLiteral("        <p>\r\n");
            EndContext();
            BeginContext(361, 19, true);
            WriteLiteral("            Title: ");
            EndContext();
            BeginContext(381, 28, false);
#line 13 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Skill/Index.cshtml"
              Write(Html.TextBox("SearchString"));

#line default
#line hidden
            EndContext();
            BeginContext(409, 75, true);
            WriteLiteral(" <br />\r\n            <input type=\"submit\" value=\"Filter\" />\r\n        </p>\r\n");
            EndContext();
#line 16 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Skill/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(491, 77, true);
            WriteLiteral("    <table class=\"table\">\r\n\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(569, 41, false);
#line 21 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Skill/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(610, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(666, 47, false);
#line 24 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Skill/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(713, 59, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n");
            EndContext();
#line 28 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Skill/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(821, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(882, 40, false);
#line 32 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Skill/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(922, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(990, 46, false);
#line 35 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Skill/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1104, 53, false);
#line 38 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Skill/Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 41 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Skill/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1212, 16, true);
            WriteLiteral("\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Scored.ViewModels.SkillViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
