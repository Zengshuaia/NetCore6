#pragma checksum "C:\Users\86188\Desktop\新建文件夹 (2)\NetCore6\ContosoUniversity\ContosoUniversity\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58534e79890660a1775535271280e4968ee994d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "C:\Users\86188\Desktop\新建文件夹 (2)\NetCore6\ContosoUniversity\ContosoUniversity\Views\_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\86188\Desktop\新建文件夹 (2)\NetCore6\ContosoUniversity\ContosoUniversity\Views\_ViewImports.cshtml"
using ContosoUniversity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58534e79890660a1775535271280e4968ee994d8", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c8c63dad9db0b17e31c66667dec1a52add46bdf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContosoUniversity.Models.SchoolViewModels.EnrollmentDateGroup>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\86188\Desktop\新建文件夹 (2)\NetCore6\ContosoUniversity\ContosoUniversity\Views\Home\About.cshtml"
   
    ViewData["Title"] = "Student Body Statitics";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Student Body Statitics</h2>\r\n<table>\r\n    <tr>\r\n        <th>\r\n            Enrollment Date\r\n        </th>\r\n        <th>\r\n            Students\r\n        </th>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Users\86188\Desktop\新建文件夹 (2)\NetCore6\ContosoUniversity\ContosoUniversity\Views\Home\About.cshtml"
     foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 19 "C:\Users\86188\Desktop\新建文件夹 (2)\NetCore6\ContosoUniversity\ContosoUniversity\Views\Home\About.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 22 "C:\Users\86188\Desktop\新建文件夹 (2)\NetCore6\ContosoUniversity\ContosoUniversity\Views\Home\About.cshtml"
                   Write(Html.DisplayFor(modelItem => item.StudenCount));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 25 "C:\Users\86188\Desktop\新建文件夹 (2)\NetCore6\ContosoUniversity\ContosoUniversity\Views\Home\About.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContosoUniversity.Models.SchoolViewModels.EnrollmentDateGroup>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
