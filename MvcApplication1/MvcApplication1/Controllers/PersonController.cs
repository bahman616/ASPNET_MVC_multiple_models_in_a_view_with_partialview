using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_Multiple_Models_In_A_View.Models;

namespace ASP_NET_MVC_Multiple_Models_In_A_View.Controllers
{
    public class PersonController : Controller
    {
        private dbEntities db = new dbEntities();

        //
        // GET: /Person/

        public ActionResult Index()
        {
            return View(db.Persons.ToList());
        }

        //
        // GET: /Person/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Person/Create

        [HttpPost]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                db.Persons.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(person);
        }


        public ActionResult _CompanyCreate()
        {
            return View();
        }

        //
        // POST: /Person/Create

        [HttpPost]
        public ActionResult _CompanyCreate(Company company)
        {
            if (ModelState.IsValid)
            {
                db.Companies.Add(company);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(company);
        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}