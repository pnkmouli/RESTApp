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
    
    public partial class ExportMediaLog
    {
        public int ID { get; set; }
        public Nullable<int> ExportMediaID { get; set; }
        public Nullable<int> PropertyID { get; set; }
        public string BranchID { get; set; }
        public string Details { get; set; }
        public string APIReference { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<bool> SuccessResponse { get; set; }
        public string ChangeType { get; set; }
        public Nullable<int> ExportProcessID { get; set; }
    
        public virtual ExportMedia ExportMedia { get; set; }
        public virtual ExportProcessed ExportProcessed { get; set; }
        public virtual PropertyEstate PropertyEstate { get; set; }
    }
}
