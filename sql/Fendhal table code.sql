create database FendhalM


create table TableProductGSTDetailss(Product_Gst_ID int primary key,
Gst_Detail_Name varchar(500),CGST decimal(18,0),SGST decimal(18,0),IGST decimal(18,0))
insert into TableProductGSTDetailss values(601,'AC and Fridge',14,14,14)
insert into TableProductGSTDetailss values(602,'Computers',9,9,9)
insert into TableProductGSTDetailss values(603,'Printers',9,9,9)
insert into TableProductGSTDetailss values(604,'Mobiles',6,6,6)
select p.CGST,p.SGST,p.IGST from TableProductGSTDetailss p inner join TableProductCategory s on  p.Product_Gst_ID=s.Product_Gst_ID where Product_Type_Name='Computers'
select * from TableProductGSTDetailss
-----------2nd table
create table TableProductCategory(Product_Category_ID int primary key,Product_Type_Name varchar(500),Product_Gst_ID int,
constraint p1 foreign key(Product_Gst_ID) references TableProductGSTDetailss(Product_Gst_ID))
insert into TableProductCategory values(1001,'Computers',602)
insert into TableProductCategory values(1002,'Mobiles',604)
insert into TableProductCategory values(1003,'Printers',603)
insert into TableProductCategory values(1004,'AC and Fridge',602)
select * from TableProductCategory


------3rd table---

create table TableProduct(ProductID int primary key,Product_Name varchar(500),Product_Category_ID int,ProductPrice decimal(18,0),
constraint c1 foreign key(Product_Category_ID)references TableProductCategory(Product_Category_ID))
insert into TableProduct values(210,'Apple',1002,4000)
insert into TableProduct values(211,'Lenevo',1002,25000)
insert into TableProduct values(212,'Samsung',1003,50000)
insert into TableProduct values(213,'IFB',1004,20000)
insert into TableProduct values(214,'LG',1004,30000)
insert into TableProduct values(215,'Sony',1001,56000)

select ProductID,Product_Name from TableProduct p inner join TableProductCategory s on p. Product_Category_ID =s.Product_Category_ID  where Product_Type_Name='Computers'
select  ProductPrice  from TableProduct where Product_Name='Apple'
----------4th table---

create table TableInvoiceDetailss(Invoice_Details_ID int primary key identity,Customer_Name varchar(500),Customer_Contact varchar(15),
Product_Category_ID int,Product_ID int,Residential_Type_ID int,Invoice_Date datetime,Quantity decimal(18,0),Price decimal(18,0),CGST decimal(18,0),SGST decimal(18,0),
IGST decimal(18,0),CGST_Value decimal(18,0),SGST_value decimal(18,0),IGST_Value decimal(18,0),Total_Amount decimal(18,0),
constraint q1 foreign key(Product_Category_ID)references TableProductCategory(Product_Category_ID),constraint q2 foreign key(Product_ID) references TableProduct(ProductID))

select * from TableInvoiceDetailss

