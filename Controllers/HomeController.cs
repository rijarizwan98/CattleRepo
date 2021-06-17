using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace cattle.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var mvcName = typeof(Controller).Assembly.GetName();
            //var isMono = Type.GetType("Mono.Runtime") != null;

            //ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            //ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            return View();
        }

        public ActionResult homepage()
        {
            return View();
        }
        public ActionResult seller()
        {
            return View();
        }
        public ActionResult nexthome()
        {
            return RedirectToAction("homepage");
        }
       
        public ActionResult history()
        {
            return View();
        }
        public ActionResult butcher()
        {
            return View();

        }
        public ActionResult categoryform()
        {
            return View();

        }
        public ActionResult categoryform1()
        {
            return View();

        }
        public ActionResult categoryform2()
        {
            return View();

        }
        public ActionResult checkout()
        {
            return View();

        }
        public ActionResult camel()
        {
            return View();

        }
        public ActionResult bull()
        {
            return View();

        }
        public ActionResult buffalo()
        {
            return View();

        }
        public ActionResult sheep()
        {
            return View();

        }
        public ActionResult categoryformc()
        {
            return View();

        }
        public ActionResult categoryformc1()
        {
            return View();

        }
        public ActionResult c2()
        {
            return View();
        }
        public ActionResult b1()
        {
            return View();
        }
        public ActionResult b2()
        {
            return View();
        }
        public ActionResult b3()
        {
            return View();
        }
        public ActionResult bb1()
        {
            return View();
        }
        public ActionResult bb2()
        {
            return View();
        }
        public ActionResult bb3()
        {
            return View();
        }

        public ActionResult S1()
        {
            return View();
        }
        public ActionResult S2()
        {
            return View();
        }
        public ActionResult S3()
        {
            return View();
        }
        public ActionResult ex()
        {
            return View();
        }

        public ActionResult cart()
        {
            return View();
        }

    }
}
