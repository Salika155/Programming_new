USE JARDINERIA
DROP DATABASE WPF_JUEGOS

-------------------------------------------------------------------------
CREATE DATABASE WPF_JUEGOS;
USE WPF_JUEGOS;

-- Crear tablas
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
    Description VARCHAR(300) DEFAULT(' '),
    ReleaseYear DATE DEFAULT('1900-01-01'),
    Rating INT,
    img VARCHAR(400),
    Genre_ID INT,
    Developer_ID INT,
    User_ID INT NOT NULL,
    Price DECIMAL(10, 2),
    PurchaseDate DATE DEFAULT('1900-01-01'),
    CompletionDate DATE,
    StatusGame VARCHAR(50),
	Platform_ID INT
    CONSTRAINT FK_JUEGO_GENRE FOREIGN KEY (Genre_ID) REFERENCES GENRE(ID_Genre),
    CONSTRAINT FK_JUEGO_DEVELOPER FOREIGN KEY (Developer_ID) REFERENCES DEVELOPER(ID_Developer),
    CONSTRAINT FK_JUEGO_USUARIO FOREIGN KEY (User_ID) REFERENCES USERTABLE(User_ID),
    CONSTRAINT FK_JUEGO_PLATFORM FOREIGN KEY (Platform_ID) REFERENCES PLATAFORMA(Platform_ID)
);


-- Si decides mantener la relación muchos a muchos entre juegos y plataformas:
CREATE TABLE JUEGO_PLATAFORM (
    Juego_ID INT,
    Platform_ID INT,
	
    CONSTRAINT PK_JUEGO_PLATAFORM PRIMARY KEY (Juego_ID, Platform_ID),
    CONSTRAINT FK_JUEGO_PLATAFORM_JUEGO FOREIGN KEY (Juego_ID) REFERENCES GAME(ID_Game),

);

-- Procedimientos almacenados
GO
CREATE OR ALTER PROCEDURE AddUser
    @Name VARCHAR(100),
    @Email VARCHAR(100),
    @Password VARCHAR(100)
AS
BEGIN
    INSERT INTO USERTABLE (Name, Email, Password)
    VALUES (@Name, @Email, @Password);
END
GO
CREATE OR ALTER PROCEDURE GetUserByID
    @UserID INT
AS
BEGIN
    SELECT User_ID AS UserID, Name, Email, Password
    FROM USERTABLE
    WHERE User_ID = @UserID;
END
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
GO
CREATE OR ALTER PROCEDURE DeleteUser
    @UserID INT
AS
BEGIN
    DELETE FROM USERTABLE
    WHERE User_ID = @UserID;
END
GO
CREATE OR ALTER PROCEDURE GetUserCount
AS
BEGIN
    SELECT COUNT(*) AS UserCount
    FROM USERTABLE;
END

GO
CREATE PROCEDURE AddGame
    @Name VARCHAR(100),
    @Description NVARCHAR(MAX) = NULL,
    @ReleaseYear DATE = '1900-01-01',
    @Rating INT = NULL,
    @img NVARCHAR(255) = NULL,
    @Genre_ID INT = NULL,
    @Developer_ID INT = NULL,
    @User_ID INT,
    @Price FLOAT = NULL,
    @PurchaseDate DATE = '1900-01-01',
    @CompletionDate DATE = '2900-01-01',
    @StatusGame INT = NULL,
    @Platform_ID INT = NULL
AS
BEGIN
    INSERT INTO GAME (Name, Description, ReleaseYear, Rating, img, Genre_ID, Developer_ID, User_ID, Price, PurchaseDate, CompletionDate, StatusGame, Platform_ID)
    VALUES (@Name, @Description, @ReleaseYear, @Rating, @img, @Genre_ID, @Developer_ID, @User_ID, @Price, @PurchaseDate, @CompletionDate, @StatusGame, @Platform_ID);
END



GO
CREATE OR ALTER PROCEDURE GetGamesByUserID
    @User_ID INT
AS
BEGIN
    SELECT ID_Game, Name, Description, ReleaseYear, Rating, img, Genre_ID, Developer_ID, User_ID, Price, PurchaseDate, CompletionDate, StatusGame, Platform_ID
    FROM GAME
    WHERE User_ID = @User_ID;
END
GO
CREATE OR ALTER PROCEDURE UpdateGame
    @ID_Game INT,
    @Name VARCHAR(100),
    @Description VARCHAR(300),
    @ReleaseYear DATE,
    @Rating INT,
    @Img VARCHAR(400),
    @Genre_ID INT,
    @Developer_ID INT,
    @User_ID INT,
    @Price DECIMAL(10, 2),
    @PurchaseDate DATE,
    @CompletionDate DATE,
    @StatusGame VARCHAR(50),
	@Platform_ID INT
