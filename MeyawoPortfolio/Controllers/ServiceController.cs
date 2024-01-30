using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class ServiceController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.Tbl_Service.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddService(Tbl_Service service)
        {
            db.Tbl_Service.Add(service);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteService(int id)
        {
            var service = db.Tbl_Service.Find(id);
            db.Tbl_Service.Remove(service);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var service = db.Tbl_Service.Find(id);
            return View(service);
        }
        [HttpPost]
        public ActionResult UpdateService(Tbl_Service p)
        {
            var service = db.Tbl_Service.Find(p.ServiceID);
            service.Title = p.Title;
            service.Description = p.Description;
            service.ImageUrl = p.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}