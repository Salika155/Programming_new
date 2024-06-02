USE JARDINERIA
DROP DATABASE WPF_JUEGOS

-------------------------------------------------------------------------
CREATE DATABASE WPF_JUEGOS;
USE WPF_JUEGOS



CREATE TABLE USERTABLE(
    User_ID INT IDENTITY PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Password VARCHAR(100) NOT NULL
);

CREATE TABLE GENRE (
    ID_Genre INT IDENTITY PRIMARY KEY,
    Name_genres VARCHAR(100) NOT NULL
);

CREATE TABLE DEVELOPER (
    ID_Developer INT IDENTITY PRIMARY KEY,
    Name_Developer VARCHAR(100) NOT NULL
);

CREATE TABLE PLATAFORMA (
    Platform_ID INT IDENTITY PRIMARY KEY,
    Name_Platform VARCHAR(100) NOT NULL
);

CREATE TABLE GAME (
    ID_Game INT IDENTITY PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Description VARCHAR(300),
    ReleaseYear SMALLDATETIME,
    Rating INT,
    img VARCHAR(400),
    Genre_ID INT NOT NULL,
    Developer_ID INT ,
    User_ID INT NOT NULL,
    Price DECIMAL(10, 2),
    PurchaseDate SMALLDATETIME,
    CompletionDate SMALLDATETIME,
	Platform_ID INT NOT NULL,
    Status VARCHAR(50) NOT NULL

    CONSTRAINT FK_JUEGO_GENRE FOREIGN KEY (Genre_ID) REFERENCES GENRE(ID_Genre),
    CONSTRAINT FK_JUEGO_DEVELOPER FOREIGN KEY (Developer_ID) REFERENCES DEVELOPER(ID_Developer),
    CONSTRAINT FK_JUEGO_USUARIO FOREIGN KEY (User_ID) REFERENCES USERTABLE(User_ID)
);

CREATE TABLE JUEGO_PLATAFORM (
    Juego_ID INT,
    Platform_ID INT NOT NULL,
    CONSTRAINT PK_JUEGO_PLATAFORM PRIMARY KEY (Juego_ID, Platform_ID),
    CONSTRAINT FK_JUEGO_PLATAFORM_JUEGO FOREIGN KEY (Juego_ID) REFERENCES GAME(ID_Game),
    CONSTRAINT FK_JUEGO_PLATFORM_PLATAFORM FOREIGN KEY (Platform_ID) REFERENCES PLATAFORMA(Platform_ID)
);



-----------------------
	--PROCEDURES--
-----------------------

--AddUser

GO
CREATE OR ALTER PROCEDURE AddUser
    @Name VARCHAR(100),
    @Email VARCHAR(100),
    @Password VARCHAR(100)
AS
BEGIN
    INSERT INTO USERTABLE(Name, Email, Password) 
	VALUES (@Name, @Email, @Password);
END

--GetUserByID

GO
CREATE OR ALTER PROCEDURE GetUserByID
    @UserID INT
AS
BEGIN
    SELECT User_ID AS UserID, Name, Email, Password
    FROM USERTABLE
    WHERE User_ID = @UserID;
END

--UpdateUser

GO
CREATE OR ALTER PROCEDURE UpdateUser
    @UserID INT,
    @Name VARCHAR(100),
    @Email VARCHAR(100),
    @Password VARCHAR(100)
AS
BEGIN
    UPDATE USERTABLE
    SET Name = @Name, Email = @Email, Password = @Password
    WHERE User_ID = @UserID;
END

--DeleteUser

GO
CREATE OR ALTER PROCEDURE DeleteUser
    @UserID INT
AS
BEGIN
    DELETE FROM USERTABLE
    WHERE User_ID = @UserID;
END

--GetUserCount

GO
CREATE OR ALTER PROCEDURE GetUserCount
AS
BEGIN
    SELECT COUNT(*) AS UserCount 
	FROM USERTABLE;
END

--AddGame

GO
CREATE OR ALTER PROCEDURE AddGame
    @Name VARCHAR(100),
    @Description VARCHAR(300),
    @ReleaseYear SMALLDATETIME,
    @Rating INT,
    @img VARCHAR(400),
    @Genre_ID INT,
    @Developer_ID INT,
    @User_ID INT,
    @Price DECIMAL(10, 2),
    @PurchaseDate SMALLDATETIME,
    @CompletionDate SMALLDATETIME,
    @Status VARCHAR(50)
