using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            //Aggregate --> Sum Count Avg Min Max
            ViewBag.v1 = db.Tbl_Category.Count();
            ViewBag.v2 = db.Tbl_Project.Count();
            ViewBag.v3 = db.Tbl_Contact.Count();
            ViewBag.v4 = db.Tbl_Project.Where(x=> x.ProjectCategory==1).Count();
            ViewBag.v5 = db.Tbl_Contact.Where(x=> x.IsRead==false).Count();
            ViewBag.v6 = db.LastProjectName().FirstOrDefault();
            ViewBag.v7 = db.Tbl_Service.Count();
            ViewBag.v8 = db.LastAspCoreProject5().FirstOrDefault();

            return View();
        }
    }
}