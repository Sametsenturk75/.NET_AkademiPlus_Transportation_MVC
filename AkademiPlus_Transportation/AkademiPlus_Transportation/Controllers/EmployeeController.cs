using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class EmployeeController : Controller
    {
        DB_TransportEntities db = new DB_TransportEntities();
        public ActionResult Index()
        {
            var values = db.TBL_Employee.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddEmployee(TBL_Employee tbl_employee)
        {
            db.TBL_Employee.Add(tbl_employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateEmployee(int id) 
        { 
            var value=db.TBL_Employee.Find(id);
            return View(value);
        }


        [HttpPost]
        public ActionResult UpdateEmployee(TBL_Employee tbl_employee) 
        {
            var value = db.TBL_Employee.Find(tbl_employee.EmployeeID);
            value.EmployeeName = tbl_employee.EmployeeName;
            value.EmployeeSurname = tbl_employee.EmployeeSurname;
            value.EmployeeImage = tbl_employee.EmployeeImage;
            value.EmployeeDescription = tbl_employee.EmployeeDescription;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}