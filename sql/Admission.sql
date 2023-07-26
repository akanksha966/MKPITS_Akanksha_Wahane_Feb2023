create database AdmissionRegistration
-----------1--------------
create table Coursetable(CourseId int primary key identity,CourseName varchar(50),Duration int)

-------------2--------------
create table BatchTable(BatchId int primary key identity,Batch varchar(40),Year varchar(45))
----------4 th ----------
create table UserTable(Id int primary key identity,FirstName varchar (40),LastName varchar(50),Username varchar(50),Password varchar(50))

create table RegistrationTable (Id int primary key identity,FirstName varchar(60),LastName varchar(50),Nic varchar(70),CourseId int,batchId int,Phoneno int ,constraint v1 foreign key (CourseId) references Coursetable(CourseId),constraint v2 foreign key (batchId) references  BatchTable(BatchId))
select * from Coursetable
select * from Batchtable
select * from Usertable
select * from RegistrationTable
