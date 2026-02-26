SET NOCOUNT ON
GO


CREATE PROC PrcDivision
			@A INT,
			@B INT
AS
BEGIN
	DECLARE
		@C INT
	BEGIN
	BEGIN TRY
		SELECT @C = @A / @B 
		PRINT 'Division is ' +Convert(varchar(10),@C)
	END TRY
	BEGIN CATCH
	IF ERROR_NUMBER() = 8134 
	BEGIN
		PRINT 'Division By Zero Impossible...'
	END
	ELSE
	BEGIN
	  PRINT 'Error Number: ' + CAST(ERROR_NUMBER() AS NVARCHAR(10));
        PRINT 'Error Message: ' + ERROR_MESSAGE();
        PRINT 'Error Line: ' + CAST(ERROR_LINE() AS NVARCHAR(10));
        PRINT 'Error Procedure: ' + ISNULL(ERROR_PROCEDURE(), 'N/A');
	END
	END CATCH
	END
END
GO

EXEC PrcDivision 'A','B'
GO

Create Proc PrcEmployInsertNew
			@Empno INT,
			@Name varchar(30),
			@Gender varchar(30),
			@Dept varchar(30),
			@Desig varchar(30),
			@Basic Numeric(9,2)
AS
BEGIN
    BEGIN TRY
	INSERT INTO Employ(Empno,Name,Gender,Dept,Desig,Basic) values(@empno,@name,@gender,@dept,@desig,@basic)
	END TRY
	BEGIN CATCH
	IF ERROR_NUMBER() = 2627 
	BEGIN
		PRINT 'Employ No Already Exists....' +Convert(varchar(10),@empno)
	END
	ELSE
	BEGIN
	  PRINT 'Error Number: ' + CAST(ERROR_NUMBER() AS NVARCHAR(10));
        PRINT 'Error Message: ' + ERROR_MESSAGE();
        PRINT 'Error Line: ' + CAST(ERROR_LINE() AS NVARCHAR(10));
        PRINT 'Error Procedure: ' + ISNULL(ERROR_PROCEDURE(), 'N/A');
	END
	END CATCH
END
GO

Exec PrcEmployInsertNew 1,'Abhi','MALE','Java','Developer',888222
GO
