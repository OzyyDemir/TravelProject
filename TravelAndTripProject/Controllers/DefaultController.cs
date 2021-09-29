using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelAndTripProject.Models.Classes;

namespace TravelAndTripProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context context = new Context();
        public ActionResult Index()
        {
            var values = context.Blogs.Take(4).ToList();
            return View(values);
        }

        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var values = context.Blogs.OrderByDescending(x => x.id).Take(2).ToList();
            return PartialView(values);
        }

        public PartialViewResult Partial2()
        {
            var values = context.Blogs.Where(x => x.id == 1).ToList();
            return PartialView(values);
        }

        public PartialViewResult Partial3()
        {
            var values = context.Blogs.ToList();
            return PartialView(values);
        }

        public PartialViewResult Partial4()
        {
            var values = context.Blogs.Take(3).ToList();
            return PartialView(values);
        }
    }
}