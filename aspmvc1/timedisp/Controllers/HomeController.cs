using Microsoft.AspNetCore.Mvc;
using System;

namespace timedisp.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet("")]
		public ViewResult Index()
		{
			DateTime current = DateTime.Now;
			ViewBag.CurrentDate = current.ToString("MMM dd, yyyy");
			ViewBag.CurrentTime = current.ToString("h:mm tt");
			return View();
		}
	}
}