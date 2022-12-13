using Microsoft.AspNetCore.Mvc;

namespace MyBlogSite.Web.Areas.Admin.Controllers
{
	public class Experience : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
