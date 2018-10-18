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
    
    public partial class BasketItem
    {
        public int Id { get; set; }
        public int BasketId { get; set; }
        public int PropertyId { get; set; }
        public decimal OiginalPrice { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public Nullable<decimal> Deposit { get; set; }
        public Nullable<decimal> AdminFee { get; set; }
        public Nullable<int> Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public Nullable<int> CountryId { get; set; }
    
        public virtual Basket Basket { get; set; }
        public virtual PropertyEstate PropertyEstate { get; set; }
    }
}