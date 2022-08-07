using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtoGaleri.Controllers
{
    public class AraclarController : Controller
    {
        // GET: Musteriler
        AracManager arm = new AracManager(new EfAraclarDal());
        AracValidator aracValidator = new AracValidator();

        public ActionResult Index()
        {
            var Aracvalues = arm.GetList();
            return View(Aracvalues);
        }
        [HttpGet]
        public ActionResult AddArac()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddArac(Araclar p)
        {
            ValidationResult results = aracValidator.Validate(p);
            if (results.IsValid)
            {
                arm.AracAdd(p);
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
        public ActionResult EditArac(int id)
        {
            List<SelectListItem> valuecategory = (from x in arm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.A_Marka,
                                                      Value = x.Id.ToString()
                                                  }).ToList();
            ViewBag.vlc = valuecategory;
            var aracValue = arm.GetByID(id);
            return View();
        }
        [HttpPost]
        public ActionResult EditArac(Araclar p)
        {
            arm.AracUpdate(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteArac(int id)
        {
            var aracValue = arm.GetByID(id);
            arm.AracDelete(aracValue);
            return RedirectToAction("Index");

        }
    }
}