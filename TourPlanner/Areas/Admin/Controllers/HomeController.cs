using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TourPlanner.Models.model;

namespace TourPlanner.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        TourPlannerEntities1 Obj = new TourPlannerEntities1();
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Destination()
        {

            using (TourPlannerEntities1 Obj = new TourPlannerEntities1())
            {
                List<tblPackage> pag = Obj.tblPackages.ToList();
                return View(pag);
            }
        }
        public ActionResult Slider()
        {
            return View();
        }

        public ActionResult User()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult AddDestination()
        {
            return View();
        }

        public ActionResult AddDetails()
        {
            return View();
        }

        public ActionResult BookingDetails()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDestination(tblPackage pacg, HttpPostedFileBase file)
        {
            TourPlannerEntities1 TP = new TourPlannerEntities1();
            if (file != null)
            {
                string ImageName = System.IO.Path.GetFileName(file.FileName);
                string physicalPath = Server.MapPath("~/Content/Images/" + ImageName);
                file.SaveAs(physicalPath);
                pacg.PackageImage = ImageName;
            }

            TP.tblPackages.Add(pacg);
            TP.SaveChanges();
            return RedirectToAction("Destination");

        }

        public ActionResult Delete(int ? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            tblPackage packagedetalis = Obj.tblPackages.Find(id);
            if (packagedetalis == null)
            {
                return HttpNotFound();
            }
            return View(packagedetalis);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            tblPackage packagedetalis = Obj.tblPackages.Find(id);
            Obj.tblPackages.Remove(packagedetalis);
            Obj.SaveChanges();
            return RedirectToAction("Destination");
        }
        public ActionResult Update(int? id)
        {
          if (id == null)
            {
              return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPackage packagedetalis = Obj.tblPackages.Find(id);
            if (packagedetalis == null)
            {
                return HttpNotFound();
            }
            return View(packagedetalis);
        }

        [HttpPost, ActionName("Update")]
        public ActionResult Update(tblPackage pac, HttpPostedFileBase file)
        {
            if (file != null)
            {
                string ImageName = System.IO.Path.GetFileName(file.FileName);
                string physicalPath = Server.MapPath("~/Content/Images/" + ImageName);
                file.SaveAs(physicalPath);
                pac.PackageImage = ImageName;

            }
            Obj.Entry(pac).State = System.Data.Entity.EntityState.Modified;
            Obj.SaveChanges();
            return RedirectToAction("Destination");
        }
    }
}