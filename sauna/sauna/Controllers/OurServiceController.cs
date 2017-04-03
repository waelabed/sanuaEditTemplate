using sauna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sauna.Controllers
{
    public class OurServiceController : Controller
    {
        AppDbContect _contecxt = new AppDbContect();

           // GET: OurService
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult GetOurService() 
        {
            var Service = _contecxt.OurServices.ToList();

            return PartialView("GetOurService", Service);
        }
         
    }
}