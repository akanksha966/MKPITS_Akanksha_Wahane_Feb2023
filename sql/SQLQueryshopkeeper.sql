create table shopkeeper1(Shop_name varchar (20) primary key,Shop_address varchar(15),Grocery varchar(30),Grocery_price int,Quantity int ,Rating_shop varchar(10) ,Total_price int)
insert into shopkeeper1 values ('Arohi','It Park Nagpur','Soap',30,3,'five',50)
insert into shopkeeper1 values ('shri krishna','Dantoli Nagpur','powder',10,2,'four',20)
insert into shopkeeper1 values ('kalpesh kirana','Gaytri Nagpur','oil',180,3,'five',180)
insert into shopkeeper1 values ('Aannapurna','It Park Nagpur','Rice',60,2,'five',120)
insert into shopkeeper1 values ('Amar','Nagoba Nagpur','Soap',30,3,'three',50)
insert into shopkeeper1 values ('Sudhrshan','Dharampeth','salt',27,3,'five',78)
insert into shopkeeper1 values ('Ramesh','Sdar Nagpur','Sugar',80,1,'four',80)
insert into shopkeeper1 values ('sagar','Sdar Nagpur','Collins',80,1,'one',80)

select *from shopkeeper1 where Grocery ='Soap'--where checked the condition 

select *from shopkeeper1 order by Shop_name --assending order (oder by used)

select * from shopkeeper1 order by Shop_name desc--decending oredr (unoredred list)

select *from shopkeeper1 where Quantity=2 order by Quantity  --mtlab jiase quantity two ho

select *from shopkeeper1 where Quantity=1 order by Quantity desc --mtlab jiase quantity two ho
select *from shopkeeper1 where Quantity=1 order by Shop_name desc


select Total_Price,COUNT(*) from shopkeeper1
where Shop_address <> 'Sadar Nagpur'
group by Total_price









select *from shopkeeper1