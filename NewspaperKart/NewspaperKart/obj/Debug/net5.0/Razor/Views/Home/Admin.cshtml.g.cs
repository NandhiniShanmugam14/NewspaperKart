#pragma checksum "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Home\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba0ffa2cb0eb83ff126e230d317c40f86136ed45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Admin), @"mvc.1.0.view", @"/Views/Home/Admin.cshtml")]
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
#line 1 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\_ViewImports.cshtml"
using NewspaperKart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\_ViewImports.cshtml"
using NewspaperKart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba0ffa2cb0eb83ff126e230d317c40f86136ed45", @"/Views/Home/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4a149215418c1d6f9afa9fe0d5be01616862dd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba0ffa2cb0eb83ff126e230d317c40f86136ed453339", async() => {
                WriteLiteral(@"
    <style>
        .tiles .link-tiles {
            margin-bottom: 20px;
            background: #090226;
            height: 137px;
        }

            .tiles .link-tiles a {
                display: inline-flex;
                width: 100%;
                height: 100%;
                align-items: center;
                position: relative;
                color: white;
                font-weight: 500;
                font-size: 17px;
                line-height: 20px;
                padding-left: 2.2rem;
                text-transform: uppercase;
                border-radius: 5px;
                text-decoration: none;
            }


        .link-tiles:hover {
            background: #0f194d;
            transition: all, 0.4s, ease;
        }

            .link-tiles:hover a {
                color: lightgreen;
            }

            .link-tiles:hover a {
                color: lightgreen;
            }
    </style>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba0ffa2cb0eb83ff126e230d317c40f86136ed455288", async() => {
                WriteLiteral(@"
    <div class=""justify-content-xl-center"" align=""center"">
        <br />
        <section class=""tiles"">
            <div class=""container"">
                <h2 style=""font-family: 'Comic Sans MS'"">Admin Dashboard</h2>
                <br /><br />
                <div class=""row"">
                    <div class=""col-md-3"">
                        <div class=""link-tiles"" style=""border-radius: 10px; padding-left: 2rem;"">
                            ");
#nullable restore
#line 50 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Home\Admin.cshtml"
                       Write(Html.ActionLink("Newspapers", "ViewNewspaper", "Newspaper"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-3\">\r\n                        <div class=\"link-tiles\" style=\"border-radius: 10px; padding-left: 1rem;\">\r\n                            ");
#nullable restore
#line 55 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Home\Admin.cshtml"
                       Write(Html.ActionLink("Subscription List", "AdminSubscription", "Subscription"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-3\">\r\n                        <div class=\"link-tiles\" style=\"border-radius: 10px; padding-left: 1rem;\">\r\n                            ");
#nullable restore
#line 60 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Home\Admin.cshtml"
                       Write(Html.ActionLink("Vendor Details", "ViewVendor", "Vendor"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-3\">\r\n                        <div class=\"link-tiles\" style=\"border-radius: 10px; padding-left: 3rem;\">\r\n                            ");
#nullable restore
#line 65 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Home\Admin.cshtml"
                       Write(Html.ActionLink("Contact", "ViewFeedback", "Feedback"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
