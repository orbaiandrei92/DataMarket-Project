//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataMarket.WindowsService.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Filter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Filter()
        {
            this.FilterValues = new HashSet<FilterValue>();
        }
    
        public int FilterId { get; set; }
        public int GroupId { get; set; }
        public string FilterName { get; set; }
        public string DisplayName { get; set; }
        public System.DateTime AddedDate { get; set; }
        public string AddedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual Group Group { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilterValue> FilterValues { get; set; }
    }
}
