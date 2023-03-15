using AkademiPlus_Transportation.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AkademiPlus_Transportation.Controllers
{
    public class MainPageController : Controller
    {
        DB_TransportEntities db = new DB_TransportEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialSlider()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.TBL_About.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialDetail()
        {
            ViewBag.leftTitle1 = "Güvenli Taşımacılık";
            ViewBag.leftTitle2 = "Dünyanın Her Yerine Tüm Kargolar";
            ViewBag.leftTitle3 = "Konumu Fark etmeksizin, doğudan batıya, kuzeyden güneye en uzak noktalara uzman ekibimizle güvenli teslimat yapıyoruz.";
            ViewBag.rightTitle1 = "Taşıma Kolaylığı";
            ViewBag.rightTitle2 = "Kendi Ambalajlarımız ile kargolarınızı paketliyoruz.";
            ViewBag.rightTitle3 = "Şehir İçi Dağıtım.";
            ViewBag.rightTitle4 = "İstediğiniz satte evlerinize veya belirlediğiniz yere teslimat yapmaktayız.";
            return PartialView();
        }
        public PartialViewResult PartialScript() 
        {
        
          return  PartialView();    
        }
        public PartialViewResult PartialMap()
        {

            return PartialView();
        }
    }
}