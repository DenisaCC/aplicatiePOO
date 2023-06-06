use aeroport
create table TipZbor(tipID int primary key identity (1, 1), numeTip varchar(50));
create table Pasageri(
pasagerID int primary key identity(1, 1),
numePasager varchar(50),
prenumePasager varchar(50),
sex varchar(50),
nrTelefonPasager varchar(50),
emailPasager varchar(50),
nrZbor varchar(50),
tipID int foreign key references TipZbor(tipID)
);

select Pasageri.pasagerID, Pasageri.numePasager, Pasageri.prenumePasager, Pasageri.sex, Pasageri.nrTelefonPasager,
Pasageri.emailPasager, Pasageri.nrZbor, TipZbor.numeTip
from Pasageri
inner join TipZbor
on 
Pasageri.tipID = TipZbor.tipID
select * from Pasageri