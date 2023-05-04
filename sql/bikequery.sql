create database bikeStore;

create table Store(Store_id int primary key,Store_Name varchar(30),Phone int ,Email varchar(20),Street varchar(15),city varchar(20),State varchar(20),Zipcode int)
insert into Store values (12,'Arohi',2567865,'wahane@gmail.com','Tumsar','nagpur','maharashtra',441915)
insert into Store values(13,'Arohi',2567865,'wahane@gmail.com','Tumsar','nagpur','maharashtra',441915)
create table Categories(Category_id int primary key,Category_Name varchar(20))--category_id primary key
insert into Categories values(1,'Grocery shop')
insert into Categories values(2,'Fortune mall')


create table Brands(Brand_id int primary key,Brand_Name varchar(30))
insert into Brands values(456,'sugar')
insert into Brands values(447,'Tshirt')



create table Products1(Product_id int primary key,Product_Name varchar(20),Brand_id int,Category_id int,Model_Year int,List_Price int,constraint p1 foreign key(Brand_id) references Brands(Brand_id),constraint p2 foreign key (Brand_id)references Categories(Category_id))
insert into Products1 values(33,'Ditergent',456,1,2010,30)
insert into Products1 values(34,'X-Size-Tshirt',447,2,2020,400)


create table Stock(Store_Id int primary key,Product_id int,Quantity int ,constraint d1 foreign key(Product_id) references Products1(Product_id))
insert into Stock values (02,33,3)
insert into Stock values(03,34,2)
--CUSTOMER TABLE

create table Customers(Customer_id int primary key,First_Name varchar(20),Last_Name varchar(15),Phone int,Email varchar(30),Street varchar (30),City varchar(14),State varchar(30),ZipCode int)
insert into Customers values(44,'Akanksha','wahane',783378,'wahane@gmail.com','Hardoli','nagpur','maharashtra',3578)
insert into Customers values(45,'Ranu','meshram',453821,'ranu@gmail.com','Sihora','nagpur','maharashtra',4993)
--STAFF TABLE
create table Staf(Staff_id int primary key,First_Name varchar(20),Last_Name varchar(20),Email varchar(30),Phone_no bigint,Active varchar(20),Store_Id int,Manager_id int,constraint k1 foreign key(Store_Id) references Stock(Store_Id))

insert into Staf values(55,'Ashu','Wahane','jd@gmail.com',4521789652,'not working',02,6788)
insert into Staf values(56,'Ranau','Meshram','ranu@gmail.com',4555789652,'Working',03,6789)


--ORDERS TABLE-


create table Orders(order_id int primary key,Customer_id int,order_status varchar(20),order_date varchar(20),Required_date varchar (20),Shipped_Date varchar(20),Store_id int,Staff_id int,constraint v1 foreign key(Customer_id) references Customers(Customer_id),constraint v2 foreign key(Staff_id) references Staf(Staff_id),constraint v3 foreign key(Store_id) references Store(Store_id))

insert into Orders values(88,44,'Arrived It park','12-3-2022','16-3-2022','20-3-2022',12,55)
insert into Orders values(89,45,'Arrived At Sadar','15-3-2022','18-3-2022','22-3-2022',13,56)


--ORDERS ITEMS--
create table order_item(order_id int primary key,item_id int ,Product_id int,Quantity int,List_price int,Discount int,constraint n1 foreign key(Product_id) references Products1(Product_id))
insert into order_item values (88,65,33,4,400,380)

select *from Customers
select * from Stock
select * from Store
select * from Categories
select * from Brands
select * from Products1
select * from Customers
select * from Staf
select * from Orders
select * from order_item








