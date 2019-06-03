using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewmodelFun.Models;

namespace viewmodelFun.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
					string message = "MVC in action";
          return View("Index", message);
        }

				[HttpGet("numbers")]
				public IActionResult Numbers()
				{
					int[] nums = {0,3,5,12,43};
					return View("Numbers", nums);
				}

				[HttpGet("users")]
				public IActionResult Users()
				{
					User[] users = {
						new User("Chika", "Fujiwara"),
						new User("Mai", "Sakurajima"),
						new User("Kaguya", "Shinomiya"),
						new User("Madoka", "Akame")
					};
					return View(users);
				}

				[HttpGet("user")]
				public IActionResult User()
				{
					User user = new User("Kei", "Shirogane");
					return View(user);
				}
    }
}
