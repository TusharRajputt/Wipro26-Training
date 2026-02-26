CREATE PROC PrcVoting
			@Age INT
AS
BEGIN
	IF @Age < 18 
	BEGIN
		RAISERROR ('You are Not Authorized for Voting...',16,1)
	END
	ELSE
	BEGIN
		PRINT 'You Can Vote...'
	END
END
GO

EXEC PrcVoting 15 
GO

CREATE PROC PrcNameShow
			@Name varchar(30)
AS
BEGIN
	Declare
		@Len INT
	BEGIN
		SELECT @Len = LEN(@Name) 
		if @Len < 5 
		BEGIN
			RAISERROR ('Name Contains Min 5 Characters...',5,1)
		END
		ELSE
		BEGIN
			PRINT 'Name is ' +@Name
		END
	END
END
GO

EXEC PrcVoting 15 
GO

EXEC PrcNameShow 'hi' 
GO

Create Proc PrcTaxInfo
				@Salary Numeric(9,2)
AS
BEGIN
	Declare
		@tax Numeric(9,2)
	BEGIN
		SELECT @tax = dbo.Fntax(@salary)
		if @Tax < 1000 
		BEGIN
			RAISERROR ('No Need to Pay for Tax...',5,1)
		END
		ELSE
		BEGIN
			PRINT 'Your Taxable Amount is ' +Convert(varchar(10),@tax)
		END
	END
ENd
GO

EXEC PrcTaxInfo 9000 
GO
