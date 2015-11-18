using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FFCNMaintenance.Models;

namespace FFCNMaintenance.Controllers
{
    [Authorize]
    public class MasterModelsController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        private Entities db2 = new Entities();

        // GET: MasterModels
        public ActionResult Index(int id)
        {
            var query = from a in db2.AspNetUsers
                        where a.Email == User.Identity.Name
                        select a;

            var firstLast = query.ToList();

            string first = firstLast[0].First;
            string last = firstLast[0].Last;

            var model = new MasterModel();

            model.Address = GetAddressList(id);
            model.Primary = GetPrimaryList(id);
            model.Email = GetEmailList(id);
            model.Phone = GetPhoneList(id);
            model.Related = GetRelatedList(id);
            model.TrainingHistory = GetTrainingHistoryList(id);
            model.InquiryReferral = GetInquiryReferralList(id);
            model.Communication = GetCommunication(id);

            model.First = first;
            model.Last = last;


            ViewBag.PhoneType = new SelectList(db.tlkpPhoneTypes, "ID", "Descr");
            ViewBag.AddressType = new SelectList(db.tlkpAddressTypes, "ID", "Descr");
            ViewBag.EmailType = new SelectList(db.tlkpEmailTypes, "ID", "Descr");
            ViewBag.HeardAboutType = new SelectList(db.tlkpRecruitmentCategories, "id", "Descr");

            ViewBag.RelatedType = new SelectList(db.tlkpRelationships, "ID", "Descr");


            ViewBag.UserId = new SelectList(db.tblUsers, "UserId", "Last");
            //may need to include states and cities as lookup tables so they can be dropdown menus?
            return View(model);

        }

        public ActionResult Edit(int id)
        {
            var model = new MasterModel();

            model.Address = GetAddressList(id);
            model.Primary = GetPrimaryList(id);
            model.Email = GetEmailList(id);
            model.Phone = GetPhoneList(id);
            model.Related = GetRelatedList(id);
            model.TrainingHistory = GetTrainingHistoryList(id);
            model.InquiryReferral = GetInquiryReferralList(id);
            model.Communication = GetCommunication(id);


            ViewBag.PhoneType = new SelectList(db.tlkpPhoneTypes, "ID", "Descr");
            ViewBag.AddressType = new SelectList(db.tlkpAddressTypes, "ID", "Descr");
            ViewBag.EmailType = new SelectList(db.tlkpEmailTypes, "ID", "Descr");
            ViewBag.HeardAboutType = new SelectList(db.tlkpRecruitmentCategories, "id", "Descr");

            ViewBag.RelatedType = new SelectList(db.tlkpRelationships, "ID", "Descr");


            ViewBag.UserId = new SelectList(db.tblUsers, "UserId", "Last");
            //may need to include states and cities as lookup tables so they can be dropdown menus?
            return View(model);

        }

        public List<tblAddress> GetAddressList(int id)
        {// Select the address information for seleced user. Return to master model.

            // new list of addresses to be returned to master model
            var model = new List<tblAddress>();

            //query the tblAddresses table with AddressType included
            var query = from a in db.tblAddresses.Include(t => t.tlkpAddressType)
                        where a.CareGiverID == id
                        select a;

            //Load a select list with correct selected address type for each address.
            foreach (var i in query)
            {
                i.AddressTypeSelectList = new SelectList(db.tlkpAddressTypes, "ID", "Descr", i.AddressType);
            }

            //query must be converted to List so that it fits into 'model'
            model = query.ToList();

            //check to make sure query (now in model) did not return null
            if (model.Count != 0)
            {
                return (model);
            }

            //if query did return null, create a row of empty text so that model will 
            //generate elements in the view. 
            else
            {
                var noAddress = new tblAddress();
                noAddress.Street1 = "";
                noAddress.Street2 = "";
                noAddress.City = "";
                noAddress.State = "";
                noAddress.AddressTypeSelectList = new SelectList(db.tlkpAddressTypes, "ID", "Descr");

                model.Add(noAddress);
                return (model);
            }

        }

        public List<tblCommunication> GetCommunication(int id)
        {
            var model = new List<tblCommunication>();

            var query = from a in db.tblCommunications
                        where a.CareGiverID == id
                        select a;

            

            model = query.ToList();

            if (model.Count != 0)
            {
                return (model);
            }
           
            else
            {
                var noComm = new tblCommunication();

                noComm.Notes = "";

                model.Add(noComm);
                return (model);
            }

        }

