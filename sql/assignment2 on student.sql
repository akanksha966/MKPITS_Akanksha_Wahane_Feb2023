create table Student (Rollno int primary key,name varchar(20),email varchar(20),city varchar(27),courseid int)

insert into Student values(12,'akanksha','wahane@gmail.com','nagpur',23)
insert into Student values(13,'ashu','wahane@gmail.com','bhandara',24)
insert into Student values(14,'mayuri','pal@gmail.com','nagpur',27)
insert into Student values(15,'rupali','barde@gmail.com','bhandara',25)
insert into Student values(16,'ranu','wahane@gmail.com','pune',23)

create table Fees(feesid int primary key,rno int,feesdate varchar(20),amount int,courseid int,constraint p1 foreign key(rno) references Student(Rollno))
insert into Fees values(1,12,'2-3-2022',20000,33)
insert into Fees values(2,13,'4-3-2022',10000,34)
insert into Fees values(3,14,'5-3-2022',50000,35)
insert into Fees values(4,15,'6-3-2022',10000,37)
insert into Fees values(5,16,'9-3-2022',40000,34)

---------write a query to display fees details of those student whose city nagpur------
select s.name,s.Rollno,s.city,p.amount from Student s inner join Fees p on s.Rollno=p.rno where city='nagpur'
---------write a query to display fees details of those student whose city pune------

select s.name,s.Rollno,s.city,p.amount from Student s inner join Fees p on s.Rollno=p.rno where city='pune'
---------write a query to display fees details of those student whose city bhandara------

select s.name,s.Rollno,s.city,p.amount from Student s inner join Fees p on s.Rollno=p.rno where city='bhandara'


---------write a query to get student details whose course is java----





select * from Student
select * from Fees