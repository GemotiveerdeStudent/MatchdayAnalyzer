﻿using MatchdayAnalyzer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MatchdayAnalyzer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }
        public IActionResult Goals()
        {
            return View();
        }
        public IActionResult Results()
        {
            return View();
        }
        public IActionResult Attendance()
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