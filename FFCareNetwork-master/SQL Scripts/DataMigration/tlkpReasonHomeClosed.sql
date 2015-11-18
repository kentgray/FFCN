UPDATE tblInquiryReferralStatus
SET ReasonHomeClosed = 1
WHERE ReasonHomeClosed = 'Closed by agency';

UPDATE tblInquiryReferralStatus
SET ReasonHomeClosed = 2
WHERE ReasonHomeClosed = 'Personal choice';

UPDATE tblInquiryReferralStatus
SET ReasonHomeClosed = 3
WHERE ReasonHomeClosed = 'Stepped down with child';

UPDATE tblInquiryReferralStatus
SET ReasonHomeClosed = 4
WHERE ReasonHomeClosed = 'Went to another program';

UPDATE tblInquiryReferralStatus
SET ReasonHomeClosed = 5
WHERE ReasonHomeClosed = 'Unknown' OR ReasonHomeClosed IS NULL;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN ReasonHomeClosed INT;

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (ReasonHomeClosed) REFERENCES tlkpHomeClosed(id);