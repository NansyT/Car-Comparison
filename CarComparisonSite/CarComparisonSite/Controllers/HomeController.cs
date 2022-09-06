using CarComparisonSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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

        public IActionResult Index()
        {
            //cars = dbConnector.GetAllCars();
            return View();
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
