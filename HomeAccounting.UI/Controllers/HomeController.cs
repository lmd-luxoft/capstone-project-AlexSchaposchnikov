﻿using HomeAccounting.BusinessLogic.Contracts;
using HomeAccounting.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAccounting.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAccounting _accounting;

        public HomeController(ILogger<HomeController> logger, IAccounting accounting)
        {
            _logger = logger;
            _accounting = accounting;
        }

        public IActionResult Index()
        {
            return View();
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

        public ActionResult CreateAccount()
        {
            _accounting.Create(new Account() { Title = "Test", CreationDate = DateTime.Now });
            return Json(new { Status = true });
        }
    }
}
