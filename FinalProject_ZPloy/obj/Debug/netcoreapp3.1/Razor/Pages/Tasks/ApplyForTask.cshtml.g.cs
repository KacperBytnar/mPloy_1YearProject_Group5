#pragma checksum "C:\Users\Mateista\Desktop\mPloy_FinalProject_group5\FinalProject_ZPloy\Pages\Tasks\ApplyForTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cfb58c49eec63a2e2526ad62b7795002916d479"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(mPloy_FinalProject_group5.Pages.Tasks.Pages_Tasks_ApplyForTask), @"mvc.1.0.razor-page", @"/Pages/Tasks/ApplyForTask.cshtml")]
namespace mPloy_FinalProject_group5.Pages.Tasks
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cfb58c49eec63a2e2526ad62b7795002916d479", @"/Pages/Tasks/ApplyForTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d4de0181529d98d458fb7e64994bd70ebeb0007", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Tasks_ApplyForTask : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\nTaskID: ");
#nullable restore
#line 7 "C:\Users\Mateista\Desktop\mPloy_FinalProject_group5\FinalProject_ZPloy\Pages\Tasks\ApplyForTask.cshtml"
   Write(Model.TaskID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\nUserID: ");
#nullable restore
#line 8 "C:\Users\Mateista\Desktop\mPloy_FinalProject_group5\FinalProject_ZPloy\Pages\Tasks\ApplyForTask.cshtml"
   Write(Model.UserID);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mPloy_FinalProject_group5.Pages.Tasks.ApplyForTaskModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<mPloy_FinalProject_group5.Pages.Tasks.ApplyForTaskModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<mPloy_FinalProject_group5.Pages.Tasks.ApplyForTaskModel>)PageContext?.ViewData;
        public mPloy_FinalProject_group5.Pages.Tasks.ApplyForTaskModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
