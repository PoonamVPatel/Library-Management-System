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
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.TransactionIDs = new HashSet<TransactionID>();
        }
    
        public short BookID { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public string BookType { get; set; }
        public float Price { get; set; }
        public string Publisher { get; set; }
        public string YearPublished { get; set; }
        public short Quantity { get; set; }
        public Nullable<short> Edition { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionID> TransactionIDs { get; set; }
    }
}