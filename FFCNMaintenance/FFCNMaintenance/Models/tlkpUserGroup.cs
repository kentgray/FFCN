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
    
    public partial class tlkpUserGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tlkpUserGroup()
        {
            this.tblUsers = new HashSet<tblUser>();
        }
    
        public int id { get; set; }
        public string Descr { get; set; }
        public Nullable<bool> Active { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUser> tblUsers { get; set; }
    }
}