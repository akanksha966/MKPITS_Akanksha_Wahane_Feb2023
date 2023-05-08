create database entryorder
create table Customers(Customer_id int primary key,First_Name varchar(20),Last_Name varchar(15),Phone bigint,Email varchar(30),Street varchar (30),City varchar(14),State varchar(30),ZipCode int)
insert into Customers values(1,'Akanksha','wahane',7865432189,'wahane@gmail.com','Tumsar','Nagpur','maharashtra',4418340)
insert into Customers values(2,'mayuri','pal',7865432189,'pal@gmail.com','it park','Nagpur','maharashtra',4488340)
insert into Customers values(3,'ruplai','barde',7865212189,'rupali@gmail.com','dharmpeth','Nagpur','maharashtra',4441340)
insert into Customers values(4,'tanu','meshram',7865432009,'meshram@gmail.com','subhash ngr','Nagpur','maharashtra',1118340)
insert into Customers values(5,'anjali','gakbjiye',7865421189,'anjali@gmail.com','fetri','Nagpur','maharashtra',4485340)









create table Orders (orderid int primary key,customerid int,orderstatus varchar(20),orderdate varchar(20),requireddate varchar(20),shippeddate varchar(20),storeid int,staffid int, constraint c1 foreign key(customerid) references Customers(Customer_id))
insert into Orders values(10,1,'Active','2-3-2022','5-3-2022','6-3-2022',99,54)
insert into Orders values(11,2,'midway','3-3-2022','4-3-2022','5-3-2022',98,50)
insert into Orders values(12,3,'Active','2-3-2022','5-3-2022','6-3-2022',97,51)
insert into Orders values(13,4,'Active','2-3-2022','5-3-2022','6-3-2022',94,51)
insert into Orders values(14,5,'midway','8-3-2022','9-3-2022','10-3-2022',99,56)
--------query----------

select z.Customer_id,z.First_Name,Last_Name,s.storeid from Customers z inner join Orders s on z.Customer_id=customerid where orderstatus='Active'
select z.Customer_id,s.orderid,s.orderstatus from Customers z inner join Orders s on z.Customer_id=s.customerid where staffid=54
select orderdate,requireddate,shippeddate from Orders where orderid=10


select * from Customers
select * from Orders