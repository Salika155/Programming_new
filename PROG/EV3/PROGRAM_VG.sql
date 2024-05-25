

-------------------------------------------------------------------------
CREATE DATABASE WPF_JUEGOS;

CREATE TABLE USERTABLE(

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
    CONSTRAINT FK_JUEGO_USUARIO FOREIGN KEY (User_ID) REFERENCES USERTABLE(User_ID)
);

CREATE TABLE JUEGO_PLATAFORM (
    Juego_ID INT,
    Platform_ID INT,

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
    DELETE FROM GAME
    WHERE ID_Game = @ID_Game;
END