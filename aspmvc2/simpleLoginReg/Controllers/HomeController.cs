using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using simpleLoginReg.Models;

namespace simpleLoginReg.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

				[HttpPost("login")]
				public IActionResult UserLogin(Login attempt)
				{
					if (ModelState.IsValid)
						return RedirectToAction("Success");
					else
						return View("Index");
				}

				[HttpPost("register")]
				public IActionResult NewUser(Register newUser)
				{
					if (ModelState.IsValid)
						return RedirectToAction("Success");
					else
						return View("Index");
				}

				[HttpGet("success")]
				public IActionResult Success()
				{
					return View();
				}
    }
}
