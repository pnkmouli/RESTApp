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
    
    public partial class ExportMedia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExportMedia()
        {
            this.ExportConfigs = new HashSet<ExportConfig>();
            this.ExportMediaLogs = new HashSet<ExportMediaLog>();
            this.ExportProcesseds = new HashSet<ExportProcessed>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ExportType { get; set; }
        public string ApiUrl { get; set; }
        public string FtpAddress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExportConfig> ExportConfigs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExportMediaLog> ExportMediaLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExportProcessed> ExportProcesseds { get; set; }
    }
}
