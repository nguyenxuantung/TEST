create database QUANLIKINHDOANHDIENTHOAI
go
use QUANLIKINHDOANHDIENTHOAI
go

create table tblUser(
Name nvarchar(20) primary key,
Pass varchar(20)
)
create table tblCustomer(
Id varchar(20) primary key,
Name varchar(20),
Address nvarchar(200),
Phone varchar(11),
)
create table tblProviders(
Id varchar(20) primary key,
Name nvarchar(100),
Address nvarchar(200),
Phone varchar(11),
Email nvarchar(50),
Fax varchar(50),
TaxNumber varchar(10)
)
create table tblStoreIn(
Id int Identity primary key,
ProvidersId varchar(20),
DateIn Datetime)
create table tblGroupProduct(
Id varchar(20) primary key,
Name nvarchar(50))
create table tblProduct(
Id varchar(13) primary key,
Name nvarchar(50),
Detail nvarchar(200),
GroupProductId varchar(20),
constraint KN1 foreign key (GroupProductId) references tblGroupProduct(Id)
)
create table tblStoreInDetail(
StoreInId int,
ProductId varchar(13),
PacelNumber varchar(20),
QuantityIn int,
PriceIn int,
constraint KN2 foreign key (StoreInId) references tblStoreIn(Id),
constraint KN3 foreign key (ProductId) references tblProduct(Id),
constraint KCSID primary key (StoreInId,ProductId,PacelNumber))

CREATE UNIQUE INDEX idx_PacelNumber ON tblStoreInDetail(PacelNumber)
WHERE PacelNumber IS NOT NULL

CREATE UNIQUE NONCLUSTERED INDEX UIX_ID 
  ON tblStoreInDetail(PacelNumber)

create table tblProductDetail(
ProductId varchar(13),
PacelNumber varchar(20),
Price int,
FromDay datetime,
ToDay datetime,
constraint KN4 foreign key (ProductId) references tblProduct(Id),
constraint KN5 foreign key (PacelNumber) references tblStoreInDetail(PacelNumber),
constraint KCPD primary key (ProductId,PacelNumber,Price))

create table tblPersonnel(
Id int identity primary key,
Name nvarchar(100),
Competence nvarchar(100),
Address nvarchar(200),
Phone varchar(11)
)
create table tblKindBill(
Id varchar(20) primary key,
Name nvarchar(100))

Create table tblBill(
Id int identity primary key,
 PersonnelId int,
 CustomerId varchar(20),
 KindBillId varchar(20),
 Status nvarchar(100),
 Date datetime
 constraint KN6 foreign key (PersonnelId) references tblPersonnel(Id),
constraint KN7 foreign key (CustomerId) references tblCustomer(Id),
constraint KN8 foreign key (KindBillId) references tblKindBill(Id))

Create table tblBillDetail(
BillId int,
ProductId varchar(13),
PacelNumber varchar(20), 
Quantity int,
constraint KN11 foreign key (ProductId) references tblProduct(Id),
constraint KN9 foreign key (BillId) references tblBill(Id),
constraint KN10 foreign key (PacelNumber) references tblStoreInDetail(PacelNumber),
constraint KCBD primary key (BillId, ProductId, PacelNumber)
)