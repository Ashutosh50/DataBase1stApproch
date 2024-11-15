using DatabasefirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabasefirstApproach.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public readonly DemoEntities _demo;
        public DemoController() 
        {
         _demo=new DemoEntities();
        }
        public ActionResult Getall()
        {
            var db = _demo.Stables.ToList();
            return View(db);
        }
    }
}