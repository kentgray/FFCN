--Add Foreign keys
ALTER TABLE tblAddresses
ADD FOREIGN KEY (CareGiverID)
REFERENCES tblPrimaryCaregiverdata(CareGiverID);

ALTER TABLE tblEmails
ADD FOREIGN KEY (CareGiverID)
REFERENCES tblPrimaryCaregiverdata(CareGiverID);

ALTER TABLE tblPhones
ADD FOREIGN KEY (CareGiverID)
REFERENCES tblPrimaryCaregiverdata(CareGiverID);

ALTER TABLE tblCommunications
ADD FOREIGN KEY (CareGiverID)
REFERENCES tblPrimaryCaregiverdata(CareGiverID);

ALTER TABLE tblRelatedCaregiver
ADD FOREIGN KEY (CareGiverID)
REFERENCES tblPrimaryCaregiverdata(CareGiverID);

INSERT INTO tlkpRecruitmentCategories(Descr, Active)
VALUES ('Unknown',1);

UPDATE tblPrimaryCaregiverdata
SET HeardAbout = 18
WHERE HeardAbout IS NULL OR HeardAbout = 0;

ALTER TABLE tblPrimaryCaregiverdata
ADD HeardAbout2 INT;
GO

UPDATE tblPrimaryCaregiverdata
SET HeardAbout2 = CAST(HeardAbout as INT) from tblPrimaryCaregiverdata;
GO

ALTER TABLE tblPrimaryCaregiverdata
DROP COLUMN HeardAbout;
GO

EXEC sp_rename 'tblPrimaryCaregiverdata.HeardAbout2', 'HeardAbout';
GO

ALTER TABLE tblPrimaryCaregiverdata
ADD FOREIGN KEY (HeardAbout)
REFERENCES tlkpRecruitmentCategories;

INSERT INTO tlkpRelationship (Descr, Active)
VALUES ('Unknown',1);

UPDATE tblRelatedCaregiver
SET Relationship = 15
WHERE Relationship = 0;

ALTER TABLE tblRelatedCaregiver
ADD FOREIGN KEY (Relationship)
REFERENCES tlkpRelationship(id);

INSERT INTO tlkpPhoneTypes (Descr, Active)
VALUES ('Unknown',1);

UPDATE tblPhones
SET PhoneType = 6
WHERE PhoneType = 0 OR PhoneType IS NULL; 

ALTER TABLE tblPhones
ADD FOREIGN KEY (PhoneType)
REFERENCES tlkpPhoneTypes(id);



CREATE TABLE tlkpEmailTypes
(
ID INT NOT NULL PRIMARY KEY,
Descr VARCHAR(10) NOT NULL,
Active BIT NOT NULL,
);

INSERT INTO tlkpEmailTypes (ID,Descr, Active)
VALUES (1,'Home',1),(2,'Work',1),(3,'Unknown',1);

UPDATE tblEmails
SET EmailType = 3
Where EmailType = 0 OR EmailType IS NULL;

ALTER TABLE tblEmails
ADD FOREIGN KEY (EmailType)
REFERENCES tlkpEmailTypes(id);

ALTER TABLE tblTrainingHistoryMain
ALTER COLUMN OngoingTraining9 INT;

ALTER TABLE tblTrainingHistoryMain
ADD FOREIGN KEY (OnGoingTraining9)
REFERENCES tlkpOngoingTraining;

UPDATE tblAddresses
SET AddressType = NULLIF(AddressType,'Washington');

UPDATE tblAddresses
SET AddressType = NULLIF(AddressType,'Clackamas');

UPDATE tblAddresses
SET AddressType = NULLIF(AddressType,'Clatsop');

UPDATE tblAddresses
SET AddressType = NULLIF(AddressType,'Columbia');

UPDATE tblAddresses
SET AddressType = NULLIF(AddressType,'Josephine');

UPDATE tblAddresses
SET AddressType = NULLIF(AddressType,'Marion');

UPDATE tblAddresses
SET AddressType = NULLIF(AddressType,'Linn');

UPDATE tblAddresses
SET AddressType = NULLIF(AddressType,'Multnomah');

UPDATE tblAddresses
SET AddressType = NULLIF(AddressType,'Yamhill');

UPDATE tblAddresses
SET AddressType = NULLIF(AddressType,'Lane');

ALTER TABLE tblAddresses
ALTER COLUMN AddressType INT;

INSERT INTO tlkpAddressType (Descr, Active)
VALUES ('Unknown',1);

UPDATE tblAddresses
SET AddressType = 4
WHERE AddressType IS NULL OR AddressType > 3 OR AddressType = 0;

ALTER TABLE tblAddresses
ADD FOREIGN KEY (AddressType)
REFERENCES tlkpAddressType(id);

--Drop SSMA timestamp columns
