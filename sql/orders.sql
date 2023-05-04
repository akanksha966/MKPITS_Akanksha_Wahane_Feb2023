create table orders(orderno int primary key,orderdate varchar(30),CustId int)
insert into orders values(11,'1-1-2022',1)
insert into orders values(12,'2-4-2022',2)
insert into orders values(13,'3-4-2022',3)

create table order_details(orderno int,ProductId int,Rate int,Quantity int,constraint p1 foreign key (orderno) references orders(orderno) )
insert into order_details values(11,201,300,2)
insert into order_details values(11,201,300,2)
insert into order_details values(12,202,400,3)
insert into order_details values(12,202,200,3)
insert into order_details values(13,204,700,5)
select * from orders
select * from order_details