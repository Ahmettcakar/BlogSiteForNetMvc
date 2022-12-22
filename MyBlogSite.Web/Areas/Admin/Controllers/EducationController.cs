using Data;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace MyBlogSite.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class EducationController : Controller
	{
		private readonly ApplicationDbContext _db;

		public EducationController(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult GetAllEducation()
		{
			return Json(new {data=_db.educations.Where(e => e.IsActive == true && e.IsDeleted == false).OrderByDescending(e => e.endDate).ToList() });
		}
		[HttpPost]
        public IActionResult EditEducation(Education education)
        {
			Education e = _db.educations.Find(education.Id);
            return Json(e);
        }
        [HttpPost]
        public IActionResult UpdateEducation(Education education)
        {
			Education e = _db.educations.Find(education.Id);
			e.description=education.description;	
			e.endDate=education.endDate;
			e.startDate=education.startDate;
			e.name=education.name;
			
			_db.educations.Update(e);
			_db.SaveChanges();
            return Json(education);
        }

    }
}
