create database bookshop
create table booktable(Bid int not null primary key identity,Bname varchar(150),Bauthor int,Bcategory int,Bqty int,Bprice int)

create table booktable2(Bid int not null primary key identity,Bname varchar(150),Bauthor int,Bcategory int,Bqty int,Bprice int,constraint s1 foreign key(Bcategory) references category(catid),constraint s2 foreign key( Bauthor)references Author(Autid))


----------2nd table-----
create table Author(Autid int not null primary key identity,Autgender varchar(150)not null,Autcountry varchar(150)not null)

create table Author2(Autid int not null primary key identity,Authorname varchar(50),Autgender varchar(150)not null,Autcountry varchar(150)not null)
select * from Author2


create table selltable2(sellid int identity(1,1)not null,selname varchar(100),selemail varchar(100),selphone varchar(150),seladdress varchar(100))
create table selltable(sellid int not null primary key identity,selname varchar(100),selemail varchar(100),selphone varchar(150),seladdress varchar(100))

create table category(catid int not null primary key identity,catname varchar(150),catdescription varchar(150))
create table Bill(billid int not null primary key identity,Bdate date not null,Sellerid int not null,Amount int not null,constraint p1 foreign key(Sellerid) references selltable(sellid))