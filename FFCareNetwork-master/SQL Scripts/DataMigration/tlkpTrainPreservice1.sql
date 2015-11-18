SET IDENTITY_INSERT tlkpTrainPreservice1 ON

INSERT INTO tlkpTrainPreservice1(ID,TrainDate)
VALUES (999,NULL);

SET IDENTITY_INSERT tlkpTrainPreservice1 OFF

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 25
WHERE TrainDateAttendedPreservice1 LIKE '%9/21/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 25
WHERE TrainDateAttendedPreservice1 LIKE '%9/28/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 14
WHERE TrainDateAttendedPreservice1 LIKE '%9/20/%14';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 26
WHERE TrainDateAttendedPreservice1 LIKE '%8/24/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 15
WHERE TrainDateAttendedPreservice1 LIKE '%8/23/%14';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 27
WHERE TrainDateAttendedPreservice1 LIKE '%7/20/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 16
WHERE TrainDateAttendedPreservice1 LIKE '%7/19/%14';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 28
WHERE TrainDateAttendedPreservice1 LIKE '%6/22/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 17
WHERE TrainDateAttendedPreservice1 LIKE '%6/21/%14';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 19
WHERE TrainDateAttendedPreservice1 LIKE '%4/12/%14';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 20
WHERE TrainDateAttendedPreservice1 LIKE '%3/15/%14';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 21
WHERE TrainDateAttendedPreservice1 LIKE '%2/15/%14';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 23
WHERE TrainDateAttendedPreservice1 LIKE '11/16/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 13
WHERE TrainDateAttendedPreservice1 LIKE '10/18/%14';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 22
WHERE TrainDateAttendedPreservice1 LIKE '1/11/%14';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 11
WHERE TrainDateAttendedPreservice1 LIKE '1/10/%15';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 32
WHERE TrainDateAttendedPreservice1 LIKE '2/16/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 31
WHERE TrainDateAttendedPreservice1 LIKE '%3/16/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 29
WHERE TrainDateAttendedPreservice1 LIKE '%5/11/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 38
WHERE TrainDateAttendedPreservice1 LIKE '%7/28/%12';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 30
WHERE TrainDateAttendedPreservice1 LIKE '%4/13/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 10
WHERE TrainDateAttendedPreservice1 LIKE '2/21/%15';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 65
WHERE TrainDateAttendedPreservice1 LIKE '11/21/%09';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 34
WHERE TrainDateAttendedPreservice1 LIKE '11/17/%12';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 12
WHERE TrainDateAttendedPreservice1 LIKE '11/15/%14';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 44
WHERE TrainDateAttendedPreservice1 LIKE '1/14/%12';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 33
WHERE TrainDateAttendedPreservice1 LIKE '1/12/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice1 = 999
WHERE TrainDateAttendedPreservice1 IS NULL;

ALTER TABLE tblTrainingHistoryMain
ALTER COLUMN TrainDateAttendedPreservice1 INT;

ALTER TABLE tblTrainingHistoryMain
ADD FOREIGN KEY (TrainDateAttendedPreservice1) REFERENCES tlkpTrainPreservice1(id);