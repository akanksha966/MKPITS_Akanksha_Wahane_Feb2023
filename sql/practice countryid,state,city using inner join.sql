create table country(countryid int primary key,countryname varchar(20))
insert into country values(11,'India')
insert into country values(12,'Usa')

create table state(stateid int primary key,statename varchar(30),countryid int,constraint a1 foreign key (countryid) references country(countryid))
insert into state values(22,'maharashtra',11)
insert into state values(23,'maharashtra',11)
insert into state values(26,'mp',11)


insert into state values(24,'texas',12)
insert into state values(25,'ohio',12)

create table city (cityid int primary key,cityname varchar(20),stateid int,constraint a3 foreign key (stateid) references state(stateid))
insert into city values(33,'nagpur',22)
insert into city values(34,'mumbai',22)
insert into city values(35,'indore',26)
insert into city values(36,'bhopal',26)
insert into city values(37,'seattle',24)
insert into city values(38,'tacoma',25)
------inner join find duplicate or city table me add kiye state---
select c1.countryid,c1.countryname,s1.statename from country c1 inner join state s1 on c1.countryid=s1.countryid where c1.countryname='India';
---------find state using inner join
select s1.statename from country c1 inner join state s1 on c1.countryid=s1.countryid where c1.countryname='India';

-----find city---using stateid state = stateid city-----
      
select b1.cityname from city b1 inner join state s1 on b1.stateid=s1.stateid where s1.statename='maharashtra';

select statename from state where countryid =(select countryid from country where countryname='India')

select cityname from city where stateid =(select stateid from state where statename='mp');
select cityname from city where stateid =(select stateid from state where statename='ohio');



select * from country

select * from state
select * from city



