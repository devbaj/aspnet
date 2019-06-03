using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace portfolio2.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet("")]
		public ViewResult Index()
		{
			return View();
		}

		[HttpGet("projects")]
		public ViewResult Projects()
		{
			return View();
		}

		[HttpGet("contact")]
		public ViewResult Contact()
		{
			return View();
		}

		[HttpPost("contact/submit")]
		public RedirectToActionResult Submit()
		{
			return RedirectToAction("Index");
		}
	}
}