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
    
    public partial class PropertyEstateType
    {
        public long Id { get; set; }
        public int PropertyId { get; set; }
        public int PropertyTypeId { get; set; }
    
        public virtual PropertyEstate PropertyEstate { get; set; }
        public virtual PropertyType PropertyType { get; set; }
    }
}
