using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace _1Destiny.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }
        

        public ActionResult SDK()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Resources()
        {
            ViewBag.Message = "Your Resource page";

            return View();
        }
        public ActionResult Tools()
        {
            ViewBag.Message = "Your Resource page";

            return View();
        }
        public void QuickAssist()
        {
            Process p = new Process();
            p.StartInfo.FileName = "C:\\Windows\\System32\\quickassist.exe";
            p.Start();
        }
        
    }
}