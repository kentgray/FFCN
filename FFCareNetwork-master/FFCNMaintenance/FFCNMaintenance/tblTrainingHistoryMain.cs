//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FFCNMaintenance
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTrainingHistoryMain
    {
        public int IDTR { get; set; }
        public Nullable<int> CareGiverID { get; set; }
        public Nullable<bool> Orientationmtg { get; set; }
        public Nullable<System.DateTime> DateOrient { get; set; }
        public string StaffOrient { get; set; }
        public Nullable<bool> RSVPd { get; set; }
        public string StaffIntro { get; set; }
        public Nullable<bool> IntroFoster { get; set; }
        public string StaffAttendedIntro { get; set; }
        public Nullable<bool> RSVPpreservice { get; set; }
        public string StaffPreserviceRSVP { get; set; }
        public Nullable<bool> AttendPreservice1 { get; set; }
        public string StaffAttendedPreservice1 { get; set; }
        public Nullable<bool> AttendPreservice2 { get; set; }
        public string StaffAttendedPreservice2 { get; set; }
        public Nullable<bool> OnHold { get; set; }
        public Nullable<bool> PreFinished8 { get; set; }
        public Nullable<System.DateTime> DatePreService { get; set; }
        public string StaffPreserviceComp { get; set; }
        public string OngoingTraining9 { get; set; }
        public Nullable<System.DateTime> DateOngoing { get; set; }
        public string StaffOngoing { get; set; }
        public Nullable<bool> OnetoOneOrientation { get; set; }
        public Nullable<System.DateTime> DateOneOnOne { get; set; }
        public string StaffOneOnOne { get; set; }
        public Nullable<bool> AttendedPrebefore2009 { get; set; }
        public string StaffPreservicePrior { get; set; }
        public string ReasonIntro { get; set; }
        public string ReasonAttendedIntro { get; set; }
        public string ReasonPreserviceRSVP { get; set; }
        public string ReasonAttendedPreservice1 { get; set; }
        public string ReasonAttendedPreservice2 { get; set; }
        public string ReasonAppProgram { get; set; }
        public string ReasonHomeCert { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        public virtual tblPrimaryCaregiverdata tblPrimaryCaregiverdata { get; set; }
    }
}
