using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeautySalons.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult IndexServices()
        {
            return View();
        }


        public IActionResult CareFace()
        {
            return View();
        }

        public IActionResult Carehear()
        {
            return View();
        }

        public IActionResult CareSkin()
        {
            return View();
        }

        public IActionResult Carebody()
        {
            return View();
        }
    }
}
