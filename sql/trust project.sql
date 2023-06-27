create database civica
-----------1st table item master
create table Item_Masters(Item_Id int primary key identity,Item_Name varchar(40),Category varchar(40),Rate decimal,Balance_Quantity int)
---------2nd table department mast
create table Department_Master(Department_Id int primary key identity,Depatment_Name varchar(30))
-----------3rd tablen vendor mast----

create table Vendor_Master(Vendor_Id int primary key identity,Vendor_Name varchar(30))
--------4rd table 
create table Item_Transaction(Transaction_Id int primary key identity,Item_Id int,
Transaction_Date datetime,Department_Id int,Vendor_Id int,Quantity int,
constraint p1 foreign key(Item_Id) references Item_Masters(Item_Id),
constraint p2 foreign key(Department_Id) references Department_Master(Department_Id),
constraint p3 foreign key(Vendor_Id) references Vendor_Master(Vendor_Id ))

select * from Item_Masters
select * from Department_Master
select * from  Vendor_Master
select * from Item_Transaction

