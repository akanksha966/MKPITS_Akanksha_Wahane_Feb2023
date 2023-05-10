create table employee (empid int primary key,
empname varchar(20))


CREATE TABLE EmpLog (
LogID int IDENTITY(1,1) NOT NULL,
EmpID int NOT NULL,
Operation nvarchar(10) NOT NULL,
UpdatedDate Datetime NOT NULL)
-------------for trigger----------

create trigger empt1
on employee

for insert as 
insert into EmpLog(EmpID,Operation,UpdatedDate)
select empid,'insert',GETDATE() from inserted;
insert into employee values(11,'amit')
insert into employee values(12,'amita')
insert into employee values(13,'amita')

--------------------------------------
select * from EmpLog
select * from employee
-------------------after trigger----
create trigger empu
on employee
after update
as
insert into EmpLog(EmpID,Operation,UpdatedDate)
select empid,'update',GETDATE() from deleted

select * from employee
update employee set empname='amitabh' where
empid=11
select * from EmpLog
---------------------------------------------------
create trigger empu4
on employee
after update
as
insert into EmpLog(EmpID,Operation,UpdatedDate)
select empid,'delete',GETDATE() from deleted

delete from employee where empid=11
select * from employee

select * from EmpLog
--------------------------------------
create trigger empu5
on employee
after delete
as
insert into EmpLog(EmpID,Operation,UpdatedDate)
select empid,'delete',GETDATE() from deleted

delete from employee where empid=12
select * from employee

select * from EmpLog
-------------------------create table student-----
create table student4 (studid int primary key,
studname varchar(20))
------------table identity2---------------
CREATE TABLE identity2 (
LogID int IDENTITY(1,1) NOT NULL,
EmpID int NOT NULL,
Operation nvarchar(10) NOT NULL,
UpdatedDate Datetime NOT NULL)

create trigger empt5
on student4

for insert as 
insert into identity2(EmpID,Operation,UpdatedDate)
select studid,'insert',GETDATE() from inserted;
insert into student4 values(1,'akanksha')
insert into student4 values(2,'ashu')
select * from Student4
select * from identity2
----------------------------------------------------------------