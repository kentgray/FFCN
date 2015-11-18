
EXEC sp_rename 'tlkpUserGroups.IDEE', 'id';
GO

UPDATE tblUsers
SET UserGroup = 1
WHERE UserGroup = 0;

ALTER TABLE tblUsers
ADD FOREIGN KEY (UserGroup) REFERENCES tlkpUserGroups(id);