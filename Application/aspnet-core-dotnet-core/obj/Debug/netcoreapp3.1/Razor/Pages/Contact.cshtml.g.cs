#pragma checksum "C:\xfer_current\WorkingDirectory2\20230125\mb-app-aks-demo-r2\Application\aspnet-core-dotnet-core\Pages\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a79dfc3e631c1d3188f3601b089f342f2558125"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(aspnet_core_dotnet_core.Pages.Pages_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact.cshtml")]
namespace aspnet_core_dotnet_core.Pages
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
#line 1 "C:\xfer_current\WorkingDirectory2\20230125\mb-app-aks-demo-r2\Application\aspnet-core-dotnet-core\Pages\_ViewImports.cshtml"
using aspnet_core_dotnet_core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a79dfc3e631c1d3188f3601b089f342f2558125", @"/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aadb2e17aeb0018471e095171d7daadd4a397e0", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\xfer_current\WorkingDirectory2\20230125\mb-app-aks-demo-r2\Application\aspnet-core-dotnet-core\Pages\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<h4>Your contact page.</h4>

<address>
    One Microsoft Way<br />
    Redmond, WA 98052-6399<br />
    <abbr title=""Phone"">P:</abbr>
    425.555.0100
</address>

<address>
    <strong>Support:</strong> <a href=""mailto:Support@example.com"">Support@example.com</a><br />
    <strong>Marketing:</strong> <a href=""mailto:Marketing@example.com"">Marketing@example.com</a>
</address>


");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel>)PageContext?.ViewData;
        public ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
