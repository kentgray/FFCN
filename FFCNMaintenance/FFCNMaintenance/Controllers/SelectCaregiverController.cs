using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FFCNMaintenance.Models;
using FFCNMaintenance.ViewModels;

namespace FFCNMaintenance.Controllers
{
    [Authorize]
    public class SelectCaregiverController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();


        // GET: SelectCaregiver
        public ActionResult Index()
        {
            LastNameLookup[] lastNameSearch =
                new LastNameLookup[db.tblPrimaryCaregiverdatas.Count()];
            FirstNameLookup[] firstNameSearch =
                new FirstNameLookup[db.tblPrimaryCaregiverdatas.Count()];
            int i = 0;
            foreach (var caregiver in db.tblPrimaryCaregiverdatas)
            {
                lastNameSearch[i] = 
                    new LastNameLookup(caregiver.CareGiverID,
                        caregiver.LastName + ',' + caregiver.FirstName);
                firstNameSearch[i] =
                    new FirstNameLookup(caregiver.CareGiverID,
                        caregiver.FirstName + ' ' + caregiver.LastName);
                i++;
            }

            PhoneNumberLookup[] phoneNumberSearch =
                new PhoneNumberLookup[db.tblPhones.Count()];
            i = 0;
            foreach (var caregiver in db.tblPhones)
            {
                if (caregiver.CareGiverID != null)
                  {
                     phoneNumberSearch[i] =
                        new PhoneNumberLookup((int)caregiver.CareGiverID,
                        caregiver.Phone);
                   }
                else
                   {
                     phoneNumberSearch[i] =
                         new PhoneNumberLookup(0, caregiver.Phone);
                   }
                i++;
            }
            
            var viewModel = new SelectCaregiverViewModel
            {
                FirstNameList = firstNameSearch.OrderBy(x => x.FirstNameLastName).ToList(),
                LastNameList = lastNameSearch.OrderBy(x => x.LastNameFirstName).ToList(),
                PhoneNumberList = phoneNumberSearch.OrderBy(x => x.PhoneNumber).ToList(),
             };
            return View(viewModel);
        }


        // POST: SelectCaregiver
        [HttpPost, ActionName("Index")]
        [ValidateAntiForgeryToken]
        public ActionResult RedirectToEdit(string lastNameSelected, string firstNameSelected, string phoneSelected, string cgidSelected)
        {
            int cidi = 0; ;

           if ((SelectionWorks(lastNameSelected.ToString(), ref cidi)) && (validRedirectId(cidi)))
                return RedirectToAction("Index", "MasterModels", new { id = cidi });
           if ((SelectionWorks(firstNameSelected.ToString(), ref cidi)) && (validRedirectId(cidi)))
                return RedirectToAction("Index", "MasterModels", new { id = cidi });
           if ((SelectionWorks(phoneSelected.ToString(), ref cidi)) && (validRedirectId(cidi)))
                return RedirectToAction("Index", "MasterModels", new { id = cidi });
            //nothing valid was selected, so just redisplay initial selection screen
            return RedirectToAction("Index");
        }

        private bool validRedirectId(int redirectId)
        {
            if (redirectId < 1) return false;
            if ((db.tblPrimaryCaregiverdatas.FirstOrDefault(x => x.CareGiverID == redirectId)) != null) return true;
            else return false;
        }

        private bool SelectionWorks(string s, ref int id)
        {
            if (s == "") return false;
            try
            {
                if (s.IndexOf("#") < 1) return false;
                string idString = s.Substring(s.IndexOf("#") + 1);
                id = int.Parse(idString);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
