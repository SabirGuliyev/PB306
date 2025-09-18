
CREATE TABLE Users(
Id INT PRIMARY KEY IDENTITY,
Username VARCHAR(128) UNIQUE

)

CREATE TABLE Musics(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(128) NOT NULL
)


CREATE TABLE Playlists(
UserId INT FOREIGN KEY REFERENCES Users(Id),
MusicId INT FOREIGN KEY REFERENCES Musics(Id)
)

SELECT m.Name FROM Users AS u
JOIN Playlists AS p
ON u.Id=p.UserId
JOIN Musics AS m
ON p.MusicId=m.Id



















CREATE DATABASE ViewExample

USE ViewExample


CREATE TABLE Students(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(50) NOT NULL,
Surname NVARCHAR(50) NOT NULL,
Point INT CHECK(Point>=0 AND Point<=100),
IsDeleted BIT
)


ALTER TABLE Students ADD IsDeleted BIT




DELETE FROM Students WHERE Id=7




SELECT * FROM Students WHERE IsDeleted=0








CREATE TRIGGER SoftDelete
ON Students
INSTEAD OF DELETE
AS
BEGIN

DECLARE @isDeleted BIT
DECLARE @id INT

SELECT @isDeleted=IsDeleted,@id=Id FROM DELETED

IF(@isDeleted=0 OR @isDeleted IS NULL)
	BEGIN
	 UPDATE Students SET IsDeleted=1 WHERE Id=@id
	END
ELSE
	BEGIN
	DELETE FROM Students WHERE Id=@id
	END

END










ALTER TRIGGER GetStudentsAfterDelete
ON Students
AFTER DELETE
AS
SELECT * FROM DELETED


CREATE TRIGGER CreateCapitalizedStudent
ON Students
INSTEAD OF INSERT
AS
DECLARE @name NVARCHAR(50)
DECLARE @surname NVARCHAR(50)
DECLARE @point INT
SELECT @name=Name,@surname=Surname,@point=Point FROM INSERTED

SET @name=(SELECT dbo.Capitalize(@name))
SET @surname=(SELECT dbo.Capitalize(@surname))

INSERT INTO Students VALUES (@name,@surname,@point)




INSERT INTO Students VALUES('teST','teSToV',100)







DELETE FROM Students WHERE Id=8
















CREATE PROCEDURE usp_CreateStudent @name NVARCHAR(50), @surname NVARCHAR(50),@point INT
AS
SET @name=(SELECT dbo.Capitalize(@name))
SET @surname=(SELECT dbo.Capitalize(@surname))

INSERT INTO Students VALUES(@name,@surname,@point)












EXEC usp_CreateStudent 'teST','tEsTov',100


INSERT 












CREATE FUNCTION Capitalize (@word NVARCHAR(150))
RETURNS NVARCHAR(150)
AS
BEGIN
SET @word=UPPER(LEFT(@word,1))+LOWER(SUBSTRING(@word,2,LEN(@word)-1))
RETURN @word
END




SELECT dbo.Capitalize('saLAM')












CREATE 
FUNCTION 
GetSum(@num INT,@num2 INT)
RETURNS INT
AS
BEGIN
DECLARE @sum INT
SET @sum=(@num+@num2)
RETURN @sum
END


SELECT  dbo.GetSum(5,6)

















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
WHERE Point BETWEEN 67 AND 86


SELECT * FROM GetStudentsGrades
WHERE Point IN(86,67,50,46)













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