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
    
    public partial class tlkpOngoingTraining
    {
        public tlkpOngoingTraining()
        {
            this.tblTrainingHistoryMains = new HashSet<tblTrainingHistoryMain>();
        }
    
        public int ID { get; set; }
        public string Descr { get; set; }
        public Nullable<bool> Active { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        public virtual ICollection<tblTrainingHistoryMain> tblTrainingHistoryMains { get; set; }
    }
}
