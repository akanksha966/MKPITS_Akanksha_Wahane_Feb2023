create database Fendahl2
-----1st table-----

create table TableNation(NationID int primary key,NationName varchar(500))

--insert into TableNation values(1,'Indian')
--delete from TableNation where NationName='Indian'

insert into TableNation values(1,'India')
insert into TableNation values(2,'United_Nation')
insert into TableNation values(3,'Nepal')
insert into TableNation values(4,'SriLanka')
select NationName from TableNation
select top 5 NationName from TableNation

SELECT SUBSTRING('SQLTutorial', 1, 5) AS ExtractString from TableNation;
select * from TableNation
--------2nd table----
create table TableState(StateID int primary key,NationID int,StateName varchar(500),
constraint s1 foreign key(NationID) references TableNation(NationID))

---------------query----
select p. StateName from TableState p inner join TableNation s on p.NationID=s.NationID where NationName='India' 
-------or option-----
select p.StateName,p.StateID from TableState p inner join TableNation s on s.NationID=p.NationID where NationName='India'

insert into TableState values(101,1,'Andhra Pradesh')
insert into TableState values(102,1,'Punjab')
insert into TableState values(103,2,'Califomia')
insert into TableState values(104,2,'Florida')
insert into TableState values(105,3,'Koshi')
insert into TableState values(106,3,'Bagmati')
insert into TableState values(107,4,'Colombo')
insert into TableState values(108,4,'Ratnapura')
select StateName ,StateID from TableState where StateID=(select max (StateID) from TableState)


SELECT GETDATE();
select * from TableNation
alter table TableNation add abc int

select * from TableState
------------------3rd table------
create table TableCity(CityID int primary key,StateID int,CityName varchar(500),
constraint a1 foreign key (StateID ) references TableState (StateId))

select l.CityName from TableCity l inner join TableState p on l.StateID=p.StateID where StateName='Koshi' 

insert into TableCity values(1001,101,'Visakhapatnam')
insert into TableCity values(1002,101,'Vijayawada')
insert into TableCity values(1003,101,'Guntur')
insert into TableCity values(1004,102,'Amritsar')
insert into TableCity values(1005,102,'Jalandhar')
insert into TableCity values(1006,102,'Chandigarh')
insert into TableCity values(1007,103,'Los Angeles')
insert into TableCity values(1008,103,'San Jose')
insert into TableCity values(1009,103,'San Diego')
insert into TableCity values(1010,104,'Jacksonville')
insert into TableCity values(1011,104,'Miami')

insert into TableCity values(1012,104,'Tampa')
insert into TableCity values(1013,105,'damak')
insert into TableCity values(1014,105,'Dharan')
insert into TableCity values(1015,105,'Biratnagar')
insert into TableCity values(1016,106,'Baneppa')
insert into TableCity values(1017,106,'Bharatpur')

insert into TableCity values(1018,106,'Hetauda')
insert into TableCity values(1019,107,'Grandpass')
insert into TableCity values(1020,107,'Borella')

insert into TableCity values(1021,107,'Pettah')
insert into TableCity values(1022,108,'Balangoda')
insert into TableCity values(1023,108,'Kolonna')



select * from TableState


select * from TableCity

----------4th table------
---4th table aur 5 and 6 me data insert nhi krna hai
create table TableCourseRegDetail( CourseRegID int primary key,CategoryID int,FullName varchar(1500),GenderID int)
insert into TableCourseRegDetail values(4,1,'mk',1)
insert into TableCourseRegDetail values(5,2,'mk2',2)
insert into TableCourseRegDetail values(6,1,'Ravi',1)
insert into TableCourseRegDetail values(7,1,'anand',1)
insert into TableCourseRegDetail values(8,1,'gaurav',1)
insert into TableCourseRegDetail values(9,1,'Pranjali',2)
insert into TableCourseRegDetail values(10,1,'mk3',1)
insert into TableCourseRegDetail values(11,1,'mk4',1)
insert into TableCourseRegDetail values(12,1,'mk5',1)
insert into TableCourseRegDetail values(13,1,'mk6',1)
insert into TableCourseRegDetail values(14,2,'dhananjay',1)
insert into TableCourseRegDetail values(15,1,'m khan',1)
insert into TableCourseRegDetail values(16,2,'ananya',2)

