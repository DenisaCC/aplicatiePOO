use aeroport
create table TaraPlecari(taraPlecariID int primary key identity (1, 1), numeTaraPlecari varchar(50));

create table TaraSosiri(taraSosiriID int primary key identity (1, 1), numeTaraSosiri varchar(50));

create table OrasPlecari(orasPlecariID int primary key identity (1, 1),numeOrasPlecari varchar(50),
taraPlecariID int foreign key references TaraPlecari(taraPlecariID));

create table OrasSosiri(orasSosiriID int primary key identity (1, 1),numeOrasSosiri varchar(50),
taraSosiriID int foreign key references TaraSosiri(taraSosiriID));

create table CompaniePlecari(companiePlecariID int primary key identity (1, 1), numeCompaniePlecari varchar(50));

create table CompanieSosiri(companieSosiriID int primary key identity (1, 1), numeCompanieSosiri varchar(50));

create table StatusPlecari(statusPlecariID int primary key identity (1, 1), numeStatusPlecari varchar(50));

create table StatusSosiri(statusSosiriID int primary key identity (1, 1), numeStatusSosiri varchar(50));

insert into TaraPlecari values('Anglia'), ('Argentina'),('Austria'),('Belgia'),('Bulgaria'),('Croatia'),('China'),('Cehia'),
('Danemarca'),('Egipt'),('Elvetia'),('Emiratele Arabe Unite'),('Franta'),('Finlanda'),('Germania'),('Georgia'),
('Haiti'),('Islanda'),('India'),('Italia'),('Japonia'),('Kenya'),('Letonia'),('Luxemburg'),('Maldive'),('Maroc'),
('Norvegia'),('Nepal'),('Olanda'),('Pakistan'),('Polonia'),('Qatar'),('Romania'),('Rusia'),('Slovacia'),('Spania'),
('Thailanda'),('Turcia'),('Ucraina'),('Ungaria'),('Vietnam'),('Venezuela'),('Zimbabwe');


insert into TaraSosiri values('Anglia'), ('Argentina'),('Austria'),('Belgia'),('Bulgaria'),('Croatia'),('China'),('Cehia'),
('Danemarca'),('Egipt'),('Elvetia'),('Emiratele Arabe Unite'),('Franta'),('Finlanda'),('Germania'),('Georgia'),
('Haiti'),('Islanda'),('India'),('Italia'),('Japonia'),('Kenya'),('Letonia'),('Luxemburg'),('Maldive'),('Maroc'),
('Norvegia'),('Nepal'),('Olanda'),('Pakistan'),('Polonia'),('Qatar'),('Romania'),('Rusia'),('Slovacia'),('Spania'),
('Thailanda'),('Turcia'),('Ucraina'),('Ungaria'),('Vietnam'),('Venezuela'),('Zimbabwe');
