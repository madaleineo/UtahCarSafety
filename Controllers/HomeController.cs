﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UtahCarSafety.Models;

namespace UtahCarSafety.Controllers
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

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult SeverityCalculator()
        {
            return View();
        }
        public IActionResult CrashScenarios()
        {
            return View();
        }
        public IActionResult KeyStats()
        {
            return View();
        }
        public IActionResult Dataset()
        {
            return View();
        }
        public IActionResult ViewStories()
        {
            return View();
        }
    }
}
