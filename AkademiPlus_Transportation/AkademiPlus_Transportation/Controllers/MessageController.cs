using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AkademiPlus_Transportation.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Index2()
        {
            return View();
        }
    }
}