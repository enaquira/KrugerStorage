#pragma checksum "C:\Users\Usuario\source\repos\Kruger.Storage\Kruger.Storage\Views\Customers\ProductsComingToExpireReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ceaeea9affcc729911446316df7266fe7f2e6f58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_ProductsComingToExpireReport), @"mvc.1.0.view", @"/Views/Customers/ProductsComingToExpireReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/ProductsComingToExpireReport.cshtml", typeof(AspNetCore.Views_Customers_ProductsComingToExpireReport))]
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
#line 1 "C:\Users\Usuario\source\repos\Kruger.Storage\Kruger.Storage\Views\_ViewImports.cshtml"
using Kruger.Storage;

#line default
#line hidden
#line 2 "C:\Users\Usuario\source\repos\Kruger.Storage\Kruger.Storage\Views\_ViewImports.cshtml"
using Kruger.Storage.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceaeea9affcc729911446316df7266fe7f2e6f58", @"/Views/Customers/ProductsComingToExpireReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7be3ee4a16ca8724004c9a7c330a400d1e4bdc59", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_ProductsComingToExpireReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Kruger.Storage.Models.ProductsComingToExpireViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Usuario\source\repos\Kruger.Storage\Kruger.Storage\Views\Customers\ProductsComingToExpireReport.cshtml"
  
    ViewData["Title"] = "Productos a vencer";

#line default
#line hidden
            BeginContext(131, 139, true);
            WriteLiteral("\r\n<h1>Listado de productos a vencer en 30 días</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(271, 47, false);
#line 13 "C:\Users\Usuario\source\repos\Kruger.Storage\Kruger.Storage\Views\Customers\ProductsComingToExpireReport.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(318, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(374, 45, false);
#line 16 "C:\Users\Usuario\source\repos\Kruger.Storage\Kruger.Storage\Views\Customers\ProductsComingToExpireReport.cshtml"
           Write(Html.DisplayNameFor(model => model.StorageId));

#line default
#line hidden
            EndContext();
            BeginContext(419, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(475, 44, false);
#line 19 "C:\Users\Usuario\source\repos\Kruger.Storage\Kruger.Storage\Views\Customers\ProductsComingToExpireReport.cshtml"
           Write(Html.DisplayNameFor(model => model.RackName));

#line default
#line hidden
            EndContext();
            BeginContext(519, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(575, 39, false);
#line 22 "C:\Users\Usuario\source\repos\Kruger.Storage\Kruger.Storage\Views\Customers\ProductsComingToExpireReport.cshtml"
           Write(Html.DisplayNameFor(model => model.Row));

#line default
#line hidden
            EndContext();
            BeginContext(614, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(670, 42, false);
#line 25 "C:\Users\Usuario\source\repos\Kruger.Storage\Kruger.Storage\Views\Customers\ProductsComingToExpireReport.cshtml"
           Write(Html.DisplayNameFor(model => model.Column));

#line default
#line hidden
            EndContext();
            BeginContext(712, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(768, 52, false);
#line 28 "C:\Users\Usuario\source\repos\Kruger.Storage\Kruger.Storage\Views\Customers\ProductsComingToExpireReport.cshtml"
           Write(Html.DisplayNameFor(model => model.DiscontinuedDate));

#line default
#line hidden
            EndContext();
            BeginContext(820, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 33 "C:\Users\Usuario\source\repos\Kruger.Storage\Kruger.Storage\Views\Customers\ProductsComingToExpireReport.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(932, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(993, 46, false);
#line 37 "C:\Users\Usuario\source\repos\Kruger.Storage\Kruger.Storage\Views\Customers\ProductsComingToExpireReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1107, 44, false);
#line 40 "C:\Users\Usuario\source\repos\Kruger.Storage\Kruger.Storage\Views\Customers\ProductsComingToExpireReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.StorageId));

#line default
#line hidden
            EndContext();
            BeginContext(1151, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1219, 43, false);
#line 43 "C:\Users\Usuario\source\repos\Kruger.Storage\Kruger.Storage\Views\Customers\ProductsComingToExpireReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.RackName));

#line default
#line hidden
            EndContext();
            BeginContext(1262, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1330, 38, false);
#line 46 "C:\Users\Usuario\source\repos\Kruger.Storage\Kruger.Storage\Views\Customers\ProductsComingToExpireReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.Row));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1436, 41, false);
#line 49 "C:\Users\Usuario\source\repos\Kruger.Storage\Kruger.Storage\Views\Customers\ProductsComingToExpireReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.Column));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1545, 51, false);
#line 52 "C:\Users\Usuario\source\repos\Kruger.Storage\Kruger.Storage\Views\Customers\ProductsComingToExpireReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.DiscontinuedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1596, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 55 "C:\Users\Usuario\source\repos\Kruger.Storage\Kruger.Storage\Views\Customers\ProductsComingToExpireReport.cshtml"
        }

#line default
#line hidden
            BeginContext(1651, 37, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1688, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ceaeea9affcc729911446316df7266fe7f2e6f5810710", async() => {
                BeginContext(1737, 29, true);
                WriteLiteral("Volver al listado de clientes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1770, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Kruger.Storage.Models.ProductsComingToExpireViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591