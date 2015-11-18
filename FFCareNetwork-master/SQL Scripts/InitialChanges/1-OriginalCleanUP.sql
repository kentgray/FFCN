DROP TABLE Audit, AuditTable, [Copy Of tblReferences], [Name AutoCorrect Save Failures], [Switchboard Items],
			[Switchboard Report Items], tblApplication, tblBeds, tblCertifications, tblChildNeeds1, tblChildren,
			tblCommunications1, tblcontactstatussubform, tblHeardAbout, tblInquiryStatus, tblNeeds, tblOngoingTraining, 
			tblOrganizations, tblPersonalInfo, tblPlacements, tblPrimaryCaregiver_ExportErrors, tblPrimaryCaregiverdata1,
			tblPrimaryCaregiverdata2, tblPrimaryCaregiverdatatest, tblRelatedCaregiver1, tblRelatedCaregiverB,
			tblTraining, tblTrainingHistory, tlkpActivityLog, tlkpAgeGroups, tlkpApplicationSteps, tlkpCertifications,
			tlkpCurrUser, tlkpDuration, tlkpEMailTypes, tlkpGenders, tlkpLookups, tlkpNeighborhoods,
			tlkpPath, tlkpRecruitmentCategorieserase, tlkpReports, tlkpStatus, tlkpSpecialNeeds, tlkpTimesOfDay1,
			tlkpTraining, tlkpTrainingSubject, test2, test3, tblReferralStatus, tlkpState, 
			tlkpCityCountyState;

ALTER TABLE tblPrimaryCaregiverdata
	DROP COLUMN phone, email, street, city, state, zip, county;
			
DELETE FROM tblRelatedCaregiver WHERE FirstName IS NULL AND LastName IS NULL;
DELETE FROM tblCommunications WHERE Notes IS NULL;
DELETE FROM tblEmails WHERE EMail IS NULL;
DELETE FROM tblPhones WHERE Phone IS NULL;
DELETE FROM tblPrimaryCaregiverdata WHERE FirstName IS NULL AND LastName IS NULL;
DELETE FROM tblPrimaryCaregiverdata WHERE FirstName = '**' AND LastName = '**';

