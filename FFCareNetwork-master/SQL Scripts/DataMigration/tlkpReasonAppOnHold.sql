UPDATE tblInquiryReferralStatus
SET ReasonAppOnHold = 1
WHERE ReasonAppOnHold = 'Awaiting background check';

UPDATE tblInquiryReferralStatus
SET ReasonAppOnHold = 2
WHERE ReasonAppOnHold LIKE '%complete%';

UPDATE tblInquiryReferralStatus
SET ReasonAppOnHold = 3
WHERE ReasonAppOnHold = 'Lack of contact';

UPDATE tblInquiryReferralStatus
SET ReasonAppOnHold = 4
WHERE ReasonAppOnHold = 'Moving';

UPDATE tblInquiryReferralStatus
SET ReasonAppOnHold = 5
WHERE ReasonAppOnHold = 'Other';

UPDATE tblInquiryReferralStatus
SET ReasonAppOnHold = 6
WHERE ReasonAppOnHold = 'Unknown' OR ReasonAppOnHold IS NULL;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN ReasonAppOnHold INT;

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (ReasonAppOnHold) REFERENCES tlkpAppOnHold(id);