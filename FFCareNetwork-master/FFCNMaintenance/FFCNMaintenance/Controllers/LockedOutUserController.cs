using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FFCNMaintenance.Controllers
{
    public class LockedOutUserController : Controller
    {
        // GET: LockedOutUser
        public ActionResult Index()
        {
            return View();
        }
    }
}