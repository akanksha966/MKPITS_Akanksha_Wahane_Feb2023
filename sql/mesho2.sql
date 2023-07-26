create database mesho2

create table Products(prodid int ,prodname varchar(40),proddescription varchar(50),prodimage varchar(50),prodprice int)
select * from Product1
insert into Product values('Classy Patyawear Dress','Ladies Dress','p1.jpg',376)

insert into Products values(1,'Classy Patyawear Dress','Ladies Dress','p11.jpg',376)
insert into Products values(2,'Classy Salwar Suit','Ladies Dress','p12.jpg',276)
insert into Products values(3,'Classy Salwar Suit','Ladies Dress','p13.jpg',376)
insert into Products values(4,'Classy Salwar Suit','Ladies Dress','p14.jpg',876)
insert into Products values(5,'Classy Salwar Suit','Ladies Dress','p15.jpg',376)
insert into Products values(6,'Classy Salwar Suit','Ladies Dress','p16.jpg',276)
insert into Products values(9,'Classy Salwar Suit','Ladies Dress','p3.jpg',500)
insert into Products values(10,'Classy Salwar Suit','Ladies Dress','p4.jpg',533)
insert into Products values(11,'Classy Salwar Suit','Ladies Dress','p5.jpg',554)
insert into Products values(12,'Classy Salwar Suit','Ladies Dress','p6.jpg',550)
insert into Products values(13,'Classy Salwar Suit','Ladies Dress','p7.jpg',578)
insert into Products values(14,'Classy Salwar Suit','Ladies Dress','p8.jpg',589)
insert into Products values(15,'Classy Salwar Suit','Ladies Dress','p9.jpg',512)
insert into Products values(16,'Classy Salwar Suit','Ladies Dress','p10.jpg',576)


--------------------------------------------------------------------------------------------
create table Product1(prodid int primary key identity ,prodname varchar(40),proddescription varchar(50),prodimage varchar(50),prodprice int)


insert into Product1 values('Classy Patyawear Dress','Ladies Dress','p1.jpg',376)

insert into Product1 values('Classy Patyawear Dress','Ladies Dress','p11.jpg',376)
insert into Product1 values('Classy Salwar Suit','Ladies Dress','p12.jpg',276)
insert into Product1 values('Classy Salwar Suit','Ladies Dress','p13.jpg',376)
insert into Product1 values('Classy Salwar Suit','Ladies Dress','p14.jpg',876)
insert into Product1 values('Classy Salwar Suit','Ladies Dress','p15.jpg',376)
insert into Product1 values('Classy Salwar Suit','Ladies Dress','p16.jpg',276)
insert into Product1 values('Classy Salwar Suit','Ladies Dress','p3.jpg',500)
insert into Product1 values('Classy Salwar Suit','Ladies Dress','p4.jpg',533)
insert into Product1 values('Classy Salwar Suit','Ladies Dress','p5.jpg',554)
insert into Product1 values('Classy Salwar Suit','Ladies Dress','p6.jpg',550)
insert into Product1 values('Classy Salwar Suit','Ladies Dress','p7.jpg',578)
insert into Product1 values('Classy Salwar Suit','Ladies Dress','p8.jpg',589)
insert into Product1 values('Classy Salwar Suit','Ladies Dress','p9.jpg',512)
insert into Product1 values('Classy Salwar Suit','Ladies Dress','p10.jpg',576)

-----------------------------------------------
create table ctable3(prodid int,prodname varchar(80),proddescription varchar(80),prodprice int,prodimage varchar(80),sessionid varchar(80),quantity int)
select * from ctable3
select * from Product1

create table ctable(prodid int primary key identity,prodname varchar(80),proddescription varchar(80),prodprice int,prodimage varchar(80),sessionid varchar(80),quantity int)



create table users(userid int primary key identity,username varchar(90),password varchar(90),roll varchar(90))

insert into users(username,password)
values('raj','kumar')

insert into users(username,password)
values('ashu','abcd')

insert into users(username,password)
values('ranu','admin')
insert into users(username,password,roll)
values('ashish','abc','admin')


select * from users