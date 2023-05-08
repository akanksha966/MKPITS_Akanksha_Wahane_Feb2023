create table course(courseid int primary key,coursename varchar(25))
insert into course values(1,'Dotnet')
insert into course values(2,'Java')

create table studentinfo(Rno int primary key,name varchar (20),courseid int ,constraint u1 foreign key(courseid) references course(courseid))
insert into studentinfo values(12,'Akanksha',1)
insert into studentinfo values(13,'Ashu',1)
insert into studentinfo values(15,'Mayuri',2)
insert into studentinfo values(14,'Rupali',2)
----inner join find duplicate---
select coursename from course where courseid in(select courseid from studentinfo where name='Akanksha')


select s.courseid,s.coursename,g.name from  course s inner join studentinfo g on s.courseid=g.courseid where coursename='java'

select s.coursename,g.rno from course s inner join studentinfo g on s.courseid=g.courseid where coursename='Dotnet'

select s.coursename,g.rno from course s inner join studentinfo g on s.courseid=g.courseid where name='Akanksha'







select * from course
select * from studentinfo