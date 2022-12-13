using Data;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogSite.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class Education : Controller
	{
		private readonly ApplicationDbContext _db;

		public Education(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult GetAllEducation()
		{
			return Json(_db.educations.Where(e => e.IsActive == true && e.IsDeleted == false).OrderByDescending(e => e.endDate).ToList());
		}



	}
}
