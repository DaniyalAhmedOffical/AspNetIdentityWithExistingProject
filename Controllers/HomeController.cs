using AspNetIdentityWithExistingProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetIdentityWithExistingProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Create an Instance of the ApplicationDbContext class
            ApplicationDbContext ctx = new ApplicationDbContext();
            //Fetch all the users, this will create the database behind the scene
            List<ApplicationUser> users = ctx.Users.ToList();
            return View();
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