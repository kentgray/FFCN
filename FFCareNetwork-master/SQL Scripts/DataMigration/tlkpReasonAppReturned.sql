UPDATE tblInquiryReferralStatus
SET ReasonAppReturned = 11
WHERE ReasonAppReturned = 'Went with DHS';

UPDATE tblInquiryReferralStatus
SET ReasonAppReturned = 8
WHERE ReasonAppReturned LIKE 'Switched to other program';

UPDATE tblInquiryReferralStatus
SET ReasonAppReturned = 7
WHERE ReasonAppReturned = 'Moved out area';

UPDATE tblInquiryReferralStatus
SET ReasonAppReturned = 6
WHERE ReasonAppReturned = 'Lack of follow-through';

UPDATE tblInquiryReferralStatus
SET ReasonAppReturned = 5
WHERE ReasonAppReturned = 'Lack of contact';

UPDATE tblInquiryReferralStatus
SET ReasonAppReturned = 4
WHERE CareGiverID = 5314;

UPDATE tblInquiryReferralStatus
SET ReasonAppReturned = 3
WHERE ReasonAppReturned = 'Closed by program/agency';

UPDATE tblInquiryReferralStatus
SET ReasonAppReturned = 2
WHERE ReasonAppReturned = 'Certification Issue';

UPDATE tblInquiryReferralStatus
SET ReasonAppReturned = 1
WHERE ReasonAppReturned = 'App withdrawn by applicant';

UPDATE tblInquiryReferralStatus
SET ReasonAppReturned = 10
WHERE ReasonAppReturned = 'Unknown' OR ReasonAppReturned IS NULL;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN ReasonAppReturned INT;

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (ReasonAppReturned) REFERENCES tlkpAppReturned(id);