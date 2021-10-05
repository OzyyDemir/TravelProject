using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelAndTripProject.Models.Classes;

namespace TravelAndTripProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin 
        Context context = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var values = context.Blogs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult BlogEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BlogEkle(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogSil(int id)
        {
            var blog = context.Blogs.Find(id);
            context.Blogs.Remove(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogGetir(int id)
        {
            var blog = context.Blogs.Find(id);
            return View("BlogGetir", blog);
        }

        public ActionResult BlogGuncelle(Blog blog)
        {
            var guncellenenBlog = context.Blogs.Find(blog.id);
            guncellenenBlog.Aciklama = blog.Aciklama;
            guncellenenBlog.Baslik = blog.Baslik;
            guncellenenBlog.Tarih = blog.Tarih;
            guncellenenBlog.BlogImage = blog.BlogImage;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YorumListesi()
        {
            var yorumlar = context.Yorumlars.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumSil(int id)
        {
            var yorum = context.Yorumlars.Find(id);
            context.Yorumlars.Remove(yorum);
            context.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult YorumGetir(int id)
        {
            var yorum = context.Yorumlars.Find(id);
            return View("YorumGetir", yorum);
        }

        public ActionResult YorumGuncelle(Yorumlar yorumlar)
        {
            var guncellenenYorum = context.Yorumlars.Find(yorumlar.id);
            guncellenenYorum.KullaniciAdi = yorumlar.KullaniciAdi;
            guncellenenYorum.Mail = yorumlar.Mail;
            guncellenenYorum.Yorum = yorumlar.Yorum;
            guncellenenYorum.BlogId = yorumlar.BlogId;
            context.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}