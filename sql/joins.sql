CREATE TABLE Student (
id int PRIMARY KEY IDENTITY,
admission_no varchar(45) NOT NULL,--table student and data
first_name varchar(45) NOT NULL,
last_name varchar(45) NOT NULL,
age int,
city varchar(25) NOT NULL
);

INSERT INTO Student (admission_no, first_name, last_name, age, city)
VALUES (3354,'Luisa', 'Evans', 13, 'Texas'),--table fee and data inserting
(2135, 'Paul', 'Ward', 15, 'Alaska'),
(4321, 'Peter', 'Bennett', 14, 'California'),
(4213,'Carlos', 'Patterson', 17, 'New York'),
(5112, 'Rose', 'Huges', 16, 'Florida'),
(6113, 'Marielia', 'Simmons', 15, 'Arizona'),
(7555,'Antonio', 'Butler', 14, 'New York'),
(8345, 'Diego', 'Cox', 13, 'California');


select * from Student

CREATE TABLE Fee (
admission_no varchar(45) NOT NULL,
course varchar(45) NOT NULL,
amount_paid int,
);

INSERT INTO Fee (admission_no, course, amount_paid)
VALUES (3354,'Java', 20000),
(7555, 'Android', 22000),
(4321, 'Python', 18000),

(8345,'SQL', 15000),
(5112, 'Machine Learning', 30000);
select * from Fee

select s.id,s.admission_no,s.first_name,s.last_name,f.course,f.amount_paid from Student s inner join Fee f on s.admission_no=f.admission_no--inner join
select s.id,s.admission_no,s.first_name,s.last_name,f.course,f.amount_paid from Student s cross join Fee f --cross join
select s.id,s.admission_no,s.first_name,s.last_name,f.course,f.amount_paid from Student s left outer join Fee f on s.admission_no=f.admission_no--left outer join join
select s.id,s.admission_no,s.first_name,s.last_name,f.course,f.amount_paid from Student s right outer join Fee f on s.admission_no=f.admission_no--right outer join join

select s.id,s.admission_no,s.first_name,s.last_name,f.course,f.amount_paid from Student s full join Fee f on s.admission_no=f.admission_no--left outer join join



