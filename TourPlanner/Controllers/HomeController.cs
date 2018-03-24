using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TourPlanner.Models;
using TourPlanner.Models.model;

namespace TourPlanner.Controllers
{
    public class HomeController : BaseController
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {      
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
       

        public ActionResult OfferPackage()
        {


            return View();
        }

        
        public ActionResult DestinationDetails()
        {
            using (TourPlannerEntities1 Obj = new TourPlannerEntities1())
            {
                List<tblPackage> pag = Obj.tblPackages.ToList();
                return View(pag);
            }
        }

        public ActionResult Destination()
        {
           return View();                 
        }

    }
}

