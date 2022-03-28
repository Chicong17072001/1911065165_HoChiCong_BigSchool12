using _1911065165_HoChiCong_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using _1911065165_HoChiCong_BigSchool.ViewModels;

namespace _1911065165_HoChiCong_BigSchool.Controllers
{
   

    public class HomeController : Controller
    {
        private ApplicationDbContext _dbcontext;
        public HomeController()
        {
            _dbcontext = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var upcommingCourses = _dbcontext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now);
            var viewModel = new CoursesViewModel
            {
                UpcommingCourses = upcommingCourses,
                ShowAction = User.Identity.IsAuthenticated
            };
            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}