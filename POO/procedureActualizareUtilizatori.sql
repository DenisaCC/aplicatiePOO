CREATE PROCEDURE ActualizareUtilizatori
@UtilizatorID int,
@NumeUtilizator nvarchar(50),
@Parola nvarchar(50),
@Functia nvarchar(50)
AS
BEGIN
	update tblUtilizatori set NumeUtilizator = @NumeUtilizator, Parola = @Parola, Functia = @Functia
	where UtilizatorID = @UtilizatorID
END
GO
