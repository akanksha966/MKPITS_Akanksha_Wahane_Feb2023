create table Teachers2 (teacher_id int primary key,Age int)
insert into Teachers2 values(12,33)     --id same ho skti hai kuyu ke hmne relationship kiye 
insert into Teachers2 values (55,44)--primary key aur foreign key me
insert into Teachers2 values(14,22)


create table Subject2 (teacher_id int,Subject varchar (20),constraint A1 foreign key (teacher_id) references Teachers(teacher_id))

insert into Subject values(12,'chemistry')    --code 12 id 
insert into Subject values (12,'Biology')      -- code 12 id--yek teacher 2 subject padha skta hai
insert into Subject values(55,'History')
insert into Subject values(13,'Science')
insert into Subject values (12,'Math')

select * from Subject
select * from Teachers2