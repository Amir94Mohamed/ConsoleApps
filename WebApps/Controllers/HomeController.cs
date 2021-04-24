using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApps.Models;
using ConsoleAppProject.App02;
using ConsoleAppProject.App01;

namespace WebApps.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DistanceConverter(DistanceConverter converter)
        {
            if(converter.FromDistance > 0)
            {
                converter.CalculateDistance();
            }
            return View(converter);
        }

        [HttpGet]
        public IActionResult BMICalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BMICalculator(BMI bmi)
        {
            return View();
        }

        public IActionResult HealthMessage()
        {
            return View();
        }

        public IActionResult StudentMarks()
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
