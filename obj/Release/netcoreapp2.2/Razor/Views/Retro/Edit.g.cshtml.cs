#pragma checksum "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c6e4774fe26b6a8a897063517b6251178cd7e34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Retro_Edit), @"mvc.1.0.view", @"/Views/Retro/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Retro/Edit.cshtml", typeof(AspNetCore.Views_Retro_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c6e4774fe26b6a8a897063517b6251178cd7e34", @"/Views/Retro/Edit.cshtml")]
    public class Views_Retro_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Scored.ViewModels.RetroViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Edit.cshtml"
  
    //using Appraisal.Web.Models;
    ViewBag.Title = "Create";

#line default
#line hidden
            BeginContext(118, 17, true);
            WriteLiteral("<h2>Create</h2>\r\n");
            EndContext();
#line 9 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(170, 23, false);
#line 11 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(200, 28, false);
#line 12 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Edit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(235, 33, false);
#line 13 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Edit.cshtml"
Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(272, 135, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Evaluate yourself</h4>\r\n        <hr />\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(408, 98, false);
#line 20 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Edit.cshtml"
       Write(Html.LabelFor(model => model.RetroDate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(506, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(562, 98, false);
#line 22 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Edit.cshtml"
           Write(Html.EditorFor(model => model.RetroDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(660, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(679, 87, false);
#line 23 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.RetroDate, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(766, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(853, 86, false);
#line 28 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Edit.cshtml"
       Write(Html.LabelFor(m => m.Level, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(939, 41, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n\r\n");
            EndContext();
            BeginContext(1102, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1119, 39, false);
#line 32 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Level));

#line default
#line hidden
            EndContext();
            BeginContext(1158, 88, true);
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1247, 88, false);
#line 38 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Edit.cshtml"
       Write(Html.LabelFor(m => m.SkillID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1335, 41, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n\r\n");
            EndContext();
            BeginContext(1502, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1519, 41, false);
#line 42 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.SkillID));

#line default
#line hidden
            EndContext();
            BeginContext(1560, 257, true);
            WriteLiteral(@"

            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </div>
    </div>
");
            EndContext();
#line 53 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(1820, 11, true);
            WriteLiteral("<div>\r\n    ");
            EndContext();
            BeginContext(1832, 40, false);
#line 55 "/Users/bmusiim/Documents/Projects/MVC/Scored 78/Scored/Views/Retro/Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1872, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Scored.ViewModels.RetroViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591