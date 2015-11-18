--Alter TABLE tblInquiryReferralStatus
ALTER TABLE tblInquiryReferralStatus
	DROP COLUMN Reason17;
ALTER TABLE tblInquiryReferralStatus
	ADD ReasonInactive int;
GO

EXEC sp_rename 'tblInquiryReferralStatus.Date1', 'DateInitialInquiry';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Date2', 'DateDidntPass';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Date3', 'DateLookingJob';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Date4', 'DateOutOfStat';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Date5', 'DateInactive';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Date6', 'DateActive';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Date7', 'DateAppReceived';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Date8', 'DateAppProgram';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Date9', 'DateAppReferredProg';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Date10', 'DateHomeCert1';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Date11', 'DateHomeClosed';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Date12', 'DateAppOnHold';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Date13', 'DateAppReturned';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Date14', 'DateAppReferredtoAnother';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Date15', 'DateAppRejectedFFCN';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Date16', 'DateAppRejectedProg';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Reason8', 'ReasonAppProgram';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Reason9', 'ReasonAppReferredProg';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Reason10', 'ReasonHomeCert';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Reason11', 'ReasonHomeClosed';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Reason12', 'ReasonAppOnHold';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Reason13', 'ReasonAppReturned';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Reason14', 'ReasonAppReferredAnother';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Reason15', 'ReasonAppRejectedFFCN';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Reason16', 'ReasonAppRejectedProg';
GO

EXEC sp_rename 'tblInquiryReferralStatus.IDEE', 'CareGiverID';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Staff1', 'StaffInitialInquiry';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Staff2', 'StaffDidntPass';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Staff3', 'StaffLookingJob';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Staff4', 'StaffOutOfStat';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Staff5', 'StaffInactive';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Staff6', 'StaffActive';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Staff7', 'StaffAppReceived';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Staff8', 'StaffAppProgram';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Staff9', 'StaffAppReferredProg';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Staff10', 'StaffHomeCert';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Staff11', 'StaffHomeClosed';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Staff12', 'StaffAppOnHold';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Staff13', 'StaffAppReturned';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Staff14', 'StaffAppReferredtoAnother';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Staff15', 'StaffAppRejectedFFCN';
GO

EXEC sp_rename 'tblInquiryReferralStatus.Staff16', 'StaffAppRejectedProg';
GO

ALTER TABLE tblInquiryReferralStatus
	ADD FOREIGN KEY (ReasonInactive) REFERENCES tlkpInactive(id);