-------------------4th table repeat--------
create table TableCourseRegDetail2( CourseRegID int primary key identity,CategoryID int,FullName varchar(1500),GenderID int)
select * from TableCourseRegDetail2

select top 1 CourseRegID from TableCourseRegDetail2 order by CourseRegID desc
			              SELECT top 1 CourseRegID FROM TableCourseRegDetail2 ORDER BY CourseRegID DESC




---5 th table------
 create table TableRegAddress(RegAddress int primary key,CourseRegID int,NationID int,StateID int,CityID int,
 constraint q1 foreign key(CourseRegID)references TableCourseRegDetail(CourseRegID),
 constraint q2 foreign key (NationID) references TableNation(NationID),
 constraint q3 foreign key(StateID) references TableState(StateID),constraint q4 foreign key(CityID) references TableCity(CityId))
 insert into TableRegAddress values(1,4,1,101,1001)
 insert into TableRegAddress values(2,5,2,102,1002)
 insert into TableRegAddress values(3,6,3,103,1003)
 insert into TableRegAddress values(4,7,4,104,1004
 insert into TableRegAddress values(5,8,4,105,1005)
 insert into TableRegAddress values(6,9,4,105,1002)
 insert into TableRegAddress values(7,10,2,102,1006)
 insert into TableRegAddress values(8,11,2,103,1007)
 insert into TableRegAddress values(9,12,1,102,1006)
 insert into TableRegAddress values(10,13,1,101,1001)
 insert into TableRegAddress values(11,14,4,107,1021)
 insert into TableRegAddress values(12,15,1,101,1002)
 insert into TableRegAddress values(13,16,1,101,1012)
 select * from TableRegAddress
 select * from TableCourseRegDetail2


 -------------------------------5th table repeat not data insert--------

 create table TableRegAddress3(RegAddress int primary key identity,CourseRegID int,NationID int,StateID int,CityID int,
 constraint j1 foreign key(CourseRegID)references TableCourseRegDetail2(CourseRegID),
 constraint j2 foreign key (NationID) references TableNation(NationID),
 constraint j3 foreign key(StateID) references TableState(StateID),constraint j4 foreign key(CityID) references TableCity(CityId))
 select * from TableRegAddress3
 ----6th table----------

 create table TableFeeDetail(FeeID int primary key identity,CourseRegID int,
 TotalAmount decimal,MinPer decimal,PaidAmount decimal,BalAmount decimal,PaidDate Datetime,
 constraint n1 foreign key (CourseRegID) references TableCourseRegDetail (CourseRegID))

 insert into TableFeeDetail values(4,1000,0,500,500,'2023-04-10')
 insert into TableFeeDetail values(4,300,0,20,2980,'2023-04-04')
 insert into TableFeeDetail values(4,1000,0,200,800,'2023-04-10')
 insert into TableFeeDetail values(4,1000,0,500,500,'2023-04-10')
 insert into TableFeeDetail values(4,1000,0,500,500,'2023-04-10')
 insert into TableFeeDetail values(4,1000,0,500,500,'2023-04-10')
 insert into TableFeeDetail values(4,100,0,500,500,'2023-04-10')
 insert into TableFeeDetail values(4,1000,0,500,500,'2023-04-10')
 insert into TableFeeDetail values(12,1000,0,600,400,'2023-04-10')
 insert into TableFeeDetail values(13,1000,500,600,400,'2023-04-10')
 insert into TableFeeDetail values(14,3000,2400,2400,600,'2023-04-10')
 insert into TableFeeDetail values(15,1000,500,500,500,'2023-04-10')
 insert into TableFeeDetail values(16,3000,2400,2500,500,'2023-04-10')


 ------6th table repeat -----
 create table TableFeeDetail2(FeeID int primary key identity,CourseRegID int,
 TotalAmount decimal,MinPer decimal,PaidAmount decimal,BalAmount decimal,PaidDate Datetime,
 constraint b1 foreign key (CourseRegID) references TableCourseRegDetail2 (CourseRegID))

 



 select * from TableFeeDetail2

             select  l.CityName,l.CityID from TableCity l inner join TableState p on l.StateID = p.StateID where StateName='Andhra Pradesh';

			              SELECT top 1 CourseRegID FROM TableCourseRegDetail2 ORDER BY CourseRegID DESC



