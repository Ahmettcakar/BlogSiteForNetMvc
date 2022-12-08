using Models;
using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;
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

        public IActionResult GetAll()
        {

            List<Profile> profiles = _db.profiles.Include(e => e.Image).Where(s => s.IsDeleted == false && s.IsActive == true && s.Image.ImageType == "ProfilFoto").ToList();


            return Json(profiles);
        }

    }
}