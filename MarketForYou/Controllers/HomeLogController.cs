﻿using MarketForYou.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MarketForYou.Controllers
{
    public class HomeLogController : Controller
    {
        private readonly ILogger<HomeLogController> _logger;

        public HomeLogController(ILogger<HomeLogController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Inicio()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Produtos()
        {
            return View();
        }

        public IActionResult Feiras()
        {
            return View();
        }
        public IActionResult ReportError()
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
