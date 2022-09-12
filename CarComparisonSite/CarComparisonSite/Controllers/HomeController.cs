using CarComparisonSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            onePageOfCars = cars.ToPagedList(pageNumber, 10);
            ViewBag.OnePageOfCars = onePageOfCars;
            return View();
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
            if (kmYear != 0)
            {
                HttpContext.Session.SetObject("kmYear", kmYear);

            }
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
