//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class PropertyType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PropertyType()
        {
            this.PropertyEstates = new HashSet<PropertyEstate>();
            this.PropertyEstateTypes = new HashSet<PropertyEstateType>();
            this.PropertySurveys = new HashSet<PropertySurvey>();
        }
    
        public int propertytypeid { get; set; }
        public string title { get; set; }
        public Nullable<int> Typeid { get; set; }
        public Nullable<int> groupid1 { get; set; }
        public Nullable<int> groupid2 { get; set; }
        public Nullable<int> groupid3 { get; set; }
        public Nullable<bool> isClientType { get; set; }
        public Nullable<int> RightMoveID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyEstate> PropertyEstates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyEstateType> PropertyEstateTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertySurvey> PropertySurveys { get; set; }
    }
}