        public List<tblPhone> GetPhoneList(int id)
        {// Select the phone information for seleced user. Return to master model.

            // new list of phones to be returned to master model
            var model = new List<tblPhone>();

            //query the tblPhones table with AddressType included
            var query = from p in db.tblPhones.Include(t => t.tlkpPhoneType)
                        where p.CareGiverID == id
                        select p;

            //Load a select list with correct selected phone type for each phone number
            foreach (var i in query)
            {
                i.PhoneTypeSelectList = new SelectList(db.tlkpPhoneTypes, "ID", "Descr", i.PhoneType);
            }

            //query must be converted to List so that it fits into 'model'
            model = query.ToList();

            //check to make sure query (now in model) did not return null
            if (model.Count != 0)
            {
                return (model);
            }

            //if query did return null, create a row of empty text so that model will 
            //generate elements in the view. 
            else
            {
                var noPhone = new tblPhone();
                noPhone.Phone = "";
                noPhone.Active = false;
                noPhone.PhoneTypeSelectList = new SelectList(db.tlkpPhoneTypes, "ID", "Descr");


                model.Add(noPhone);
                return (model);
            }
        }

        // Email partial view logic.
        public List<tblEmail> GetEmailList(int id)
        {
            var model = new List<tblEmail>();

            var query = from p in db.tblEmails.Include(t => t.tlkpEmailType)
                        where p.CareGiverID == id
                        select p;



            foreach (var i in query)
            {
                i.EmailTypeSelectList = new SelectList(db.tlkpEmailTypes, "ID", "Descr", i.EmailType);
            }

            model = query.ToList();

            if (model.Count != 0)
            {
                return (model);
            }
            else
            {
                var noEmail = new tblEmail();
                noEmail.EMail = "";
                noEmail.EmailTypeSelectList = new SelectList(db.tlkpEmailTypes, "ID", "Descr");



                model.Add(noEmail);
                return (model);
            }

        }
        // Partial view for Secondary Contact information.


        public List<tblRelatedCaregiver> GetRelatedList(int id)
        {
            var model = new List<tblRelatedCaregiver>();

            var query = from p in db.tblRelatedCaregivers.Include(t => t.tlkpRelationship)
                        where p.CareGiverID == id
                        select p;

            model = query.ToList();

            foreach (var i in query)
            {
                i.RelationshipSelectList = new SelectList(db.tlkpRelationships, "ID", "Descr", i.Relationship);
            }

            if (model.Count != 0)
            {
                return (model);
            }
            else
            {
                var noRelation = new tblRelatedCaregiver();
                noRelation.FirstName = "";
                noRelation.LastName = "";
                noRelation.RelationshipSelectList = new SelectList(db.tlkpRelationships, "ID", "Descr");

                model.Add(noRelation);
                return (model);
            }

        }


