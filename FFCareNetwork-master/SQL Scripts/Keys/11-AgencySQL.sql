UPDATE tblUsers
SET Agency = 1
WHERE Agency = 0;

ALTER TABLE tblUsers
ADD FOREIGN KEY (Agency) REFERENCES tlkpAgencies(id);