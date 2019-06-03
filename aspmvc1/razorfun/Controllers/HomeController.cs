using Microsoft.AspNetCore.Mvc;

namespace razorfun.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet("")]
		public ViewResult Index()
		{
			return View();
		}
	}
}