        public List<tblTrainingHistoryMain> GetTrainingHistoryList(int id)
        {
            List<tblTrainingHistoryMain> model = new List<tblTrainingHistoryMain>();
            var query = from th in db.tblTrainingHistoryMains
                        where th.CareGiverID == id
                        select th;

            model = query.ToList();

            if (model.Count != 0)
            {
                foreach (var i in query)
                {
                    i.UserSelectList1 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffOrient);
                    i.UserSelectList2 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffOneOnOne);
                    i.UserSelectList3 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffIntro);
                    i.UserSelectList4 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffAttendedIntro);
                    i.UserSelectList5 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffPreserviceRSVP);
                    i.UserSelectList6 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffAttendedPreservice1);
                    i.UserSelectList7 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffAttendedPreservice2);
                    i.UserSelectList8 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffPreserviceComp);
                    i.UserSelectList9 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffPreservicePrior);
                    i.UserSelectList10 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffOngoing);

                    i.TrainIntroRSVP = new SelectList(db.tlkpTrainIntroRSVPs, "id", "TrainDate", i.TrainDateIntro);
                    i.TrainAttendedIntro = new SelectList(db.tlkpTrainAttendIntroes, "id", "TrainDate", i.TrainDateAttendedIntro);
                    i.TrainPreserviceRSVP = new SelectList(db.tlkpTrainPreserviceRSVPs, "id", "TrainDate", i.TrainDatePreserviceRSVP);
                    i.TrainAttendPreservice1 = new SelectList(db.tlkpTrainPreservice1, "id", "TrainDate", i.TrainDateAttendedPreservice1);
                    i.TrainAttendPreservice2 = new SelectList(db.tlkpTrainPreservice2, "id", "TrainDate", i.TrainDateAttendedPreservice2);
                    i.TrainPreserviceComp = new SelectList(db.tlkpTrainPreserviceComps, "id", "TrainDate", i.TrainDatePreserviceComp);
                    i.TrainPreservice2009 = new SelectList(db.tlkpTrainPreservice2009, "id", "TrainDate", i.TrainDatePreservice2009);
                    i.OngoingTraingingList = new SelectList(db.tlkpOngoingTrainings, "id", "Descr", i.OngoingTraining9);


                }
                return (model);
            }
            else
            {
                var notrain = new tblTrainingHistoryMain();
                notrain.Orientationmtg = false;


                notrain.UserSelectList1 = new SelectList(db.tblUsers, "UserId", "Last");
                notrain.UserSelectList2 = new SelectList(db.tblUsers, "UserId", "Last");
                notrain.UserSelectList3 = new SelectList(db.tblUsers, "UserId", "Last");
                notrain.UserSelectList4 = new SelectList(db.tblUsers, "UserId", "Last");
                notrain.UserSelectList5 = new SelectList(db.tblUsers, "UserId", "Last");
                notrain.UserSelectList6 = new SelectList(db.tblUsers, "UserId", "Last");
                notrain.UserSelectList7 = new SelectList(db.tblUsers, "UserId", "Last");
                notrain.UserSelectList8 = new SelectList(db.tblUsers, "UserId", "Last");
                notrain.UserSelectList9 = new SelectList(db.tblUsers, "UserId", "Last");
                notrain.UserSelectList10 = new SelectList(db.tblUsers, "UserId", "Last");

                notrain.TrainIntroRSVP = new SelectList(db.tlkpTrainIntroRSVPs, "id", "TrainDate");
                notrain.TrainAttendedIntro = new SelectList(db.tlkpTrainAttendIntroes, "id", "TrainDate");
                notrain.TrainPreserviceRSVP = new SelectList(db.tlkpTrainPreserviceRSVPs, "id", "TrainDate");
                notrain.TrainAttendPreservice1 = new SelectList(db.tlkpTrainPreservice1, "id", "TrainDate");
                notrain.TrainAttendPreservice2 = new SelectList(db.tlkpTrainPreservice2, "id", "TrainDate");
                notrain.TrainPreserviceComp = new SelectList(db.tlkpTrainPreserviceComps, "id", "TrainDate");
                notrain.TrainPreservice2009 = new SelectList(db.tlkpTrainPreservice2009, "id", "TrainDate");
                notrain.OngoingTraingingList = new SelectList(db.tlkpOngoingTrainings, "id", "Descr");





                model.Add(notrain);
                return (model);
            }

        }
        public List<tblInquiryReferralStatu> GetInquiryReferralList(int id)
        {
            List<tblInquiryReferralStatu> model = new List<tblInquiryReferralStatu>();
            var query = from iq in db.tblInquiryReferralStatus
                        where iq.CareGiverID == id
                        select iq;

            model = query.ToList();

            if (model.Count != 0)
            {
                foreach (var i in query)
                {
                    i.UserSelectList1 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffInitialInquiry);
                    i.UserSelectList2 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffDidntPass);
                    i.UserSelectList3 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffLookingJob);
                    i.UserSelectList4 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffOutOfStat);
                    i.UserSelectList5 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffInactive);
                    i.UserSelectList6 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffActive);
                    i.UserSelectList7 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffAppReceived);
                    i.UserSelectList8 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffAppProgram);
                    i.UserSelectList9 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffAppReferredProg);
                    i.UserSelectList10 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffHomeCert);
                    i.UserSelectList11 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffHomeClosed);
                    i.UserSelectList12 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffAppOnHold);
                    i.UserSelectList13 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffAppReturned);
                    i.UserSelectList14 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffAppReferredtoAnother);
                    i.UserSelectList15 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffAppRejectedFFCN);
                    i.UserSelectList16 = new SelectList(db.tblUsers, "UserId", "Last", i.StaffAppRejectedProg);

                    i.ReasonAppOnHoldList = new SelectList(db.tlkpAppOnHolds, "id", "Reason", i.ReasonAppOnHold);
                    i.Program1 = new SelectList(db.tlkpPrograms, "id", "Description", i.ReasonAppProgram);
                    i.Program2 = new SelectList(db.tlkpPrograms, "id", "Description", i.ReasonAppReferredProg);
                    i.Program3 = new SelectList(db.tlkpPrograms, "id", "Description", i.ReasonHomeCert);
                    i.Program4 = new SelectList(db.tlkpPrograms, "id", "Description", i.ReasonAppReferredAnother);
                    i.ReasonInactiveList = new SelectList(db.tlkpInactives, "id", "Description", i.ReasonInactive);
                    i.ReasonHomeClosedList = new SelectList(db.tlkpHomeCloseds, "id", "Reason", i.ReasonHomeClosed);
                    i.ReasonAppReturnedList = new SelectList(db.tlkpAppReturneds, "id", "Reason", i.ReasonAppReturned);
                    i.ReasonAppRejectedProgList = new SelectList(db.tlkpAppRejectedProgs, "id", "Reason", i.ReasonAppRejectedProg);
                    i.ReasonAppRejectedFFCNList = new SelectList(db.tlkpAppRejectedFFCNs, "id", "Reason", i.ReasonAppRejectedFFCN);

                }

                return (model);
            }
            else
            {
                var noinq = new tblInquiryReferralStatu();
                noinq.InitialInquiry1 = false;

                noinq.UserSelectList1 = new SelectList(db.tblUsers, "UserId", "Last");
                noinq.UserSelectList2 = new SelectList(db.tblUsers, "UserId", "Last");
                noinq.UserSelectList3 = new SelectList(db.tblUsers, "UserId", "Last");
                noinq.UserSelectList4 = new SelectList(db.tblUsers, "UserId", "Last");
                noinq.UserSelectList5 = new SelectList(db.tblUsers, "UserId", "Last");
                noinq.UserSelectList6 = new SelectList(db.tblUsers, "UserId", "Last");
                noinq.UserSelectList7 = new SelectList(db.tblUsers, "UserId", "Last");
                noinq.UserSelectList8 = new SelectList(db.tblUsers, "UserId", "Last");
                noinq.UserSelectList9 = new SelectList(db.tblUsers, "UserId", "Last");
                noinq.UserSelectList10 = new SelectList(db.tblUsers, "UserId", "Last");
                noinq.UserSelectList11 = new SelectList(db.tblUsers, "UserId", "Last");
                noinq.UserSelectList12 = new SelectList(db.tblUsers, "UserId", "Last");
                noinq.UserSelectList13 = new SelectList(db.tblUsers, "UserId", "Last");
                noinq.UserSelectList14 = new SelectList(db.tblUsers, "UserId", "Last");
                noinq.UserSelectList15 = new SelectList(db.tblUsers, "UserId", "Last");
                noinq.UserSelectList16 = new SelectList(db.tblUsers, "UserId", "Last");

                noinq.ReasonAppOnHoldList = new SelectList(db.tlkpAppOnHolds, "id", "Reason");
                noinq.Program1 = new SelectList(db.tlkpPrograms, "id", "Description");
                noinq.Program2 = new SelectList(db.tlkpPrograms, "id", "Description");
                noinq.Program3 = new SelectList(db.tlkpPrograms, "id", "Description");
                noinq.Program4 = new SelectList(db.tlkpPrograms, "id", "Description");
                noinq.ReasonInactiveList = new SelectList(db.tlkpInactives, "id", "Description");
                noinq.ReasonHomeClosedList = new SelectList(db.tlkpHomeCloseds, "id", "Reason");
                noinq.ReasonAppReturnedList = new SelectList(db.tlkpAppReturneds, "id", "Reason");
                noinq.ReasonAppRejectedProgList = new SelectList(db.tlkpAppRejectedProgs, "id", "Reason");
                noinq.ReasonAppRejectedFFCNList = new SelectList(db.tlkpAppRejectedFFCNs, "id", "Reason");

                model.Add(noinq);
                return (model);
            }

        }

        public List<tblPrimaryCaregiverdata> GetPrimaryList(int id)
        {
            var model = new List<tblPrimaryCaregiverdata>();
            var query = from p in db.tblPrimaryCaregiverdatas.Include(t => t.tlkpRecruitmentCategory)
                        where p.CareGiverID == id
                        select p;

            //since there is no lkp table for ChildrenHome, we have to make a select list
            //here. We then use it both to create the ChildrenInHomeSelectList as well as
            //pass it to the view bag to be able to be used when the model is null in the
            //partial view.
            List<SelectListItem> childrenInHome = new List<SelectListItem>();
            for (int i = 0; i <= 9; i++)
            {
                var item = new SelectListItem { Text = i.ToString(), Value = i.ToString() };
                childrenInHome.Add(item);
            }


            foreach (var i in query)
            {
                i.HeardAboutSelectList = new SelectList(db.tlkpRecruitmentCategories, "id", "Descr", i.HeardAbout);
                i.ChildrenInHomeSelectList = new SelectList(childrenInHome, "Text", "Value", i.ChildrenHome);
            }

            model = query.ToList();
            ViewBag.ChildrenInHome = childrenInHome;

            return (model);
        }

        public PartialViewResult ShowPartialView()
        {
            return PartialView("_AddressPartial");
        }


        // GET: MasterModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterModel masterModel = db.MasterModels.Find(id);
            if (masterModel == null)
            {
                return HttpNotFound();
            }
            return View(masterModel);
        }

        // GET: MasterModels/Create
        public ActionResult Create()
        {

            ViewBag.PhoneType = new SelectList(db.tlkpPhoneTypes, "ID", "Descr");
            ViewBag.AddressType = new SelectList(db.tlkpAddressTypes, "ID", "Descr");
            ViewBag.EmailType = new SelectList(db.tlkpEmailTypes, "ID", "Descr");
            ViewBag.HeardAboutType = new SelectList(db.tlkpRecruitmentCategories, "id", "Descr");
            ViewBag.RelatedType = new SelectList(db.tlkpRelationships, "ID", "Descr");
            ViewBag.UserList = new SelectList(db.tblUsers, "UserId", "Last");
            ViewBag.AttendIntro = new SelectList(db.tlkpTrainAttendIntroes, "id", "TrainDate");
            ViewBag.IntroRSVP = new SelectList(db.tlkpTrainIntroRSVPs, "id", "TrainDate");
            ViewBag.PS1 = new SelectList(db.tlkpTrainPreservice1, "id", "TrainDate");
            ViewBag.PS2 = new SelectList(db.tlkpTrainPreservice2, "id", "TrainDate");
            ViewBag.PS2009 = new SelectList(db.tlkpTrainPreservice2009, "id", "TrainDate");
            ViewBag.PSComp = new SelectList(db.tlkpTrainPreserviceComps, "id", "TrainDate");
            ViewBag.PSRSVP = new SelectList(db.tlkpTrainPreserviceRSVPs, "id", "TrainDate");
            ViewBag.Ongoing = new SelectList(db.tlkpOngoingTrainings, "id", "Descr");

            ViewBag.Progam = new SelectList(db.tlkpPrograms, "id", "Description");
            ViewBag.Inactive = new SelectList(db.tlkpInactives, "id", "Description");
            ViewBag.HomeClosed = new SelectList(db.tlkpHomeCloseds, "id", "Reason");
            ViewBag.AppOnHold = new SelectList(db.tlkpAppOnHolds, "id", "Reason");
            ViewBag.AppReturned = new SelectList(db.tlkpAppReturneds, "id", "Reason");
            ViewBag.AppRejectFFCN = new SelectList(db.tlkpAppRejectedFFCNs, "id", "Reason");
            ViewBag.AppRejectProg = new SelectList(db.tlkpAppRejectedProgs, "id", "Reason");


            //see GetPrimaryList for explanation. Since the code is here and there we
            //could probably make a method for it instead of writing the same think mulitple
            //times
            List<SelectListItem> childrenInHome = new List<SelectListItem>();
            for (int i = 0; i <= 9; i++)
            {
                var item = new SelectListItem { Text = i.ToString(), Value = i.ToString() };
                childrenInHome.Add(item);
            }

            ViewBag.ChildrenInHome = childrenInHome;
            return View();
        }

        // POST: MasterModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterModel masterModel)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();

                db.tblPrimaryCaregiverdatas.Add(masterModel.Primary[0]);
                db.SaveChanges();

                int newCareGiverID = db.tblPrimaryCaregiverdatas.OrderByDescending(p => p.CareGiverID)
                    .FirstOrDefault().CareGiverID;


                foreach (var ph in masterModel.Phone)
                {
                    if (!String.IsNullOrWhiteSpace(ph.Phone))
                    {
                        ph.CareGiverID = newCareGiverID;
                        db.tblPhones.Add(ph);
                    }

                }

                foreach (var ad in masterModel.Address)
                {
                    if (!String.IsNullOrWhiteSpace(ad.Street1))
                    {
                        ad.CareGiverID = newCareGiverID;
                        db.tblAddresses.Add(ad);
                    }

                }

                foreach (var em in masterModel.Email)
                {
                    if (!String.IsNullOrWhiteSpace(em.EMail))
                    {
                        em.CareGiverID = newCareGiverID;
                        db.tblEmails.Add(em);
                    }
                }
                masterModel.mandatoryKey = 10;
                db.SaveChanges();
                return RedirectToAction("Index", new { id = newCareGiverID });
            }

            return View();
        }

        // POST: MasterModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(int? id, MasterModel masterModel)
        {
            if (ModelState.IsValid)
            {
                foreach (var item in masterModel.Email)
                {
                    if (item.id != 0)
                    {
                        db.Entry(item).State = EntityState.Modified;
                    }
                    else
                    {
                        if (item.EMail != null)
                        {
                            item.CareGiverID = id;
                            db.tblEmails.Add(item);
                        }
                    }
                }

                foreach (var item in masterModel.Phone)
                {
                    if (item.Phone != null)
                    {
                        if (item.id != 0)
                        {
                            db.Entry(item).State = EntityState.Modified;
                        }
                        else
                        {
                            if (item.Phone.Length > 0)
                            {
                                item.CareGiverID = id;
                                db.tblPhones.Add(item);
                            }
                        }
                    }
                }

                foreach (var item in masterModel.Address)
                {
                    if (item.id != 0)
                    {
                        db.Entry(item).State = EntityState.Modified;
                    }
                    else
                    {
                        item.CareGiverID = id;
                        db.tblAddresses.Add(item);
                    }
                }
                if (masterModel.Related != null)
                {
                    foreach (var item in masterModel.Related)
                    {
                        if (item.id != 0)
                        {
                            db.Entry(item).State = EntityState.Modified;
                        }
                        else
                        {
                            if (item.FirstName.Length > 0)
                            {
                                item.CareGiverID = (int)id;
                                db.tblRelatedCaregivers.Add(item);
                            }
                        }
                    }
                }

                foreach (var item in masterModel.Communication)
                {
                    if (item.Notes != null)
                    {
                        if (item.Notes.Length > 0)
                        {
                            string emailuser = User.Identity.Name;


                            item.CareGiverID = (int)id;
                            item.CommnDate = DateTime.Now;


                            db.tblCommunications.Add(item);
                        }
                    }
                }

                foreach (var item in masterModel.TrainingHistory)
                {
                    if (item.IDTR != 0)
                    {
                        db.Entry(item).State = EntityState.Modified;
                    }
                }

                foreach (var item in masterModel.InquiryReferral)
                {
                    if (item.IDIRS != 0)
                    {
                        db.Entry(item).State = EntityState.Modified;
                    }
                }

                foreach (var item in masterModel.Primary)
                {

                    db.Entry(item).State = EntityState.Modified;
                }

                db.SaveChanges();
                return Redirect("../Index/" + id.ToString());
            }
            return View(masterModel);
        }

        // GET: MasterModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterModel masterModel = db.MasterModels.Find(id);
            if (masterModel == null)
            {
                return HttpNotFound();
            }
            return View(masterModel);
        }

        // POST: MasterModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MasterModel masterModel = db.MasterModels.Find(id);
            db.MasterModels.Remove(masterModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
