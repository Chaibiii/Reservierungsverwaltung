create database gestiondereservations
use gestiondereservations

create table RIAD(
numeroR int primary key not null ,
nomR nvarchar(20),
adresserueR nvarchar(20),
codepostalR int,
villeR nvarchar(30),
telephoneR int,
nomcontactR nvarchar(30),
codeReg int foreign key references REGION(codeRegion) ,
nombredeplaces int

)
create table REGION(
codeRegion int primary key not null,
libelle nvarchar(20)

)
create table TYPEHEBERGEMENT (
NumeroType int primary key not null,
LibelleType nvarchar(20)

)
create table CLIENT  (
CodeClient int primary key not null,
Nom nvarchar(20),
Prenom nvarchar(20),
GSM numeric(20),
Mail nvarchar(20),
Adresse nvarchar(20),
Pays nvarchar(20)

)

create table NEGOCIER  (
NumeroR int not null foreign key references RIAD(numeroR),
NumeroType int not null foreign  key references TYPEHEBERGEMENT(NumeroType)  ,
CodeClient int not null foreign  key references CLIENT(codeClient),
DateNego date,
Prix money
)
alter table NEGOCIER
add constraint pk primary key (numeroR,NumeroType,CodeClient)

create table RESERVATION   (
NumRes int primary key not null,
NumClient int foreign  key references CLIENT(codeClient),
NumType int foreign  key references TYPEHEBERGEMENT(NumeroType),
DateDebut date,
DateFin date


)