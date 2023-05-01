create table DEPARTMENT(
	DeptNo varchar(2),
	DeptName varchar(20),
	[Location] varchar(15)
	constraint DeptPK1 primary key(DeptNo)
)

create table EMPLOYEE(
	EmpNo int,
	EmpFname varchar(10),
	EmpLname varchar(10),
	DeptNo varchar(2),
	constraint EmpPK1 primary key(EmpNo),
	constraint EmpFK1 foreign key(DeptNo) references DEPARTMENT(DeptNo) on delete cascade
)

create table PROJECT(
	ProjectNo varchar(2),
	ProjectName varchar(10),
	Budget int,
	constraint ProjPK1 primary key(ProjectNo)
)

create table WORKS_ON(
	EmpNo int,
	ProjectNo varchar(2),
	Job varchar(10),
	[Date] date,
	constraint WorkFK1 foreign key(EmpNo) references EMPLOYEE(EmpNo) on delete cascade,
	constraint WorkFK2 foreign key(ProjectNo) references PROJECT(ProjectNo) on delete cascade
)

insert into DEPARTMENT values('d1','Research','Dallas')
insert into DEPARTMENT values('d2','Accounting','Seattle')
insert into DEPARTMENT values('d3','Marketing','Dallas')

insert into EMPLOYEE values(25348,'Matthew','Smith','d3')
insert into EMPLOYEE values(10102,'Ann','Jones','d3')
insert into EMPLOYEE values(18316,'John','Barrimore','d1')
insert into EMPLOYEE values(29346,'James','James','d2')

insert into PROJECT values('p1','Apollo',120000)
insert into PROJECT values('p2','Gemini',95000)
insert into PROJECT values('p3','Mercury',185600)

insert into WORKS_ON values(10102,'p1','Analyst','1998-01-04')
insert into WORKS_ON values(10102,'p3','Manager','1999-01-01')
insert into WORKS_ON values(25348,'p2','Clerk','1998-02-15')
insert into WORKS_ON values(18316,'p2',null,'1998-02-15')
insert into WORKS_ON values(29346,'p2',null,'1997-12-15')
insert into WORKS_ON values(29346,'p1','Clerk','1998-01-04')
insert into WORKS_ON values(10102,'p1','Clerk','1998-01-01')

/*Q1*/ select EmpNo from WORKS_ON where Job='Clerk'

/*Q2*/ select EmpNo from WORKS_ON where ProjectNo='p2' and EmpNo<10000

/*Q3*/ select EmpNo from WORKS_ON where [Date] not like '1998%'

/*Q4*/ select EmpNo from WORKS_ON where (Job='Analyst' or Job='Manager') and ProjectNo='p1'

/*Q5*/ select [Date] from WORKS_ON where Job is null and ProjectNo='p2'

/*Q6*/ select EmpNo,EmpLname from EMPLOYEE where EmpFname like '%tt%'

/*Q7*/ select EmpNo,EmpFname from EMPLOYEE where EmpLname like ('_o%es') or EmpLname like ('_a%es')

/*Q8*/ select EmpNo from EMPLOYEE as E join DEPARTMENT as D on E.DeptNo=D.DeptNo where D.[Location]='Seattle'

/*Q9*/ select * from DEPARTMENT group by [Location]

/*10*/ select max(EmpNo) from EMPLOYEE

/*11*/ select Job from WORKS_ON group by Job having count(EmpNo)>2

/*12*/ select distinct(E.EmpNo) from WORKS_ON as W join EMPLOYEE as E on W.EmpNo=E.EmpNo where W.Job='Clerk' or E.DeptNo='d3'

--Complex

/*Q1*/ select EmpNo, Job from WORKS_ON as W join PROJECT as P on W.ProjectNo=P.ProjectNo where P.ProjectName='Gemini'

/*Q2*/ select EmpFname,EmpLname from EMPLOYEE as E join DEPARTMENT as D on E.DeptNo=D.DeptNo where D.DeptName='Research' or D.DeptName='Accounting'

/*Q3*/ select [Date] from WORKS_ON as W join EMPLOYEE as E on E.EmpNo=W.EmpNo where E.DeptNo='d1'

/*Q4*/ select P.ProjectName from PROJECT as P join WORKS_ON as W on P.ProjectNo=W.ProjectNo where W.Job='Clerk' group by W.Job,P.ProjectName having count(W.ProjectNo)>=2

/*Q5*/ select E.EmpFname,E.EmpLname from EMPLOYEE as E join WORKS_ON as W on E.EmpNo=W.EmpNo join PROJECT as P on W.ProjectNo = P.ProjectNo where W.Job='Manager' and P.ProjectName='Mercury'

--/*Q6*/ select E.EmpFname,E.EmpLname from EMPLOYEE as E join WORKS_ON as W on E.EmpNo=W.EmpNo group by W.[Date] having count(W.EmpNo)>1

--/*Q7*/ select * from EMPLOYEE as E join DEPARTMENT as D on E.DeptNo=D.DeptNo --group by E.DeptNo having count(D.Location)>1

/*Q8*/ select E.EmpNo from EMPLOYEE as E join DEPARTMENT as D on E.DeptNo=D.DeptNo where D.DeptName='Marketing'

drop table DEPARTMENT
drop table EMPLOYEE
drop table PROJECT
drop table WORKS_ON