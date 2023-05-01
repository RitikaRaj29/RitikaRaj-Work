create table SUPPLIER(
	SNO varchar(10) primary key,
	SNAME varchar(20),
	[STATUS] int,
	CITY varchar(10)
)

create table PART(
	PNO varchar(10) primary key,
	PNAME varchar(10),
	COLOR varchar(10),
	[WEIGHT] int,
	CITY varchar(10)
)

create table SUPP_PART(
	SNO varchar(10),
	PNO varchar(10),
	QTY int
)

insert into SUPPLIER values('s1','Smith',20,'London')
insert into SUPPLIER values('s2','Jones',10,'Paris')
insert into SUPPLIER values('s3','Blakes',30,'Paris')
insert into SUPPLIER values('s4','Clark',20,'London')
insert into SUPPLIER values('s5','Adams',30,'Athens')
insert into SUPPLIER(SNO,SNAME,CITY) values('s6','Oh','Seattle')
insert into SUPPLIER(SNO,SNAME,CITY) values('s7','Fidel','Seattle')
insert into SUPPLIER(SNO,SNAME,CITY) values('s8','Carlyle','Seattle')

insert into PART values('p1','Nut','Red',12,'London')
insert into PART values('p2','Bolt','Green',17,'Paris')
insert into PART values('p3','Screw','Blue',17,'Rome')
insert into PART values('p4','Screw','Red',14,'London')
insert into PART values('p5','Cam','Blue',12,'Paris')
insert into PART values('p6','Cog','Red',19,'London')

insert into SUPP_PART values('s1','p1',300)
insert into SUPP_PART values('s1','p2',200)
insert into SUPP_PART values('s1','p3',400)
insert into SUPP_PART values('s1','p4',200)
insert into SUPP_PART values('s1','p5',100)
insert into SUPP_PART values('s1','p6',100)
insert into SUPP_PART values('s2','p1',300)
insert into SUPP_PART values('s2','p2',400)
insert into SUPP_PART values('s3','p2',200)
insert into SUPP_PART values('s4','p2',200)
insert into SUPP_PART values('s4','p4',300)
insert into SUPP_PART values('s4','p5',400)

select * from SUPPLIER

/* Q1 */	select SNO,[STATUS] from SUPPLIER where CITY='Paris'

/* Q2 */	select PNO from SUPP_PART

/* Q3 */	select PNO from PART

/* Q4 */	select * from SUPPLIER

/* Q5 */	select PNO, [WEIGHT], [WEIGHT]*454 as WEIGHT_IN_GRAMS from PART

/* Q6 */	select SNO from SUPPLIER where [STATUS]>20

/* Q7 */	select SNO,[STATUS] from SUPPLIER where CITY='Paris' order by [STATUS] desc

/* Q8 */	select SNO from SUPPLIER where [STATUS] IS NULL

/* Q9 */	select * from SUPPLIER as s inner join PART as p on s.CITY=p.CITY order by s.SNO

/* Q10 */	select * from SUPPLIER as s inner join PART as p on s.CITY=p.CITY where s.[STATUS] not like 20 order by s.SNO

/* Q13 */	select count(SNO) as CountOfSNO from SUPPLIER

/* Q14 */	select count(PNO) as CountOfPNO from SUPP_PART where PNO='p2'

/* Q15 */	select sum(QTY) as SumOfQTY from SUPP_PART where PNO='p2'

/* Q16 */	select PNO,sum(QTY) as SumOfQTY from SUPP_PART group by PNO

/* Q17 */	select PNO from SUPP_PART group by PNO having count(SNO)>1

/* Q18 */	select PNAME from PART where PNAME like 'C%'