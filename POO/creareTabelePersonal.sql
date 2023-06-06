use aeroport
create table FunctiePersonal(functiePersonalID int primary key identity(1, 1), numeFunctiePersonal varchar(50));
create table Personal(
personalID int primary key identity(1, 1),
numePersonal varchar(50),
prenumePersonal varchar(50),
dataNasterii datetime,
adresaPersonal varchar(50),
nrTelefonPersonal varchar(50),
emailPersonal varchar(50),
functiePersonallID int foreign key references FunctiePersonal(functiePersonalID)
);

select Personal.personalID, Personal.numePersonal, Personal.prenumePersonal, Personal.dataNasterii, Personal.adresaPersonal,
Personal.nrTelefonPersonal, Personal.emailPersonal, FunctiePersonal.numeFunctiePersonal
from Personal
inner join FunctiePersonal
on 
Personal.functiePersonallID = FunctiePersonal.functiePersonalID

select * from Personal

