using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SpeedRush.Leaderboard.Models;

namespace SpeedRush.Leaderboard.Controllers
{
    public class FunController : Controller
    {
        private readonly ILogger<FunController> _logger;

        public FunController(ILogger<FunController> logger)
        {
            _logger = logger;
        }

        public IActionResult Party() 
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
