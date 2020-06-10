using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstResponsiveWebAppMcCloud.Models;

namespace FirstResponsiveWebAppMcCloud.Controllers
{
    public class HomeController : Controller
    {
        // Getting user input data. 
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.YourAge= string.Empty;
            ViewBag.UserName= string.Empty;
            return View();
        }

        // Returning results based on age calculator and validating input.
        [HttpPost]
        public IActionResult Index(AgeCheckModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.UserName = model.NameEntered;
                ViewBag.YourAge = model.AgeThisYear;
            }
            else
            {
                ViewBag.UserName = string.Empty;
                ViewBag.YourAge = string.Empty;
            }
            return View(model);
        }
    }
}