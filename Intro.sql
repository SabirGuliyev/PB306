
--CREATE DATABASE PB306

USE PB306

CREATE TABLE Students(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(25) NOT NULL,
Surname NVARCHAR(25) DEFAULT 'XXX',
Email VARCHAR(256) UNIQUE,
Age INT CHECK(Age>10 AND Age<65) NOT NULL
)

--TRUNCATE TABLE Students

--ALTER TABLE Students ADD FinCode CHAR(7)
--ALTER TABLE Students DROP COLUMN FinCode

--DROP TABLE Students


--INSERT
--INTO
--Students
--VALUES
--(3,N'Əli','Aliyev','test@'),
--(4,N'Nasib','Testov','test2@'),
--(5,N'Zulfuqar','Aliyev','test3@'),
--(6,N'vali','Aliyev','test@')




--INSERT INTO Students(Name,Email,Id) 
--VALUES('Test','@',10)

--UPDATE Students SET Surname='Aliyev' WHERE Id=4

--DELETE FROM Students WHERE Id=3

--SELECT [Name]+' '+Surname AS [Fullname], Age
--FROM Students
--WHERE Name LIKE '_a%'


