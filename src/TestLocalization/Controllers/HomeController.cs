using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestLocalization.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult FirstWebpage()
        {
            return View();
        }
        public IActionResult SecondWebpage()
        {
            return View();
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
