SET IDENTITY_INSERT tlkpProgram ON;

INSERT INTO tlkpProgram (ID,Description,Active)
VALUES (999,NULL,1);

SET IDENTITY_INSERT tlkpProgram OFF;

UPDATE tblInquiryReferralStatus
SET ReasonAppProgram = 999
WHERE ReasonAppProgram IS NULL;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN ReasonAppProgram INT;

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (ReasonAppProgram) REFERENCES tlkpProgram(ID);

UPDATE tblInquiryReferralStatus
SET ReasonHomeCert = 999
WHERE ReasonHomeCert = 'Ph.D.' OR ReasonHomeCert IS NULL;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN ReasonHomeCert INT;

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (ReasonHomeCert) REFERENCES tlkpProgram(ID);

UPDATE tblInquiryReferralStatus
SET ReasonAppReferredProg = 999
WHERE ReasonAppReferredProg = 'Ph.D.' OR ReasonAppReferredProg IS NULL;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN ReasonAppReferredProg INT;

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (ReasonAppReferredProg) REFERENCES tlkpProgram(ID);

UPDATE tblInquiryReferralStatus
SET ReasonAppReferredAnother = 999
WHERE ReasonAppReferredAnother = 'Ph.D.' OR  ReasonAppReferredAnother IS NULL;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN ReasonAppReferredAnother INT;

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (ReasonAppReferredAnother) REFERENCES tlkpProgram(ID);