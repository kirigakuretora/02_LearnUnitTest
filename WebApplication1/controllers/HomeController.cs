using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var RelArithmeticBase = new ArithmeticBase();
            var Result = RelArithmeticBase.Arithmetic(1, 1);
            var ResultSecound = RelArithmeticBase.ArithmeticSecound(2.0, 2.1);
            ViewData["Result"] = Result;
            ViewData["ResultSecound"] = ResultSecound;
            return View();
        }
    }
}