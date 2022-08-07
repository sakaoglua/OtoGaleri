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
    public class MusterilerController : Controller
    {
        // GET: Musteriler
        MusteriManager mm = new MusteriManager(new EfMusterilerDal());
        MusteriValidator musteriValidator = new MusteriValidator();

        public ActionResult Index()
        {
            var Musterivalues = mm.GetList();
            return View(Musterivalues);
        }
        [HttpGet]
        public ActionResult AddMusteri()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMusteri(Musteriler p)
        {
            ValidationResult results = musteriValidator.Validate(p);
            if (results.IsValid)
            {
                mm.MusteriAdd(p);
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
        [HttpGet]
        public ActionResult EditMusteri(int id)
        {
            var musterivalue = mm.GetByID(id);
            return View(musterivalue);
        }
        [HttpPost]
        public ActionResult EditMusteri(Musteriler p)
        {
            ValidationResult results = musteriValidator.Validate(p);
            if (results.IsValid)
            {
                mm.MusteriUpdate(p);
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
        public ActionResult DeleteMusteri(int id)
        {
            var musteriValue = mm.GetByID(id);
            mm.MusteriDelete(musteriValue);
            return RedirectToAction("Index");

        }
    }
}
