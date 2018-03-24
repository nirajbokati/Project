using System.Linq;
using System.Web.Mvc;
using TourPlanner.Models.model;

namespace TourPlanner.Controllers
{
    public class BaseController : Controller
    {
        TourPlannerEntities1 TP = new TourPlannerEntities1();

        public ActionResult Index1()
        {

            var model1 = TP.dbNavSelect().Select(d => new menu()
            {
                MenuName = d.MenuName,
                Menuhref = d.Menuhref,
            }).ToList();

            return PartialView("_menulist",model1);
        }
    }
}