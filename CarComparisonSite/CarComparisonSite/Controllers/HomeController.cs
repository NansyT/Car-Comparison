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

        public HomeController(ILogger<HomeController> logger, IFetchCarFromDb fetch)
        {
            _logger = logger;
            dbConnector = fetch;
        }

        public IActionResult Index(int? page)
        {
            cars = dbConnector.GetAllCars();
            int pageNumber = page ?? 1;
            IPagedList<Car> onePageOfCars = cars.ToPagedList(pageNumber, 4);

            ViewBag.OnePageOfCars = onePageOfCars;
            return View();
        }

        //Reports back to the server what car was chosen in the grid
        //so it can be set in viewbag and shown on reload
        [HttpPost]
        public ActionResult Index(int car)
        {
            cars = dbConnector.GetAllCars();
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].CarId == car)
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
