using CarComparisonSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using X.PagedList;

namespace CarComparisonSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFetchCarFromDb dbConnector;
        private List<Car> cars;
        private IPagedList<Car> onePageOfCars;
        private int pageNumber;

        public HomeController(ILogger<HomeController> logger, IFetchCarFromDb fetch)
        {
            _logger = logger;
            dbConnector = fetch;
        }

        public IActionResult Index(int? page)
        {
            cars = dbConnector.GetAllCars();
            pageNumber = page ?? 1;
            cars = FilterCars(cars);

            onePageOfCars = cars.ToPagedList(pageNumber, 10);
            ViewBag.OnePageOfCars = onePageOfCars;
            GetAllBrands();
            //FilterCars(modelFilter, variantFilter, dateFilter, brandfilter);
            return View();
        }


        private List<Car> FilterCars(List<Car> cars)
        {
            Brand? brand = HttpContext.Session.GetObject<Brand?>("currentBrand");
            string model = HttpContext.Session.GetObject<string>("currentModel");
            string variant = HttpContext.Session.GetObject<string>("currentVariant");
            int? year = HttpContext.Session.GetObject<int?>("currentYear");

            if (brand != null)
            {
                for (int i = cars.Count - 1; i > -1; i--)
                {
                    if (cars[i].Brand != brand)
                    {
                        cars.RemoveAt(i);
                    }
                }
            }
            if (model != null)
            {
                for (int i = cars.Count - 1; i > -1; i--)
                {
                    if (cars[i].Model != model)
                    {
                        cars.RemoveAt(i);
                    }
                }
            }
            if (variant != null)
            {
                for (int i = cars.Count - 1; i > -1; i--)
                {
                    if (cars[i].Variant != variant)
                    {
                        cars.RemoveAt(i);
                    }
                }
            }
            if (year != null && year != 0)
            {
                for (int i = cars.Count - 1; i > -1; i--)
                {
                    if (cars[i].ReleaseYear.Year != year)
                    {
                        cars.RemoveAt(i);
                    }
                }
            }

            return cars;
        }

        [HttpGet]
        public ActionResult ClearFilters()
        {

            HttpContext.Session.SetObject("model", null);
            HttpContext.Session.SetObject("variant", null);
            HttpContext.Session.SetObject("brand", null);
            HttpContext.Session.SetObject("year", 0);
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult GetAllBrands()
        {
            try
            {
                List<Brand> brands = ((MsSqlConnection)dbConnector).GetAllBrands();
                if (brands != null && brands.Count > 0)
                {
                    HttpContext.Session.SetObject("brands", brands);
                    return Ok();
                }
                else
                {
                    throw new Exception("The returned list was null or no elements were found");
                }
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public ActionResult GetModels(Brand brand)
        {
            try
            {
                if (HttpContext.Session.GetObject<Brand>("currentBrand") != brand)
                {
                    HttpContext.Session.SetObject("currentBrand", brand);
                    ResetButtons();
                }

                List<string> models = ((MsSqlConnection)dbConnector).GetModelsByBrand(brand);
                if (models != null && models.Count > 0)
                {
                    HttpContext.Session.SetObject("models", models);
                    return RedirectToAction("index");
                }
                else
                {
                    throw new Exception("The returned list was null or no elements were found");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        private void ResetButtons()
        {
            HttpContext.Session.SetObject("currentModel", null);
            HttpContext.Session.SetObject("models", null);
            HttpContext.Session.SetObject("currentVariant", null);
            HttpContext.Session.SetObject("variants", null);
            HttpContext.Session.SetObject("currentYear", null);
            HttpContext.Session.SetObject("years", null);
        }

        [HttpPost]
        public ActionResult GetVariantsByModel(string model)
        {
            try
            {
                HttpContext.Session.SetObject("currentModel", model);

                List<string> variants = ((MsSqlConnection)dbConnector).GetVariantsByModel(model);
                if (variants != null && variants.Count > 0)
                {
                    HttpContext.Session.SetObject("variants", variants);
                    return RedirectToAction("index");
                }
                else
                {
                    throw new Exception("The returned list was null or no elements were found");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        public ActionResult GetYears(string variant = "")
        {
            HttpContext.Session.SetObject("currentVariant", variant);

            Brand brand = HttpContext.Session.GetObject<Brand>("currentBrand");
            string model = HttpContext.Session.GetObject<string>("currentModel");

            List<int> years = ((MsSqlConnection)dbConnector).GetYears(brand, variant, model);
            if (years != null && years.Count > 0)
            {
                HttpContext.Session.SetObject("years", years);

                return RedirectToAction("index");
            }
            else
            {
                return StatusCode(500, "error");
            }
        }

        [HttpPost]
        public ActionResult SetYear(int year)
        {
            HttpContext.Session.SetObject("currentYear", year);
            Brand brand = HttpContext.Session.GetObject<Brand>("currentBrand");
            GetModels(brand);
            return RedirectToAction("index");
        }

        [HttpPost]
        public ActionResult SetKmPerYear(int kmYear)
        {
            if (kmYear != 0)
            {
                HttpContext.Session.SetObject("kmYear", kmYear);
            }
            return RedirectToAction("index");
        }

        //Called from an onclick in JS
        //Sends us the carId that was clicked,
        //so we can save it in session and be used in the view for selected cars

        //Viewbag and TempData does not last long, so session is required
        [HttpPost]
        public ActionResult Index(int carId, double kmYear = 0)
        {
            cars = dbConnector.GetAllCars();
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].CarId == carId)
                {
                    if (cars[i].Fuel.FuelType == FuelType.Benzin)
                    {
                        HttpContext.Session.SetObject("SelectedGas", cars[i]);
                    }
                    else
                    {
                        HttpContext.Session.SetObject("SelectedElectric", cars[i]);
                    }
                    i = cars.Count + 1;
                }
            }
            //if (kmYear != 0)
            //{
            //    HttpContext.Session.SetObject("kmYear", kmYear);

            //}
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
