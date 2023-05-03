create table MovieTicket (MovieTicketId int primary key,Title varchar(20),ShowTime varchar (20),SeatNumber int,Theater varchar(20),price int,DateOfTheShow varchar(15),TheaterRules varchar(40))
insert into MovieTicket values(11,'Ved','12:00:AM',2345,'Cinemax',120,'02-01-2022','Remainder To Turn Of Cell Phone')
insert into MovieTicket values(12,'Sultan','10:00:AM',2346,'Cinepolis',140,'02-01-2022','Do Not Receiving Calls')
insert into MovieTicket values(13,'stri','3:00:AM',2347,'Inox',150,'02-01-2022','Remainder To Turn on Cell Phone Silent')
insert into MovieTicket values(14,'Circus','10:30:AM',2344,'Liberty',160,'03-01-2022','Do Not Disturb')
insert into MovieTicket values(15,'Sudama','4:00:AM',2347,'Sudama',100,'02-01-2022','Remainder To Turn Of Cell Phone')
insert into MovieTicket values(16,'GoodBye','12:00:AM',2341,'Inox',120,'03-01-2022','Do Not Receiving Calls')
insert into MovieTicket values(17,'Freedy','5:00:AM',2349,'Carnival',140,'03-01-2022','Do not to bring outside food or drinks')
insert into MovieTicket values(17,'Freedy','5:00:AM',2349,'Carnival',140,'03-01-2022','Do not to bring outside food or drinks')
insert into MovieTicket values(18,'Jercey','5:00:AM',2349,'Jayshree',125,'04-01-2022','Remainder To Turn Of Cell Phone')

select distinct Theater from MovieTicket --Do not repeated
select Title from MovieTicket order by LEN (Title)--find length
select Title from MovieTicket order by LEN (Title) DESC;    --find length in decending order
select * from MovieTicket where price=120 --where ondition
select * from MovieTicket where price>120
select * from MovieTicket where Title ='Sultan'--where condition used checked the name 
select * from  MovieTicket where price=120 order by price--assending order
select * from  MovieTicket where price=120 order by price desc--decending order
select * from MovieTicket where price between 120 and 160 order by price
select * from MovieTicket where price in (120,160) --in method
select * from MovieTicket where price not in (120,160)--not in
select * from MovieTicket where Title like 's%'--starting me s variable
select * from MovieTicket where Title like '%s'--starting me s variable
select * from MovieTicket where Title like '%da%'--mtlab khi pe bhi rah skta hai
select Top 4 Title from MovieTicket where price=120 order by Title
select top 4 Title from MovieTicket order by Title --select top 4
select top 50 percent Title from MovieTicket --using 50 percent

select price ,count(*) from MovieTicket group by price

select price ,count(1) from MovieTicket group by price


select price from MovieTicket where price=120



















select * from MovieTicket