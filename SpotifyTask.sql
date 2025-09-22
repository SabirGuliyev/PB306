CREATE DATABASE SpotifyTask

USE SpotifyTask




CREATE TABLE Artists(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(50) NOT NULL,
Surname NVARCHAR(50) NOT NULL,
Birthday DATE,
Gender VARCHAR(10) CHECK(Gender IN ('male','female','others'))
)




CREATE TABLE Users(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(50) NOT NULL,
Surname NVARCHAR(50) NOT NULL,
Username VARCHAR(128) UNIQUE NOT NULL,
Password NVARCHAR(128) NOT NULL CHECK(LEN(Password)>=8),
Gender VARCHAR(10) CHECK(Gender IN ('male','female','others'))

)


CREATE TABLE Categories(

Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(100) UNIQUE NOT NULL,
)


CREATE TABLE Musics(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(150) NOT NULL,
Duration INT NOT NULL CHECK(Duration>0),
CategoryId INT REFERENCES Categories(Id),
ArtistId INT REFERENCES Artists(Id) NOT NULL
)

CREATE TABLE Playlists(
UserId INT REFERENCES Users(Id) NOT NULL,
MusicId INT REFERENCES Musics(Id) NOT NULL
)


--1. Mahnını adını, uzunluğunu, 
--kateqoriyasını, hansı ifaçı tərəfindən oxunulduğunu
--bildirən sorğunu özündə saxlayan updateable view yazın

CREATE VIEW GetMusicsInfo
AS
SELECT m.Name,m.Duration,c.Name AS Category,a.Name AS Artist FROM Musics AS m
JOIN Categories AS c
ON m.CategoryId=c.Id
JOIN Artists AS a
ON m.ArtistId=a.Id

SELECT * FROM GetMusicsInfo



--2.Procedure yazirsiz Id qebul edir hemin Id-li userin
--playlistinə əlavə etdiyi mahnıların siyahısını çıxarır


CREATE PROCEDURE GetUserMusics @id INT
AS
SELECT m.Name FROM Users AS u
JOIN Playlists AS p
ON u.Id=p.UserId
JOIN Musics AS m
ON p.MusicId=m.Id
WHERE u.Id=@id

EXEC GetUserMusics 5

Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(150) NOT NULL,
Duration INT NOT NULL CHECK(Duration>0),
CategoryId INT REFERENCES Categories(Id),
ArtistId INT REFERENCES Artists(Id) NOT NULL


CREATE PROCEDURE CreateMusic @name VARCHAR(150),@duration INT,@categoryId INT, @artistId INT
AS
INSERT INTO Musics VALUES (@name,@duration,@categoryId,@artistId)

EXEC CreateMusic 'Lithium',156,1,1



--4. Function yazirsiz . Id qebul edir gonderilen Id-li 
--Userin dinlediyi Ifacilarin sayini geriye qaytarir
--(Ifacilarin sayini mahnilarin yox)


CREATE FUNCTION GetArtistsCount (@id INT)
RETURNS INT
AS
BEGIN
DECLARE @count INT

SET @count=(SELECT COUNT(*) AS [Artist Count] FROM 
(SELECT COUNT(m.Name) AS MusicCount, a.Name FROM Users AS u
JOIN Playlists AS p
ON u.Id=p.UserId
JOIN Musics AS m
ON p.MusicId=m.Id
JOIN Artists AS a
ON m.ArtistId=a.Id
WHERE u.Id=@id
GROUP BY a.Name) AS sub)

RETURN @count
END


SELECT dbo.GetArtistsCount(2)


SELECT Name,Duration FROM Musics
ORDER BY Duration ASC



SELECT a.Name, COUNT(m.Name) AS MusicCount FROM Artists AS a
JOIN Musics AS m
ON a.Id=m.ArtistId
GROUP BY a.Name
HAVING COUNT(m.Name)=(SELECT MAX(MusicCount) AS MaxCount FROM (
SELECT COUNT(m.Name) AS MusicCount FROM Artists AS a
JOIN Musics AS m
ON a.Id=m.ArtistId
GROUP BY a.Name) AS sub)






SELECT MAX(sub.MusicCount) AS MaxCount FROM(
SELECT COUNT(m.Name) AS MusicCount FROM Artists AS a
JOIN Musics AS m
ON a.Id=m.ArtistId
GROUP BY a.Name) as sub


ALTER TABLE Users ADD IsDeleted BIT


CREATE TRIGGER SofDeleteOnUsers
ON Users
INSTEAD OF DELETE
AS
DECLARE @id INT
DECLARE @isDeleted BIT

SELECT @id=Id,@isDeleted=IsDeleted FROM DELETED

IF @isDeleted=0
	BEGIN
	UPDATE Users SET IsDeleted=1 WHERE  Id=@id
	END
ELSE
	BEGIN
	DELETE FROM Users WHERE Id=@id
	END




	DELETE FROM Users WHERE Id=4