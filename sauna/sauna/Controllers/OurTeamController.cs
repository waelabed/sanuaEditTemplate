using sauna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sauna.Controllers
{
    public class OurTeamController : Controller
    {
        AppDbContect _context = new AppDbContect();
        // GET: OurTeam
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetTeams() 
        {
          var  Teams = _context.Teams.ToList().OrderByDescending(G=>G.TeamId);
            return PartialView("GetTeams",Teams); 
        }
        [HttpGet]
        public ActionResult Create()
        {
         
            return View();
        }
        [HttpPost]
        public ActionResult Create( TeamVn Teams) 
        {

            ModelState.Remove("Img"); 
                if (ModelState.IsValid) 
                {

                Teams.Img = Teams.attachfile.FileName; 
                        _context.Teams.Add(parse(Teams));
                Teams.attachfile.SaveAs(Server.MapPath("~\\images\\team\\" + Teams.Img ));
                        _context.SaveChanges();  
                        return View(); 
                }
             return View(); 
         }
         private Team parse(TeamVn item) 
         {
            Team details = new Team
            {
                FaceBookUrl = item.FaceBookUrl,
                GooglePlusUrl = item.GooglePlusUrl,
                Name = item.Name,
                TeamId = item.TeamId,
                TwitterUrl = item.TwitterUrl,
                Img = item.Img
            };
            return details;
         } 
         public  ActionResult HOMEWORK() 
         {
            return View();

        }
    }
}