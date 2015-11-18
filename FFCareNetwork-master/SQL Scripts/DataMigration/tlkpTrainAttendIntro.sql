SET IDENTITY_INSERT tlkpTrainAttendIntro ON

INSERT INTO tlkpTrainAttendIntro (ID,TrainDate)
VALUES (999,NULL);

SET IDENTITY_INSERT tlkpTrainAttendIntro OFF

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 236
WHERE TrainDateAttendedIntro = 32;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 237
WHERE TrainDateAttendedIntro = 33;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 239
WHERE TrainDateAttendedIntro = 35 ;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 243
WHERE TrainDateAttendedIntro = 39;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 246
WHERE TrainDateAttendedIntro = 42;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 229
WHERE TrainDateAttendedIntro = 25;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 219
WHERE TrainDateAttendedIntro = 15;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 232
WHERE TrainDateAttendedIntro = 28;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 220
WHERE TrainDateAttendedIntro = 16;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 235
WHERE TrainDateAttendedIntro = 31;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 231
WHERE TrainDateAttendedIntro = 27;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 214
WHERE TrainDateAttendedIntro = 10;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 239
WHERE TrainDateAttendedIntro = 35;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 232
WHERE TrainDateAttendedIntro = 28;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 230
WHERE TrainDateAttendedIntro = 26;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 217
WHERE TrainDateAttendedIntro = 13;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 249
WHERE TrainDateAttendedIntro = 45;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 216
WHERE TrainDateAttendedIntro = 12;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 247
WHERE TrainDateAttendedIntro = 43;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 224
WHERE TrainDateAttendedIntro = 20;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 226
WHERE TrainDateAttendedIntro = 22;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 289
WHERE TrainDateAttendedIntro = 85;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 233
WHERE TrainDateAttendedIntro = 29;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 218
WHERE TrainDateAttendedIntro = 14;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 234
WHERE TrainDateAttendedIntro = 30;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 221
WHERE TrainDateAttendedIntro = 17;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 281
WHERE TrainDateAttendedIntro = 77;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 260
WHERE TrainDateAttendedIntro = 56;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 243
WHERE TrainDateAttendedIntro = 39;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 226
WHERE TrainDateAttendedIntro = 22;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 244
WHERE TrainDateAttendedIntro = 40;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 227
WHERE TrainDateAttendedIntro = 23;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 245
WHERE TrainDateAttendedIntro = 41;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 247
WHERE TrainDateAttendedIntro =243;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 325
WHERE TrainDateAttendedIntro = 122;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 265
WHERE TrainDateAttendedIntro = 61;

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 999
WHERE TrainDateAttendedIntro LIKE '%/%/%';

UPDATE tblTrainingHistoryMain
SET TrainDateAttendedIntro = 999
WHERE TrainDateAttendedIntro IS NULL;

ALTER TABLE tblTrainingHistoryMain
ALTER COLUMN TrainDateAttendedIntro INT;

ALTER TABLE tblTrainingHistoryMain
ADD FOREIGN KEY (TrainDateAttendedIntro) REFERENCES tlkpTrainAttendIntro(id);