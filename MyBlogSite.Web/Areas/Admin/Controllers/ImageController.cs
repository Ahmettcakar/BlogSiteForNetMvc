using Microsoft.AspNetCore.Mvc;

namespace MyBlogSite.Web.Areas.Admin.Controllers
{
    public class ImageController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
