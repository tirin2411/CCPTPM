#pragma checksum "O:\Projects\AAA\AdminApp\Views\PriceAndDestination\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d71a8730df21a22da9d0c5de5b23a0709a6e2641"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PriceAndDestination_Index), @"mvc.1.0.view", @"/Views/PriceAndDestination/Index.cshtml")]
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
#line 1 "O:\Projects\AAA\AdminApp\Views\_ViewImports.cshtml"
using AdminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "O:\Projects\AAA\AdminApp\Views\_ViewImports.cshtml"
using AdminApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d71a8730df21a22da9d0c5de5b23a0709a6e2641", @"/Views/PriceAndDestination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54074211c3cd656cc81e95629b2c9f9dfd6df440", @"/Views/_ViewImports.cshtml")]
    public class Views_PriceAndDestination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ViewModels.Shipment.PriceAndDestinationVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PriceAndDestination", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "O:\Projects\AAA\AdminApp\Views\PriceAndDestination\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <h1 class=""mt-4"">Danh s??ch khu v????c v????n chuy????n</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/"">Trang ch???</a></li>
        <li class=""breadcrumb-item active"">Danh s??ch khu v????c v????n chuy????n</li>
    </ol>
    <div class=""card mb-4"">
        <div class=""card-header"">
            <div class=""row"">
                <div class=""col-md-6 col-xs-12"">
                </div>
                <div class=""col-md-6 col-xs-12"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d71a8730df21a22da9d0c5de5b23a0709a6e26414879", async() => {
                WriteLiteral("T???o m???i");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"card-body\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 27 "O:\Projects\AAA\AdminApp\Views\PriceAndDestination\Index.cshtml"
                 if (ViewBag.SuccessMsg != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"msgAlert\" class=\"alert alert-success\" role=\"alert\">\r\n                        ");
#nullable restore
#line 30 "O:\Projects\AAA\AdminApp\Views\PriceAndDestination\Index.cshtml"
                   Write(ViewBag.SuccessMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 32 "O:\Projects\AAA\AdminApp\Views\PriceAndDestination\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>
                                Id
                            </th>
");
            WriteLiteral("                            <th>\r\n                                Ti??nh Tha??nh\r\n                            </th>\r\n");
            WriteLiteral("                            <th>\r\n                                Qu????n Huy????n\r\n                            </th>\r\n");
            WriteLiteral(@"                            <th>
                                Xa?? Ph??????ng
                            </th>
                           
                            <th>
                                Gia??
                            </th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 67 "O:\Projects\AAA\AdminApp\Views\PriceAndDestination\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 71 "O:\Projects\AAA\AdminApp\Views\PriceAndDestination\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n");
            WriteLiteral("                                <td id=\"province\">\r\n                                    ");
#nullable restore
#line 77 "O:\Projects\AAA\AdminApp\Views\PriceAndDestination\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ProvinceName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n");
            WriteLiteral("                                <td>\r\n                                    ");
#nullable restore
#line 83 "O:\Projects\AAA\AdminApp\Views\PriceAndDestination\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DistrictName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n");
            WriteLiteral("                                <td>\r\n                                    ");
#nullable restore
#line 89 "O:\Projects\AAA\AdminApp\Views\PriceAndDestination\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.WardName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                               \r\n                                <td>\r\n                                    ");
#nullable restore
#line 93 "O:\Projects\AAA\AdminApp\Views\PriceAndDestination\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ShippingPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 96 "O:\Projects\AAA\AdminApp\Views\PriceAndDestination\Index.cshtml"
                               Write(Html.ActionLink("Edit", "Edit", new {  id=item.Id  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n");
            WriteLiteral("                                    ");
#nullable restore
#line 98 "O:\Projects\AAA\AdminApp\Views\PriceAndDestination\Index.cshtml"
                               Write(Html.ActionLink("Delete", "Delete", new {  id=item.Id  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 101 "O:\Projects\AAA\AdminApp\Views\PriceAndDestination\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ViewModels.Shipment.PriceAndDestinationVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
