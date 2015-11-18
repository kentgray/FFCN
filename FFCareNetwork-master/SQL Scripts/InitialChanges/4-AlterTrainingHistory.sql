--Alter tblTrainingHistoryMain
ALTER TABLE tblTrainingHistoryMain
	DROP COLUMN Date2, Date3, Date4, Date5, Date6, Date7, Date10, Staff7, Reason11;
EXEC sp_rename 'tblTrainingHistoryMain.Date1', 'DateOrient';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Date8', 'DatePreService';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Date9', 'DateOngoing';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Date11', 'DateOneOnOne';
GO

EXEC sp_rename 'tblTrainingHistoryMain.IDEE', 'CareGiverID';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Staff1', 'StaffOrient';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Staff2', 'StaffIntro';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Staff3', 'StaffAttendedIntro';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Staff4', 'StaffPreserviceRSVP';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Staff5', 'StaffAttendedPreservice1';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Staff6', 'StaffAttendedPreservice2';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Staff8', 'StaffPreserviceComp';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Staff9', 'StaffOngoing';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Staff10', 'StaffPreservicePrior';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Staff11', 'StaffOneOnOne';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Reason8', 'TrainDatePreserviceComp';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Reason10', 'TrainDatePreservice2009';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Reason2', 'TrainDateIntro';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Reason3', 'TrainDateAttendedIntro';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Reason4', 'TrainDatePreserviceRSVP';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Reason5', 'TrainDateAttendedPreservice1';
GO

EXEC sp_rename 'tblTrainingHistoryMain.Reason6', 'TrainDateAttendedPreservice2';
GO