AS
BEGIN
    INSERT INTO GAME (Name, Description, ReleaseYear, Rating, img, Genre_ID, Developer_ID, User_ID, Price, PurchaseDate, CompletionDate, Status)
    VALUES (@Name, @Description, @ReleaseYear, @Rating, @img, @Genre_ID, @Developer_ID, @User_ID, @Price, @PurchaseDate, @CompletionDate, @Status);
END

--GetGamesByUserID

GO
CREATE OR ALTER PROCEDURE GetGamesByUserID
    @User_ID INT
AS
BEGIN
    SELECT ID_Game, Name, Description, ReleaseYear, Rating, img, Genre_ID, Developer_ID, User_ID, Price, PurchaseDate, CompletionDate, Status
    FROM GAME
    WHERE User_ID = @User_ID;
END

--UpdateGame

GO
CREATE OR ALTER PROCEDURE UpdateGame
    @ID_Game INT,
    @Name VARCHAR(100),
    @Description VARCHAR(300),
    @ReleaseYear SMALLDATETIME,
    @Rating INT,
    @Img VARCHAR(400),
    @Genre_ID INT,
    @Developer_ID INT,
    @User_ID INT,
    @Price DECIMAL(10, 2),
    @PurchaseDate SMALLDATETIME,
    @CompletionDate SMALLDATETIME,
    @Status VARCHAR(50)
AS
BEGIN
    UPDATE GAME
    SET Name = @Name, Description = @Description, ReleaseYear = @ReleaseYear, Rating = @Rating, img = @Img, Genre_ID = @Genre_ID, Developer_ID = @Developer_ID, User_ID = @User_ID, Price = @Price, PurchaseDate = @PurchaseDate, CompletionDate = @CompletionDate, Status = @Status
    WHERE ID_Game = @ID_Game;
END

--RemoveGame

GO
CREATE OR ALTER PROCEDURE RemoveGame
    @ID_Game INT
AS
BEGIN
    DELETE 
	FROM GAME
    WHERE ID_Game = @ID_Game;
END

--GetGameCount
GO
CREATE OR ALTER PROCEDURE GetGameCount
	@ID_User INT
AS
BEGIN
    SELECT COUNT(*) AS GameCount 
	FROM GAME
	WHERE User_ID = @ID_User;
END

-----------
--Inserts--
-----------
-- Insertar usuarios
INSERT INTO USERTABLE (Name, Email, Password) 
VALUES ('Juan Pérez', 'a@hotmail.com', 'a');
INSERT INTO USERTABLE (Name, Email, Password) 
VALUES ('María López', 'b@gmail.com', 'b');

-- Insertar géneros
INSERT INTO GENRE (Name_genres) 
VALUES ('Acción');
INSERT INTO GENRE (Name_genres) 
VALUES ('Aventura');
INSERT INTO GENRE (Name_genres) 
VALUES ('Estrategia');
INSERT INTO GENRE (Name_genres) 
VALUES ('Deportes');
INSERT INTO GENRE (Name_genres) 
VALUES ('Rol');
INSERT INTO GENRE (Name_genres) 
VALUES ('Simulación');

-- Insertar desarrolladores
INSERT INTO DEVELOPER (Name_Developer) 
VALUES ('Electronic Arts');
INSERT INTO DEVELOPER (Name_Developer) 
VALUES ('Ubisoft');
INSERT INTO DEVELOPER (Name_Developer) 
VALUES ('Bethesda Softworks');
INSERT INTO DEVELOPER (Name_Developer) 
VALUES ('Rockstar Games');
INSERT INTO DEVELOPER (Name_Developer) 
VALUES ('CD Projekt Red');
INSERT INTO DEVELOPER (Name_Developer) 
VALUES ('Nintendo');

-- Insertar plataformas
INSERT INTO PLATAFORMA (Name_Platform) 
VALUES ('PC');
INSERT INTO PLATAFORMA (Name_Platform) 
VALUES ('PlayStation 4');
INSERT INTO PLATAFORMA (Name_Platform) 
VALUES ('Xbox One');
INSERT INTO PLATAFORMA (Name_Platform) 
VALUES ('Nintendo Switch');
INSERT INTO PLATAFORMA (Name_Platform) 
VALUES ('PlayStation 5');
INSERT INTO PLATAFORMA (Name_Platform) 
VALUES ('Xbox Series X');

