using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OtoGaleri.Controllers
{
    public class AdminlerController : Controller
    {
        // GET: Musteriler
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Adminler p)
        {
            Context c = new Context();
            var adminuserinfo=c.Adminlers.FirstOrDefault(x=>x.Admin_Name==p.Admin_Name && 
            x.Admin_Surname==p.Admin_Surname);
            if (adminuserinfo!=null)
            {
                FormsAuthentication.SetAuthCookie(adminuserinfo.Admin_Name, false);
                Session["Admin_Name"] = adminuserinfo.Admin_Name;
                return RedirectToAction("Index", "AdminKullanici");
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }



    }
}

