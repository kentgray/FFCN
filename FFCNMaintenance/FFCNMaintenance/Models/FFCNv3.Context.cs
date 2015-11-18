﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FFCNMaintenance.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FFCNEntitiesOld : DbContext
    {
        public FFCNEntitiesOld()
            : base("name=FFCNEntitiesOld")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblAddress> tblAddresses { get; set; }
        public virtual DbSet<tblCommunication> tblCommunications { get; set; }
        public virtual DbSet<tblEmail> tblEmails { get; set; }
        public virtual DbSet<tblInquiryReferralStatu> tblInquiryReferralStatus { get; set; }
        public virtual DbSet<tblPhone> tblPhones { get; set; }
        public virtual DbSet<tblPrimaryCaregiverdata> tblPrimaryCaregiverdatas { get; set; }
        public virtual DbSet<tblRelatedCaregiver> tblRelatedCaregivers { get; set; }
        public virtual DbSet<tblTrainingHistoryMain> tblTrainingHistoryMains { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tlkpAddressType> tlkpAddressTypes { get; set; }
        public virtual DbSet<tlkpAgency> tlkpAgencies { get; set; }
        public virtual DbSet<tlkpAppOnHold> tlkpAppOnHolds { get; set; }
        public virtual DbSet<tlkpAppRejectedFFCN> tlkpAppRejectedFFCNs { get; set; }
        public virtual DbSet<tlkpAppRejectedProg> tlkpAppRejectedProgs { get; set; }
        public virtual DbSet<tlkpAppReturned> tlkpAppReturneds { get; set; }
        public virtual DbSet<tlkpCommunicationType> tlkpCommunicationTypes { get; set; }
        public virtual DbSet<tlkpEmailType> tlkpEmailTypes { get; set; }
        public virtual DbSet<tlkpHomeClosed> tlkpHomeCloseds { get; set; }
        public virtual DbSet<tlkpInactive> tlkpInactives { get; set; }
        public virtual DbSet<tlkpOngoingTraining> tlkpOngoingTrainings { get; set; }
        public virtual DbSet<tlkpPhoneType> tlkpPhoneTypes { get; set; }
        public virtual DbSet<tlkpProgram> tlkpPrograms { get; set; }
        public virtual DbSet<tlkpRecruitmentCategory> tlkpRecruitmentCategories { get; set; }
        public virtual DbSet<tlkpRelationship> tlkpRelationships { get; set; }
        public virtual DbSet<tlkpTrainAttendIntro> tlkpTrainAttendIntroes { get; set; }
        public virtual DbSet<tlkpTrainIntroRSVP> tlkpTrainIntroRSVPs { get; set; }
        public virtual DbSet<tlkpTrainPreservice1> tlkpTrainPreservice1 { get; set; }
        public virtual DbSet<tlkpTrainPreservice2> tlkpTrainPreservice2 { get; set; }
        public virtual DbSet<tlkpTrainPreservice2009> tlkpTrainPreservice2009 { get; set; }
        public virtual DbSet<tlkpTrainPreserviceComp> tlkpTrainPreserviceComps { get; set; }
        public virtual DbSet<tlkpTrainPreserviceRSVP> tlkpTrainPreserviceRSVPs { get; set; }
        public virtual DbSet<tlkpUserGroup> tlkpUserGroups { get; set; }

    }
}