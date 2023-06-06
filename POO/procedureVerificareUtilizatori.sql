CREATE PROCEDURE VerificareUtilizatori
@NumeUtilizator nvarchar(50),
@Parola nvarchar(50)
AS
BEGIN
	select * from tblUtilizatori
	where NumeUtilizator = @NumeUtilizator or
	Parola = @Parola
END
GO
