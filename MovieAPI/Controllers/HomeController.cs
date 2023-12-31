﻿using Microsoft.AspNetCore.Mvc;
using MovieAPI.Models;
using System.Diagnostics;

namespace MovieAPI.Controllers
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

        public IActionResult Result(string Title)
        {
            Movie m = MovieDAL.GetMovie(Title);
            return View(m);
        }
        public IActionResult Privacy()
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