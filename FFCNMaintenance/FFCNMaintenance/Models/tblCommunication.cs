//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FFCNMaintenance.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCommunication
    {
        public int ID { get; set; }
        public Nullable<int> Agency { get; set; }
        public Nullable<int> CareGiverID { get; set; }
        public Nullable<System.DateTime> CommnDate { get; set; }
        public Nullable<int> CommType { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> Userbak { get; set; }
        public string Notes { get; set; }
        public string TypeDescr { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        public virtual tblPrimaryCaregiverdata tblPrimaryCaregiverdata { get; set; }
        public virtual tlkpCommunicationType tlkpCommunicationType { get; set; }
        public virtual tblUser tblUser { get; set; }
    }
}
