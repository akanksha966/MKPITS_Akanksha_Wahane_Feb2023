create database Perficient
--------------1 st table------------
create table Product (BrandID int primary key identity,BrandName varchar(40))
insert into Product values('Acer')
insert into Product values('HP')
insert into Product values('Lenevo')
insert into Product values('Asus')
select * from Product
----------2 nd table----------
create table ProductDetail(BrandID int primary key identity,ProductName varchar(30),AvailableQty int,TotalQty int,Price decimal,
constraint s1 foreign key (BrandID) references Product(BrandID))
select * from ProductDetail


-----------------3rd table--------

create table ProductDetail1(BrandID int primary key identity,AvailableQty int,TotalQty int,Price decimal,
constraint p1 foreign key (BrandID) references Product(BrandID))


select * from ProductDetail1


----11 st table------
----------------------------------------TABLE COMPUTER--------------------------------
CREATE TABLE COMPUTER(ID INT PRIMARY KEY IDENTITY,NAME VARCHAR(30),AVAILABLE_QTY INT,SELL_QTY INT,
PRICE_PER_UNIT DECIMAL,CGST int,SGST int)


INSERT INTO COMPUTER VALUES('HP',52,2,45000,8,9)
INSERT INTO COMPUTER VALUES('LENOVO',42,1,50000,6,6)
INSERT INTO COMPUTER VALUES('DELL',62,2,48000,9,9)
INSERT INTO COMPUTER VALUES('ASUS',32,2,55000,7,7)
INSERT INTO COMPUTER VALUES('ACER',20,2,65000,5,5)
SELECT * FROM COMPUTER
---query--------
--2nd query--
select NAME from COMPUTER where NAME='HP'
select Name from COMPUTER
---------------2nd table------
CREATE TABLE CUSTOMER(ID INT PRIMARY KEY IDENTITY,FIRST_NAME VARCHAR(30),LAST_NAME VARCHAR(30),GENDER VARCHAR(10),
MOBILE VARCHAR(20),PAID_AMOUNT DECIMAL)
SELECT * FROM CUSTOMER


-------------3rd table------
CREATE TABLE REF_SELLING(ID INT IDENTITY,CUSTOMER_ID INT,COMPUTER_ID INT,SELL_DATE DATE,SELL_QTY INT,
SOLD_BY_PERSON VARCHAR(50),PAYMENT_MODE VARCHAR(15),PAID_AMOUNT DECIMAL,CGST_VALUE decimal,SGST_VALUE decimal,TOTAL_AMOUNT decimal,
CONSTRAINT FK1 FOREIGN KEY (CUSTOMER_ID) REFERENCES CUSTOMER(ID) ON DELETE CASCADE,
CONSTRAINT FK2 FOREIGN KEY (COMPUTER_ID) REFERENCES COMPUTER(ID) ON DELETE CASCADE)

SELECT * FROM CUSTOMER
SELECT * FROM REF_SELLING
SELECT * FROM COMPUTER

            




