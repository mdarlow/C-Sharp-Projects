#pragma checksum "C:\Users\Michael Darlow\OneDrive\Desktop\Basic_C#_Programs\ActualServerTime_Challenge_450\ActualServerTime_Challenge_450\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dce7d2b205ffb4f3bb858cb281919a3281afb78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ActualServerTime_Challenge_450.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ActualServerTime_Challenge_450.Pages
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
#line 1 "C:\Users\Michael Darlow\OneDrive\Desktop\Basic_C#_Programs\ActualServerTime_Challenge_450\ActualServerTime_Challenge_450\Pages\_ViewImports.cshtml"
using ActualServerTime_Challenge_450;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dce7d2b205ffb4f3bb858cb281919a3281afb78", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91661dfd6351c9a13402c219934f967e3d8773c7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Michael Darlow\OneDrive\Desktop\Basic_C#_Programs\ActualServerTime_Challenge_450\ActualServerTime_Challenge_450\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Michael Darlow\OneDrive\Desktop\Basic_C#_Programs\ActualServerTime_Challenge_450\ActualServerTime_Challenge_450\Pages\Index.cshtml"
   
    var totallyAccurateString = "the best server in the galaxy";
    var dayOfWeek = DateTime.Now.DayOfWeek;
 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>The current time is ");
#nullable restore
#line 12 "C:\Users\Michael Darlow\OneDrive\Desktop\Basic_C#_Programs\ActualServerTime_Challenge_450\ActualServerTime_Challenge_450\Pages\Index.cshtml"
                   Write(Model.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 12 "C:\Users\Michael Darlow\OneDrive\Desktop\Basic_C#_Programs\ActualServerTime_Challenge_450\ActualServerTime_Challenge_450\Pages\Index.cshtml"
                                Write(dayOfWeek);

#line default
#line hidden
#nullable disable
            WriteLiteral(") on ");
#nullable restore
#line 12 "C:\Users\Michael Darlow\OneDrive\Desktop\Basic_C#_Programs\ActualServerTime_Challenge_450\ActualServerTime_Challenge_450\Pages\Index.cshtml"
                                               Write(totallyAccurateString);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h2>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