-- Insertar juegos
INSERT INTO GAME (Name, Description, ReleaseYear, Rating, img, Genre_ID, Developer_ID, User_ID, Price, PurchaseDate, CompletionDate, Platform_ID, Status)
VALUES ('The Witcher 3: Wild Hunt', 'RPG de acción', '2015-01-01', 9, 'the_witcher_3.jpg', 1, 3, 1, 29.99, '2023-05-20', '2023-10-15', 3, 'Completo');

INSERT INTO GAME (Name, Description, ReleaseYear, Rating, img, Genre_ID, Developer_ID, User_ID, Price, PurchaseDate, CompletionDate, Platform_ID, Status)
VALUES ('Grand Theft Auto V', 'Juego de mundo abierto', '2013-01-01', 8, 'gta_v.jpg', 1, 1, 2, 39.99, '2023-07-10', NULL, 1, 'En progreso');

INSERT INTO GAME (Name, Description, ReleaseYear, Rating, img, Genre_ID, Developer_ID, User_ID, Price, PurchaseDate, CompletionDate, Platform_ID, Status)
VALUES ('FIFA 21', 'Juego de fútbol', '2020-10-09', 7, 'fifa_21.jpg', 4, 1, 2, 59.99, '2023-01-15', NULL, 4, 'En progreso');

INSERT INTO GAME (Name, Description, ReleaseYear, Rating, img, Genre_ID, Developer_ID, User_ID, Price, PurchaseDate, CompletionDate, Platform_ID, Status)
VALUES ('The Legend of Zelda: Breath of the Wild', 'Juego de aventuras', '2017-03-03', 10, 'zelda_botw.jpg', 2, 6, 1, 59.99, '2022-12-01', '2023-03-10', 1, 'Completo');

INSERT INTO GAME (Name, Description, ReleaseYear, Rating, img, Genre_ID, Developer_ID, User_ID, Price, PurchaseDate, CompletionDate, Platform_ID, Status)
VALUES ('Cyberpunk 2077', 'Juego de rol y acción', '2020-12-10', 7, 'cyberpunk_2077.jpg', 5, 5, 2, 49.99, '2023-04-20', NULL, 2, 'En progreso');

-- Insertar juegos-plataformas
--INSERT INTO JUEGO_PLATAFORM (Juego_ID, Platform_ID) 
--VALUES (1, 1); -- The Witcher 3: Wild Hunt en PC
--INSERT INTO JUEGO_PLATAFORM (Juego_ID, Platform_ID) 
--VALUES (1, 2); -- The Witcher 3: Wild Hunt en PlayStation 4
--INSERT INTO JUEGO_PLATAFORM (Juego_ID, Platform_ID) 
--VALUES (2, 1); -- Grand Theft Auto V en PC
--INSERT INTO JUEGO_PLATAFORM (Juego_ID, Platform_ID) 
--VALUES (2, 3); -- Grand Theft Auto V en Xbox One
--INSERT INTO JUEGO_PLATAFORM (Juego_ID, Platform_ID) 
--VALUES (3, 1); -- FIFA 21 en PC
--INSERT INTO JUEGO_PLATAFORM (Juego_ID, Platform_ID) 
--VALUES (3, 2); -- FIFA 21 en PlayStation 4
--INSERT INTO JUEGO_PLATAFORM (Juego_ID, Platform_ID) 
--VALUES (4, 4); -- The Legend of Zelda: Breath of the Wild en Nintendo Switch
--INSERT INTO JUEGO_PLATAFORM (Juego_ID, Platform_ID) 
--VALUES (5, 1); -- Cyberpunk 2077 en PC
--INSERT INTO JUEGO_PLATAFORM (Juego_ID, Platform_ID) 
--VALUES (5, 5); -- Cyberpunk 2077 en PlayStation 5

select *
from GAME

SELECT * 
FROM GENRE;

SELECT * 
FROM DEVELOPER;

SELECT * 
FROM PLATAFORMA;

select *
from JUEGO_PLATAFORM
select *
from GAME
