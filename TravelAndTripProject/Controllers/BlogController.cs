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
        BlogYorum blogYorum = new BlogYorum();
        public ActionResult Index()
        {
            // var blogs = context.Blogs.ToList();

            blogYorum.deger1 = context.Blogs.ToList();
            blogYorum.deger3 = context.Blogs.OrderByDescending(x=>x.id).Take(3).ToList();
            return View(blogYorum);
        } 
        public ActionResult BlogDetay(int id)
        {
            //   var BlogBul = context.Blogs.Where(x => x.id == id).ToList();

            blogYorum.deger1 = context.Blogs.Where(x => x.id == id).ToList();
            blogYorum.deger2 = context.Yorumlars.Where(x => x.BlogId == id).ToList();
            return View(blogYorum);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.value = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar yorumlar)
        {
            context.Yorumlars.Add(yorumlar);
            context.SaveChanges();
            return PartialView();
        }
    }
}