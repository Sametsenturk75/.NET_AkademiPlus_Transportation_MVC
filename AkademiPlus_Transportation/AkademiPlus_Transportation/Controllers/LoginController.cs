using AkademiPlus_Transportation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AkademiPlus_Transportation.Controllers
{
    public class LoginController : Controller
    {
        DB_TransportEntities db=new DB_TransportEntities();


        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TBL_Admin tbl_admin) 
        {
            var values = db.TBL_Admin.Where(x => x.UserName == tbl_admin.UserName & x.Password == tbl_admin.Password).FirstOrDefault();
            if (values != null) 
            {
                FormsAuthentication.SetAuthCookie(values.UserName, false);
                Session["UserName"] = tbl_admin.UserName;
                return RedirectToAction("Index","Customer");
            }
            return View();
        }
    }
}