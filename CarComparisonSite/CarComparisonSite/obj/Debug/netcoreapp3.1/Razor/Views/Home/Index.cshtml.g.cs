#pragma checksum "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4ae6c1b620ff80fd535ca6bd5eaa5d776d35efb"
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
#line 1 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\_ViewImports.cshtml"
using CarComparisonSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\_ViewImports.cshtml"
using CarComparisonSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4ae6c1b620ff80fd535ca6bd5eaa5d776d35efb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5af09e692fa2b84608d31e1e89856486b7cb8c95", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/priceOverview.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4ae6c1b620ff80fd535ca6bd5eaa5d776d35efb5310", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4ae6c1b620ff80fd535ca6bd5eaa5d776d35efb6507", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 12 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
      
		double kmYear = Context.Session.GetObject<double>("kmYear");
		if (kmYear != default)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<input id=\"kmYear\" class=\"kmTitel\" placeholder=\"KM om året\" type=\"text\" pattern=\"[0-9]+\"");
            BeginWriteAttribute("value", " value=\"", 445, "\"", 460, 1);
#nullable restore
#line 16 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 453, kmYear, 453, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 17 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
		}
		else
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<input id=\"kmYear\" class=\"kmTitel\" placeholder=\"KM om året\" type=\"text\" pattern=\"[0-9]+\" />\r\n");
#nullable restore
#line 21 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
		}
	

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div id=\"contentAligner\" class=\"contentAligner\">\r\n");
#nullable restore
#line 25 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
     if (ViewBag.OnePageOfCars != null)
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
			<div class=""col-5"">
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
#line 44 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
         using (Html.BeginForm("Index", "Home", FormMethod.Post))
		{
			

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
             for (int i = 0; i < (ViewBag.OnePageOfCars).Count; i++)
			{
				Car car = (Car)ViewBag.OnePageOfCars[i];
				

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
           Write(Html.Partial("CarPartialView", car));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                                                    
				;

			}

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
             
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"pagedListPager\">\r\n\t\t\t");
#nullable restore
#line 55 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
       Write(Html.PagedListPager((IPagedList)ViewBag.OnePageOfCars, page =>
		Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n");
            WriteLiteral("\t\t<div class=\"chosenCars\">\r\n\t\t\t<div id=\"chosenGas\" class=\"row\">\r\n");
#nullable restore
#line 61 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                 if (Context.Session.GetObject<Car>("SelectedGas") != null)
				{
					Car car = Context.Session.GetObject<Car>("SelectedGas");

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"col-sm\">\r\n\t\t\t\t\t\t<p class=\"lead\" id=\"chosenGasCarBrand\"> ");
#nullable restore
#line 65 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                                                           Write(car.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-sm\">\r\n\t\t\t\t\t\t<p class=\"lead\">");
#nullable restore
#line 68 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                                   Write(car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-5\">\r\n\t\t\t\t\t\t<p class=\"lead\">");
#nullable restore
#line 71 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                                   Write(car.Variant);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-sm\">\r\n\t\t\t\t\t\t<p class=\"lead\">");
#nullable restore
#line 74 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                                   Write(car.ReleaseYear.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-sm\">\r\n\t\t\t\t\t\t<p class=\"lead\">");
#nullable restore
#line 77 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                                   Write(car.Fuel.FuelType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<p hidden=\"hidden\" id=\"newPGasI\" class=\"lead\">");
#nullable restore
#line 79 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                                                             Write(car.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t<p hidden=\"hidden\" id=\"useKmGasI\" class=\"lead\">");
#nullable restore
#line 80 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                                                              Write(car.FuelUsagePerKM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 81 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
				}
				else
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"col-sm\">\r\n\t\t\t\t\t\t<p class=\"lead\"> Vælg Benzin bil </p>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 87 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n\t\t\t<div id=\"chosenElec\" class=\"row\">\r\n");
#nullable restore
#line 90 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                 if (Context.Session.GetObject<Car>("SelectedElectric") != null)
				{
					Car car = Context.Session.GetObject<Car>("SelectedElectric");

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"col-sm\">\r\n\t\t\t\t\t\t<p class=\"lead\" id=\"chosenElecCarBrand\"> ");
#nullable restore
#line 94 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                                                            Write(car.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-sm\">\r\n\t\t\t\t\t\t<p class=\"lead\">");
#nullable restore
#line 97 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                                   Write(car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-5\">\r\n\t\t\t\t\t\t<p class=\"lead\">");
#nullable restore
#line 100 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                                   Write(car.Variant);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-sm\">\r\n\t\t\t\t\t\t<p class=\"lead\">");
#nullable restore
#line 103 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                                   Write(car.ReleaseYear.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-sm\">\r\n\t\t\t\t\t\t<p class=\"lead\">");
#nullable restore
#line 106 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                                   Write(car.Fuel.FuelType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<p hidden=\"hidden\" id=\"newPElecI\" class=\"lead\">");
#nullable restore
#line 108 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                                                              Write(car.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t<p hidden=\"hidden\" id=\"useKmElecI\" class=\"lead\">");
#nullable restore
#line 109 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
                                                               Write(car.FuelUsagePerKM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 110 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
				}
				else
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"col-sm\">\r\n\t\t\t\t\t\t<p class=\"lead\"> Vælg El bil </p>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 116 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n\t\t</div>\r\n");
            WriteLiteral(@"		<div class=""form-check"">
			<h3 class=""lead"">Ladestander type</h3>
			<div class=""electricRadioBoxes"">
				<div class=""custom-control custom-radio custom-control-inline"">
					<input type=""radio"" id=""electricRadioRent"" name=""electricRadio"" class=""custom-control-input"">
					<label class=""custom-control-label"" for=""electricRadioRent"">Leje (Abonnement)</label>
				</div>
				<div class=""custom-control custom-radio custom-control-inline"">
					<input type=""radio"" id=""electricRadioOwn"" name=""electricRadio"" class=""custom-control-input"">
					<label class=""custom-control-label"" for=""electricRadioOwn"">Ejer Selv</label>
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
");
            WriteLiteral(@"					<div class=""d-flex p-2 "">Bilsyn</div>
					<div class=""d-flex p-2 "">Serviceeftersyn</div>
					<div class=""d-flex p-2 "">Ladestander</div>
					<div class=""d-flex p-2 "">Ladeabonnement</div>
					<br />
					<div class=""d-flex p-2 "">Totalt</div>
				</div>
				<div class=""col"">
					<div id=""newPGasO"" class=""d-flex p-2""></div>
					<div id=""fuelPGasO"" class=""d-flex p-2""></div>
");
            WriteLiteral(@"					<div id=""synPGasO"" class=""d-flex p-2""></div>
					<div id=""servPGasO"" class=""d-flex p-2""></div>
					<div id=""chargPGasO"" class=""d-flex p-2""></div>
					<div id=""subPGasO"" class=""d-flex p-2""></div>
					<br />
					<div id=""totalPGas"" class=""d-flex p-2""></div>
				</div>
				<div class=""statisticsElectric"">
					<div class=""col"">
						<div id=""newPElecO"" class=""d-flex p-2""></div>
						<div id=""electPElecO"" class=""d-flex p-2""></div>
");
            WriteLiteral(@"						<div id=""synPElecO"" class=""d-flex p-2""></div>
						<div id=""servPElecO"" class=""d-flex p-2""></div>
						<div id=""chargPElecO"" class=""d-flex p-2""></div>
						<div id=""subPElecO"" class=""d-flex p-2""></div>
						<br />
						<div id=""totalPElec"" class=""d-flex p-2""></div>
					</div>
				</div>
				<div class=""canvasContainer"">
					<canvas id=""myChart""></canvas>
				</div>
			</div>
		</div>
");
#nullable restore
#line 198 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
	}
	else
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"text-center\">\r\n\t\t\t<h1 class=\"display-2\">Der kunne ikke indlæses nogle biler på dette tidspunkt, prøv igen senere</h1>\r\n\t\t</div>\r\n");
#nullable restore
#line 204 "C:\Users\nann8059\Documents\GitHub\Car-Comparison\CarComparisonSite\CarComparisonSite\Views\Home\Index.cshtml"
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
