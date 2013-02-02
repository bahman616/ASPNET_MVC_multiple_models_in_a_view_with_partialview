using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_Multiple_Models_In_A_View.Models;

namespace ASP_NET_MVC_Multiple_Models_In_A_View.Controllers
{
    public class CompanyController : Controller
    {
        private dbEntities db = new dbEntities();
        //
        // GET: /Company/

        public ActionResult Index()
        {
            return View(db.Companies.ToList());
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


    }
}
