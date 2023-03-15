using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        DB_TransportEntities db = new DB_TransportEntities();
        public ActionResult Index()
        {
            var values = db.TBL_Category.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(TBL_Category tbl_category)
        {
            db.TBL_Category.Add(tbl_category);
            db.SaveChanges();
            return View();
        }

        public ActionResult DeleteCategory(int id)
        {
            var value = db.TBL_Category.Find(id);
            db.TBL_Category.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var value = db.TBL_Category.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateCategory(TBL_Category tbl_category)
        {
            var value = db.TBL_Category.Find(tbl_category.CategoryID);
            value.CategoryName = tbl_category.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}