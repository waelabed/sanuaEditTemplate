using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sauna.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult gallery()
        {
            return View();
        }
        public ActionResult about()
        {
            return View();
        }
       public ActionResult contact()
        {
            return View();
        }
        public ActionResult icon()
        {
            return View();
        }
        public ActionResult codes()
        {
           return View();
        }
        public ActionResult AnimationImage() 
        {
            return View(); 
        }
  

    }
}