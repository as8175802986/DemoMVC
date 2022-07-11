using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExample5.Controllers
{
    public class WebinarController : Controller
    {
        // GET: Webinar
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(string FullName , string Age, string Contact, string Email)
        {
            TempData["FullName"] = FullName;
            TempData["Age"] = Age;
            TempData["Contact"] = Contact;
            TempData["email"] = Email;
            return RedirectToAction("Confirmation");
            //return View();
        }
        public ActionResult Confirmation()
        {
            return View();
        }
    }
}