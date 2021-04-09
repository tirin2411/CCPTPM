#pragma checksum "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85a2a882e3a5968d7cb275307e0a75641b26fc53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pager_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pager/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85a2a882e3a5968d7cb275307e0a75641b26fc53", @"/Views/Shared/Components/Pager/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54074211c3cd656cc81e95629b2c9f9dfd6df440", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pager_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels.Common.PagedResultBase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml"
  
    var urlTemplate = Url.Action() + "?pageIndex={0}";
    var request = ViewContext.HttpContext.Request;
    foreach (var key in request.Query.Keys)
    {
        if (key == "pageIndex")
        {
            continue;
        }
        if (request.Query[key].Count > 1)
        {
            foreach (var item in (string[])request.Query[key])
            {
                urlTemplate += "&" + key + "=" + item;
            }
        }
        else
        {
            urlTemplate += "&" + key + "=" + request.Query[key];
        }
    }

    var startIndex = Math.Max(Model.PageIndex - 5, 1);
    var finishIndex = Math.Min(Model.PageIndex + 5, Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 28 "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml"
 if (Model.PageCount > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"pagination\">\r\n");
#nullable restore
#line 31 "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != startIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\" title=\"1\"");
            BeginWriteAttribute("href", " href=\"", 939, "\"", 978, 1);
#nullable restore
#line 34 "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 946, urlTemplate.Replace("{0}", "1"), 946, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&#171;</a>\r\n            </li>\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1083, "\"", 1149, 1);
#nullable restore
#line 37 "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1090, urlTemplate.Replace("{0}", (Model.PageIndex-1).ToString()), 1090, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&lsaquo;</a>\r\n            </li>\r\n");
#nullable restore
#line 39 "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml"
         for (var i = startIndex; i <= finishIndex; i++)
        {
            if (i == Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item active\">\r\n                    <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 45 "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml"
                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n                </li>\r\n");
#nullable restore
#line 47 "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1591, "\"", 1618, 2);
            WriteAttributeValue("", 1599, "Trang", 1599, 5, true);
#nullable restore
#line 50 "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue(" ", 1604, i.ToString(), 1605, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1619, "\"", 1667, 1);
#nullable restore
#line 50 "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1626, urlTemplate.Replace("{0}", i.ToString()), 1626, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml"
                                                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 51 "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != finishIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1837, "\"", 1872, 1);
#nullable restore
#line 56 "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1845, Model.PageCount.ToString(), 1845, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1873, "\"", 1939, 1);
#nullable restore
#line 56 "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1880, urlTemplate.Replace("{0}", (Model.PageIndex+1).ToString()), 1880, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&rsaquo;</a>\r\n            </li>\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2046, "\"", 2108, 1);
#nullable restore
#line 59 "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2053, urlTemplate.Replace("{0}", Model.PageCount.ToString()), 2053, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&#187;</a>\r\n            </li>\r\n");
#nullable restore
#line 61 "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 63 "O:\Projects\AAA\AdminApp\Views\Shared\Components\Pager\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModels.Common.PagedResultBase> Html { get; private set; }
    }
}
#pragma warning restore 1591
