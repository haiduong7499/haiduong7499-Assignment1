#pragma checksum "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\ShowProductByCate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "603d673cd0d60e01a894836aaa248dd47cf6cbd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowProductByCate), @"mvc.1.0.view", @"/Views/Product/ShowProductByCate.cshtml")]
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
#line 1 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\_ViewImports.cshtml"
using Assignment.CustomerSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\_ViewImports.cshtml"
using Assignment.CustomerSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\_ViewImports.cshtml"
using Assignment.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"603d673cd0d60e01a894836aaa248dd47cf6cbd0", @"/Views/Product/ShowProductByCate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45384b9193ea96b127fb00e8944c63baf981dbd6", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowProductByCate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assignment.Shared.ProductRespone>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowProductByCate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"col-lg-3 col-md-6\">\r\n    <div class=\"single-product\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "603d673cd0d60e01a894836aaa248dd47cf6cbd04122", async() => {
                WriteLiteral("<img class=\"img-fluid\"");
                BeginWriteAttribute("src", " src=\"", 233, "\"", 256, 1);
#nullable restore
#line 6 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\ShowProductByCate.cshtml"
WriteAttributeValue("", 239, Model.ProductImg, 239, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 257, "\"", 281, 1);
#nullable restore
#line 6 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\ShowProductByCate.cshtml"
WriteAttributeValue("", 263, Model.NameProduct, 263, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 6 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\ShowProductByCate.cshtml"
                                                                     WriteLiteral(Model.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"product-details\">\r\n            <h6>\r\n                ");
#nullable restore
#line 9 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\ShowProductByCate.cshtml"
           Write(Model.NameProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h6>\r\n            <h6>\r\n                ");
#nullable restore
#line 12 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\ShowProductByCate.cshtml"
           Write(Model.NameCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h6>\r\n            <h6>\r\n                ");
#nullable restore
#line 15 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\ShowProductByCate.cshtml"
           Write(Model.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h6>\r\n            <div class=\"price\">\r\n                <h6>");
#nullable restore
#line 18 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\ShowProductByCate.cshtml"
               Write(Convert.ToDecimal(Model.Price).ToString("#,##"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</h6>\r\n            </div>\r\n            <p>");
#nullable restore
#line 20 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\ShowProductByCate.cshtml"
          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <div class=\"prd-bottom\">\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 776, "\"", 783, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"social-info\">\r\n                    <span class=\"ti-bag\"></span>\r\n                    <p class=\"hover-text\">add to bag</p>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 955, "\"", 962, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"social-info\">\r\n                    <span class=\"lnr lnr-heart\"></span>\r\n                    <p class=\"hover-text\">Wishlist</p>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1139, "\"", 1146, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"social-info\">\r\n                    <span class=\"lnr lnr-sync\"></span>\r\n                    <p class=\"hover-text\">compare</p>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1321, "\"", 1328, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"social-info\">\r\n                    <span class=\"lnr lnr-move\"></span>\r\n                    <p class=\"hover-text\">view more</p>\r\n                </a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment.Shared.ProductRespone> Html { get; private set; }
    }
}
#pragma warning restore 1591
