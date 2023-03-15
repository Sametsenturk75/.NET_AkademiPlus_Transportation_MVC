using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AkademiPlus_Transportation.Controllers
{
    public class ProfileController : Controller
    {
        //Partial View
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Partial1() 
        {
            return PartialView();        
        }
        public PartialViewResult Partial2()
        {
            return PartialView();
        }
    }
}