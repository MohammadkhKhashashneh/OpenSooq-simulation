#pragma checksum "C:\Users\Mohammad KH\source\repos\OpenSooq\OpenSooq1\Views\Home\ShopDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c660f1379cf99cebdd920b7ffe1481eb613ca00c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShopDetails), @"mvc.1.0.view", @"/Views/Home/ShopDetails.cshtml")]
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
#line 1 "C:\Users\Mohammad KH\source\repos\OpenSooq\OpenSooq1\Views\_ViewImports.cshtml"
using OpenSooq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mohammad KH\source\repos\OpenSooq\OpenSooq1\Views\_ViewImports.cshtml"
using OpenSooq.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c660f1379cf99cebdd920b7ffe1481eb613ca00c", @"/Views/Home/ShopDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13c35aa0bc2b57ffc218baae5e5496fd6a60ce32", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ShopDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OpenSooq.Models.Shop>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100 h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Mohammad KH\source\repos\OpenSooq\OpenSooq1\Views\Home\ShopDetails.cshtml"
  
    ViewData["Title"] = "ProductsShop";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-fluid py-5"">
    <div class=""row px-xl-5"">
        <div class=""col-lg-5 pb-5"">
            <div id=""product-carousel"" class=""carousel slide"" data-ride=""carousel"">
                <div class=""carousel-inner border"">

                    <div class=""carousel-Model active"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c660f1379cf99cebdd920b7ffe1481eb613ca00c4508", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\Mohammad KH\source\repos\OpenSooq\OpenSooq1\Views\Home\ShopDetails.cshtml"
                                         WriteLiteral(Url.Content("~/newImg/" + @Model.ShopImage));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "C:\Users\Mohammad KH\source\repos\OpenSooq\OpenSooq1\Views\Home\ShopDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-lg-7 pb-5\">\r\n            <h3 class=\"font-weight-semi-bold\">");
#nullable restore
#line 22 "C:\Users\Mohammad KH\source\repos\OpenSooq\OpenSooq1\Views\Home\ShopDetails.cshtml"
                                         Write(Model.ShopName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h3 class=\"font-weight-semi-bold mb-4\">\r\n                ");
#nullable restore
#line 24 "C:\Users\Mohammad KH\source\repos\OpenSooq\OpenSooq1\Views\Home\ShopDetails.cshtml"
           Write(Html.DisplayFor(model => model.Category.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h3>\r\n            <p class=\"mb-4\">");
#nullable restore
#line 26 "C:\Users\Mohammad KH\source\repos\OpenSooq\OpenSooq1\Views\Home\ShopDetails.cshtml"
                       Write(Model.ShopDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <div class=\"text-left\">\r\n                <a class=\"btn btn-primary px-3\"");
            BeginWriteAttribute("href", " href=\"", 989, "\"", 1044, 2);
            WriteAttributeValue("", 996, "tel:", 996, 4, true);
#nullable restore
#line 28 "C:\Users\Mohammad KH\source\repos\OpenSooq\OpenSooq1\Views\Home\ShopDetails.cshtml"
WriteAttributeValue("", 1000, Html.DisplayFor(model => model.User.Mobile), 1000, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Call <i class=\"fa fa-phone mr-1\"></i></a>\r\n            \r\n                <a class=\"btn btn-primary px-3\"");
            BeginWriteAttribute("href", " href=\"", 1151, "\"", 1216, 2);
            WriteAttributeValue("", 1158, "https://wa.me/", 1158, 14, true);
#nullable restore
#line 30 "C:\Users\Mohammad KH\source\repos\OpenSooq\OpenSooq1\Views\Home\ShopDetails.cshtml"
WriteAttributeValue("", 1172, Html.DisplayFor(model => model.User.Mobile), 1172, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> WhatsApp <i class=\"fa-brands fa-whatsapp\"></i></a>\r\n            </div>\r\n\r\n        </div>\r\n    </div>  \r\n\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c660f1379cf99cebdd920b7ffe1481eb613ca00c9077", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OpenSooq.Models.Shop> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
