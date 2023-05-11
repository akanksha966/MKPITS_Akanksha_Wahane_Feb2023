create database abcd
create table customers(customer_id int primary key, cust_name varchar(20),city varchar (20), grade int,  salesmanid int,constraint k foreign key (salesmanid) references salseman33(salesmanid))
exec sp_rename 'customer.salesman_id','salesmanid'
 insert into customers values(  3002,'Nick Rimando' ,'New York' , 100 , 5001)
 insert into customers values(3007 , 'Brad Davis' , 'New York' , 200 , 50010)
insert into customers values (3005 ,' Graham Zusi',  'California',  200,  5002)
 insert into customers values (3008,  'Julian Green' , 'London' , 300 , 5002)
insert into customers values (3004 , 'Fabian Johnson' , 'Paris' , 300 ,5006)
insert into customers values(3009 , 'Geoff Cameron' , 'Berlin' , 100 , 5003)
insert into customers values(3003 , 'Jozy Altidor' , 'Moscow'  ,200  ,5007)
insert into customers values(3001 ,'Brad Guzan' , 'London' ,100, 5005)
select * from customers
create table salseman33(salesmanid int primary key,name varchar(20), city varchar (29), commission dec)
insert into salseman33 values(5001, 'James Hoog',' New York', 0.15)
 insert into salseman33 values(5002 ,'Nail Knite',' Paris', 0.13)
 insert into salseman33 values(5005,' Pit Alex', 'London', 0.11)
 insert into salseman33 values(5006, 'Mc Lyon',' Paris', 0.14)
 insert into salseman33 values(5003,' Lauson Hen',' San Jose', 0.12)
 insert into salseman33 values (5007,'Paul Adam',' Rome', 0.13)

   create table ordersss(ord_no int primary key, purch_amt int,ord_date varchar(20),customer_id int, salesman_id int, constraint h1 foreign key (customer_id) references customers(customer_id),constraint h2 foreign key (salesman_id) references salseman33(salesmanid))
   insert into ordersss values(70001, 150.5,' 2012-10-05', 3005, 5002)
 insert into ordersss values(70009 ,270.65, '2012-09-10' ,3001 ,5005)
insert into ordersss values(70002 ,65.26, '2012-10-05' ,3002 ,5001)
insert into ordersss values(70004 ,110.5, '2012-08-17', 3009 ,5003)
insert into ordersss values(70007 ,948.5,' 2012-09-10', 3005 ,5002)

insert into ordersss values(70005 ,2400.6 ,'2012-07-27' ,3007, 5001)
insert into ordersss values(70008 ,5760, '2012-09-10', 3002, 5001)
insert into ordersss values(70010, 1983.43, '2012-10-10' ,3004, 5006)
insert into ordersss values(70003, 2480.4 ,'2012-10-10' ,3009 ,5003)
insert into ordersss values(70012, 250.45 ,'2012-06-27' ,3008, 5002)
insert into ordersss values(70011, 75.29 ,'2012-08-17' ,3003 ,5007)
insert into ordersss values(70013 ,3045.6,' 2012-04-25', 3002 ,5001)
select * from ordersss
 select * from salseman33
 select * from customers
 ----------------q1----------------
 select ord_no, purch_amt, ord_date, customer_id ,salesman_id from ordersss where salesman_id in (select salesman_id from salseman where name='Paul Adam')
 
  select s.ord_no, s.purch_amt, s.ord_date, s.customer_id ,f.salesmanid from ordersss s inner join salseman33 f on s.salesman_id=f.salesmanid--inner join
  -----------------q2----------------------
  select s.ord_no, s.purch_amt, s.ord_date, s.customer_id,p.city from customers p inner join ordersss s on s.customer_id=p.customer_id
   
  ----------------q3-------------------
   select ord_no, purch_amt, ord_date, customer_id ,salesman_id from ordersss where salesman_id in (select salesman_id from salseman where customer_id=3008)
   ---------------q4------------
   select * from ordersss where purch_amt>100 (SELECT AVG(purch_amt)FROM ordersss
WHERE ord_date ='10-10-2012');
-----------q5------------
   select ord_no, purch_amt, ord_date, customer_id ,salesman_id from ordersss where customer_id in (select customer_id from customers where city ='New York')
   ----------q6------------------------
      select ord_no, purch_amt, ord_date, customer_id ,salesman_id from ordersss where customer_id in (select customer_id from customers where city='Paris')

	  ---------------q7-------------------
	  select * from customers where customer_id=(select salesmanid-2001 from salseman33 where name='Mc Lyon');
	  -------------q8-------
	  select grade ,count (*)  from customers where city='New York' group by grade
	  --------------q9-------
	  
      select ord_no, purch_amt, ord_date, customer_id ,salesman_id from ordersss where salesman_id in (select salesman_id from salseman33 where commission=(select max(commission)from salseman33))

	 ------------q10--------------
	 select ord_no, purch_amt, ord_date, customer_id, salesman_id  from ordersss where salesman_id in (select salesman_id from salseman33 where ord_date='2012-10-05' and name='Mc Lyon')
	 -------or-----------
	 	 select ord_no, purch_amt, ord_date, customer_id, salesman_id  from ordersss where salesman_id in (select salesman_id from salseman33 where ord_date='2012-10-05')
		 -----------------q11---------------
		 select cust_name from customers where  customer_id in (select salesman_id from ordersss where salesman_id>1)
		 --or--------

		 SELECT salesmanid,name from salseman33 where 1<(select count(*)from ordersss WHERE salesmanid=salesmanid);
		 --------------q12---------------


		 select * from ordersss
 select * from salseman33
 select * from customers