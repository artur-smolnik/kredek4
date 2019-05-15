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

        /// <summary>
        /// Wyswietlanie listy modeli samochodow
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetListOfModels()
        {
            List<string> allModels = new List<string>();

            //Petla dodajaca model samochdou do listy
            foreach(CarViewModel car in allCars)
            {
                allModels.Add(car.Model);
            }

            return View(allModels);
        }
        /// <summary>
        /// Pobieranie samochodu po jego modelu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCarByModel(string model)
        {
            // Wyszukanie samochodu w liscie
            CarViewModel car = allCars.Where(a => a.Model.ToLower() == model.ToLower()).FirstOrDefault();

            //przekazanie obiektu do widoku
            return View(car);
        }
        [HttpGet]
        public IActionResult ContactForm1()
        { return View(); }
        /// <summary>;
        /// Wyswietlenie formularza kontaktowego do wypelnienia
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ContactForm()
        {
            return View();
        }

        /// <summary>
        /// Wyswietlenie powietania po wyswietleniu formularza kontaktowego
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ContactForm(ContactFormViewModel userData)
        {
            string fullName = userData.FirstName + " " + userData.LastName;
            ViewBag.UserName = fullName;
            return View("ContactFormGreetings");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
