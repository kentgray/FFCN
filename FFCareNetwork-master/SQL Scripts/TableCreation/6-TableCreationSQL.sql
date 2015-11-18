CREATE TABLE tlkpHomeClosed
(
id INT IDENTITY (1,1) PRIMARY KEY,
Reason varchar(50) UNIQUE
)

CREATE TABLE tlkpAppRejectedProg
(
id INT IDENTITY (1,1) PRIMARY KEY,
Reason varchar(50) UNIQUE
);
CREATE TABLE tlkpAppOnHold
(
id INT IDENTITY (1,1) PRIMARY KEY,
Reason varchar(50) UNIQUE
);

CREATE TABLE tlkpAppReturned
(
id INT IDENTITY (1,1) PRIMARY KEY,
Reason varchar(50) UNIQUE
);

CREATE TABLE tlkpAppRejectedFFCN
(
id INT IDENTITY (1,1) PRIMARY KEY,
Reason varchar(50) UNIQUE
);

INSERT INTO tlkpAppRejectedFFCN (Reason)
VALUES ('App received, awaiting training'),('Closed by applicant'),('Unable to contact');

INSERT INTO tlkpAppRejectedProg (Reason)
VALUES ('Did not pass background check'),('Rejected by agency, see notes'),('Rejected by FFCN, see notes'),('Other, see notes');

INSERT INTO tlkpAppReturned (Reason)
VALUES ('App withdrawn by applicant'),('Certification Issue'),('Closed by program/agency'),
		('Didn''t pass background check'),('Lack of contact'),('Lack of follow-through'),
		('Moved out of area'),('Switched to other program'),('Training Expired'),('Unknown'),('Went with DHS');

INSERT INTO tlkpAppOnHold (Reason)
VALUES ('Awaiting Background Check'),('Didn''t complete training'),('Lack of contact'),('Moving'),('Other'),('Unknown');

INSERT INTO tlkpHomeClosed (Reason)
VALUES ('Closed by agency'),('Personal choice'),('Stepped down with child'),('Went to another program'),('Unknown');

