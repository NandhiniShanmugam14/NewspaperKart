#pragma checksum "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Feedback\ViewFeedback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af6c36516fd07ca4471f0a5d3de0ac41c62acac5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedback_ViewFeedback), @"mvc.1.0.view", @"/Views/Feedback/ViewFeedback.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af6c36516fd07ca4471f0a5d3de0ac41c62acac5", @"/Views/Feedback/ViewFeedback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4a149215418c1d6f9afa9fe0d5be01616862dd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedback_ViewFeedback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NewspaperKart.Models.Feedbacktbl>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFeedback", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Feedback\ViewFeedback.cshtml"
  
    ViewData["Title"] = "ViewContact";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6c36516fd07ca4471f0a5d3de0ac41c62acac54997", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n    <style>\r\n        ");
                WriteLiteral(@"@import url(""https://fonts.googleapis.com/css2?family=Poppins&display=swap"");

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

        .wrapper {
            display: inline-flex;
        }

            .wrapper .icon {
                position: relative;
                background-color: #ffffff;
                border-rad");
                WriteLiteral(@"ius: 50%;
                border: 1px solid #adc4bf;
                padding: 15px;
                margin: 10px;
                width: 50px;
                height: 50px;
                font-size: 18px;
                display: flex;
                justify-content: center;
                align-items: center;
                flex-direction: column;
                box-shadow: 0 10px 10px rgba(0, 0, 0, 0.1);
                cursor: pointer;
                transition: all 0.2s cubic-bezier(0.68, -0.55, 0.265, 1.55);
            }

            .wrapper .tooltip {
                position: absolute;
                top: 0;
                font-size: 14px;
                background-color: #ffffff;
                color: #ffffff;
                padding: 5px 8px;
                border-radius: 5px;
                box-shadow: 0 10px 10px rgba(0, 0, 0, 0.1);
                opacity: 0;
                pointer-events: none;
                transition: all 0.3s cubic-bezier(0.68, -0.55");
                WriteLiteral(@", 0.265, 1.55);
            }

                .wrapper .tooltip::before {
                    position: absolute;
                    content: """";
                    height: 8px;
                    width: 8px;
                    background-color: #ffffff;
                    bottom: -3px;
                    left: 50%;
                    transform: translate(-50%) rotate(45deg);
                    transition: all 0.3s cubic-bezier(0.68, -0.55, 0.265, 1.55);
                }

            .wrapper .icon:hover .tooltip {
                top: -45px;
                opacity: 1;
                visibility: visible;
                pointer-events: auto;
            }

            .wrapper .icon:hover span,
            .wrapper .icon:hover .tooltip {
                text-shadow: 0px -1px 0px rgba(0, 0, 0, 0.1);
            }

            .wrapper .edit:hover,
            .wrapper .edit:hover .tooltip,
            .wrapper .edit:hover .tooltip::before {
                background-c");
                WriteLiteral(@"olor: #3b5999;
                color: #ffffff;
            }

            .wrapper .delete:hover,
            .wrapper .delete:hover .tooltip,
            .wrapper .delete:hover .tooltip::before {
                background-color: #de463b;
                color: #ffffff;
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
            WriteLiteral("\r\n<div class=\"justify-content-xl-center\" align=\"center\">\r\n\r\n    <h1>Customer Feedbacks</h1>\r\n    \r\n    <table class=\"subscription\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n");
            WriteLiteral("                    <label style=\"margin-top: 5px;\">Customer Id</label>\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 126 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Feedback\ViewFeedback.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 129 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Feedback\ViewFeedback.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    <label style=\"margin-top: 5px;\">Phone number</label>\r\n");
            WriteLiteral("                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 136 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Feedback\ViewFeedback.cshtml"
               Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 139 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Feedback\ViewFeedback.cshtml"
               Write(Html.DisplayNameFor(model => model.Issue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 145 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Feedback\ViewFeedback.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 149 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Feedback\ViewFeedback.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CustId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 152 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Feedback\ViewFeedback.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 155 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Feedback\ViewFeedback.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 158 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Feedback\ViewFeedback.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Phoneno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 161 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Feedback\ViewFeedback.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 164 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Feedback\ViewFeedback.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Issue));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td>
                        <div class=""wrapper"">
                            <div class=""icon delete"">
                                <div class=""tooltip"">Delete</div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6c36516fd07ca4471f0a5d3de0ac41c62acac514828", async() => {
                WriteLiteral("<span><i class=\"fa fa-trash\" style=\"color: black;\"></i></span>");
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
#line 170 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Feedback\ViewFeedback.cshtml"
                                                                 WriteLiteral(item.FeedId);

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
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 175 "C:\Users\Administrator\Documents\Technical_Training\Projects\Newspapercartsite\NewspaperKart\NewspaperKart\Views\Feedback\ViewFeedback.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table><br /><br />\r\n    <center>\r\n        <div class=\"row button\" style=\"margin-left: 500px;\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6c36516fd07ca4471f0a5d3de0ac41c62acac517671", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </center>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NewspaperKart.Models.Feedbacktbl>> Html { get; private set; }
    }
}
#pragma warning restore 1591
