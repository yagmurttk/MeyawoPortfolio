using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class TestimonialController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.Tbl_Testimonial.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTestimonial(Tbl_Testimonial testimonial)
        {
            db.Tbl_Testimonial.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var testimonial = db.Tbl_Testimonial.Find(id);
            db.Tbl_Testimonial.Remove(testimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var testimonial = db.Tbl_Testimonial.Find(id);
            return View(testimonial);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Tbl_Testimonial p)
        {
            var testimonial = db.Tbl_Testimonial.Find(p.TestimonialID);
            testimonial.NameSurname = p.NameSurname;
            testimonial.Description = p.Description;
            testimonial.Image = p.Image;
            testimonial.Status = p.Status;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}