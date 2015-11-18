using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace FFCNMaintenance.Controllers
{
    public class HomeController : Controller
    {
        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
        public ActionResult Index()
        {
            AuthenticationManager.SignOut();
            return RedirectToAction("Index", "SelectCaregiver");
        }
    }
}