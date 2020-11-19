using MvcSchemaFIrst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSchemaFIrst.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/
        BUssiness_Layer ob = new BUssiness_Layer();

        public ActionResult Index()
        {
            
            return View(ob.list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product p)
        {
            int a = ob.AddProduct(p);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            Product temp = ob.Display(Id);
            return View(temp);
        }

       [HttpPost, ActionName("Delete")]
        public ActionResult Deleteka(int a)
        {
           int b= ob.DelProduct(a);
           return RedirectToAction("Index");
        }

       public ActionResult details(int ID)
       {
           Product temp = ob.Display(ID);
           return View(temp);
       }

        [HttpGet]
       public ActionResult Edit(int ID)
       {
           Product p = ob.Display(ID);
           return View(p);
       }

       [HttpPost]
       public ActionResult Edit(Product k)
       {
           int p = ob.update(k);
           return RedirectToAction("Index");
       }
    }
}
