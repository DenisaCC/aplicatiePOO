create procedure AdaugareUtilizator
(
@NumeUtilizator as nvarchar(50),
@Parola as nvarchar(50),
@Functia as nvarchar(50)
)
as
begin
insert into tblUtilizatori(NumeUtilizator, Parola, Functia)
values (@NumeUtilizator, @Parola, @Functia)
end