using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SupplierController : Controller
    {
       static List<Supplier> suppliers = new List<Supplier>()
        {
            new Supplier(){ Id=1, Name="Name-1", Mobile="Mobile-1", Email="Email-1", Address="Address-1"},
            new Supplier(){ Id=2, Name="Name-2", Mobile="Mobile-2", Email="Email-2", Address="Address-2"},
            new Supplier(){ Id=3, Name="Name-3", Mobile="Mobile-3", Email="Email-3", Address="Address-3"},
            new Supplier(){ Id=4, Name="Name-4", Mobile="Mobile-4", Email="Email-4", Address="Address-4"},
            new Supplier(){ Id=5, Name="Name-5", Mobile="Mobile-5", Email="Email-5", Address="Address-5"}
        };
        public ActionResult Index()
        {
            ViewBag.suppliers = suppliers;
            return View();
        }
        [HttpPost]
        public ActionResult SaveSupplier(Supplier s)
        {
            s.Id=suppliers.Count+1;
            suppliers.Add(s);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var s = suppliers.FirstOrDefault(a => a.Id == id);
            if (s!=null)
            {
                suppliers.Remove(s);
            }
            return RedirectToAction("Index");
        }





    }
}