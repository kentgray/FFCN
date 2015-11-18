SET IDENTITY_INSERT tlkpAppRejectedFFCN ON

INSERT INTO tlkpAppRejectedFFCN (id,Reason)
VALUES (999,NULL);

SET IDENTITY_INSERT tlkpAppRejectedFFCN OFF

UPDATE tblInquiryReferralStatus
SET ReasonAppRejectedFFCN = 999
WHERE ReasonAppRejectedFFCN = 'Ph.D.';

UPDATE tblInquiryReferralStatus
SET ReasonAppRejectedFFCN = 3
WHERE ReasonAppRejectedFFCN = 'Unable to contact';

UPDATE tblInquiryReferralStatus
SET ReasonAppRejectedFFCN = 2
WHERE ReasonAppRejectedFFCN = 'Closed by applicant';

UPDATE tblInquiryReferralStatus
SET ReasonAppRejectedFFCN = 999
WHERE ReasonAppRejectedFFCN IS NULL;

ALTER TABLE tblInquiryReferralStatus
ALTER COLUMN ReasonAppRejectedFFCN INT;

UPDATE tblInquiryReferralStatus
SET ReasonAppRejectedFFCN = 999
WHERE ReasonAppRejectedFFCN > 3

ALTER TABLE tblInquiryReferralStatus
ADD FOREIGN KEY (ReasonAppRejectedFFCN) REFERENCES tlkpAppRejectedFFCN(id);