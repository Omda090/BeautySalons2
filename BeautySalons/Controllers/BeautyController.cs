using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeautySalons.Controllers
{
    public class BeautyController : Controller
    {
        public IActionResult IndexBeauty()
        {
            return View();
        }
    }
}
