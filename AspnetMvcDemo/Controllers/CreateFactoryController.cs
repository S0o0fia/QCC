using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspnetMvcDemo.Controllers
{
    public class CreateFactoryController : Controller
    {
        // GET: CreateFactory
        public ActionResult Index()
        {
            return View("~/Views/CreateFactory/CreateFactory.cshtml");
        }
    }
}