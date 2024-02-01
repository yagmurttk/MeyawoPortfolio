using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;


namespace MeyawoPortfolio.Controllers
{
    public class DashboardController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();

        // GET: Dashboard
        public ActionResult Index()
        {
            ViewBag.categoryCount = db.Tbl_Category.Count();
            ViewBag.projectCount = db.Tbl_Project.Count();
            ViewBag.messageCount = db.Tbl_Contact.Count();
           


            return View();
        }
    }
}