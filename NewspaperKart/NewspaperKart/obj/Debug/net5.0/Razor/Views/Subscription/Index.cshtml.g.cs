#pragma checksum "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Subscription\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33c93a088f230f42e3bf2a99296fdbb6af2f9647"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subscription_Index), @"mvc.1.0.view", @"/Views/Subscription/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#nullable restore
#line 3 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Subscription\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Subscription\Index.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33c93a088f230f42e3bf2a99296fdbb6af2f9647", @"/Views/Subscription/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4a149215418c1d6f9afa9fe0d5be01616862dd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Subscription_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NewspaperKart.Models.Subscriptiontbl>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteSubscription", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Subscription\Index.cshtml"
  
    ViewData["Title"] = "ViewSubscription";
    ViewBag.CustId = HttpContextAccessor.HttpContext.Session.GetInt32("CustId");
    ViewBag.CustomerId = HttpContextAccessor.HttpContext.Session.GetInt32("CustUserId");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .subscription {
        font-family: Arial, Helvetica, sans-serif;
        border-collapse: collapse;
        width: 100%;
    }

        .subscription td, .subscription th {
            border: 1px solid #ddd;
            padding: 8px;
        }

        .subscription tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        .subscription tr:hover {
            background-color: #ddd;
        }

        .subscription th {
            padding-top: 12px;
            padding-bottom: 12px;
            text-align: left;
            background-color: #01054d;
            color: white;
        }
</style>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33c93a088f230f42e3bf2a99296fdbb6af2f96475769", async() => {
                WriteLiteral("\r\n    <br />\r\n    <h2 class=\"text-center\" style=\"font-family: \'Comic Sans MS\'\">My Subscriptions</h2><br />\r\n    <table class=\"subscription\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 49 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Subscription\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CustId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 52 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Subscription\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 55 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Subscription\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 58 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Subscription\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Subscriptiontype));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 61 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Subscription\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Timeperiod));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>Unsubscribe</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 67 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Subscription\Index.cshtml"
             foreach (var item in Model)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Subscription\Index.cshtml"
                 if (ViewBag.CustomerId == item.CustId)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 73 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Subscription\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CustId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 76 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Subscription\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 79 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Subscription\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 82 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Subscription\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Subscriptiontype));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 85 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Subscription\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Timeperiod));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33c93a088f230f42e3bf2a99296fdbb6af2f964711196", async() => {
                    WriteLiteral("Unsubscribe");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Subscription\Index.cshtml"
                                                                 WriteLiteral(item.SubId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 93 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Subscription\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Subscription\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
            WriteLiteral("\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NewspaperKart.Models.Subscriptiontbl>> Html { get; private set; }
    }
}
#pragma warning restore 1591
