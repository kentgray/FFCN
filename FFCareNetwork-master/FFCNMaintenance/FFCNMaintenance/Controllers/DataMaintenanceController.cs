using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FFCNMaintenance.Controllers
{
    [Authorize]
    public class DataMaintenanceController : Controller
    {
        // GET: DataMaintenance
        public ActionResult Index()
        {
            return View();
        }
    }
}