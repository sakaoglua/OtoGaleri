using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtoGaleri.Controllers
{
    public class AdminKullaniciController : Controller
    {
        // GET: AdminKullanici
        KullaniciManager km = new KullaniciManager(new EfKullanicilarDal());
        [Authorize]

        public ActionResult Index()
        {
            var kullanicivalues = km.GetList();
            return View(kullanicivalues);
        }
        [HttpGet]
        public ActionResult AddKullanici()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddKullanici(Kullanicilar p)
        {
            KullaniciValidator kullaniciValidator = new KullaniciValidator();
            ValidationResult results = kullaniciValidator.Validate(p);
            if (results.IsValid)
            {
                km.KullaniciAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public ActionResult DeleteKullanici(int id)
        {
            var kullanicivalue = km.GetByID(id);
            km.KullaniciDelete(kullanicivalue);
            return RedirectToAction("Index");
            
        }
        [HttpGet]
        public ActionResult EditKullanicilar(int id)
        {
            var kullaniciValue = km.GetByID(id);
            return View(kullaniciValue);

        }

        [HttpPost]
        public ActionResult EditKullanicilar(Kullanicilar p)
        {
            km.KullaniciUpdate(p);
            return RedirectToAction("Index");

        }
    }
}