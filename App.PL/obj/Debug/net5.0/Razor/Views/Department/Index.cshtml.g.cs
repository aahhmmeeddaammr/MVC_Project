#pragma checksum "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9cd87ee3e56a7afdb817cef878bb28f512bb40d7b8735e4bf189dadf1bb7c00c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\_ViewImports.cshtml"
using App.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\_ViewImports.cshtml"
using App.PL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\_ViewImports.cshtml"
using App.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\_ViewImports.cshtml"
using App.BLL.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9cd87ee3e56a7afdb817cef878bb28f512bb40d7b8735e4bf189dadf1bb7c00c", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"67c3a9c8f2bcb57dc40991682986077035a286a2f8806a828c7c449518d84c8f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Department>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info my-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"
  
	ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cd87ee3e56a7afdb817cef878bb28f512bb40d7b8735e4bf189dadf1bb7c00c4983", async() => {
                WriteLiteral("Create New Department");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t <p class=\"alert alert-danger \">There is No Departments</p>\r\n");
#nullable restore
#line 9 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<h1 class=\"my-3 text-center\">All Departments</h1>\r\n");
            WriteLiteral("\t\t\t\t\t<table class=\"table table-bordered table-striped text-center\">\n\t\t\t<thead class=\"bg-dark text-white\">\n\t\t\t\t<tr>\r\n\t\t\t\t\t<th>");
#nullable restore
#line 17 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"
    Write(Html.DisplayNameFor(e => e.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t<th>");
#nullable restore
#line 18 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"
    Write(Html.DisplayNameFor(e => e.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t<th>");
#nullable restore
#line 19 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"
    Write(Html.DisplayNameFor(e => e.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t<th>");
#nullable restore
#line 20 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"
    Write(Html.DisplayNameFor(e => e.DateOfCreation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t<th>Delete</th>\r\n\t\t\t\t\t<th>Update</th>\r\n\t\t\t\t\t<th>Details</th>\r\n\t\t\t\t</tr>\r\n\t\t\t</thead>\n\t\t\t<tbody>\r\n");
#nullable restore
#line 27 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"
    foreach (var department in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<tr>\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 30 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"
       Write(department.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 31 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"
       Write(department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 32 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"
       Write(department.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 33 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"
        Write(department.DateOfCreation.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 33 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"
                                          Write(department.DateOfCreation.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 33 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"
                                                                             Write(department.DateOfCreation.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(" at ");
#nullable restore
#line 33 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"
                                                                                                               Write(department.DateOfCreation.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(" :");
#nullable restore
#line 33 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"
                                                                                                                                                Write(department.DateOfCreation.Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral(" :");
#nullable restore
#line 33 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"
                                                                                                                                                                                   Write(department.DateOfCreation.Second);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9cd87ee3e56a7afdb817cef878bb28f512bb40d7b8735e4bf189dadf1bb7c00c11446", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 34 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = department.ID;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</partial>\r\n\t\t</tr>\r\n");
#nullable restore
#line 36 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</tbody>\n\n\n\t</table>\r\n");
#nullable restore
#line 41 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Department\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Department>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
