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
            //set up page view with X.pagedlist
            onePageOfCars = cars.ToPagedList(pageNumber, 10);
            ViewBag.OnePageOfCars = onePageOfCars;
            //collect the items for the first dropdown
            GetAllBrands();
            return View();
        }

        //Called from an onclick in JS
        //Sends us the carId that was clicked,
        //so we can save it in session and be used in the view for selected cars
        //Viewbag and TempData does not last long, so session is used
        [HttpPost]
        public ActionResult Index(int carId)
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
            return RedirectToAction("Index");
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
        public ActionResult SelectBrand(Brand brand)
        {
            try
            {
                if (HttpContext.Session.GetObject<Brand>("currentBrand") != brand)
                {
                    HttpContext.Session.SetObject("currentBrand", brand);
                    ResetButtons();
                    SetAVailableModels(brand);
                }
                return RedirectToAction("index");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        /// <summary>
        /// Gets all models that has the selected <paramref name="brand"/> and sets them in session
        /// </summary>
        /// <param name="brand"></param>
        /// <exception cref="Exception"></exception>
        private void SetAVailableModels(Brand brand)
        {
            List<string> models = ((MsSqlConnection)dbConnector).GetModelsByBrand(brand);
            if (models != null && models.Count > 0)
            {
                HttpContext.Session.SetObject("models", models);
            }
            else
            {
                throw new Exception("The returned list was null or no elements were found");
            }
        }

        [HttpPost]
        public ActionResult SelectModel(string model)
        {
            try
            {
                if (HttpContext.Session.GetObject<string>("currentModel") != model)

                {
                    HttpContext.Session.SetObject("currentModel", model);
                    SetAvailableVariants(model);
                }
                return RedirectToAction("index");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        private void SetAvailableVariants(string model)
        {
            List<string> variants = ((MsSqlConnection)dbConnector).GetVariantsByModel(model);
            if (variants != null && variants.Count > 0)
            {
                HttpContext.Session.SetObject("variants", variants);
            }
            else
            {
                throw new Exception("The returned list was null or no elements were found");
            }
        }

        [HttpPost]
        public ActionResult SelectVariant(string variant = "")
        {
            try
            {
                HttpContext.Session.SetObject("currentVariant", variant);

                Brand? brand = HttpContext.Session.GetObject<Brand?>("currentBrand");
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
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        private void SetAvailableYears(string variant)
		{

		}

        [HttpPost]
        public ActionResult SelectYear(int year)
        {
            HttpContext.Session.SetObject("currentYear", year);
            //Brand brand = HttpContext.Session.GetObject<Brand>("currentBrand");
            //SelectBrand(brand);
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// Tries to get every current filter and remove elements from <paramref name="cars"/> that doesn't fit those criteria
        /// </summary>
        /// <param name="cars">The list to filter on</param>
        /// <returns>returns a filtered list of cars</returns>
        private List<Car> FilterCars(List<Car> cars)
        {
            Brand? brand = HttpContext.Session.GetObject<Brand?>("currentBrand");
            string model = HttpContext.Session.GetObject<string>("currentModel");
            string variant = HttpContext.Session.GetObject<string>("currentVariant");
            int? year = HttpContext.Session.GetObject<int?>("currentYear");

            if (brand != null)
            {
                //Loop backwards through the elements, as to not skip any or go out of bounds
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
        private void ResetButtons()
        {
            HttpContext.Session.SetObject("currentModel", null);
            HttpContext.Session.SetObject("models", null);
            HttpContext.Session.SetObject("currentVariant", null);
            HttpContext.Session.SetObject("variants", null);
            HttpContext.Session.SetObject("currentYear", null);
            HttpContext.Session.SetObject("years", null);
        }
    }
}
