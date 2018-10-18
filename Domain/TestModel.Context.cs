﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WaltonPropertiesEntities : DbContext
    {
        public WaltonPropertiesEntities()
            : base("name=WaltonPropertiesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ApplicantGender> ApplicantGenders { get; set; }
        public virtual DbSet<ApplicantTitle> ApplicantTitles { get; set; }
        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<BasketItem> BasketItems { get; set; }
        public virtual DbSet<DevelopmentGroup> DevelopmentGroups { get; set; }
        public virtual DbSet<ExportConfig> ExportConfigs { get; set; }
        public virtual DbSet<ExportMedia> ExportMedias { get; set; }
        public virtual DbSet<ExportMediaLog> ExportMediaLogs { get; set; }
        public virtual DbSet<ExportProcessed> ExportProcesseds { get; set; }
        public virtual DbSet<FurnishedType> FurnishedTypes { get; set; }
        public virtual DbSet<ImportType> ImportTypes { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<PropertyAlert> PropertyAlerts { get; set; }
        public virtual DbSet<PropertyAlertsProcessed> PropertyAlertsProcesseds { get; set; }
        public virtual DbSet<PropertyCategory> PropertyCategories { get; set; }
        public virtual DbSet<PropertyClientType> PropertyClientTypes { get; set; }
        public virtual DbSet<PropertyEstateClientType> PropertyEstateClientTypes { get; set; }
        public virtual DbSet<PropertyEstate> PropertyEstates { get; set; }
        public virtual DbSet<PropertyEstateType> PropertyEstateTypes { get; set; }
        public virtual DbSet<PropertyFile> PropertyFiles { get; set; }
        public virtual DbSet<PropertyFileType> PropertyFileTypes { get; set; }
        public virtual DbSet<PropertyImage> PropertyImages { get; set; }
        public virtual DbSet<PropertyImageType> PropertyImageTypes { get; set; }
        public virtual DbSet<PropertyImportProcess> PropertyImportProcesses { get; set; }
        public virtual DbSet<PropertyLettingSpecification> PropertyLettingSpecifications { get; set; }
        public virtual DbSet<PropertyOption> PropertyOptions { get; set; }
        public virtual DbSet<PropertyRoom> PropertyRooms { get; set; }
        public virtual DbSet<PropertyStatu> PropertyStatus { get; set; }
        public virtual DbSet<PropertyStyle> PropertyStyles { get; set; }
        public virtual DbSet<PropertySurvey> PropertySurveys { get; set; }
        public virtual DbSet<PropertyTypeGroup> PropertyTypeGroups { get; set; }
        public virtual DbSet<PropertyType> PropertyTypes { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Shortlist> Shortlists { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tracking> Trackings { get; set; }
        public virtual DbSet<TrackingType> TrackingTypes { get; set; }
        public virtual DbSet<WindowCard> WindowCards { get; set; }
    }
}
