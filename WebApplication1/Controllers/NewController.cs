using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Registration()
        {
            UserInformation model = new UserInformation();

            return View(model);
        }
        [HttpPost]
        public ActionResult Registration(UserInformation model)
        {
            if (model.FirstName == model.LastName)
            {
                ModelState.AddModelError("LastName", "The last name cannot be the same as the first name.");
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Index");
           
        }
        public ActionResult Result(UserInformation u)
        {
           
            ViewBag.FirstName = u.FirstName;
            ViewBag.Email = u.Email;

            return View();
        }
    }   
}