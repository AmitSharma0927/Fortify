#pragma checksum "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\OrdersMvc\AllOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39d7f56595ef4bf32e8f2229330f7df5dd762f32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrdersMvc_AllOrders), @"mvc.1.0.view", @"/Views/OrdersMvc/AllOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrdersMvc/AllOrders.cshtml", typeof(AspNetCore.Views_OrdersMvc_AllOrders))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39d7f56595ef4bf32e8f2229330f7df5dd762f32", @"/Views/OrdersMvc/AllOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e5b95bdb520a4101d64f735ad34f10dba324a4", @"/Views/_ViewImports.cshtml")]
    public class Views_OrdersMvc_AllOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EcommerceMVC.Models.OrderData>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\OrdersMvc\AllOrders.cshtml"
  
    ViewData["Title"] = "AllOrders";

#line default
#line hidden
            BeginContext(99, 50, false);
#line 6 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\OrdersMvc\AllOrders.cshtml"
Write(Html.ActionLink("OrdersMvc", "print", "OrdersMvc"));

#line default
#line hidden
            EndContext();
            BeginContext(149, 135, true);
            WriteLiteral("\r\n<style>\r\n    .table{\r\n        background-color:burlywood;\r\n    }\r\n    #bg{\r\n        background-color:antiquewhite;\r\n    }\r\n</style>\r\n");
            EndContext();
            BeginContext(284, 1755, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "670a21681ad14641a21681cf53000341", async() => {
                BeginContext(298, 106, true);
                WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(405, 43, false);
#line 20 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\OrdersMvc\AllOrders.cshtml"
               Write(Html.DisplayNameFor(model => model.OrderId));

#line default
#line hidden
                EndContext();
                BeginContext(448, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(516, 45, false);
#line 23 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\OrdersMvc\AllOrders.cshtml"
               Write(Html.DisplayNameFor(model => model.OrderDesc));

#line default
#line hidden
                EndContext();
                BeginContext(561, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(629, 47, false);
#line 26 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\OrdersMvc\AllOrders.cshtml"
               Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
                EndContext();
                BeginContext(676, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(744, 50, false);
#line 29 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\OrdersMvc\AllOrders.cshtml"
               Write(Html.DisplayNameFor(model => model.DispatchedDate));

#line default
#line hidden
                EndContext();
                BeginContext(794, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(862, 44, false);
#line 32 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\OrdersMvc\AllOrders.cshtml"
               Write(Html.DisplayNameFor(model => model.Isactive));

#line default
#line hidden
                EndContext();
                BeginContext(906, 25, true);
                WriteLiteral("\r\n                </th>\r\n");
                EndContext();
                BeginContext(1049, 81, true);
                WriteLiteral("                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 41 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\OrdersMvc\AllOrders.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(1187, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1260, 42, false);
#line 45 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\OrdersMvc\AllOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OrderId));

#line default
#line hidden
                EndContext();
                BeginContext(1302, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1382, 44, false);
#line 48 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\OrdersMvc\AllOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OrderDesc));

#line default
#line hidden
                EndContext();
                BeginContext(1426, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1506, 46, false);
#line 51 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\OrdersMvc\AllOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
                EndContext();
                BeginContext(1552, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1632, 49, false);
#line 54 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\OrdersMvc\AllOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DispatchedDate));

#line default
#line hidden
                EndContext();
                BeginContext(1681, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1761, 43, false);
#line 57 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\OrdersMvc\AllOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Isactive));

#line default
#line hidden
                EndContext();
                BeginContext(1804, 29, true);
                WriteLiteral("\r\n                    </td>\r\n");
                EndContext();
                BeginContext(1962, 23, true);
                WriteLiteral("                </tr>\r\n");
                EndContext();
#line 63 "C:\Users\s343417\source\repos\Ecommerce\EcommerceMVC\Views\OrdersMvc\AllOrders.cshtml"
            }

#line default
#line hidden
                BeginContext(2000, 32, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2039, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EcommerceMVC.Models.OrderData>> Html { get; private set; }
    }
}
#pragma warning restore 1591
