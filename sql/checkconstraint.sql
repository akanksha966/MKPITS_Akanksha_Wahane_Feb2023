create table products(product_id int primary key,product_name varchar (22) not null,price dec(10,3) check (price>0))--decimal
--check constrain me ham condition checked kr skte hai
insert into products values(23,'Ashu',100.00)
insert into products values(24,'Akanksha',120.00)
insert into products values(25,'mayuri',140.00)
insert into products values(26,'Rupali',2500)
select * from products


create table result(rno int primary key,
marks int check(marks > 0))
insert into result values(1,0)
insert into result values(1,99)
--practice question
create table aaa(rno int,name varchar(20),price int,check (price>0))
insert into aaa values(12,'ashu',78)
--practice question
create table aaaa(rno int,name varchar(20),price int constraint s1 check (price>0))
insert into aaaa values(12,'ashu',78)

--using constraint example of check constraint
create table result1(rno int primary key,
marks int constraint x1 check(marks > 0))
--insert into result1 values(1,0)
insert into result1 values(1,99)
select * from result1

create table product5(product_id int,product_name varchar(20),price int)
insert into product5 values (233,'ashu',null)
select * from product5


create table result6(rno int primary key,
marks int constraint x4 check(marks > 0))
--insert into result1 values(1,0)
insert into result6 values(1,null)
select * from result6

create table product6(product_id int primary key,Product_name varchar(20),price dec(10,3),discount dec(10,3), check (price>0) ,check(discount>0),check(price>discount));
insert into product6 values(12,'oil',200,20)
insert into product6 values(13,'Soap',20,5)
insert into product6 values(14,'Salt',30,5)
insert into product6 values(15,'sugar',60,10)
select*from product6


CREATE TABLE product0(
product_id INT IDENTITY PRIMARY KEY,
product_name VARCHAR(255),
unit_price DEC(10,2) )

select*from product0

--ALTER TABLE product0
--ADD CONSTRAINT positive_price CHECK(unit_price > 0);
--select* from product0

alter table product0
add discounted_price dec(20,2)

alter table product0 add customer_id int
alter table product0 add customer_name varchar(20),price int
sp_help product0--structure of a table









-------------------------

