create table productqty(id int primary key,Region varchar(20),Products varchar(20),Year int,Quantity int,Price int)
insert into productqty values(1,'East','Computer',2020,130,50000)
insert into productqty values(2,'South','Computer',2020,450,35000)
insert into productqty values(3,'North','Computer',2020,250,40000)
insert into productqty values(4,'East','Hard Disk',2020,190,3500)
insert into productqty values(5,'West','Computer',2021,250,45000)
insert into productqty values(6,'South','Hard Disk',2021,550,4400)
insert into productqty values(7,'West','Hrad Disk',2021,650,7500)
insert into productqty values(8,'East','Pen Drive',2021,120,800)
insert into productqty values(9,'North','Mouse',2019,100,500)
insert into productqty values(10,'East','pen drive',2019,2000,1200)
insert into productqty values(11,'West','Mouse',2029,190,650)
insert into productqty values(12,'East','Computer',2020,130,50000)

----min function-----
select min (Quantity) from productqty --normal
select min (Quantity) as 'minumum quantity' from productqty--second form
select products,Quantity,price from productqty where Quantity=100 and Products='Mouse'
select products,Quantity,price from productqty where Quantity=(select min(Quantity)as 'minium quantity'from productqty)--using whwre condition using min function

select Products,min(Quantity) as 'minimum quantity' from productqty group by Products --using group by

select Products ,min(Quantity) as 'minimum quantity'from productqty group by Products having  min (Quantity)>100--using having condition

----------max function-----
select max(Quantity) from productqty
select max(Quantity) as 'maximum quantity' from productqty
select products,Quantity,price from productqty 









select * from productqty