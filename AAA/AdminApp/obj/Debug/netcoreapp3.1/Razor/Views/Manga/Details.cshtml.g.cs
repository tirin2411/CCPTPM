#pragma checksum "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5e4143cf222271474fdfaf55fc513811717998c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manga_Details), @"mvc.1.0.view", @"/Views/Manga/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e4143cf222271474fdfaf55fc513811717998c", @"/Views/Manga/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54074211c3cd656cc81e95629b2c9f9dfd6df440", @"/Views/_ViewImports.cshtml")]
    public class Views_Manga_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels.Catalog.Mangas.MangaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Manga", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.ckeditor.com/ckeditor5/21.0.0/classic/ckeditor.js""></script>
    <script>
        ClassicEditor
            .create(document.querySelector('#rtxContent'), {
                // toolbar: [ 'heading', '|', 'bold', 'italic', 'link' ]
            })
            .then(editor => {
                window.editor = editor;
            })
            .catch(err => {
                console.error(err.stack);
            });
    </script>
");
            }
            );
            WriteLiteral(@"<div class=""container-fluid"">
    <h1 class=""mt-4"">Chi tiết</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Chi tiết</li>
    </ol>
    <div class=""card mb-4"">
        <div class=""card-header"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5e4143cf222271474fdfaf55fc513811717998c5152", async() => {
                WriteLiteral("Về danh sách");
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
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"card-body\">\r\n            <div class=\"col-md-12\">\r\n                <dl class=\"row\">\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 37 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.mangaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-7\">\r\n                        ");
#nullable restore
#line 40 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayFor(model => model.mangaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 43 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-7\">\r\n                        ");
#nullable restore
#line 46 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 49 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Gia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-7\">\r\n                        ");
#nullable restore
#line 52 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Gia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 55 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Giagoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-7\">\r\n                        ");
#nullable restore
#line 58 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Giagoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 61 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Anhien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-7\">\r\n                        ");
#nullable restore
#line 64 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Anhien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 67 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-7\">\r\n                        ");
#nullable restore
#line 70 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 73 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.TinhtrangMn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-7\">\r\n                        ");
#nullable restore
#line 76 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayFor(model => model.TinhtrangMn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 79 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Mota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-7\">\r\n                        <textarea id=\"rtxContent\">");
#nullable restore
#line 82 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                                             Write(Html.DisplayFor(model => model.Mota));

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 86 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Tacgia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-7\">\r\n                        ");
#nullable restore
#line 89 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Tacgia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 92 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.NamXB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-7\">\r\n                        ");
#nullable restore
#line 95 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayFor(model => model.NamXB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 98 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Sotrang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-7\">\r\n                        ");
#nullable restore
#line 101 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Sotrang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 104 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.TheloaiId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-7\">\r\n                        ");
#nullable restore
#line 107 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayFor(model => model.TheloaiId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 110 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-7\">\r\n                        ");
#nullable restore
#line 113 "O:\Projects\AAA\AdminApp\Views\Manga\Details.cshtml"
                   Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModels.Catalog.Mangas.MangaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591