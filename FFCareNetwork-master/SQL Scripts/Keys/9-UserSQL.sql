ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN StaffInitialInquiry INT;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN StaffDidntPass INT;

UPDATE tblInquiryReferralStatus SET
StaffLookingJob = NULL,
StaffOutOfStat = NULL,
StaffInactive = NULL,
StaffActive = NULL,
StaffAppReceived = NULL,
StaffAppProgram = NULL,
StaffAppReferredProg = NULL,
StaffHomeCert = NULL,
StaffHomeClosed = NULL,
StaffAppOnHold = NULL,
StaffAppReturned = NULL,
StaffAppReferredtoAnother = NULL,
StaffAppRejectedFFCN = NULL,
StaffAppRejectedProg = NULL
WHERE CareGiverID = 5959;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN StaffLookingJob INT;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN StaffOutOfStat INT;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN StaffInactive INT;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN StaffActive INT;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN StaffAppReceived INT;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN StaffAppProgram INT;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN StaffAppReferredProg INT;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN StaffHomeCert INT;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN StaffHomeClosed INT;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN StaffAppOnHold INT;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN StaffAppReturned INT;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN StaffAppReferredtoAnother INT;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN StaffAppRejectedFFCN INT;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN StaffAppRejectedProg INT;

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (StaffLookingJob) REFERENCES tblUsers(UserId);

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (StaffOutOfStat) REFERENCES tblUsers(UserId);

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (StaffInactive) REFERENCES tblUsers(UserId);

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (StaffActive) REFERENCES tblUsers(UserId);

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (StaffAppReceived) REFERENCES tblUsers(UserId);

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (StaffAppProgram) REFERENCES tblUsers(UserId);

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (StaffAppReferredProg) REFERENCES tblUsers(UserId);

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (StaffHomeCert) REFERENCES tblUsers(UserId);

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (StaffHomeClosed) REFERENCES tblUsers(UserId);

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (StaffAppOnHold) REFERENCES tblUsers(UserId);

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (StaffAppReturned) REFERENCES tblUsers(UserId);

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (StaffAppReferredtoAnother) REFERENCES tblUsers(UserId);

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (StaffAppRejectedFFCN) REFERENCES tblUsers(UserId);

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (StaffAppRejectedProg) REFERENCES tblUsers(UserId);

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (StaffInitialInquiry) REFERENCES tblUsers(UserId);

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (StaffDidntPass) REFERENCES tblUsers(UserId);
