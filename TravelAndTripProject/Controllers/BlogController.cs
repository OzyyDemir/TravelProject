using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelAndTripProject.Models.Classes;

namespace TravelAndTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context context = new Context();
        public ActionResult Index()
        {
            var blogs = context.Blogs.ToList();
            return View(blogs);
        }

        public ActionResult BlogDetay(int id)
        {
            return View();
        }
    }
}