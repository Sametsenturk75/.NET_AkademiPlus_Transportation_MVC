using AkademiPlus_Transportation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AkademiPlus_Transportation.Controllers
{
    public class DashboardController : Controller
    {
        DB_TransportEntities db = new DB_TransportEntities();
        public ActionResult Index()
        {
            var countAdmin = db.TBL_Admin.Count();
            ViewBag.Count = countAdmin;
            var countProduct = db.TBL_Product.Count();
            ViewBag.CountProduct = countProduct;
            var countCustomer = db.TBL_Customer.Count();
            ViewBag.CountCustomer = countCustomer;
            var categoryCount = db.TBL_Category.Count();
            ViewBag.CategoryCount = categoryCount;
            return View();
        }
    }
}