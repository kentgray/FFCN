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
    
    public partial class tlkpTrainPreservice1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tlkpTrainPreservice1()
        {
            this.tblTrainingHistoryMains = new HashSet<tblTrainingHistoryMain>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> TrainDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTrainingHistoryMain> tblTrainingHistoryMains { get; set; }
    }
}