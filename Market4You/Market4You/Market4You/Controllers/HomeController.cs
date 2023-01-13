using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Market4You.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Categorias()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Feiras()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}