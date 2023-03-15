using AkademiPlus_Transportation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace AkademiPlus_Transportation.Controllers
{
    public class ProductController : Controller
    {
        DB_TransportEntities db = new DB_TransportEntities();
        public ActionResult Index()
        {
            var values = db.TBL_Product.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddProduct()
        {
            List<SelectListItem> values = (from x in db.TBL_Category
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v=values;
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(TBL_Product tbl_product)
        {

            db.TBL_Product.Add(tbl_product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProduct(int id)
        {
            var values = db.TBL_Product.Find(id);
            db.TBL_Product.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            var values = db.TBL_Product.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateProduct(TBL_Product tbl_product)
        {
            var values = db.TBL_Product.Find(tbl_product.ProductID);
            values.ProductName = tbl_product.ProductName;
            values.ProductSizeType = tbl_product.ProductSizeType;
            values.ProductSize = tbl_product.ProductSize;
            values.ProductDescription = tbl_product.ProductDescription;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}