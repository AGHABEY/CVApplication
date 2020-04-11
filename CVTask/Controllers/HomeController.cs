using CVTask.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CVTask.Controllers
{
    public class HomeController : Controller
    {
        private CvContext cvContext;
        public HomeController()
        {
            cvContext = new CvContext();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Resume() 
        {
            var resume = cvContext.Resumes.ToList();
              
            return View(resume);
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Skills() 
        {
            var skills = cvContext.Skills.ToList();
            return View(skills);
        }

        public ActionResult Project() 
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}