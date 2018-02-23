using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using xochxoch.Models;

namespace xochxoch.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.selectedItem = "about";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.selectedItem = "contact";

            return View();
        }

        

        public IActionResult Gallery()
        {
            ViewBag.selectedItem = "gallery";

            return View();
        }

        public IActionResult Shop()
        {
            ViewBag.selectedItem = "shop";

            return View();
        }


    }
}
