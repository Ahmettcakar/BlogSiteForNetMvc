﻿using Models;
using Microsoft.AspNetCore.Mvc;
using Data;
using Microsoft.EntityFrameworkCore;

namespace MyBlogSite.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
            
        }

        public IActionResult GetProfile()
        {
              Profile profile = _db.profiles.Include(e=>e.Experiences).Include(i => i.Image).Where(i => i.IsDeleted == false && i.IsActive == true && i.Image.ImageType == "ProfilFoto").FirstOrDefault();

              profile.Experiences.AddRange(_db.experiences.Where(e=>e.IsActive==true && e.IsDeleted==false).OrderByDescending(e => e.EndDate).ToList());


			return Json(profile);
        }



		public IActionResult GetAllExperience()
		{
			return Json(_db.experiences.Where(e=>e.IsActive==true && e.IsDeleted==false).OrderByDescending(e=>e.EndDate).ToList());
		}

		public IActionResult GetAllEducation()
		{
			return Json(_db.educations.Where(e => e.IsActive == true && e.IsDeleted == false).OrderByDescending(e => e.endDate).ToList());
		}

	}
}