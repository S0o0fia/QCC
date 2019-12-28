using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspnetMvcDemo.Controllers
{
    public class ConcreteFactoryReportsController : Controller
    {
        // GET: ConcreteFactoryReports
        public ActionResult ConcreteFactoryReports()
        {
            return View("~/Views/Reports/ConcreteFactoryReports.cshtml");
        }
    }
}