using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnaliseDeInvestimento.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AnaliseInvestimento()
        {
            
            return View();
        }


        public ActionResult About()
        {
  
            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }
    }
}