using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UISet.Areas.Zixin.Controllers
{
    [Area("Zixin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Customs()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }

        public IActionResult Companies()
        {
            return View();
        }

        public IActionResult Error()
        {
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            return null;
        }
    }
}