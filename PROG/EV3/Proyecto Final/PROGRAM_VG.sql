
CREATE DATABASE WPF_JUEGOS

CREATE TABLE JUEGO(

	ID INT,
	Nombre VARCHAR(100),
	Descripcion VARCHAR(300),
	ReleaseYear SMALLDATETIME,
	Rating INT,
	img VARCHAR(400),
	Genre_ID INT,
	Platform_ID INT

	CONSTRAINT PK_ID_JUEGO PRIMARY KEY (ID)
	)


CREATE TABLE GENRE(

	Genre_ID INT,
	Name_genres VARCHAR(100)

	CONSTRAINT PK_Genre_ID_GENRE PRIMARY KEY (Genre_ID)
	)


CREATE TABLE GAME_PLATFORM(

	Platform_ID INT,
	Name_Platform VARCHAR(100)

	CONSTRAINT PK_Platform_ID PRIMARY KEY (Platform_ID)

	)