#pragma checksum "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57fc6037c171fb8fdf468e447591224e09aa2cf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CustomerIndex), @"mvc.1.0.view", @"/Views/Home/CustomerIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CustomerIndex.cshtml", typeof(AspNetCore.Views_Home_CustomerIndex))]
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
#line 1 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\_ViewImports.cshtml"
using EcommerceMVC;

#line default
#line hidden
#line 2 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\_ViewImports.cshtml"
using EcommerceMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57fc6037c171fb8fdf468e447591224e09aa2cf3", @"/Views/Home/CustomerIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e5b95bdb520a4101d64f735ad34f10dba324a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CustomerIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EcommerceMVC.Models.CustomerData>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
  
    ViewData["Title"] = "CustomerIndex";

#line default
#line hidden
            BeginContext(105, 37, true);
            WriteLiteral("\r\n<h2>CustomerIndex</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(142, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df1c93e09f2444a6afa3661c42be9ec2", async() => {
                BeginContext(165, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(179, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(272, 46, false);
#line 16 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.Customerid));

#line default
#line hidden
            EndContext();
            BeginContext(318, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(374, 48, false);
#line 19 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(422, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(478, 48, false);
#line 22 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.MobileNumber));

#line default
#line hidden
            EndContext();
            BeginContext(526, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(582, 45, false);
#line 25 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.PostalAdd));

#line default
#line hidden
            EndContext();
            BeginContext(627, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(683, 43, false);
#line 28 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.EmailId));

#line default
#line hidden
            EndContext();
            BeginContext(726, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(782, 44, false);
#line 31 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(826, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(882, 47, false);
#line 34 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(929, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1047, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1096, 45, false);
#line 43 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customerid));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1197, 47, false);
#line 46 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(1244, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1300, 47, false);
#line 49 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.MobileNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1347, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1403, 44, false);
#line 52 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.PostalAdd));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1503, 42, false);
#line 55 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmailId));

#line default
#line hidden
            EndContext();
            BeginContext(1545, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1601, 43, false);
#line 58 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(1644, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1700, 46, false);
#line 61 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1746, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1802, 65, false);
#line 64 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1867, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1888, 71, false);
#line 65 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1959, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1980, 69, false);
#line 66 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2049, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 69 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\Home\CustomerIndex.cshtml"
}

#line default
#line hidden
            BeginContext(2088, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EcommerceMVC.Models.CustomerData>> Html { get; private set; }
    }
}
#pragma warning restore 1591
