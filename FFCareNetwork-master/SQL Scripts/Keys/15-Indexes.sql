drop index tblAddresses.tblAddresses$IDEE;

EXEC sp_rename 'tblAddresses.tblAddresses$ContactID','CareGiverID','INDEX';
GO

DROP INDEX tblCommunications.tblCommunications$IDEE;

CREATE INDEX CareGiverID ON tblCommunications (CareGiverID);

DROP INDEX tblInquiryReferralStatus.tblInquiryReferralStatus$IDIRS;

DROP INDEX tblInquiryReferralStatus.tblInquiryReferralStatus$tblInquiryReferralStatusIDEE;

DROP INDEX tblInquiryReferralStatus.tblInquiryReferralStatus$tblPrimaryCaregiverdatatblInquiryReferralStatus;

--CREATE UNIQUE INDEX UXI_CareGiverID on tblInquiryReferralStatus (CareGiverID);

DROP INDEX tblEmails.tblEmails$IDEE;

CREATE INDEX CareGiverID on tblEmails (CareGiverID);

DROP INDEX tblPhones.tblPhones$IDEE;

EXEC sp_rename 'tblPhones.tblPhones$ContactID','CareGiverID','INDEX';
GO

DROP INDEX tblPrimaryCaregiverdata.tblPrimaryCaregiverdata$IDEE;

DROP INDEX tblRelatedCaregiver.tblRelatedCaregiver$IDEE;

CREATE INDEX CareGiverID on tblRelatedCaregiver (CareGiverID);

DROP INDEX tblTrainingHistoryMain.tblTrainingHistoryMain$IDEE;
DROP INDEX tblTrainingHistoryMain.tblTrainingHistoryMain$IDTR;
DROP INDEX tblTrainingHistoryMain.tblTrainingHistoryMain$tblPrimaryCaregiverdatatblTrainingHistoryMain;

CREATE UNIQUE INDEX UXT_CareGiverID on tblTrainingHistoryMain (CareGiverID);

DROP INDEX tblUsers.tblUsers$IDEE;

DROP INDEX tlkpAddressType.tlkpAddressType$IDEE;

DROP INDEX tlkpAgencies.tlkpAgencies$IDEE;

DROP INDEX tlkpCommunicationTypes.tlkpCommunicationTypes$IDEE;

DROP INDEX tlkpProgram.tlkpProgram$IDEE;

DROP INDEX tlkpRelationship.tlkpRelationship$IDEE;

DROP INDEX tlkpUserGroups.tlkpUserGroups$IDEE;




