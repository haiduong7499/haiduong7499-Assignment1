#pragma checksum "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "074d00c5e05a8bc0809aa7370ffc546a60990b75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"074d00c5e05a8bc0809aa7370ffc546a60990b75", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"410b674406e4913182a5ed418c61463ee897c59f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Assignment.Shared.ProductRespone>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""single-product-slider mt-5"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-6 text-center"">
                <div class=""section-title"">
                    <h1>Our Products Ralated</h1>
                </div>
            </div>
        </div>
        <div class=""row"">
            <!-- single product -->
");
#nullable restore
#line 18 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Home\Index.cshtml"
             foreach (var item in ViewBag.ProductCate)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("RelatedProduct", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Home\Index.cshtml"
                                                                    ;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"row\">\r\n            <!-- single product -->\r\n");
#nullable restore
#line 26 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Home\Index.cshtml"
             foreach (var item in ViewBag.ProductCate1)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("RelatedProduct", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Home\Index.cshtml"
                                                                    ;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>

<div class=""single-product-slider mt-5"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-6 text-center"">
                <div class=""section-title"">
                    <h1>Our Products</h1>
                </div>
            </div>
        </div>
        <div class=""row"">
            <!-- single product -->
");
#nullable restore
#line 45 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Home\Index.cshtml"
             foreach (var item in ViewBag.Product)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("Product", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Home\Index.cshtml"
                                                             
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Assignment.Shared.ProductRespone>> Html { get; private set; }
    }
}
#pragma warning restore 1591