AS
BEGIN
    UPDATE GAME
    SET Name = @Name, Description = @Description, ReleaseYear = @ReleaseYear, Rating = @Rating, img = @Img, Genre_ID = @Genre_ID, Developer_ID = @Developer_ID, User_ID = @User_ID, Price = @Price, PurchaseDate = @PurchaseDate, CompletionDate = @CompletionDate, StatusGame = @StatusGame, Platform_ID = @Platform_ID
    WHERE ID_Game = @ID_Game;
END
GO
CREATE OR ALTER PROCEDURE RemoveGame
    @ID_Game INT
AS
BEGIN
    DELETE FROM GAME
    WHERE ID_Game = @ID_Game;
END
GO
CREATE OR ALTER PROCEDURE GetGameCount
    @ID_User INT
AS
BEGIN
    SELECT COUNT(*) AS GameCount
    FROM GAME
    WHERE User_ID = @ID_User;
END

-- Inserciones
-- Insertar usuarios
INSERT INTO USERTABLE (Name, Email, Password)
VALUES ('Juan Pérez', 'a@hotmail.com', 'a'),
       ('María López', 'b@gmail.com', 'b');

-- Insertar géneros
INSERT INTO GENRE (Name_genres)
VALUES ('Acción'), ('Aventura'), ('Estrategia'), ('Deportes'), ('Rol'), ('Simulación'), ('JRPG');

-- Insertar desarrolladores
INSERT INTO DEVELOPER (Name_Developer)
VALUES ('Electronic Arts'), ('Ubisoft'), ('Bethesda Softworks'), ('Rockstar Games'), ('CD Projekt Red'), ('Nintendo'), ('Nihon Falcom');

-- Insertar plataformas
INSERT INTO PLATAFORMA (Name_Platform)
VALUES ('PC'), ('PlayStation4'), ('XboxOne'), ('NintendoSwitch'), ('PlayStation5'), ('XboxSeriesX'), ('Unknown');

-- Insertar juegos
INSERT INTO GAME (Name, Description, ReleaseYear, Rating, img, Genre_ID, Developer_ID, User_ID, Price, PurchaseDate, CompletionDate, StatusGame, Platform_ID)
VALUES ('The Witcher 3: Wild Hunt', 'RPG de acción', '2015-01-01', 9, 'https://image.api.playstation.com/vulcan/ap/rnd/202211/0714/ojKZ7l0T2M5egR9YHIjVhI0R.png', 1, 3, 1, 29.99, '2023-05-20', '2023-10-15', 'Completado', 3),
       ('Grand Theft Auto V', 'Juego de mundo abierto', '2013-01-01', 8, 'https://cdn1.epicgames.com/0584d2013f0149a791e7b9bad0eec102/offer/GTAV_EGS_Artwork_1200x1600_Portrait%20Store%20Banner-1200x1600-382243057711adf80322ed2aeea42191.jpg', 1, 1, 2, 39.99, '2023-07-10', NULL,'Jugando', 1),
       ('FIFA 21', 'Juego de fútbol', '2020-10-09', 7, 'https://sm.ign.com/t/ign_es/screenshot/default/ea8bc81e-23e4-4317-aaf2-cc17917236cf_f6d7.1280.jpg', 4, 1, 2, 59.99, '2023-01-15', NULL, 'PorJugar', 4),
       ('The Legend of Zelda: Breath of the Wild', 'Juego de aventuras', '2017-03-03', 10, 'https://www.nintendo.com/eu/media/images/08_content_images/games_6/nintendo_switch_7/nswitch_thelegendofzeldabreathofthewild/NSwitch_TheLegendOfZeldaBreathOfTheWild_wp_tablet_01.jpg', 2, 6, 1, 59.99, '2022-12-01', '2023-03-10', 'Abandonado', 1),
       ('Cyberpunk 2077', 'Juego de rol y acción', '2020-12-10', 7, 'cyberpunk_2077.jpg', 5, 5, 2, 49.99, '2023-04-20', NULL, 'Jugando', 2),
       ('The Legend of Heroes Trails of Cold Steel IV', 'JRPG con Worldbuilding masivo', '2019-03-09', 9, 'https://assetsio.gnwcdn.com/co31wc.jpg?width=1920&height=1920&fit=bounds&quality=80&format=jpg&auto=webp', 2, 6, 1, 59.99, '2022-12-01', '2023-03-10', 'Jugando', 1);


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


