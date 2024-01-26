using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult FeaturePartial()
        {
            var values = db.Tbl_Future.ToList();
            return PartialView(values);
        }
        public PartialViewResult AboutPartial()
        {
            var values = db.Tbl_About.ToList();
            return PartialView(values);
        }
        public PartialViewResult ServicePartial()
        {
            var values = db.Tbl_Service.ToList();
            return PartialView(values);
        }
        public PartialViewResult ProjectPartial()
        {
            var values = db.Tbl_Project.ToList();
            return PartialView(values);
        }
        public PartialViewResult TestimonialPartial()
        {
            var values = db.Tbl_Testimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult ContactPartial()
        {
            var values = db.Tbl_Contact.ToList();
            return PartialView(values);
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}