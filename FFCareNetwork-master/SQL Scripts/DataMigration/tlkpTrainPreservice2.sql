SET IDENTITY_INSERT tlkpTrainPreservice2 ON

INSERT INTO tlkpTrainPreservice2(ID,TrainDate)
VALUES (999,NULL);

SET IDENTITY_INSERT tlkpTrainPreservice2 OFF

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 25
WHERE TrainDateAttendedPreservice2 LIKE '%9/28/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 14
WHERE TrainDateAttendedPreservice2 LIKE '%9/27/%14';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 26
WHERE TrainDateAttendedPreservice2 LIKE '%8/25/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 15
WHERE TrainDateAttendedPreservice2 LIKE '%8/24/%14';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 38
WHERE TrainDateAttendedPreservice2 LIKE '%7/29/%12';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 27
WHERE TrainDateAttendedPreservice2 LIKE '%7/21/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 16
WHERE TrainDateAttendedPreservice2 LIKE '%7/20/%14';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 39
WHERE TrainDateAttendedPreservice2 LIKE '%6/30/%12';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 17
WHERE TrainDateAttendedPreservice2 LIKE '%6/28/%14';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 28
WHERE TrainDateAttendedPreservice2 LIKE '%6/29/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 23
WHERE TrainDateAttendedPreservice2 LIKE '11/23/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 13
WHERE TrainDateAttendedPreservice2 LIKE '%10/25/%14';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 29
WHERE TrainDateAttendedPreservice2 LIKE '5/18/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 30
WHERE TrainDateAttendedPreservice2 LIKE '4/20/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 19
WHERE TrainDateAttendedPreservice2 LIKE '4/19/%14';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 31
WHERE TrainDateAttendedPreservice2 LIKE '3/23/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 20
WHERE TrainDateAttendedPreservice2 LIKE '3/22/%14';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 32
WHERE TrainDateAttendedPreservice2 LIKE '2/23/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 21
WHERE TrainDateAttendedPreservice2 LIKE '2/22/%14';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 11
WHERE TrainDateAttendedPreservice2 LIKE '1/17/%15';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 22
WHERE TrainDateAttendedPreservice2 LIKE '1/18/%14';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 33
WHERE TrainDateAttendedPreservice2 LIKE '1/19/%13';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 65
WHERE TrainDateAttendedPreservice2 LIKE '12/5/%09';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 44
WHERE TrainDateAttendedPreservice2 LIKE '1/21/%12';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedPreservice2 = 999
WHERE TrainDateAttendedPreservice2 IS NULL;

ALTER TABLE tblTrainingHistoryMain
ALTER COLUMN TrainDateAttendedPreservice2 INT;

ALTER TABLE tblTrainingHistoryMain
ADD FOREIGN KEY (TrainDateAttendedPreservice2) REFERENCES tlkpTrainPreservice2(id);