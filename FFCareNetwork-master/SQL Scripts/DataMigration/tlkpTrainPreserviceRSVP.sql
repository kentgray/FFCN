SET IDENTITY_INSERT tlkpTrainPreserviceRSVP ON

INSERT INTO tlkpTrainPreserviceRSVP (ID,TrainDate)
VALUES (999,NULL);

SET IDENTITY_INSERT tlkpTrainPreserviceRSVP OFF

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 3
WHERE TrainDatePreserviceRSVP LIKE '%2015-Sep';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 13
WHERE TrainDatePreserviceRSVP LIKE '%2014-Sep';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 12
WHERE TrainDatePreserviceRSVP LIKE '%2014-Oct';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 24
WHERE TrainDatePreserviceRSVP LIKE '%2014-Nov';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 17
WHERE TrainDatePreserviceRSVP LIKE '%2014-May';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 19
WHERE TrainDatePreserviceRSVP LIKE '%2014-Mar';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 16
WHERE TrainDatePreserviceRSVP LIKE '%2014-Jun';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 15
WHERE TrainDatePreserviceRSVP LIKE '%2014-Jul';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 21
WHERE TrainDatePreserviceRSVP LIKE '%2014-Jan';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 20
WHERE TrainDatePreserviceRSVP LIKE '%2014-Feb';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 25
WHERE TrainDatePreserviceRSVP LIKE '%2014-Aug';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 18
WHERE TrainDatePreserviceRSVP LIKE '%2014-Apr';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 23
WHERE TrainDatePreserviceRSVP LIKE '%2013-Oct';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 22
WHERE TrainDatePreserviceRSVP LIKE '%2013-Nov';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 9
WHERE TrainDatePreserviceRSVP LIKE '2015-Mar';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 11
WHERE TrainDatePreserviceRSVP LIKE '2015-Jan';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 10
WHERE TrainDatePreserviceRSVP LIKE '2015-Feb';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 13
WHERE TrainDatePreserviceRSVP LIKE '2014-Sep';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 26
WHERE TrainDatePreserviceRSVP LIKE '%/%/%';

UPDATE tblTrainingHistoryMain
SET TrainDatePreserviceRSVP = 999
WHERE TrainDatePreserviceRSVP IS NULL;

ALTER TABLE tblTrainingHistoryMain
ALTER COLUMN TrainDatePreserviceRSVP INT;

ALTER TABLE tblTrainingHistoryMain
ADD FOREIGN KEY (TrainDatePreserviceRSVP) REFERENCES tlkpTrainPreserviceRSVP(id);