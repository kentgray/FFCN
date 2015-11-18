using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FFCNMaintenance.Models
{
    public class MasterModel
    {
        [Key]
        public int mandatoryKey { get; set; }
        public List<tblAddress> Address { get; set; }
        public List<tblPrimaryCaregiverdata> Primary { get; set; }
        public List<tblPhone> Phone { get; set; }
        public List<tblEmail> Email { get; set; }
        public List<tblRelatedCaregiver> Related { get; set; }
        public List<tblTrainingHistoryMain> TrainingHistory { get; set; }
        public List<tblInquiryReferralStatu> InquiryReferral { get; set; }
        public List<tblCommunication> Communication { get; set; }
        public string First { get; set; }
        public string Last { get; set; }

    }

   
}
