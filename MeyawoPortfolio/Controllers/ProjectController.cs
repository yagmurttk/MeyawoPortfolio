using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class ProjectController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.Tbl_Project.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddProject()
        {
            ViewBag.categories = new SelectList(db.Tbl_Category.ToList(), "CategoryID", "CategoryName");
            return View();
        }
        [HttpPost]
        public ActionResult AddProject(Tbl_Project project)
        {
            db.Tbl_Project.Add(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProject(int id)
        {
            var project = db.Tbl_Project.Find(id);
            db.Tbl_Project.Remove(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            ViewBag.categories = new SelectList(db.Tbl_Category.ToList(), "CategoryID", "CategoryName");
            var project = db.Tbl_Project.Find(id);
            return View(project);
        }
        [HttpPost]
        public ActionResult UpdateProject(Tbl_Project p)
        {
            var project = db.Tbl_Project.Find(p.ProjectID);
            project.Title = p.Title;
            project.Description = p.Description;
            project.ImageUrl = p.ImageUrl;
            project.ProjectUrl = p.ProjectUrl;
            project.ProjectCategory = p.ProjectCategory;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}