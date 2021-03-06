#pragma checksum "D:\Projects\ASP .NET Core\GenericRepositoryPattern\GenericRepositoryPattern\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "653e591eb898dfe34365233f2a5b8e30e33e1c03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
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
#line 1 "D:\Projects\ASP .NET Core\GenericRepositoryPattern\GenericRepositoryPattern\Views\_ViewImports.cshtml"
using GenericRepositoryPattern;

#line default
#line hidden
#line 2 "D:\Projects\ASP .NET Core\GenericRepositoryPattern\GenericRepositoryPattern\Views\_ViewImports.cshtml"
using GenericRepositoryPattern.Models;

#line default
#line hidden
#line 3 "D:\Projects\ASP .NET Core\GenericRepositoryPattern\GenericRepositoryPattern\Views\_ViewImports.cshtml"
using GenericRepositoryPattern.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"653e591eb898dfe34365233f2a5b8e30e33e1c03", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d1dd7f7c97b69b26c8dfe3f9fb3f07cfcadbe34", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeIndexViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\ASP .NET Core\GenericRepositoryPattern\GenericRepositoryPattern\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(85, 971, true);
            WriteLiteral(@"
<div class=""content-wrapper"">
    <div class=""row"">
        <div class=""col-md-12 grid-margin"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-md-12 table-responsive-md"">
                        <table class=""table table-striped"">
                            <thead>
                                <tr>
                                    <th>First Name</th>
                                    <th>Middle Name</th>
                                    <th>Last Name</th>
                                    <th>Gender</th>
                                    <th>DOB</th>
                                    <th>Email</th>
                                    <th>Phone</th>
                                    <th>Address</th>
                                    <th>City</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 27 "D:\Projects\ASP .NET Core\GenericRepositoryPattern\GenericRepositoryPattern\Views\Employee\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
            BeginContext(1153, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(1240, 14, false);
#line 30 "D:\Projects\ASP .NET Core\GenericRepositoryPattern\GenericRepositoryPattern\Views\Employee\Index.cshtml"
                                       Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1254, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1306, 15, false);
#line 31 "D:\Projects\ASP .NET Core\GenericRepositoryPattern\GenericRepositoryPattern\Views\Employee\Index.cshtml"
                                       Write(item.MiddleName);

#line default
#line hidden
            EndContext();
            BeginContext(1321, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1373, 13, false);
#line 32 "D:\Projects\ASP .NET Core\GenericRepositoryPattern\GenericRepositoryPattern\Views\Employee\Index.cshtml"
                                       Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1386, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1438, 11, false);
#line 33 "D:\Projects\ASP .NET Core\GenericRepositoryPattern\GenericRepositoryPattern\Views\Employee\Index.cshtml"
                                       Write(item.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(1449, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1501, 8, false);
#line 34 "D:\Projects\ASP .NET Core\GenericRepositoryPattern\GenericRepositoryPattern\Views\Employee\Index.cshtml"
                                       Write(item.DOB);

#line default
#line hidden
            EndContext();
            BeginContext(1509, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1561, 10, false);
#line 35 "D:\Projects\ASP .NET Core\GenericRepositoryPattern\GenericRepositoryPattern\Views\Employee\Index.cshtml"
                                       Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1571, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1623, 10, false);
#line 36 "D:\Projects\ASP .NET Core\GenericRepositoryPattern\GenericRepositoryPattern\Views\Employee\Index.cshtml"
                                       Write(item.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1633, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1685, 12, false);
#line 37 "D:\Projects\ASP .NET Core\GenericRepositoryPattern\GenericRepositoryPattern\Views\Employee\Index.cshtml"
                                       Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1697, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1749, 9, false);
#line 38 "D:\Projects\ASP .NET Core\GenericRepositoryPattern\GenericRepositoryPattern\Views\Employee\Index.cshtml"
                                       Write(item.City);

#line default
#line hidden
            EndContext();
            BeginContext(1758, 50, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 40 "D:\Projects\ASP .NET Core\GenericRepositoryPattern\GenericRepositoryPattern\Views\Employee\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(1843, 192, true);
            WriteLiteral("                            </tbody>\r\n                        </table><br /><br />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeIndexViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
