using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                string hashed = FormsAuthentication.HashPasswordForStoringInConfigFile(model.Password, "SHA1");                
                if (FormsAuthentication.Authenticate(model.Name, hashed))
                {
                    FormsAuthentication.SetAuthCookie(model.Name, true);
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    ModelState.AddModelError("", "Неверный логин/пароль");
                }
            }
            return View(model);
        }
        
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}