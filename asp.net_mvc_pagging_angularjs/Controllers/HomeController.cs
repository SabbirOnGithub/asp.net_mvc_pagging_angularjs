using asp.net_mvc_pagging_angularjs.Helper;
using asp.net_mvc_pagging_angularjs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp.net_mvc_pagging_angularjs.Controllers
{
    public class HomeController : Controller
    {
        POSEntities context = new POSEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPaggedData(int pageNumber=1,int pageSize=20)
        {
            List<Item> data = context.Items.ToList();
            var paggedData = Paggination.PagedResult(data, pageNumber, pageSize);
            return Json(paggedData, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}