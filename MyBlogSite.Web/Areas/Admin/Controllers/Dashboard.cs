using Microsoft.AspNetCore.Mvc;

namespace MyBlogSite.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class Dashboard : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
