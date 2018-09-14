﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Support
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class igr_collectionsEntities : DbContext
    {
        public igr_collectionsEntities()
            : base("name=igr_collectionsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<abuthpaymentitem> abuthpaymentitems { get; set; }
        public virtual DbSet<abuthpayment> abuthpayments { get; set; }
        public virtual DbSet<agent> agents { get; set; }
        public virtual DbSet<aspnetrole> aspnetroles { get; set; }
        public virtual DbSet<aspnetuserclaim> aspnetuserclaims { get; set; }
        public virtual DbSet<aspnetuser> aspnetusers { get; set; }
        public virtual DbSet<assessmenttable> assessmenttables { get; set; }
        public virtual DbSet<asset> assets { get; set; }
        public virtual DbSet<bank> banks { get; set; }
        public virtual DbSet<beneficiary> beneficiaries { get; set; }
        public virtual DbSet<buypowernotification> buypowernotifications { get; set; }
        public virtual DbSet<colortab> colortabs { get; set; }
        public virtual DbSet<conlog> conlogs { get; set; }
        public virtual DbSet<enumeration> enumerations { get; set; }
        public virtual DbSet<fundsweep> fundsweeps { get; set; }
        public virtual DbSet<igr> igrs { get; set; }
        public virtual DbSet<igr_categories> igr_categories { get; set; }
        public virtual DbSet<invoice> invoices { get; set; }
        public virtual DbSet<isnotification> isnotifications { get; set; }
        public virtual DbSet<jambpayment> jambpayments { get; set; }
        public virtual DbSet<jigawalog> jigawalogs { get; set; }
        public virtual DbSet<kedcopayment> kedcopayments { get; set; }
        public virtual DbSet<kingscare> kingscares { get; set; }
        public virtual DbSet<mda> mdas { get; set; }
        public virtual DbSet<mda_category> mda_category { get; set; }
        public virtual DbSet<mda_stations> mda_stations { get; set; }
        public virtual DbSet<notification> notifications { get; set; }
        public virtual DbSet<oneclickpayment> oneclickpayments { get; set; }
        public virtual DbSet<payertype> payertypes { get; set; }
        public virtual DbSet<paymentnotification> paymentnotifications { get; set; }
        public virtual DbSet<pos> pos { get; set; }
        public virtual DbSet<pos_collection> pos_collection { get; set; }
        public virtual DbSet<power> powers { get; set; }
        public virtual DbSet<remittance> remittances { get; set; }
        public virtual DbSet<reportslisting> reportslistings { get; set; }
        public virtual DbSet<reportsparameter> reportsparameters { get; set; }
        public virtual DbSet<revenuehead> revenueheads { get; set; }
        public virtual DbSet<richfield> richfields { get; set; }
        public virtual DbSet<rserver> rservers { get; set; }
        public virtual DbSet<rssh_upload> rssh_upload { get; set; }
        public virtual DbSet<schoolclass> schoolclasses { get; set; }
        public virtual DbSet<schooldetail> schooldetails { get; set; }
        public virtual DbSet<schoolnotification> schoolnotifications { get; set; }
        public virtual DbSet<schoolsession> schoolsessions { get; set; }
        public virtual DbSet<schoolterm> schoolterms { get; set; }
        public virtual DbSet<student_information> student_information { get; set; }
        public virtual DbSet<subhead> subheads { get; set; }
        public virtual DbSet<taxpayer> taxpayers { get; set; }
        public virtual DbSet<tin> tins { get; set; }
        public virtual DbSet<valueswitchpayment> valueswitchpayments { get; set; }
        public virtual DbSet<web_collection> web_collection { get; set; }
        public virtual DbSet<aspnetuserlogin> aspnetuserlogins { get; set; }
        public virtual DbSet<pos_test_najib> pos_test_najib { get; set; }
        public virtual DbSet<igr_users> igr_users { get; set; }
        public virtual DbSet<vw_collections> vw_collections { get; set; }
        public virtual DbSet<vw_remittances> vw_remittances { get; set; }
    }
}
