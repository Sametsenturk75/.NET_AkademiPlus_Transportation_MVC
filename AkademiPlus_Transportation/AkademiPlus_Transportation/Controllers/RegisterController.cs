using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class RegisterController : Controller
    {
        DB_TransportEntities db = new DB_TransportEntities();


        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TBL_Admin tbl_admin)
        {
            db.TBL_Admin.Add(tbl_admin);
            db.SaveChanges();
            return RedirectToAction("Index","Login");
        }
    }
}