CREATE PROCEDURE esteUtilizatorValid 
(
@NumeUtilizator nvarchar(50),
@Parola nvarchar(50)
)
AS
BEGIN
	declare @EsteutilizatorValid bit set @EsteutilizatorValid = 0
	if exists(select * from tblUtilizatori where NumeUtilizator = @NumeUtilizator and Parola = @Parola)
	BEGIN
	set @EsteutilizatorValid = 1
	end
	select @EsteutilizatorValid
END
GO
