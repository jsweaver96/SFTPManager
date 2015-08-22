using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SFTPManager.Models;

namespace SFTPManager.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {

        }

        // GET: ResetPassword
        public ActionResult ResetPassword()
        {
            return View();
        }

        // POST: ResetPassword
        [HttpPost]
        public ActionResult ResetPassword(ResetModel model)
        {

        }

        // GET: ChangePassword
        public ActionResult ChangePassword()
        {
            return View();
        }

        // POST: ChangePassword
        [HttpPost]
        public ActionResult ChangePassword(ChangeModel model)
        {

        }

        // POST: Logout
        [HttpPost]
        public ActionResult Logout()
        {

        }
    }
}