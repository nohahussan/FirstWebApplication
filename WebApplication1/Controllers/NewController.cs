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
        public ActionResult Result(UserInformation u)
        {
            ViewBag.FirstName = u.FirstName;
            ViewBag.Email = u.Email;

            return View();
        }
    }   
}