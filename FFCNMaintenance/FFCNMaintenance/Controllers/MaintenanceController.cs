using FFCNMaintenance.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FFCNMaintenance.Controllers
{
    [Authorize]
    public class MaintenanceController : Controller
    {
        public MaintenanceController()
        {
            context = new ApplicationDbContext();
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
        }

        public UserManager<ApplicationUser> UserManager { get; private set; }
        public ApplicationDbContext context { get; private set; }


        // GET: Maintenance
        public ActionResult Index()
        {
            List<ApplicationUser> currentStaffMembers =
                UserManager.Users.ToList();
            currentStaffMembers.RemoveAll(x => x.Active == false);
            currentStaffMembers.RemoveAll(x => x.Email == "admin@ffcn.org");
            return View(currentStaffMembers);
        }
    }
}