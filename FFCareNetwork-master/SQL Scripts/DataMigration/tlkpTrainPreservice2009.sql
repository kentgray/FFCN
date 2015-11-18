SET IDENTITY_INSERT tlkpTrainPreservice2009 ON

INSERT INTO tlkpTrainPreservice2009 (ID,TrainDate)
VALUES (999,NULL);

SET IDENTITY_INSERT tlkpTrainPreservice2009 OFF

UPDATE tblTrainingHistoryMain
SET TrainDatePreservice2009 = 4
WHERE TrainDatePreservice2009 = '9/20/08';

UPDATE tblTrainingHistoryMain
SET TrainDatePreservice2009 = 4
WHERE TrainDatePreservice2009 = '2/13/07-3/20/07';

UPDATE tblTrainingHistoryMain
SET TrainDatePreservice2009 = 999
WHERE TrainDatePreservice2009 IS NULL;

ALTER TABLE tblTrainingHistoryMain
ALTER COLUMN TrainDatePreservice2009 INT;

ALTER TABLE tblTrainingHistoryMain
ADD FOREIGN KEY (TrainDatePreservice2009) REFERENCES tlkpTrainPreservice2009(id);