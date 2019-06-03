using Microsoft.AspNetCore.Mvc;

namespace dojosurvey.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet("")]
		public ViewResult Index()
		{
			return View();
		}

		[HttpPost("result")]
		public IActionResult Result(string name, string loc, string lang, string comment)
		{
			ViewBag.Name = name;
			ViewBag.Loc = loc;
			ViewBag.Lang = lang;
			ViewBag.Comment = comment;
			return View();
		}
	}
}