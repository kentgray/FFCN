EXEC sp_rename 'tblPrimaryCaregiverdata.IDEE', 'CareGiverID';
GO

--Alter tblCommunications
EXEC sp_rename 'tblCommunications.IDEE', 'id';
GO

EXEC sp_rename 'tblCommunications.Caregiver', 'CareGiverID';
GO

EXEC sp_rename 'tblCommunications.Staff', 'UserID';
GO

EXEC sp_rename 'tblCommunications.User', 'Userbak';

--Alter tblEmails
EXEC sp_rename 'tblEmails.Caregiver', 'CareGiverID';
GO

EXEC sp_rename 'tblEmails.IDEE', 'id';
GO

--Alter tblPhones
EXEC sp_rename 'tblPhones.IDEE', 'id';
GO

EXEC sp_rename 'tblPhones.ContactID', 'CareGiverID';
GO

--Alter tblRelatedCaregiver
EXEC sp_rename 'tblRelatedCaregiver.IDEE', 'id';
GO

EXEC sp_rename 'tblRelatedCaregiver.Primary', 'CareGiverID';
GO

--Alter tblAddresses
EXEC sp_rename 'tblAddresses.IDEE', 'id';
GO

EXEC sp_rename 'tblAddresses.ContactID', 'CareGiverID';
GO

--Alter tlkpAddressType
EXEC sp_rename 'tlkpAddressType.IDEE', 'id';
GO

--Alter tlkAgencies
EXEC sp_rename 'tlkpAgencies.IDEE', 'id';
GO

--Alter tlkpCommunicationTypes
EXEC sp_rename 'tlkpCommunicationTypes.IDEE', 'id';
GO

--Alter tlkpInactive
EXEC sp_rename 'tlkpInactive.IDEE', 'id';
GO

--Alter tlkpPhoneTypes
EXEC sp_rename 'tlkpPhoneTypes.IDEE', 'id';
GO

--Alter tlkpProgram
EXEC sp_rename 'tlkpProgram.IDEE', 'id';
GO

--Alter tlkpRecruitmentCategories
EXEC sp_rename 'tlkpRecruitmentCategories.IDEE', 'id';
GO

--Alter tlkpRelationship
EXEC sp_rename 'tlkpRelationship.IDEE', 'id';
GO

--Alter tblUsers
EXEC sp_rename 'tblUsers.IDEE', 'UserId';
EXEC sp_rename 'tlkpOngoingTraining.IDEE', 'id';