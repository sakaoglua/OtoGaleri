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
    public class SubelerController : Controller
    {
        // GET: Subeler

        SubeManager sm = new SubeManager(new EfSubelerDal());
        SubeValidator subeValidator = new SubeValidator();

        public ActionResult Index()
        {
            var subeValues = sm.GetList();
            return View(subeValues);
        }
        [HttpGet]
        public ActionResult AddSube()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSube(Subeler p)
        {
            ValidationResult results = subeValidator.Validate(p);
            if (results.IsValid)
            {
                sm.SubeAdd(p);
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
        public ActionResult EditSube(int id)
        {
            List<SelectListItem> valuecategory = (from x in sm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.S_Name,
                                                      Value = x.Id.ToString()
                                                  }).ToList();
            ViewBag.vlc = valuecategory;
            var aracValue = sm.GetByID(id);
            return View();
        }
        [HttpPost]
        public ActionResult EditSube(Subeler p)
        {
            sm.SubeUpdate(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSube(int id)
        {
            var subeValue = sm.GetByID(id);
            sm.SubeDelete(subeValue);
            return RedirectToAction("Index");

        }
    }
}