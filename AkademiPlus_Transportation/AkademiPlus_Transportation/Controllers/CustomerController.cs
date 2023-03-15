using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    
    public class CustomerController : Controller
    {
        DB_TransportEntities db = new DB_TransportEntities();
        public ActionResult Index()
        {
            var values = db.TBL_Customer.ToList();
            return View(values);
        }



        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddCustomer(TBL_Customer tbl_customer)
        {
            db.TBL_Customer.Add(tbl_customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCustomer(int id)
        {
            var value = db.TBL_Customer.Find(id);
            db.TBL_Customer.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCustomer(int id)
        {
            var value = db.TBL_Customer.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateCustomer(TBL_Customer tbl_customer)
        {
            var value = db.TBL_Customer.Find(tbl_customer.CustomerID);
            value.CustomerName = tbl_customer.CustomerName;
            value.CustomerSurname = tbl_customer.CustomerSurname;
            value.CustomerCity = tbl_customer.CustomerCity;
            value.CustomerPhone = tbl_customer.CustomerPhone;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}