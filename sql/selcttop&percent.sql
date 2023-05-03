create table progressresult1(RollNo int,Name varchar(30),LastName varchar(20),Subject varchar(20),Marks int,MobileNo bigint,AdmisionFees int)

insert into progressresult1 values (1,'Ashu','Wahane','Math',79,3678965456,30000)
insert into progressresult1 values (2,'Akanksha','Wasnik','Science',60,3678964106,5000)
insert into progressresult1 values (3,'Mayuri','Pal','History',50,3678985456,3000)
insert into progressresult1 values (4,'Ranu','Lonkar','Math',60,3678465456,3000)
insert into progressresult1 values (5,'Mahima','Barde','Geography',79,3678965456,3500)

delete  from progressresult1





select *from progressresult1

insert into progressresult1 values (1,'Ashu','Wahane','Math',79,3678965456,30000)
insert into progressresult1 values (2,'Akanksha','Wasnik','Science',60,3678964106,5000)
insert into progressresult1 values (3,'Mayuri','Pal','History',50,3678985456,3000)
insert into progressresult1 values (4,'Ranu','Lonkar','Math',80,3678465456,3000)
insert into progressresult1 values (5,'Mahima','Barde','Geography',79,3678965456,3500)

insert into progressresult1 values (6,'puja','shrnagt','Hindi',85,3674965456,2000)
insert into progressresult1 values (7,'komal','Bhoyar','Marathi',88,3678765456,1000)
insert into progressresult1 values (8,'anjali','Pathk','Hindi',98,3677965456,3500)

insert into progressresult1 values (5,'Mahima','Barde','Geography',79,3678965456,3500)

select distinct Name from progressresult1;--do not repeated word

select AdmisionFees from progressresult1 order by LEN(AdmisionFees);--length function

select AdmisionFees from progressresult1 order by LEN(AdmisionFees) DESC;

select * from progressresult1 where AdmisionFees=3000--Where use the
select * from progressresult1 where Subject='Geography'and LastName='Barde'   --Where use along with and condition
select *from progressresult1 where Subject='abc' or Name='Mahima' -- or means dono me se yek condition true chahiye
select *from progressresult1 where AdmisionFees>3000 -- find 3000 greater admission fees
select *from progressresult1 where Marks<60    --find less marks
select * from progressresult1 where Marks between 50 and 60 order by Marks --range find using (between)
select * from progressresult1 where AdmisionFees between 3000 and 5000 order by Name
select * from progressresult1 where RollNo in (2,3,5)  --jiski value hme chahiye vo (uske liye in)
select *from progressresult1 where Subject not in ('math','science') --jiski value hme nhi chahiye

select * from progressresult1 where Name like '%ma%'  --matlab khi pe bhi rah skta ma
select * from progressresult1 where Name like 'a%'-- starting word bad me kuch bhi ho skta hai 
select * from progressresult1 where Name like 'a%u' --first aur last name

select Top 2 Marks from progressresult1 order by Marks--select top2 marks

select Top 4 Marks from progressresult1 order by Marks--select top4 marks


select Top 50 percent AdmisionFees from progressresult1 order by AdmisionFees--using percent divide
select Top 50 percent AdmisionFees from progressresult1
















