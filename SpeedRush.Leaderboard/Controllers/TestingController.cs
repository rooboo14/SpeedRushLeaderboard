using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace SpeedRush.Leaderboard.Controllers
{
    public class TestingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Thing(int? id, string name)
        {
            if (id < 1)
            {
                return NotFound();
            }
            if (id == null)
            {
                ViewData["Message"] = "Hello! This is the thing view page. :)";
                return View();
            }
            ViewData["Message"] = "Hello, " + name + "! The id you requested is: " + id;
            return View();
        }

    }
}