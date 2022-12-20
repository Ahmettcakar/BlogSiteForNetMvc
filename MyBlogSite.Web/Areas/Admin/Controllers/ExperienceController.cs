using Data;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace MyBlogSite.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
	public class ExperienceController : Controller
	{
		private readonly ApplicationDbContext _db;

        public ExperienceController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
		{
			return View();
		}
        public IActionResult GetAllExperience()
        {
            return Json(_db.experiences.Where(e => e.IsActive == true && e.IsDeleted == false).OrderByDescending(e => e.EndDate).ToList() );
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
           Experience e=_db.experiences.Find(experience.Id);
            if (e == null)
            {
                return View("Böyle bir Kayıt bulunamamaktadır");

            }
            e.Id= experience.Id;
            e.Name= experience.Name;
            e.EndDate= experience.EndDate;  
            e.StartDate= experience.StartDate;
            e.Description= experience.Description;
            e.ExperienceCity= experience.ExperienceCity;
            e.DateModified=DateTime.Now;
            _db.experiences.Update(e);
            _db.SaveChanges();
            return Json(experience);    
        }

    }
}
