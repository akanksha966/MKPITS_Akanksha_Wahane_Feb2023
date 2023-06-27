create database drivenit
create table Itemmaster(ItemId int primary key identity not null,ItemDescr varchar(100) null,BalQty int null,CreatedOn datetime)


create table Transactions(TransID int identity(1,1) NOT NULL, ItemId int NOT NULL,TransType char(1) NOT NULL,TransQty int,
TransDate datetime constraint p1 foreign key (ItemId) references Itemmaster(ItemId))
select * from Itemmaster

create table Transaction1(TransID int primary key identity NOT NULL, ItemId int NOT NULL,TransType char(1) NOT NULL,TransQty int,
TransDate datetime constraint s1 foreign key (ItemId) references Itemmaster(ItemId))
select max (BalQty) from Itemmaster where ItemId=5
select * from Itemmaster
select * from Transaction1



truncate table Transaction1
truncate table Itemmaster



