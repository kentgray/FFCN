SET IDENTITY_INSERT tlkpTrainPreserviceComp ON

INSERT INTO tlkpTrainPreserviceComp (ID,TrainDate)
VALUES (999,NULL);

SET IDENTITY_INSERT tlkpTrainPreserviceComp OFF

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceComp = 1
WHERE TrainDatePreserviceComp = '13 Hour Cert';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceComp = 2
WHERE TrainDatePreserviceComp = '16 Hour Cert';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceComp = 999
WHERE TrainDatePreserviceComp LIKE '%/%/%';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceComp = 999
WHERE TrainDatePreserviceComp IS NULL;

ALTER TABLE tblTrainingHistoryMain
ALTER COLUMN TrainDatePreserviceComp INT;

ALTER TABLE tblTrainingHistoryMain
ADD FOREIGN KEY (TrainDatePreserviceComp) REFERENCES tlkpTrainPreserviceComp(id);