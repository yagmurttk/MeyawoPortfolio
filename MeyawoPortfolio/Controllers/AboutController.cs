using MeyawoPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeyawoPortfolio.Controllers
{
    public class AboutController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.Tbl_About.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAbout(Tbl_About about)
        {
            db.Tbl_About.Add(about);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAbout(int id)
        {
            var about = db.Tbl_About.Find(id);
            db.Tbl_About.Remove(about);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateAbout(int id)
        {
            var about = db.Tbl_About.Find(id);
            return View(about);
        }
        [HttpPost]
        public ActionResult UpdateAbout(Tbl_About p)
        {
            var about = db.Tbl_About.Find(p.AboutID);
            about.Title = p.Title;
            about.Header = p.Header;
            about.Description = p.Description;
            about.ImageUrl = p.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}