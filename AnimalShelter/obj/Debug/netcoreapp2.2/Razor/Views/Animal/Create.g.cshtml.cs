#pragma checksum "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42c780fec68a2a9e25e1c2f9478850aa8478ecd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animal_Create), @"mvc.1.0.view", @"/Views/Animal/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Animal/Create.cshtml", typeof(AspNetCore.Views_Animal_Create))]
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
#line 5 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Create.cshtml"
using AnimalShelter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42c780fec68a2a9e25e1c2f9478850aa8478ecd0", @"/Views/Animal/Create.cshtml")]
    public class Views_Animal_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnimalShelter.Models.Animal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(91, 27, true);
            WriteLiteral("\n<h4>Add a new animal</h4>\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(151, 42, false);
#line 11 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Create.cshtml"
Write(Html.LabelFor(model => model.Name, "Name"));

#line default
#line hidden
            EndContext();
            BeginContext(199, 67, false);
#line 12 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name, new {@class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(272, 40, false);
#line 13 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Create.cshtml"
Write(Html.LabelFor(model => model.Age, "Age"));

#line default
#line hidden
            EndContext();
            BeginContext(318, 66, false);
#line 14 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Create.cshtml"
Write(Html.TextBoxFor(model => model.Age, new {@class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(390, 63, false);
#line 15 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Create.cshtml"
Write(Html.LabelFor(model => model.AdmittanceDate, "Admittance Date"));

#line default
#line hidden
            EndContext();
            BeginContext(459, 77, false);
#line 16 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Create.cshtml"
Write(Html.TextBoxFor(model => model.AdmittanceDate, new {@class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(542, 45, false);
#line 17 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Create.cshtml"
Write(Html.LabelFor(model => model.PetType, "Type"));

#line default
#line hidden
            EndContext();
            BeginContext(593, 150, false);
#line 18 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Create.cshtml"
Write(Html.DropDownListFor(model => model.PetType,
    new SelectList(Enum.GetValues(typeof(AnimalType))),
    "Select Type", new {@class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(749, 44, false);
#line 21 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Create.cshtml"
Write(Html.LabelFor(model => model.Breed, "Breed"));

#line default
#line hidden
            EndContext();
            BeginContext(799, 68, false);
#line 22 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Create.cshtml"
Write(Html.TextBoxFor(model => model.Breed, new {@class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(869, 51, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new animal\" />\n");
            EndContext();
#line 25 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Create.cshtml"
}

#line default
#line hidden
            BeginContext(922, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(926, 42, false);
#line 26 "/Users/Guest/Desktop/AnimalShelter.Solution/AnimalShelter/Views/Animal/Create.cshtml"
Write(Html.ActionLink("Show all items", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(968, 5, true);
            WriteLiteral("</p> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnimalShelter.Models.Animal> Html { get; private set; }
    }
}
#pragma warning restore 1591
