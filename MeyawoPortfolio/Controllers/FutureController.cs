using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class FutureController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.Tbl_Future.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddFuture()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddFuture(Tbl_Future future)
        {
            db.Tbl_Future.Add(future);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteFuture(int id)
        {
            var future = db.Tbl_Future.Find(id);
            db.Tbl_Future.Remove(future);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateFuture(int id)
        {
            var future = db.Tbl_Future.Find(id);
            return View(future);
        }
        [HttpPost]
        public ActionResult UpdateFuture(Tbl_Future p)
        {
            var future = db.Tbl_Future.Find(p.FutureID);
            future.Header = p.Header;
            future.NameSurname = p.NameSurname;
            future.Title = p.Title;
            future.ProjectUrl = p.ProjectUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}