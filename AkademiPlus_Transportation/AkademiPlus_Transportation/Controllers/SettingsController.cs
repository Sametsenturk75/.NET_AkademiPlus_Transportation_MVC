using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class SettingsController : Controller
    {
        DB_TransportEntities db = new DB_TransportEntities();


        [HttpGet]
        public ActionResult Index()
        {
            var values = Session["UserName"];
            var userValue = db.TBL_Admin.Where(x => x.UserName == values).FirstOrDefault();
            return View(userValue);
        }

        [HttpPost]
        public ActionResult Index(TBL_Admin tbl_admin)
        {

            return View();
        }
    }
}