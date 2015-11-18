SET IDENTITY_INSERT tlkpAppRejectedProg ON

INSERT INTO tlkpAppRejectedProg (ID,Reason)
VALUES (999,NULL);

SET IDENTITY_INSERT tlkpAppRejectedProg OFF

UPDATE tblInquiryReferralStatus
SET ReasonAppRejectedProg = 1
WHERE ReasonAppRejectedProg = 'Did not pass background check';

UPDATE tblInquiryReferralStatus
SET ReasonAppRejectedProg = 2
WHERE ReasonAppRejectedProg = 'Rejected by agency, see notes';

UPDATE tblInquiryReferralStatus
SET ReasonAppRejectedProg = 3
WHERE ReasonAppRejectedProg = 'Rejected by FFCN, see notes';

UPDATE tblInquiryReferralStatus
SET ReasonAppRejectedProg = 4
WHERE ReasonAppRejectedProg = 'Other, see notes';

UPDATE tblInquiryReferralStatus
SET ReasonAppRejectedProg = 999
WHERE ReasonAppRejectedProg IS NULL;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN ReasonAppRejectedProg INT;

UPDATE tblInquiryReferralStatus
SET ReasonAppRejectedProg = 999
WHERE ReasonAppRejectedProg > 4

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (ReasonAppRejectedProg) REFERENCES tlkpAppRejectedProg(id);