#pragma checksum "/Users/Guest/Desktop/ParcelShipping.Solution/ParcelShipping/Views/Parcels/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5de9c506cd80e3f93b3500875f545b3de5cf0a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parcels_Index), @"mvc.1.0.view", @"/Views/Parcels/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Parcels/Index.cshtml", typeof(AspNetCore.Views_Parcels_Index))]
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
#line 1 "/Users/Guest/Desktop/ParcelShipping.Solution/ParcelShipping/Views/Parcels/Index.cshtml"
using ParcelShipping.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5de9c506cd80e3f93b3500875f545b3de5cf0a2", @"/Views/Parcels/Index.cshtml")]
    public class Views_Parcels_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 36, true);
            WriteLiteral("\n<h1>List Your Shippment!</h1>\n<ul>\n");
            EndContext();
#line 5 "/Users/Guest/Desktop/ParcelShipping.Solution/ParcelShipping/Views/Parcels/Index.cshtml"
   if (Model.Count == 0)
  {

#line default
#line hidden
            BeginContext(95, 46, true);
            WriteLiteral("    <p>There are currently no shippments!</p>\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/ParcelShipping.Solution/ParcelShipping/Views/Parcels/Index.cshtml"
  }

#line default
#line hidden
            BeginContext(145, 2, true);
            WriteLiteral("  ");
            EndContext();
#line 9 "/Users/Guest/Desktop/ParcelShipping.Solution/ParcelShipping/Views/Parcels/Index.cshtml"
   if(Model.Count != 0)
  {
    

#line default
#line hidden
#line 11 "/Users/Guest/Desktop/ParcelShipping.Solution/ParcelShipping/Views/Parcels/Index.cshtml"
     foreach (Parcel parcel in Model)
    {

#line default
#line hidden
            BeginContext(217, 10, true);
            WriteLiteral("      <li>");
            EndContext();
            BeginContext(228, 13, false);
#line 13 "/Users/Guest/Desktop/ParcelShipping.Solution/ParcelShipping/Views/Parcels/Index.cshtml"
     Write(parcel.Height);

#line default
#line hidden
            EndContext();
            BeginContext(241, 23, true);
            WriteLiteral(" inches</li>\n      <li>");
            EndContext();
            BeginContext(265, 12, false);
#line 14 "/Users/Guest/Desktop/ParcelShipping.Solution/ParcelShipping/Views/Parcels/Index.cshtml"
     Write(parcel.Width);

#line default
#line hidden
            EndContext();
            BeginContext(277, 23, true);
            WriteLiteral(" inches</li>\n      <li>");
            EndContext();
            BeginContext(301, 13, false);
#line 15 "/Users/Guest/Desktop/ParcelShipping.Solution/ParcelShipping/Views/Parcels/Index.cshtml"
     Write(parcel.Length);

#line default
#line hidden
            EndContext();
            BeginContext(314, 23, true);
            WriteLiteral(" inches</li>\n      <li>");
            EndContext();
            BeginContext(338, 13, false);
#line 16 "/Users/Guest/Desktop/ParcelShipping.Solution/ParcelShipping/Views/Parcels/Index.cshtml"
     Write(parcel.Weight);

#line default
#line hidden
            EndContext();
            BeginContext(351, 10, true);
            WriteLiteral(" lbs</li>\n");
            EndContext();
#line 17 "/Users/Guest/Desktop/ParcelShipping.Solution/ParcelShipping/Views/Parcels/Index.cshtml"
    }

#line default
#line hidden
#line 17 "/Users/Guest/Desktop/ParcelShipping.Solution/ParcelShipping/Views/Parcels/Index.cshtml"
     
  }

#line default
#line hidden
            BeginContext(371, 63, true);
            WriteLiteral("\n\n</ul>\n<a href=\"/parcels/new\">Add a shippment to list it.</a>\n");
            EndContext();
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
