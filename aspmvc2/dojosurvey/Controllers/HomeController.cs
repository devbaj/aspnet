using Microsoft.AspNetCore.Mvc;
using dojosurvey.Models;

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
		public IActionResult Result(Survey result)
		{
			return View(result);
		}
	}
}