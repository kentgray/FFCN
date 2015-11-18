DELETE
FROM tblAddresses
WHERE NOT EXISTS (SELECT CareGiverID FROM tblPrimaryCaregiverdata
WHERE CareGiverID = tblAddresses.CareGiverID);

DELETE
FROM tblPhones
WHERE NOT EXISTS (SELECT CareGiverID FROM tblPrimaryCaregiverdata
WHERE CareGiverID = tblPhones.CareGiverID);

DELETE
FROM tblEmails
WHERE NOT EXISTS (SELECT CareGiverID FROM tblPrimaryCaregiverdata
WHERE CareGiverID = tblEmails.CareGiverID);

DELETE
FROM tblCommunications
WHERE NOT EXISTS (SELECT CareGiverID FROM tblPrimaryCaregiverdata
WHERE CareGiverID = tblCommunications.CareGiverID);

DELETE
FROM tblRelatedCaregiver
WHERE NOT EXISTS (SELECT CareGiverID FROM tblPrimaryCaregiverdata
WHERE CareGiverID = tblRelatedCaregiver.CareGiverID);