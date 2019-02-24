using PortalLibrary;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Portal.controllers
{
    public class HomeController : System.Web.Mvc.Controller
    {
        ArithmeticBase RelArithmeticBase = new ArithmeticBase();

        public ActionResult Index()
        {   
            // 1.
            var Result = RelArithmeticBase.Addition(1, 1);
            var ResultSecound = RelArithmeticBase.AdditionSecound(2.0, 2.1);
            var ResultThird = RelArithmeticBase.Division(22.0, -7.0);

            // 2.
            var ResultList = new List<Double>();
            ResultList.Add(Result);
            ResultList.Add(ResultSecound);
            ResultList.Add(ResultThird);

            return View(ResultList);
        }


    }
}