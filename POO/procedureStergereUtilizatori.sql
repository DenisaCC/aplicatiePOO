CREATE PROCEDURE StergereUtilizatori
(
@UtilizatorID int
)
AS
BEGIN
	delete from tblUtilizatori where UtilizatorID = @UtilizatorID
END
GO
