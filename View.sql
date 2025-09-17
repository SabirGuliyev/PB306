
CREATE DATABASE ViewExample

USE ViewExample


CREATE TABLE Students(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(50) NOT NULL,
Surname NVARCHAR(50) NOT NULL,
Point INT CHECK(Point>=0 AND Point<=100)
)



CREATE PROCEDURE usp_CreateStudent @name NVARCHAR(50), @surname NVARCHAR(50),@point INT
AS
SET @name=UPPER(LEFT(@name,1))+LOWER(SUBSTRING(@name,2,LEN(@name)-1))
SET @surname=UPPER(LEFT(@surname,1))+LOWER(SUBSTRING(@surname,2,LEN(@surname)-1))

INSERT INTO Students VALUES(@name,@surname,@point)







EXEC usp_CreateStudent 'raFIg','tesTOV',99



















CREATE TABLE Grades(
Id INT PRIMARY KEY IDENTITY,
Letter CHAR(2) UNIQUE NOT NULL,
MinGrade INT CHECK(MinGrade>=0 AND MinGrade<=91),
MaxGrade INT CHECK(MaxGrade>=50 AND MaxGrade<=100)
)



CREATE VIEW GetStudentsGrades
AS
SELECT s.Name,s.Surname,s.Point,g.Letter AS Grade FROM Students AS s
JOIN Grades AS g
ON s.Point>=g.MinGrade AND Point<=g.MaxGrade

--DROP VIEW GetStudentsGrades

SELECT * FROM GetStudentsGrades


SELECT Name,Surname,Point FROM Students AS s
JOIN Grades AS g
ON s.Point>=g.MinGrade AND Point<=g.MaxGrade
WHERE Point=(SELECT MAX(Point) FROM (SELECT s.Name,s.Surname,s.Point,g.Letter AS Grade FROM Students AS s
JOIN Grades AS g
ON s.Point>=g.MinGrade AND Point<=g.MaxGrade
WHERE Point>50) AS sub)


CREATE VIEW GetTopStudent
AS
SELECT Name,Surname,Point FROM GetStudentsGrades
WHERE Point=(SELECT MAX(Point) FROM (SELECT * FROM GetStudentsGrades
WHERE Point>50) AS sub)


SELECT * FROM GetTopStudent





SELECT * FROM GetStudentsGrades
Order BY Point


SELECT * FROM GetStudentsGrades
Where Point>7

SELECT * FROM GetStudentsGrades
Where Point>70



CREATE PROCEDURE usp_GetStudentsByPoint @point INT
AS

SELECT * FROM GetStudentsGrades 
WHERE Point>@point



EXEC usp_GetStudentsByPoint 80



















SELECT * FROM GetStudentsGrades
Where Point>80



SELECT * FROM GetStudentsGrades
ORDER BY s.Point


SELECT s.Name,s.Point,g.Letter AS Grade FROM Students AS s
JOIN Grades AS g
ON s.Point>=g.MinGrade AND Point<=g.MaxGrade
WHERE s.Point>50

SELECT s.Name,s.Point,g.Letter AS Grade FROM Students AS s
JOIN Grades AS g
ON s.Point>=g.MinGrade AND Point<=g.MaxGrade




SELECT Letter FROM Grades WHERE Letter='C'