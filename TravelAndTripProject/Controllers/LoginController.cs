using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelAndTripProject.Models.Classes;

namespace TravelAndTripProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context context = new Context();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var isTrue = context.Admins.FirstOrDefault
                (x => x.Kullanici == admin.Kullanici && x.Sifre == admin.Sifre);
            if (isTrue!=null)
            {
                FormsAuthentication.SetAuthCookie(isTrue.Kullanici, false);
                Session["Kullanici"] = isTrue.Kullanici.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login"); 
        }
    }
}