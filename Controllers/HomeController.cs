using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calc(double a, double b, string action)
        {
            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.action = action;
            switch (action)
            {
                case "+": { ViewBag.result = a + b; } break;
                case "-": { ViewBag.result = a - b; } break;
                case "*": { ViewBag.result = a * b; } break;
                case "/": { ViewBag.result = a / b; } break;
                default: ViewBag.result = ""; break;
            }
            return View();
        }
    }
}