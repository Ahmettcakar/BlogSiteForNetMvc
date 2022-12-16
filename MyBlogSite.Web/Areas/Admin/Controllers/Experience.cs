using Data;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogSite.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
	public class Experience : Controller
	{
		private readonly ApplicationDbContext _db;

        public Experience(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
		{
			return View();
		}
        public IActionResult GetAllExperience()
        {
            return Json(_db.experiences.Where(e => e.IsActive == true && e.IsDeleted == false).OrderByDescending(e => e.EndDate).ToList());
        }

    }
}
