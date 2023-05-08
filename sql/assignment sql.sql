
--------------------Q1-----------

create table salesman (salesmanid int primary key,name varchar(20),city varchar(15),commission int)
insert into salesman values(5001 ,'James Hoog' ,' New York',  0.15)
insert into salesman values(5002, 'Nail Knite' ,'Paris', 0.13)
insert into salesman values(5005,'Pit Alex ',' London',  0.11)
 insert into salesman values(5006 ,' Mc Lyon', ' Paris ', 0.14)
 insert into salesman values(5007 , 'Paul Adam' , 'Rome',  0.13)
 insert into salesman values(5003, 'Lauson Hen ',' San Jose',  0.12)
 select * from salesman
 --------------------Q2-----------
 select name,commission from salesman
  --------------------Q3-----------
  create table entryorder(ordno int primary key,purchamt dec,orddate varchar(30),customerid int,salesmanid int)
  -----change data type innt float---
  alter table entryorder alter column orddate varchar(30)
  -------------------------------------
  insert into entryorder values(70001, 150.5, '2012-10-05', 3005 ,5002)
  
  insert into entryorder values(70009, 270.65, '2012-09-10' ,3001 ,5005)
 
  insert into entryorder values(70002, 65.26, '2012-10-05', 3002, 5001)
 
  insert into entryorder values(70004, 110.5 ,'2012-08-17', 3009, 5003)
 
  insert into entryorder values(70007 ,948.5 ,'2012-09-10', 3005 ,5002)
  
  insert into entryorder values(70005, 2400.6, '2012-07-27', 3007, 5001)

  insert into entryorder values(70008, 5760.0, '2012-09-10', 3002 ,5001)
  select * from entryorder
  ---like order date, salesman id, order number and purchase amount from for all the orders.
  select orddate,salesmanid,ordno,purchamt from entryorder
  -----update query
  update entryorder set salesmanid=7890 where ordno=7001
  update entryorder set customerid=3778 where customerid=3005
  update entryorder set purchamt=277 where salesmanid=5001 -------table ke data me kuch krna hai to update
  ----delete-
  delete from entryorder where salesmanid=5005
    select * from entryorder
delete from entryorder where purchamt=151 --delete row
  insert into entryorder values(70022, 5760.0, '2012-09-10', 3002 ,5081)
  -----------------------------------
  truncate table entryorder
    insert into entryorder values(700548, 5760.0, '2012-09-10', 3002 ,5091)
	------------------------------------
	--------add one more column----
	alter table entryorder add totalsalary dec
	alter table entryorder add salary int
	---------------------------------------
	sp_help entryorder -------show procedure----
	----------change  data type-
	alter table entryorder alter column totalsalary int

	---------drop column----
	alter table entryorder drop column salary
	alter table entryorder drop column totalsalary
	select * from entryorders

	-----------table rename---
	sp_rename 'entryorder','entryorders'
	select * from entryorders

	-------column name---
	exec sp_rename 'entryorders.ordno','ordnum'
	exec sp_rename 'entryorders.orddate','orderdate'