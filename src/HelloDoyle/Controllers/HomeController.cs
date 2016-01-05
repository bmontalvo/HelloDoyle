using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace HelloDoyle.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page, O'Doyle.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "O'Doyle contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
