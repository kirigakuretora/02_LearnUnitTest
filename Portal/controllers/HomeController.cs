using PortalLibrary;
using System.Web.Mvc;

namespace Portal.controllers
{
    public class HomeController : System.Web.Mvc.Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var ResultVersion = ArithmeticAssembly.GetArithmeticAssemblyVersion.version;

            var RelArithmeticBase = new ArithmeticBase();
            var Result = RelArithmeticBase.Addition(1, 1);
            var ResultSecound = RelArithmeticBase.AdditionSecound(2.0, 2.1);
            var ResultThird = RelArithmeticBase.Division(22.0, -7.0);

            ViewData["ResultVersion"] = ResultVersion;
            ViewData["Result"] = Result;
            ViewData["ResultSecound"] = ResultSecound;
            ViewData["ResultThird"] = ResultThird;

            return View();
        }


    }
}