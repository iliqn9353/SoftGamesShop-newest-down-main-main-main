#pragma checksum "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\UserCollection\MyCollection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5ecc9d1b9c845b07b5a050085770573eb11dd6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserCollection_MyCollection), @"mvc.1.0.view", @"/Views/UserCollection/MyCollection.cshtml")]
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
#line 1 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\_ViewImports.cshtml"
using SoftGamesShop.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\_ViewImports.cshtml"
using SoftGamesShop.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\_ViewImports.cshtml"
using SoftGamesShop.Web.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5ecc9d1b9c845b07b5a050085770573eb11dd6e", @"/Views/UserCollection/MyCollection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9262a2bde2120653c4566c4d616dcc84154a3d1c", @"/Views/_ViewImports.cshtml")]
    public class Views_UserCollection_MyCollection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Games", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\UserCollection\MyCollection.cshtml"
   this.ViewData["Title"] = "My Collection";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5ecc9d1b9c845b07b5a050085770573eb11dd6e4477", async() => {
                WriteLiteral("\n    <style>\n        body {\n            background-image: url(\'https://cdn.wallpapersafari.com/82/19/F9ielj.jpg\');\n        }\n    </style>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<h1 class=\"text-center mt-2\">My Collection</h1>\n\n\n<div class=\"row mt-2 mb-4\">\n\n");
#nullable restore
#line 15 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\UserCollection\MyCollection.cshtml"
     foreach (SoftGamesShop.Web.ViewModels.Collection.MyCollectionViewModel game in Model)
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card col-6 col-lg-3 game-card\">\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 466, "\"", 482, 1);
#nullable restore
#line 20 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\UserCollection\MyCollection.cshtml"
WriteAttributeValue("", 472, game.Name, 472, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 483, "\"", 503, 1);
#nullable restore
#line 20 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\UserCollection\MyCollection.cshtml"
WriteAttributeValue("", 489, game.ImageUrl, 489, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\n                  \n                             height=\"350\" width=\"200\">\n\n            <div class=\"card-body\">\n\n                <h5 class=\"card-title text-center\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5ecc9d1b9c845b07b5a050085770573eb11dd6e7074", async() => {
#nullable restore
#line 27 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\UserCollection\MyCollection.cshtml"
                                                                                       Write(game.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("  ");
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
#line 27 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\UserCollection\MyCollection.cshtml"
                                                                  WriteLiteral(game.GameId);

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
            WriteLiteral("\n                </h5>\n\n                <a");
            BeginWriteAttribute("href", " href=\"", 819, "\"", 882, 2);
            WriteAttributeValue("", 826, "/UserCollection/RemoveFromCollection?gameId=", 826, 44, true);
#nullable restore
#line 30 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\UserCollection\MyCollection.cshtml"
WriteAttributeValue("", 870, game.GameId, 870, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-block btn-danger\">Remove from Collection</a>\n\n            </div>\n        </div>\n");
#nullable restore
#line 34 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\UserCollection\MyCollection.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
