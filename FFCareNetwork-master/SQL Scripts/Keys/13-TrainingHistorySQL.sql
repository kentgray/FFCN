ALTER TABLE tblTrainingHistoryMain
ALTER COLUMN StaffOrient INT;

ALTER TABLE tblTrainingHistoryMain
ALTER COLUMN StaffIntro INT;

ALTER TABLE tblTrainingHistoryMain
ALTER COLUMN StaffAttendedIntro INT;

ALTER TABLE tblTrainingHistoryMain
ALTER COLUMN StaffPreserviceRSVP INT;

ALTER TABLE tblTrainingHistoryMain
ALTER COLUMN StaffAttendedPreservice1 INT;

ALTER TABLE tblTrainingHistoryMain
ALTER COLUMN StaffAttendedPreservice2 INT;

ALTER TABLE tblTrainingHistoryMain
ALTER COLUMN StaffPreserviceComp INT;

ALTER TABLE tblTrainingHistoryMain
ALTER COLUMN StaffOngoing INT;

ALTER TABLE tblTrainingHistoryMain
ALTER COLUMN StaffOneOnOne INT;

ALTER TABLE tblTrainingHistoryMain
ALTER COLUMN StaffPreservicePrior INT;

ALTER TABLE tblTrainingHistoryMain
ADD FOREIGN KEY (StaffOrient) REFERENCES tblUsers(UserId);

ALTER TABLE tblTrainingHistoryMain
ADD FOREIGN KEY (StaffIntro) REFERENCES tblUsers(UserId);

ALTER TABLE tblTrainingHistoryMain
ADD FOREIGN KEY (StaffAttendedIntro) REFERENCES tblUsers(UserId);

ALTER TABLE tblTrainingHistoryMain
ADD FOREIGN KEY (StaffPreserviceRSVP) REFERENCES tblUsers(UserId);

ALTER TABLE tblTrainingHistoryMain
ADD FOREIGN KEY (StaffAttendedPreservice1) REFERENCES tblUsers(UserId);

ALTER TABLE tblTrainingHistoryMain
ADD FOREIGN KEY (StaffAttendedPreservice2) REFERENCES tblUsers(UserId);

ALTER TABLE tblTrainingHistoryMain
ADD FOREIGN KEY (StaffPreserviceComp) REFERENCES tblUsers(UserId);

ALTER TABLE tblTrainingHistoryMain
ADD FOREIGN KEY (StaffOngoing) REFERENCES tblUsers(UserId);

ALTER TABLE tblTrainingHistoryMain
ADD FOREIGN KEY (StaffOneOnOne) REFERENCES tblUsers(UserId);

ALTER TABLE tblTrainingHistoryMain
ADD FOREIGN KEY (StaffPreservicePrior) REFERENCES tblUsers(UserId);

SET IDENTITY_INSERT tblUsers ON;

INSERT INTO tblUsers (UserId,Last,Active,Agency,UserGroup)
VALUES (999,NULL,1,1,1);

SET IDENTITY_INSERT tblUsers OFF;

UPDATE tblCommunications
SET UserID = 999
WHERE UserID IS NULL OR UserID = 0;

ALTER TABLE tblCommunications
ADD FOREIGN KEY (UserID) REFERENCES tblUsers(UserId);