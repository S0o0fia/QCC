using AspnetMvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspnetMvcDemo.Controllers
{
    public class AuthenticationController : Controller
    {
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            UserLogin UserLogin = new UserLogin();
            return View(UserLogin);
        }

        [HttpPost]
        public ActionResult Login(UserLogin MM, string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            ViewBag.Message = "";

            if (ModelState.IsValid)
            {
                //var user = db.UserAuthentication.Where(u => u.UserName == MM.UserName && u.Password == MM.Password).Select(u => new { u.CustomerId, u.Password }).FirstOrDefault();
                var user = new UserLogin { UserName = "admin", Password = "admin" };
                if (user != null && string.Compare(user.Password, MM.Password) == 0)
                {

                    //Session["CustomerID"] = user.CustomerId;
                    if (returnUrl == null)
                    {
                        //return View("~/Views/Home/Home.cshtml");
                        return RedirectToAction("Home", "Home");
                        //return Redirect(returnUrl);
                    }
                    else
                    {
                        //return View("~/Views/Home/Home.cshtml");
                        return RedirectToAction("Home", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }


            }
            // If we got this far, something failed, redisplay form
            return View("Login", MM);
        }
    }
}