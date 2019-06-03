using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using randomcode.Models;
using Microsoft.AspNetCore.Http;

namespace randomcode.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
					int? counter = HttpContext.Session.GetInt32("counter");
					if (counter == null)
						HttpContext.Session.SetInt32("counter", 1);
					else
					{
						counter += 1;
						HttpContext.Session.SetInt32("counter", (int)counter);
					}
					ViewBag.Counter = HttpContext.Session.GetInt32("counter");
					ViewBag.Code = Generate();
            return View();
        }

				public static string Generate()
				{
					Random rand = new Random();
					string characters = "0123456789QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghbnm";
					string result = string.Empty;
					for (int i = 0; i < 14; i++)
					{
						result += characters[rand.Next(characters.Length)];
					}
					return result;
				}

    }
}
