create database joins
create table departments( DEPARTMENT_ID int primary key,DEPARTMENT_NAME varchar (20), MANAGER_ID int, LOCATION_ID int)
insert into departments values(10, 'Administration', 200 , 1700)
insert into departments values( 20 ,'Marketing', 201,1800)
insert into departments values( 30 , 'Purchasing' , 114 ,1700)
insert into departments values(40 , 'Human Resources' , 203 , 2400 )
insert into departments values(50 ,' Shipping',  121 , 1500 )
insert into departments values( 60 , 'IT',  103 , 1400 )
insert into departments values(70 , 'Public Relations', 204 ,2700 )
insert into departments values(80 , 'Sales' , 145 , 2500 )
insert into departments values( 90 , 'Executive' , 100 , 1700 )
insert into departments values(100 , 'Finance' , 108 , 1700)

create table employeess(EMPLOYEE_ID int primary key, FIRST_NAME varchar (20), LAST_NAME varchar(20), EMAIL varchar (20) , PHONE_NUMBER bigint,HIRE_DATE varchar(20),
JOB_ID varchar(20), SALARY int, COMMISSION_PCT int , MANAGER_ID int, DEPARTMENT_ID int,constraint p1 foreign key(DEPARTMENT_ID) references departments (DEPARTMENT_ID))
insert into employeess values(100,  'Steven  King',' SKING','', 5151234567, '2003-06-1765', 'AD_PRE',  24000.00,0.00, 0 , 90 )
insert into employeess values (101, 'Neena', ' Kochhar NKOCHHAR','',  5151234568, '2005-09-21', 'AD_VP',17000.00 , 0.00, 100 , 90 )

insert into employeess values (102 ,'Lex', ' De Haan LDEHAAN','', 5151234569 ,' 2001-01-13', ' AD_VP' , 17000.00, 0.00 , 100 , 90 )
insert into employeess values (103 ,'Alexander', 'Hunold  AHUNOLD','',  5904234567 ,' 2006-01-03',' IT_PROG', 9000.00 , 0.00 , 102 , 60)
insert into employeess values( 104 , 'Bruce ',' Ernst  BERNST','' ,5904234568 , '2007-05-21' , 'IT_PROG' , 6000.00, 0.00, 103, 60 )

insert into employeess values(105,' David ','Austin DAUSTIN' ,'',5904234569, '2005-06-25', 'IT_PROG', 4800.00, 0.00 , 103, 60)
insert into employeess values(106 , 'Valli' ,'Pataballa VPABAL' ,'',5904234560, '2006-02-05', 'IT_PROG' , 4800.00, 0.00 , 103 ,60 )

insert into employeess values(107 , 'Diana' , 'Lorentz  DLORENTZ','',5904235567, '2007-02-07' ,'IT_PROG' ,4200.00, 0.00 , 103 , 60)

select * from employeess
select * from departments


--1. From the following tables, write a SQL query to find the first name, last name, department number, and department name for each employee.
select e.FIRST_NAME,e.LAST_NAME,f.DEPARTMENT_ID,f.DEPARTMENT_NAME from employeess e join departments f on e.DEPARTMENT_ID=f.DEPARTMENT_ID


create table location (LOCATION_ID int primary key, STREET_ADDRESS varchar(20), STATE_PROVINCE int,  COUNTRY_ID int, POSTAL_CODE varchar(20), CITY varchar(30))
insert into location values(1000  ,'Via Cola di Rie',1297, 989, 'Roma' , 'IT')
insert into location values (1100, ' Calle della Testa ',93091, 10934, 'Venice ', 'IT ')
insert into location values(1200 ,'Shinjuku-ku', 2017, 1689,  'Tokyo Prefecture', 'JP' )
insert into location values(1300 , ' Kamiya-cho',9450, 6823 ,'Hiroshima', ' JP' )
insert into location values(1400 ,'Jabberwocky Rd', 2014, 26192, 'Southlake  Texas' ,'US' )
insert into location values (1500 ,'Interiors Blvd',2011, 99236, 'South San Francisc', ' US')
insert into location values(2000 ,'Laogianggen', 40512 ,190518, 'Beijing', 'CN ')
insert into location values( 2100, ' Vileparle (E)',1298 , 490231, 'Bombay Maharashtra ', 'IN ')
insert into location values(2200, 'Victoria Street',1298 ,2901 ,'Sydney New South', 'AU')

insert into location values( 2300 ,'Clementi North',198, 540198 ,'Singapore',' SG' )
insert into location values( 2400,' Arthur St',8204,45621,'London ',' UK')
select * from location

--From the following tables, write a SQL query to find the first name, last name, department, city, and
--state province for each employee.
select e.FIRST_NAME,e.LAST_NAME,f.DEPARTMENT_NAME,l.CITY,l.STATE_PROVINCE FROM employeess e join departments f on e.DEPARTMENT_ID=f.DEPARTMENT_ID join location l on  l.LOCATION_ID = l.LOCATION_ID;

create table job_grades(GRADE_LEVEL varchar (10) primary key, LOWEST_SAL int, HIGHEST_SAL int)
insert into job_grades values('A' ,1000, 2999)
 insert into job_grades values('B' ,3000 ,5999)
insert into job_grades values('C' ,6000 ,9999)
insert into job_grades values('D ',10000 ,14999)
insert into job_grades values('E' ,15000 ,24999)
insert into job_grades values('F' ,25000 ,40000)
select * from job_grades

--From the following table, write a SQL query to find the first name, last name, salary, and job grade for all employees.
select e.FIRST_NAME,e.LAST_NAME,SALARY,b.GRADE_LEVEL from employeess e join job_grades b on  e.salary BETWEEN b.lowest_sal AND b.highest_sal;

--From the following tables, write a SQL query to find all those employees who work in department ID 80 or 40. Return first name, last name, department number and department name.
select e.FIRST_NAME,e.LAST_NAME,e.DEPARTMENT_ID,f.DEPARTMENT_NAME FROM employeess e join departments f on e.DEPARTMENT_ID=f.DEPARTMENT_ID where e.DEPARTMENT_ID between 30 and 80

select e.FIRST_NAME,e.LAST_NAME,f.DEPARTMENT_ID,f.DEPARTMENT_NAME FROM employeess e join departments f on f.DEPARTMENT_ID=e.DEPARTMENT_ID where f.DEPARTMENT_ID between 30 and 80

--. From the following tables, write a SQL query to find those employees whose first name contains the letter ‘z’. Return first name, last name, department, city, and state province.
select e.FIRST_NAME,e.LAST_NAME,f.DEPARTMENT_NAME,l.city,l.STATE_PROVINCE from employeess e join  departments f on e.DEPARTMENT_ID=f.DEPARTMENT_ID join location l on  l.LOCATION_ID=l.LOCATION_ID where e.FIRST_NAME like 'a%' 

--From the following tables, write a SQL query to find all departments, including those without
--employees. Return first name, last name, department ID, department name.
select e.FIRST_NAME,e.LAST_NAME,f.DEPARTMENT_ID,f.DEPARTMENT_NAME FROM employeess e right join  departments f on e.DEPARTMENT_ID=f.DEPARTMENT_ID
