using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FibMVC.Biz;

namespace FibMVC.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            List<int> fifteenFibs = new List<int>();
            Fib fibInstance = new Fib();

            fifteenFibs = fibInstance.returnListOfFib(15);
            ViewData["fifteenFibs"] = fifteenFibs;

            return View();
        }
    }
}