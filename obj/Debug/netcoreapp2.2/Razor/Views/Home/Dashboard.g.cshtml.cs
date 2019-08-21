#pragma checksum "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/weddingPlanner/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ea7f61ad11e0f71ec5a48405533018a208fa63a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/weddingPlanner/Views/_ViewImports.cshtml"
using weddingPlanner;

#line default
#line hidden
#line 1 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/weddingPlanner/Views/Home/Dashboard.cshtml"
using weddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ea7f61ad11e0f71ec5a48405533018a208fa63a", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d2f7e7fad137d735531a94f00fd8cb8297fea8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserAndListOfWeddings>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 38, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n    ");
            EndContext();
            BeginContext(96, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ea7f61ad11e0f71ec5a48405533018a208fa63a3393", async() => {
                BeginContext(102, 210, true);
                WriteLiteral("\n        <meta charset=\"UTF-8\">\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n        <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n        <title>Dashboard</title>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(319, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(324, 1607, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ea7f61ad11e0f71ec5a48405533018a208fa63a4780", async() => {
                BeginContext(330, 388, true);
                WriteLiteral(@"
        <h1>Welcome to the Wedding Planner</h1>
        <a href=""/logout"">Logout</a>

        <a href=""/new"">New Wedding</a>
        <table>
            <thead>
                <tr>
                    <th>Wedding</th>
                    <th>Date</th>
                    <th>Guest</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 27 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/weddingPlanner/Views/Home/Dashboard.cshtml"
                  
                    foreach(Wedding wedding in Model.ListOfWeddings)
                    {

#line default
#line hidden
                BeginContext(828, 63, true);
                WriteLiteral("                        <tr>\n                            <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 891, "\"", 925, 2);
                WriteAttributeValue("", 898, "/wedding/", 898, 9, true);
#line 31 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/weddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 907, wedding.WeddingId, 907, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(926, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(928, 17, false);
#line 31 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/weddingPlanner/Views/Home/Dashboard.cshtml"
                                                                 Write(wedding.WedderOne);

#line default
#line hidden
                EndContext();
                BeginContext(945, 3, true);
                WriteLiteral(" & ");
                EndContext();
                BeginContext(949, 17, false);
#line 31 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/weddingPlanner/Views/Home/Dashboard.cshtml"
                                                                                      Write(wedding.WedderTwo);

#line default
#line hidden
                EndContext();
                BeginContext(966, 42, true);
                WriteLiteral("</a></td>\n                            <td>");
                EndContext();
                BeginContext(1009, 43, false);
#line 32 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/weddingPlanner/Views/Home/Dashboard.cshtml"
                           Write(wedding.WeddingDate.ToString("MMM d, yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(1052, 38, true);
                WriteLiteral("</td>\n                            <td>");
                EndContext();
                BeginContext(1091, 27, false);
#line 33 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/weddingPlanner/Views/Home/Dashboard.cshtml"
                           Write(wedding.WeddingsUsers.Count);

#line default
#line hidden
                EndContext();
                BeginContext(1118, 53, true);
                WriteLiteral("</td>\n                            if(wedding.Host == ");
                EndContext();
                BeginContext(1172, 18, false);
#line 34 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/weddingPlanner/Views/Home/Dashboard.cshtml"
                                          Write(Model.UsersWedding);

#line default
#line hidden
                EndContext();
                BeginContext(1190, 66, true);
                WriteLiteral(")\n                            {\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1256, "\"", 1289, 2);
                WriteAttributeValue("", 1263, "/delete/", 1263, 8, true);
#line 36 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/weddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1271, wedding.WeddingId, 1271, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1290, 129, true);
                WriteLiteral(">Cancel Wedding</a>\n                            }\n                            else if(wedding.WeddingsUsers.Any(w => w.UserId == ");
                EndContext();
                BeginContext(1420, 25, false);
#line 38 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/weddingPlanner/Views/Home/Dashboard.cshtml"
                                                                          Write(Model.UsersWedding.UserId);

#line default
#line hidden
                EndContext();
                BeginContext(1445, 67, true);
                WriteLiteral("))\n                            {\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1512, "\"", 1572, 4);
                WriteAttributeValue("", 1519, "/remove/", 1519, 8, true);
#line 40 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/weddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1527, wedding.WeddingId, 1527, 18, false);

#line default
#line hidden
                WriteAttributeValue("", 1545, "/", 1545, 1, true);
#line 40 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/weddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1546, Model.UsersWedding.UserId, 1546, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1573, 140, true);
                WriteLiteral(">Un-RSVP</a>\n                            }\n                            else\n                            {\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1713, "\"", 1771, 4);
                WriteAttributeValue("", 1720, "/RSVP/", 1720, 6, true);
#line 44 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/weddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1726, wedding.WeddingId, 1726, 18, false);

#line default
#line hidden
                WriteAttributeValue("", 1744, "/", 1744, 1, true);
#line 44 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/weddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1745, Model.UsersWedding.UserId, 1745, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1772, 70, true);
                WriteLiteral(">RSVP</a>\n                            }\n                        </tr>\n");
                EndContext();
#line 47 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/weddingPlanner/Views/Home/Dashboard.cshtml"
                    }
                

#line default
#line hidden
                BeginContext(1882, 42, true);
                WriteLiteral("            </tbody>\n        </table>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1931, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserAndListOfWeddings> Html { get; private set; }
    }
}
#pragma warning restore 1591