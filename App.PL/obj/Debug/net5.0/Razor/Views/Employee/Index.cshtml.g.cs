#pragma checksum "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "142e0f773f9b8b73d5e03ef40af35e9ba20cf717e07e263787c23c47c8149930"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"142e0f773f9b8b73d5e03ef40af35e9ba20cf717e07e263787c23c47c8149930", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"67c3a9c8f2bcb57dc40991682986077035a286a2f8806a828c7c449518d84c8f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Employee>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info my-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
  
	ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "142e0f773f9b8b73d5e03ef40af35e9ba20cf717e07e263787c23c47c81499305586", async() => {
                WriteLiteral("Add New Employee");
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
#line 7 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t <p class=\"alert alert-danger \">There is No Employees</p>\r\n");
#nullable restore
#line 10 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "142e0f773f9b8b73d5e03ef40af35e9ba20cf717e07e263787c23c47c81499307385", async() => {
                WriteLiteral("\r\n\t\t<input  type=\"text\" class=\"form-control my-4\" id=\"input\" name=\"name\" />\r\n\t\t<input type=\"submit\" value=\"submit\" class=\"btn btn-danger\"/>\r\n\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h1 class=\"my-3 text-center\">All Employees</h1>\r\n");
            WriteLiteral("\t\t\t\t<table class=\"table table-bordered table-striped text-center\">\r\n\t\t\t\t<thead class=\"bg-dark text-white\">\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<th>");
#nullable restore
#line 22 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
     Write(Html.DisplayNameFor(e => e.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t\t<th>");
#nullable restore
#line 23 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
     Write(Html.DisplayNameFor(e => e.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t\t<th>");
#nullable restore
#line 24 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
     Write(Html.DisplayNameFor(e => e.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t\t<th>");
#nullable restore
#line 25 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
     Write(Html.DisplayNameFor(e => e.CreationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t\t<th>");
#nullable restore
#line 26 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
     Write(Html.DisplayNameFor(e => e.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t\t<th>");
#nullable restore
#line 27 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
     Write(Html.DisplayNameFor(e => e.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t\t<th>");
#nullable restore
#line 28 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
     Write(Html.DisplayNameFor(e => e.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t\t<th>Delete</th>\r\n\t\t\t\t\t\t<th>Update</th>\r\n\t\t\t\t\t\t<th>Details</th>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t</thead>\r\n\t\t\t\t<tbody>\r\n");
#nullable restore
#line 35 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
    foreach (var employee in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 38 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
        Write(employee.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 39 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
        Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 40 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
        Write(employee.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 41 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
        Write(employee.CreationDate.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 41 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
                                      Write(employee.CreationDate.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 41 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
                                                                     Write(employee.CreationDate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(" at ");
#nullable restore
#line 41 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
                                                                                                   Write(employee.CreationDate.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(" :");
#nullable restore
#line 41 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
                                                                                                                                Write(employee.CreationDate.Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral(" :");
#nullable restore
#line 41 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
                                                                                                                                                               Write(employee.CreationDate.Second);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n");
#nullable restore
#line 43 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
       if (@employee.IsActive)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<p class=\"bg-success rounded \">");
#nullable restore
#line 45 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
                                    Write(employee.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</p>\r\n");
#nullable restore
#line 47 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
						}
						else
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<p class=\"bg-danger rounded \">");
#nullable restore
#line 50 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
                                   Write(employee.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 51 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"

						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 54 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
          Write(employee.Department?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</td>\r\n\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 55 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
        Write(employee.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "142e0f773f9b8b73d5e03ef40af35e9ba20cf717e07e263787c23c47c814993016437", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 56 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = employee.ID;

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
            WriteLiteral("</partial>\r\n\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 58 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</tbody>\r\n\r\n\r\n\t\t\t\t</table>\r\n");
#nullable restore
#line 63 "C:\Users\Ahmed\Desktop\fullstack\ASP.NET\7.MVC\MVC_Project\App.PL\Views\Employee\Index.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Employee>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
