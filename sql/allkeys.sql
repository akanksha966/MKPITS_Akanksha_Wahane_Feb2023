--composit key--

create table orderdetails(orderid int ,productid int,quantity int ,primary key(orderid,productid))

insert into orderdetails values(12,345,4)  --composit key means konse column me hme repeayed values nahi chahiye vo ham decide kr skte hai
insert into orderdetails values(12,346,5)
insert into orderdetails values(13,347,5)
insert into orderdetails values(14,347,5)
insert into orderdetails values(13,13,5)
insert into orderdetails values(13,15,5)
select*from orderdetails
--unique key example
create table employee (empid int primary key,empname varchar(30),passportno int,drivinglicense int,unique (passportno,drivinglicense))

insert into employee values (12,'Ashu',3476,7689)
insert into employee values (13,'Akanksha',3479,7682)
insert into employee values(14,'Mayuri',3451,8741)
insert into employee values(15,'sherya',3451,8742)

--unique key example
 create table sample(studentid int unique, nam varchar(10))
 --insert into sample values('Ranu')
  --insert into sample(nam) values('Ashu')
   --insert into sample(nam) values('As')
   insert into sample (nam) values('yasmin')
   select * from sample
   --unique exit null value at ones time

    create table sample2(studentid int unique, nam varchar(10))
	insert into sample2(nam) values('Ashu')
		insert into sample2 values(12,'Ashu1')
		select * from sample2

create table sample3(empid int primary key,empname varchar(10),passportno int,drivinglicen int, constraint e1 unique(passportno,drivinglicen))
insert into sample3 values (12,'jayesh',234,456)
insert into sample3 values (13,'jayesh',214,456)
--3rd type

create table sample4(empid int primary key,empname varchar(10),passportno int unique,drivinglicen int unique)
insert into sample4 values (12,'jayesh',234,456)
insert into sample4 values (13,'jayesh',214,455)
select * from sample4

--identity
create table sample5(empid int primary key identity,empname varchar(10),passportno int ,drivinglicen int)
insert into sample5 values ('jayesh',234,456)
insert into sample5 values ('jayesh',214,455)
select * from sample5













