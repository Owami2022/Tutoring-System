#pragma checksum "C:\Users\koketso mosena\OneDrive\Desktop\Latest\TBHAcademy\Views\Module\Content.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e98315447fd0bf0517e427a613b807d35a68bbac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Module_Content), @"mvc.1.0.view", @"/Views/Module/Content.cshtml")]
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
#line 1 "C:\Users\koketso mosena\OneDrive\Desktop\Latest\TBHAcademy\Views\_ViewImports.cshtml"
using TBHAcademy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\koketso mosena\OneDrive\Desktop\Latest\TBHAcademy\Views\_ViewImports.cshtml"
using TBHAcademy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98315447fd0bf0517e427a613b807d35a68bbac", @"/Views/Module/Content.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6dbcc57f67d04b7437938f6811bce6b62e099ff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Module_Content : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TBHAcademy.Models.ModuleDisplay>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\koketso mosena\OneDrive\Desktop\Latest\TBHAcademy\Views\Module\Content.cshtml"
  
    ViewData["Title"] = @ViewBag.Tittle;
    Layout = ViewBag.Layout;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!------------------------------------------------- Header --------------------------------------------------------------------------------------->
<div class=""w-100 "" style=""background: rgba(6, 73, 181,0.5)"">
    <div class=""pt-1 m-0 row"">
        <h5 class=""text-white text-center "">");
#nullable restore
#line 11 "C:\Users\koketso mosena\OneDrive\Desktop\Latest\TBHAcademy\Views\Module\Content.cshtml"
                                       Write(ViewBag.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
    </div>
</div>
<!------------------------------------------------- accordion --------------------------------------------------------------------------------------->
<div class=""dropdown"">
  <button class=""btn btn-primary dropdown-toggle"" type=""button"" id=""dropdownMenuButton1"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
    Add Content
  </button>
  <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton1"">
    <li><a class=""dropdown-item"" href=""#"">Text</a></li>
    <li><a class=""dropdown-item"" href=""#"">Document</a></li>
    <li><a class=""dropdown-item"" href=""#"">Link</a></li>
  </ul>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TBHAcademy.Models.ModuleDisplay>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
