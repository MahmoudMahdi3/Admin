using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Mailbox()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Form()
        {
            ViewBag.Message = "Fill the form.";

            return View();
        }

        public ActionResult compose()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}