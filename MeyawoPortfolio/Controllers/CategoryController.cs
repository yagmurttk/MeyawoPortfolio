using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class CategoryController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var ktgr = db.Tbl_Category.ToList();
            return View(ktgr);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Tbl_Category ktgr)
        {
            db.Tbl_Category.Add(ktgr);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCategory(int id)
        {
            var ktgr = db.Tbl_Category.Find(id);
            db.Tbl_Category.Remove(ktgr);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var ktgr = db.Tbl_Category.Find(id);
            return View(ktgr);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Tbl_Category p)
        {
            var ktgr = db.Tbl_Category.Find(p.CategoryID);
            ktgr.CategoryName = p.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}