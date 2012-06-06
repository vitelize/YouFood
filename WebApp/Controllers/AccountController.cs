using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Login()
        {
            ViewBag.aspProvider = Membership.Provider.ToString();

            return View();
        }

        public ActionResult InitDB()
        {
            MembershipUser user = Membership.CreateUser("cudini", "Azerty0", "lcudini@supinfo.com");

            if (user == null)
            {
                Console.WriteLine("It's my provider");
            }
            else
            {
                Console.WriteLine("the cake is a lie");
            }

            return RedirectToAction("login");
        }
    }
}
