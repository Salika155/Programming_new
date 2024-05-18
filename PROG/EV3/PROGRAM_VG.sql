

-------------------------------------------------------------------------
CREATE DATABASE WPF_JUEGOS;

CREATE TABLE USER(

    User_ID INT IDENTITY,
    Name VARCHAR(100),
    Email VARCHAR(100),
    Password VARCHAR(100)

	CONSTRAINT PK_ID PRIMARY KEY (User_ID)
);

CREATE TABLE GENRE (
    ID_Genre INT PRIMARY KEY,
    Name_genres VARCHAR(100)
);

CREATE TABLE DEVELOPER (
    ID_Developer INT PRIMARY KEY,
    Name_Developer VARCHAR(100)
);

CREATE TABLE PLATAFORMA (
    Platform_ID INT PRIMARY KEY,
    Name_Platform VARCHAR(100)
);

CREATE TABLE GAME (
    ID_Game INT PRIMARY KEY,
    Name VARCHAR(100),
    Description VARCHAR(300),
    ReleaseYear SMALLDATETIME,
    Rating INT,
    img VARCHAR(400),
    Genre_ID INT,
    Developer_ID INT,
    User_ID INT,
    Price DECIMAL(10, 2),
    PurchaseDate SMALLDATETIME,
    CompletionDate SMALLDATETIME,
    Status VARCHAR(50), -- Campo para el estado del juego

    CONSTRAINT FK_JUEGO_GENRE FOREIGN KEY (Genre_ID) REFERENCES GENRE(ID_Genre),
    CONSTRAINT FK_JUEGO_DEVELOPER FOREIGN KEY (Developer_ID) REFERENCES DEVELOPER(ID_Developer),
    CONSTRAINT FK_JUEGO_USUARIO FOREIGN KEY (User_ID) REFERENCES USER(User_ID)
);

CREATE TABLE JUEGO_PLATAFORM (
    Juego_ID INT,
    Platform_ID INT,

    CONSTRAINT PK_JUEGO_PLATAFORM PRIMARY KEY (Juego_ID, Platform_ID),
    CONSTRAINT FK_JUEGO_PLATAFORM_JUEGO FOREIGN KEY (Juego_ID) REFERENCES GAME(ID_Game),
    CONSTRAINT FK_JUEGO_PLATFORM_PLATAFORM FOREIGN KEY (Platform_ID) REFERENCES PLATAFORMA(Platform_ID)
);



--------------------------------------------------------------------------------------------
GO
CREATE OR ALTER PROCEDURE AddUser
    @Name VARCHAR(100),
    @Email VARCHAR(100),
    @Password VARCHAR(100)
AS
BEGIN
    INSERT INTO USER (Name, Email, Password) VALUES (@Name, @Email, @Password);
END