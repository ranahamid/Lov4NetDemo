using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace Lov4NetV3.Controllers
{
  

    public class HomeController : Controller
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ActionResult Index()
        {
            log.Info("info msg");
            return View();
        }

        public ActionResult About()
        {
            //if(log.IsInfoEnabled)
            log.Error("error msg");
            log.Fatal("Fatal msg");
            log.Warn("warn msg");
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            log.Debug("debug msg");
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}