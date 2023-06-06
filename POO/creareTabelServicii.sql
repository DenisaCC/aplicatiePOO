use aeroport
create table Categorii(categorieID int primary key identity (1, 1), numeCategorie varchar(50));

create table Denumiri(denumireID int primary key identity (1, 1),nume varchar(50),categorieID int foreign key references Categorii(categorieID));


create table Servicii(
serviciuID int primary key identity(1, 1),
program varchar(50),
locatie varchar(50),
contact varchar(50),
ddenumireID int foreign key references Denumiri(denumireID),
ccategorieID int foreign key references Categorii(categorieID),
);

select Servicii.serviciuID, Servicii.program, Servicii.locatie,Servicii.contact,
Categorii.numeCategorie, Denumiri.nume
from Servicii
inner join Categorii
on 
Servicii.ccategorieID = Categorii.categorieID
inner join Denumiri
on
Servicii.ddenumireID = Denumiri.denumireID

select * from servicii