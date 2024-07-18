using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmrCalendar.Models;

namespace EmrCalendar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calendar()
        {
            ViewData["events"] = new[]
            {
                new Event { Id = 1, Title = "Video for Marisa", StartDate = "2020-11-14"},
                new Event { Id = 2, Title = "Preparation", StartDate = "2020-11-12"},
            };

            return View();
        }
    }
}
