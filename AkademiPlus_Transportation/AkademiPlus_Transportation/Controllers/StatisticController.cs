using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class StatisticController : Controller
    {
        DB_TransportEntities db = new DB_TransportEntities();
        public ActionResult Index()
        {

            ViewBag.customerCount = db.TBL_Customer.Count();
            ViewBag.cityAnkara = db.TBL_Customer.Where(x => x.CustomerCity == "Ankara").Count();
            ViewBag.categoryCount = db.TBL_Category.Count();
            ViewBag.citySelect = db.TBL_Customer.Where(x => x.CustomerID == 1).Select(y => y.CustomerCity).FirstOrDefault();
            return View();
        }
    }
}