#pragma checksum "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b9aa86dd79b53d0fedb46466799697f2b379849"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b9aa86dd79b53d0fedb46466799697f2b379849", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4a149215418c1d6f9afa9fe0d5be01616862dd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddSubscription", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Subscription", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<style>
        
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
                /*    color: #f1f1f1;

    */
                color: lightgreen;
            }

            .link-tiles:hover a {
                /*        color: #f1f1f1;
    */ color: lightgreen;
            }
</style>

<div class=""j");
            WriteLiteral("ustify-content-xl-center\" align=\"center\">\r\n\r\n    <br />\r\n\r\n    <section class=\"tiles\">\r\n        <div class=\"container\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 1161, "\"", 1169, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <h2 style=""font-family: 'Comic Sans MS'"">Most Popular</h2><br /><br />
                <div class=""row"">
                    <div class=""col-md-3"">
                        <div class=""link-tiles"" style=""border-radius: 10px;"">

                            ");
#nullable restore
#line 56 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("The Times of India", "TimesOfIndia", "NewspaperDetails"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                        <!--.link-tiles-->
                    </div>
                    <div class=""col-md-3"">
                        <div class=""link-tiles"" style=""padding-left: 3rem; border-radius: 10px;"">
                            ");
#nullable restore
#line 63 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Indian Era", "Indianera", "NewspaperDetails"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                        <!--.link-tiles-->
                    </div>

                    <div class=""col-md-3"">
                        <div class=""link-tiles"" style=""padding-left: 3rem; border-radius: 10px;"">
                            ");
#nullable restore
#line 71 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("The Hindu", "TheHindu", "NewspaperDetails"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                        <!--.link-tiles-->
                    </div>
                    <div class=""col-md-3"">
                        <div class=""link-tiles"" style=""border-radius: 10px;"">
                            ");
#nullable restore
#line 78 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Hindustan Times", "HindustanTimes", "NewspaperDetails"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                        <!--.link-tiles-->
                    </div>
                    <div class=""col-md-3"">
                        <div class=""link-tiles"" style=""border-radius: 10px;"">
                            ");
#nullable restore
#line 85 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("The Economic Times", "EconomicalTimes", "NewspaperDetails"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                        <!--.link-tiles-->
                    </div>
                    <div class=""col-md-3"">
                        <div class=""link-tiles"" style=""border-radius: 10px;"">
                            ");
#nullable restore
#line 92 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Deccan Chronicle", "DeccanChronicle", "NewspaperDetails"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                        <!--.link-tiles-->
                    </div>
                    <div class=""col-md-3"">
                        <div class=""link-tiles"" style=""border-radius: 10px;"">
                            ");
#nullable restore
#line 99 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Business Standard", "BusinessStandard", "NewspaperDetails"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                        <!--.link-tiles-->
                    </div>
                    <div class=""col-md-3"">
                        <div class=""link-tiles"" style=""border-radius: 10px;"">
                            ");
#nullable restore
#line 106 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("The Indian Express", "IndianExpress", "NewspaperDetails"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                        <!--.link-tiles-->
                    </div>



                </div>
            </div>
            <!--.row-->
        </div>
        <!--.container-->
    </section>

    <div class=""justify-content-xl-center"" align=""center"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b9aa86dd79b53d0fedb46466799697f2b37984910840", async() => {
                WriteLiteral("Subscribe");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n\r\n");
            WriteLiteral("    <br />\r\n");
            WriteLiteral("\r\n</div>");
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
