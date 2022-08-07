using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using DataAccessLayer.EntityFramework;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;

namespace OtoGaleri.Controllers
{
    public class KullanicilarController : Controller
    {
        // GET: KullaniciEkle
        KullaniciManager km = new KullaniciManager(new EfKullanicilarDal());

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetKullaniciList()
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
            //km.KullaniciAddBl(p);
            KullaniciValidator kullaniciValidator = new KullaniciValidator();
            ValidationResult results = kullaniciValidator.Validate(p);
            if (results.IsValid)
            {
                km.KullaniciAdd(p);
                return RedirectToAction("GetKullaniciList");
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
    }


}