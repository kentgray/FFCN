SET IDENTITY_INSERT tlkpCommunicationTypes ON;

INSERT INTO tlkpCommunicationTypes (ID,Descr,Active)
VALUES (999,NULL,1);

SET IDENTITY_INSERT tlkpCommunicationTypes OFF;

UPDATE tblCommunications
SET CommType = 999
WHERE CommType = 0 OR CommType = 46 OR CommType IS NULL;

ALTER TABLE tblCommunications
ADD FOREIGN KEY (CommType) REFERENCES tlkpCommunicationTypes(id);