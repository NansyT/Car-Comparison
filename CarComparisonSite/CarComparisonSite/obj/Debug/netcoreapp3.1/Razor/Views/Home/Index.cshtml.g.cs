#pragma checksum "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "125b244c89349471e0b2aa7286e4250e9366a18b"
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
#line 1 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\_ViewImports.cshtml"
using CarComparisonSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\_ViewImports.cshtml"
using CarComparisonSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"125b244c89349471e0b2aa7286e4250e9366a18b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5af09e692fa2b84608d31e1e89856486b7cb8c95", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "125b244c89349471e0b2aa7286e4250e9366a18b4927", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n\t<input class=\"kmTitel\" placeholder=\"KM om året\" type=\"text\" pattern=\"[0-9]+\" />\r\n</div>\r\n<div id=\"contentAligner\" class=\"contentAligner\">\r\n");
#nullable restore
#line 15 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
     if (

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                          true)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"		<div class=""row"">
			<div class=""col-sm"">
				<p> <strong> Mærke </strong> </p>
			</div>
			<div class=""col-sm"">
				<p> <strong> Model </strong></p>
			</div>
			<div class=""col-sm"">
				<p> <strong> Udgave </strong></p>
			</div>
			<div class=""col-sm"">
				<p> <strong> År </strong></p>
			</div>
			<div class=""col-sm"">
				<p> <strong> Type </strong></p>
			</div>
		</div>
");
#nullable restore
#line 34 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
         using (Html.BeginForm("Index", "Home", FormMethod.Post))
		{
			

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
             foreach (Car car in ViewBag.OnePageOfCars)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t<div class=\"col-sm\">\r\n");
            WriteLiteral("\r\n\t\t\t\t\t\t");
#nullable restore
#line 42 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                   Write(Html.Hidden("car",@car.CarId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t<input class=\"lead clickAbleContent\" type=\"submit\"");
            BeginWriteAttribute("id", " id=\"", 1227, "\"", 1242, 1);
#nullable restore
#line 43 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 1232, car.CarId, 1232, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1243, "\"", 1289, 1);
#nullable restore
#line 43 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 1251, Enum.GetName(typeof(Brand),car.Brand), 1251, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n\t\t</div>\r\n\t\t<div class=\"col-sm\">\r\n\t\t\t\t\t\t<p class=\"lead\">");
#nullable restore
#line 47 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                                   Write(car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-sm\">\r\n\t\t\t\t\t\t<p class=\"lead\">");
#nullable restore
#line 50 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                                   Write(car.Variant);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-sm\">\r\n\t\t\t\t\t\t<p class=\"lead\">");
#nullable restore
#line 53 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                                   Write(car.ReleaseYear.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-sm\">\r\n\t\t\t\t\t\t<p class=\"lead\">");
#nullable restore
#line 56 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                                   Write(Enum.GetName(typeof(FuelType),car.Fuel.FuelType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 59 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
             
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"pagedListPager\">\r\n\t\t\t");
#nullable restore
#line 62 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
       Write(Html.PagedListPager( (IPagedList)ViewBag.OnePageOfCars, page =>
		Url.Action("Index", new { page, ViewBag.SelectedGas,ViewBag.SelectedElectric })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n");
            WriteLiteral("\t\t<div class=\"chosenCars\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-sm\">\r\n");
#nullable restore
#line 69 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                     if (ViewBag.SelectedGas != null)
					{
						Car gas = ViewBag.SelectedGas;
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<p class=\"lead\"> Valgte bil </p>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-sm\">\r\n");
#nullable restore
#line 78 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                     if (ViewBag.SelectedElectric != null)
					{
						Car gas = ViewBag.SelectedElectric;
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<p class=\"lead\"> Valgte bil </p>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
            WriteLiteral(@"		<div class=""form-check"">
			<h3 class=""lead"">Ladestander type</h3>
			<div class=""electricRadioBoxes"">
				<div class=""custom-control custom-radio custom-control-inline"">
					<input type=""radio"" id=""electricRadioRent"" name=""electricRadio"" class=""custom-control-input"">
					<label class=""custom-control-label"" for=""electricRadioRent"">Rent</label>
				</div>
				<div class=""custom-control custom-radio custom-control-inline"">
					<input type=""radio"" id=""electricRadioOwn"" name=""electricRadio"" class=""custom-control-input"">
					<label class=""custom-control-label"" for=""electricRadioOwn"">Own</label>
				</div>
			</div>
		</div>
");
            WriteLiteral(@"		<div class=""statisticsContainer"">
			<div class=""statisticsNav"">
				<ul class=""nav nav-tabs"">
					<li class=""nav-item"">
						<a class=""nav-link active"" href=""#"">1. År</a>
					</li>
					<li class=""nav-item"">
						<a class=""nav-link"" href=""#"">2. År</a>
					</li>
					<li class=""nav-item"">
						<a class=""nav-link"" href=""#"">3. År</a>
					</li>
					<li class=""nav-item"">
						<a class=""nav-link"" href=""#"">4. År</a>
					</li>
					<li class=""nav-item"">
						<a class=""nav-link"" href=""#"">5. År</a>
					</li>
					<li class=""nav-item"">
						<a class=""nav-link"" href=""#"">Samlet</a>
					</li>
				</ul>
			</div>
			<div class=""statisticsBody"">
				<div class=""statisticsGas col category"">
					<div class=""d-flex p-2 "">Nypris</div>
					<div class=""d-flex p-2 "">Brændstof/el forbrug</div>
					<div class=""d-flex p-2 "">Co2 afgift</div>
					<div class=""d-flex p-2 "">Bilsyn</div>
					<div class=""d-flex p-2 "">Serviceeftersyn</div>
					<div class=""d-flex p-2 "">Ladestander</div>
			");
            WriteLiteral(@"		<div class=""d-flex p-2 "">Ladeabonnement</div>
				</div>
				<div class=""col"">
					<div id=""newPGas"" class=""d-flex p-2""></div>
					<div id=""fuelPGas"" class=""d-flex p-2""></div>
					<div id=""co2Gas"" class=""d-flex p-2""></div>
					<div id=""synPGas"" class=""d-flex p-2""></div>
					<div id=""servPGas"" class=""d-flex p-2""></div>
					<div id=""cargPGas"" class=""d-flex p-2""></div>
					<div id=""subPGas"" class=""d-flex p-2""></div>
				</div>
				<div class=""statisticsElectric"">
					<div class=""col"">
						<div id=""newPElec"" class=""d-flex p-2""></div>
						<div id=""fuelPElec"" class=""d-flex p-2""></div>
						<div id=""co2Elec"" class=""d-flex p-2""></div>
						<div id=""synElec"" class=""d-flex p-2""></div>
						<div id=""servElec"" class=""d-flex p-2""></div>
						<div id=""chargPElec"" class=""d-flex p-2""></div>
						<div id=""subPElec"" class=""d-flex p-2""></div>
					</div>
				</div>
				<div class=""canvasContainer"">
					<canvas id=""myChart""></canvas>
				</div>
			</div>
		</div>
");
#nullable restore
#line 159 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
	}
	else
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"text-center\">\r\n\t\t\t<h1 class=\"display-2\">Det kunne ikke indlæses nogle biler på dette tidspunkt, prøv igen senere</h1>\r\n\t\t</div>\r\n");
#nullable restore
#line 165 "C:\Users\kenn5073\source\repos\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\t\t\t\t");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
