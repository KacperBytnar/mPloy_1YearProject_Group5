#pragma checksum "C:\Users\Mateista\Desktop\mPloy_FinalProject_group5\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7111d46e0ee3a612815c1a3a5f14414a62072e9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(mPloy_FinalProject_group5.Pages.UserAccount.Pages_UserAccount_DisplayUser), @"mvc.1.0.razor-page", @"/Pages/UserAccount/DisplayUser.cshtml")]
namespace mPloy_FinalProject_group5.Pages.UserAccount
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
#line 1 "C:\Users\Mateista\Desktop\mPloy_FinalProject_group5\FinalProject_ZPloy\Pages\_ViewImports.cshtml"
using mPloy_FinalProject_group5;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7111d46e0ee3a612815c1a3a5f14414a62072e9a", @"/Pages/UserAccount/DisplayUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d4de0181529d98d458fb7e64994bd70ebeb0007", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UserAccount_DisplayUser : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/UserAccount/EditUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn rounded-pill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" font-size: medium; margin-left: 25px; margin-right: 25px; width: 125px; background-color: rgb(163 160 130);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" font-size: medium; width:125px; background-color: rgb(163 160 130);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<style>

    .profile {
        margin: auto;
        width: 60%;
        padding-top: 20px;
    }

    label {
        font-weight: 600;
        margin-right: 10px;
    }



    * {
        box-sizing: border-box;
    }

    .column {
        float: left;
        padding: 10px;
        height: 300px;
    }

    .left {
        width: 25%;
    }

    .right {
        width: 50%;
    }


    .row:after {
        content: """";
        display: table;
        clear: both;
    }

    .img-fluid {
        background-size: cover;
        width: 100%;
        height: 100%;
        object-fit: contain;
    }

    .row {
        margin-left: 20%;
        margin-right: 0;
        top: 30%;
        position: absolute;
    }
</style>






<div class=""row"">
    <div class=""column left"">

        <img");
            BeginWriteAttribute("src", " src=\"", 878, "\"", 909, 1);
#nullable restore
#line 68 "C:\Users\Mateista\Desktop\mPloy_FinalProject_group5\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
WriteAttributeValue("", 884, Model.LoggedUser.Picture, 884, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid img-thumbnail\"");
            BeginWriteAttribute("title", " title=\"", 942, "\"", 950, 0);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 951, "\"", 957, 0);
            EndWriteAttribute();
            WriteLiteral(">\n\n\n");
            WriteLiteral("    </div>\n\n\n    <div class=\"column right\">\n        <div>\n            <h3 class=\"dark-color\">About Me</h3>\n\n            <p>\n                ");
#nullable restore
#line 80 "C:\Users\Mateista\Desktop\mPloy_FinalProject_group5\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
           Write(Model.LoggedUser.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </p>\n\n            <div class=\"col-6\" style=\"float:left;\">\n                <div class=\"media\">\n                    <label>   Username: </label>\n                    <p>");
#nullable restore
#line 86 "C:\Users\Mateista\Desktop\mPloy_FinalProject_group5\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                  Write(Model.LoggedUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n                </div>\n                <div class=\"media\">\n                    <label>   Full Name: </label>\n                    <p>");
#nullable restore
#line 90 "C:\Users\Mateista\Desktop\mPloy_FinalProject_group5\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                  Write(Model.LoggedUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 90 "C:\Users\Mateista\Desktop\mPloy_FinalProject_group5\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                                              Write(Model.LoggedUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n                <div class=\"media\">\n                    <label>   Age: </label>\n                    <p>");
#nullable restore
#line 94 "C:\Users\Mateista\Desktop\mPloy_FinalProject_group5\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                  Write(Model.LoggedUser.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n                </div>\n            </div>\n            <div class=\"col-6\" style=\"float:right\">\n                <div class=\"media\">\n                    <label> Address: </label>\n                    <p> ");
#nullable restore
#line 100 "C:\Users\Mateista\Desktop\mPloy_FinalProject_group5\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                   Write(Model.LoggedUser.StreetAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 100 "C:\Users\Mateista\Desktop\mPloy_FinalProject_group5\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                                                   Write(Model.LoggedUser.ZipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 100 "C:\Users\Mateista\Desktop\mPloy_FinalProject_group5\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                                                                             Write(Model.LoggedUser.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n                </div>\n                <div class=\"media\">\n                    <label> Email:</label>\n                    <p>");
#nullable restore
#line 104 "C:\Users\Mateista\Desktop\mPloy_FinalProject_group5\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                  Write(Model.LoggedUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n                <div class=\"media\">\n                    <label> Phone: </label>\n                    <p>   +45 ");
#nullable restore
#line 108 "C:\Users\Mateista\Desktop\mPloy_FinalProject_group5\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                         Write(Model.LoggedUser.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n            </div>\n\n        </div>\n    </div>\n\n</div>\n\n<div class=\"container\" style=\"position:absolute; bottom:34%; left:19.6%; margin-top:50px;\">\n    <div class=\"form-group\" style=\"display:flex\">\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7111d46e0ee3a612815c1a3a5f14414a62072e9a10629", async() => {
                WriteLiteral("Edit Profile");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7111d46e0ee3a612815c1a3a5f14414a62072e9a11963", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mPloy_FinalProject_group5.Pages.UserAccount.DisplayUserModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<mPloy_FinalProject_group5.Pages.UserAccount.DisplayUserModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<mPloy_FinalProject_group5.Pages.UserAccount.DisplayUserModel>)PageContext?.ViewData;
        public mPloy_FinalProject_group5.Pages.UserAccount.DisplayUserModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
