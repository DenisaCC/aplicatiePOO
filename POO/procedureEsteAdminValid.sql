CREATE PROCEDURE esteAdminValid 
(
@Admin nvarchar(50),
@Parola nvarchar(50)
)
AS
BEGIN
	declare @EsteAdminValid bit set @EsteAdminValid = 0
	if exists(select * from tblAdmin where Admin = @Admin and Parola = @Parola)
	BEGIN
	set @EsteAdminValid = 1
	end
	select @EsteAdminValid
END
GO
