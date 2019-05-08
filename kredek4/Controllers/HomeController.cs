using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kredek4.Models;

namespace kredek4.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Lista samochodow do wyswietlenia
        /// </summary>
        List<CarViewModel> allCars;

        public HomeController()
        {
            allCars = new List<CarViewModel>();
            allCars.Add(new CarViewModel("Focus", "Ford", 70000, "~/focus.png"));
            allCars.Add(new CarViewModel("Golf", "VW", 70000, "~/golf.png"));
            allCars.Add(new CarViewModel("Civic", "Honda", 70000, "~/civic.png"));
            allCars.Add(new CarViewModel("Megane", "Renault", 70000, "~/megane.png"));

        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult InterestingLinks()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllCars()
        {
            return View(allCars);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
