using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FFCNMaintenance.ViewModels
{
    public class MaintenanceContactViewModel
    {
        [Key]
        public int CaregiverID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public int? PhoneType { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string SecondaryFirstName { get; set; }
        public string SecondaryLastName { get; set; }
        public string SecondaryPhone { get; set; }
        public string SecondaryEmail { get; set; }
        public int SecondaryRelType { get; set; }
        public string SecondaryRelationship { get; set; }
        public bool psqPhysicianRelease { get; set; }
        public bool psqEnglish { get; set; }
        public bool psqKerrInternet { get; set; }
        public bool psqLivesClose { get; set; }
        public bool psqInRecovery { get; set; }
        public bool psqDHSRelease { get; set; }
        public bool psqExtraRoom { get; set; }
        public bool psqIncome { get; set; }
        public bool psqOver25 { get; set; }
        public bool psqRoommates { get; set; }
        public bool psqNoDUI { get; set; }
        public bool psqReliableTransport { get; set; }
        public bool psqParentChildRatio { get; set; }
        public string HeardAboutName { get; set; }
        public int HeardAbout { get; set; }
        public int ChildrenInHome { get; set; }
        public int intrSpeaksSpanish { get; set; }
        public int intrVolunteer { get; set; }
        public int intrDonor { get; set; }
        public int intrRespite { get; set; }

        public IQueryable<MaintenanceContactViewModel> qryMaintenanceContactViewModel { get; set; }
    }
}
