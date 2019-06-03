using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using formsubmission.Models;

namespace formsubmission.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

				[HttpPost("users/new")]
				public IActionResult Create(User newUser)
				{
					if (ModelState.IsValid)
					{
						return RedirectToAction("Success");
					}
					else
					{
						return View("Index");
					}
				}

				[HttpGet("success")]
				public IActionResult Success()
				{
					return View();
				}
    }
}
