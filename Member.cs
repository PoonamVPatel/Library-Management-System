//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA47_Team9B_UIDesignTemplate
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            this.TransactionIDs = new HashSet<TransactionID>();
        }
    
        public string MemberID { get; set; }
        public string MemberName { get; set; }
        public string MemberType { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string ContactTitle { get; set; }
        public string EmailAddress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionID> TransactionIDs { get; set; }
    }
}
