//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalManagmentSystem_
{
    using System;
    using System.Collections.Generic;
    
    public partial class worker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public worker()
        {
            this.shifts = new HashSet<shift>();
        }
    
        public int id_worker { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public Nullable<long> pesel { get; set; }
        public string user_type { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public Nullable<bool> status_admin { get; set; }
        public Nullable<bool> status_user { get; set; }
        public string specialization { get; set; }
        public Nullable<int> pwz { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<shift> shifts { get; set; }
    }
}
