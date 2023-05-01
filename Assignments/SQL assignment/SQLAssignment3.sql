 -- Q2 --

create table STUDENT(
	Fname varchar(10),
	Lname varchar(10),
	Age int
)

create table TEACHER(
	Fname varchar(10),
	Lname varchar(10),
	Age int
)

insert into STUDENT values('Susan','Yao',18)
insert into STUDENT values('Ramesh','Arvind',20)
insert into STUDENT values('Joseph','Antony',19)
insert into STUDENT values('Jennifer','Amy',30)
insert into STUDENT values('Andy','Perumal',21)

insert into TEACHER values('Jennifer','Amy',30)
insert into TEACHER values('Nanda','Sham',40)
insert into TEACHER values('Ramesh','Arvind',20)

/* Q2 a. */ select Fname,Lname from STUDENT 
			INTERSECT
			select Fname,Lname from TEACHER

/* Q2 b. */ select Fname,Lname from STUDENT 
			where Fname not in (select Fname from TEACHER)

/* Q2 c. */ select Fname,Lname from TEACHER
			where Fname not in (select Fname from STUDENT)

-- Q4 --

create table PURCHASES(
	CUST_ID int,
	Amount int
)

create table CUSTOMERS(
	CUST_ID int,
	[NAME] varchar(10),
)

insert into PURCHASES values(1,100)
insert into PURCHASES values(3,50)
insert into PURCHASES values(1,200)
insert into PURCHASES values(1,500)
insert into PURCHASES values(3,20)

insert into CUSTOMERS values(1,'Adam')
insert into CUSTOMERS values(2,'Bob')
insert into CUSTOMERS values(3,'Cathy')

/*Q4*/	select C.CUST_ID,isnull(sum(P.Amount),0) as [SUM] 
		from PURCHASES as P right outer join CUSTOMERS as C on P.CUST_ID=C.CUST_ID
		group by C.CUST_ID 
		order by [SUM]