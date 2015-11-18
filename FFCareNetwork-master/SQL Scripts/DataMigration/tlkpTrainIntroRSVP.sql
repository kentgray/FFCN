SET IDENTITY_INSERT tlkpTrainIntroRSVP ON

INSERT INTO tlkpTrainIntroRSVP(ID,TrainDate)
VALUES (999,NULL);

SET IDENTITY_INSERT tlkpTrainIntroRSVP OFF

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 95
WHERE TrainDateIntro = 31;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 96
WHERE TrainDateIntro = 32;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 77
WHERE TrainDateIntro = 13;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 92
WHERE TrainDateIntro = 28;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 78
WHERE TrainDateIntro = 14;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 93
WHERE TrainDateIntro = 29;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 79
WHERE TrainDateIntro = 15;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 94
WHERE TrainDateIntro = 30;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 97
WHERE TrainDateIntro = 33;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 80
WHERE TrainDateIntro = 16;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 81
WHERE TrainDateIntro = 17;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 85
WHERE TrainDateIntro = 21;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 86
WHERE TrainDateIntro = 22;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 76
WHERE TrainDateIntro = 12;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 90
WHERE TrainDateIntro = 26;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 75
WHERE TrainDateIntro = 11;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 87
WHERE TrainDateIntro = 23;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 88
WHERE TrainDateIntro = 24;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 74
WHERE TrainDateIntro = 10;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 89
WHERE TrainDateIntro = 25;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 73
WHERE TrainDateIntro = 9;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 82
WHERE TrainDateIntro = 18;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 83
WHERE TrainDateIntro = 19;

UPDATE tblTrainingHistoryMain
SET TrainDateIntro = 999
WHERE TrainDateIntro IS NULL;

ALTER TABLE tblTrainingHistoryMain
ALTER COLUMN TrainDateIntro INT;

ALTER TABLE tblTrainingHistoryMain
ADD FOREIGN KEY (TrainDateIntro) REFERENCES tlkpTrainIntroRSVP(id);