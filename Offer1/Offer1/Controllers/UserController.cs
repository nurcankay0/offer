using Offer1.Models.Context;
using Offer1.Models.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Offer1.Controllers
{
    public class UserController : Controller
    {
        MvcOfferContext db = new MvcOfferContext();
        // GET: User
        public ActionResult Index()
        {
            var users = db.Users.ToList();
            return View(users);
        }
        [HttpGet]
        public ActionResult Offer()
        {
         
            return View();
        }
        [HttpPost]
        public ActionResult Offer(User user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                TempData["BasariliMesaj"] = "Ekleme İşlemi Başarıyla Gerçekleşti";
            }
            catch (Exception)
            {
                TempData["HataliMesaj"] = "Hata Oluştu! Lütfen Yeniden Teklif Verin";
            }
            return RedirectToAction("Index");
        }
    }
}