create table customer( custid int primary key,custname varchar(20),phoneNo bigint)
insert into customer values(11,'Ashu',1234565432)
insert into customer values(12,'Akanksha',1234565442)
insert into customer values(13,'Mayuri',1234565732)
insert into customer values(14,'Rupali',1234005432)
insert into customer values(15,'Sherya',1234587432)
select * from customer

create table order2(orderid int ,orderdate varchar(20),custid int,productName varchar(20),Quantity int,Rate int)
insert into order2 values(22,'12-2-2022',11,'Oil',2,200)
insert into order2 values(23,'12-3-2022',12,'Oil',2,200)
insert into order2 values(24,'12-4-2022',13,'Oil',2,200)
insert into order2 values(25,'12-5-2022',15,'Oil',2,200)
select * from order2
select p.custid,p.custname,f.productName,f.Quantity,f.Rate from customer p inner join order2 f on p.custid=f.custid --inner join
select p.custid,p.custname,f.productName,f.Quantity,f.Rate from customer p cross join order2 f  --cross join
select p.custid,p.custname,f.productName,f.Quantity,f.Rate from customer p left outer join order2 f on p.custid=f.custid  --left outer join
select p.custid,p.custname,f.productName,f.Quantity,f.Rate from customer p right outer join order2 f on p.custid=f.custid  --right outer join
select p.custid,p.custname,f.productName,f.Quantity,f.Rate from customer p full outer join order2 f on p.custid=f.custid  --full outer join
------------------another condition of inner join-----------
select p.custid,p.custname,f.productName,f.Quantity,f.Rate from customer p inner join order2 f on p.custid=13 and Rate=200 --inner join






