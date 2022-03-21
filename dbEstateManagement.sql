create database dbEstateManagement
use dbEstateManagement


create table tOwners(
  idOwner int identity(1,1) constraint PK_idOwner primary key,
  name varchar(100),
  email varchar(100),
  phone char(10),
  cnp char(13) constraint CK_cnpOwner check (len(cnp) = 13)
)


create table tEstates(
  idEstate int identity(1,1) constraint PK_idEstate primary key,
  name varchar(50) ,
  address varchar(100),
  price numeric(10,2),
  type tinyint,
  createDate smalldatetime constraint DF_createDateEstate default  getdate(),
  idOwner int constraint FK_idOwnerEstate foreign key references tOwners(idOwner)
 )

create table tPictures(
  idPicture int identity(1,1) constraint PK_idPicture primary key,
  name varchar(200),
  createDate smalldatetime constraint DF_createDatePicture default getdate(),
  size bigint,
  idEstate int constraint FK_idEstatePicture foreign key references tEstates(idEstate)
 );


 

select * from tEstates
select * from tPictures
select * from tOwners;

DBCC CHeckident(tOwners,reseed,10)

DBCC CHeckident(tOwners)


insert into tEstates values(
'estate1','pitesti',10.2,1,getdate(),1)


delete from tOwners
where idOwner = 1

update tEstates
set idOwner = 2
where idOwner =1;

delete from tOwners
where idOwner = 1

