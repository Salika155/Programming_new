DROP DATABASE WPF_APP_BD

CREATE DATABASE WPF_APP_BD

USE WPF_APP_BD

CREATE TABLE STUDENTS(

	id INT IDENTITY,
	name VARCHAR(100) NOT NULL,
	age TINYINT NOT NULL,
	description VARCHAR(200)

	CONSTRAINT PK_STUDENTS PRIMARY KEY (id),
	CONSTRAINT CK_age CHECK (age <= 130)
	)


	select *
	from students


GO
CREATE OR ALTER PROCEDURE insertStudentsOnDB (@name VARCHAR(100), 
												@age TINYINT, 
												@description VARCHAR(200),
												@ID INT OUTPUT)
AS
BEGIN 
	BEGIN TRY

	DECLARE @errors INT

	IF @name IS NULL
	SET @errors += 'name'

	IF @age IS NULL
	SET @errors += 'age'

	IF @errors <> ''
	BEGIN
		PRINT CONCAT ('Los campos no pueden ser nulos: ', @errores)
		RETURN -1
	END

		BEGIN
			PRINT ('El estudiante ya existe')
			RETURN -2
		END

		INSERT INTO STUDENTS
		VALUES(@name, @age, @description)

		SET @ID = SCOPE_IDENTITY()

		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT CONCAT('ERROR: ', ERROR_NUMBER(),
					 'DESC: ', ERROR_MESSAGE(),
					 'LINEA: ', ERROR_LINE(),
					 'PROC: ', ERROR_PROCEDURE())
		END CATCH
	END


GO
CREATE OR ALTER FUNCTION SelectStudents (@id INT)
RETURNS TABLE

AS
	
	RETURN SELECT *
			FROM STUDENTS
			WHERE id = @id

GO
CREATE OR ALTER FUNCTION StudentCount()
RETURNS INT
AS
BEGIN
	RETURN(SELECT COUNT(ID)
			FROM STUDENTS)
END

GO
CREATE OR ALTER PROCEDURE updateStudent(@id INT,
										@name VARCHAR(100),
										@age TINYINT,
										@description VARCHAR(200))

AS
BEGIN
	BEGIN TRY

	DECLARE @errors INT = ''

	IF @name IS NULL
	SET @errors += 'name'

	IF @age IS NULL
	SET @errors += 'age'

	IF @id IS NULL
	SET @errors += 'id'

	IF @errors <> ''
	BEGIN
		PRINT CONCAT ('Los campos no pueden ser nulos: ', @errores)
		RETURN -1
	END

	IF NOT EXISTS (SELECT *
					FROM STUDENTS
					WHERE ID = @ID)

		BEGIN
			PRINT ('El estudiante no existe')
			RETURN -2
		END

	BEGIN TRAN

	UPDATE STUDENTS
	SET
            name = @name,
            age = @age,
            description = @description
        WHERE
            ID = @id
        COMMIT

	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT CONCAT('ERROR: ', ERROR_NUMBER(),
					 'DESC: ', ERROR_MESSAGE(),
					 'LINEA: ', ERROR_LINE(),
					 'PROC: ', ERROR_PROCEDURE())
		END CATCH
	END


CREATE OR ALTER PROCEDURE removeStudents (@id int)

AS
BEGIN
	BEGIN TRY

	IF NOT EXISTS (SELECT *
					FROM STUDENTS
					WHERE id = @id)

		BEGIN
			PRINT 'El estudiante no existe'
			RETURN -1
		END

	BEGIN TRAN

	DELETE FROM STUDENTS
	WHERE id = @id

	COMMIT
END TRY

BEGIN CATCH
	ROLLBACK
	PRINT CONCAT('ERROR: ', ERROR_NUMBER(),
                     'DESC: ', ERROR_MESSAGE(),
                     'LINEA: ', ERROR_LINE(),
                     'PROC: ', ERROR_PROCEDURE())
    END CATCH
END
	

