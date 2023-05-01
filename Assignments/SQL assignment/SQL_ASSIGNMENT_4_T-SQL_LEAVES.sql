create table Employee2
(
	ecode int primary key,
	ename varchar(20),
	salary int,
	deptid int,
)

create table Leaves
(
	ecode int references Employee2(ecode),
	available_leaves int,
)

create table leaves_applied
(
	ecode int references Employee2(ecode),
	no_of_leaves_applied int,
	[status] varchar(10) check([status] in('APPROVED','REJECTED')),
)

create trigger trig1_leaves_applied
on leaves_applied
for insert 
as
declare @ec int,@avlbl_leaves int,@req_leaves int
--access the leaves applied from inserted table
select @req_leaves = no_of_leaves_applied from inserted
--get the available names from leaves table for the employees
select @avlbl_leaves = available_leaves from leaves where ecode=@ec
--check if leaves are available 
if @avlbl_leaves >= @req_leaves
begin
	update leaves_applied set [status]='APPROVED' where ecode=@ec
	update leaves set available_leaves = available_leaves-@req_leaves where ecode=@ec
	print 'Leave Request Approved'
end
else
begin
	update leaves_applied set [status] ='REJECTED' where ecode=@ec
	print 'Leave Request Rejected'
end

--create procedure sp_update_leave 

insert into Employee2 values(101,'ATUL',1000,201)
insert into Employee2 values(102,'ABHAY',2000,202)
insert into Employee2 values(103,'ADITYA',3000,203)
insert into Employee2 values(104,'ARMAAN',4000,204)
insert into Employee2 values(105,'ALOK',5000,205)

insert into Leaves values(101,10)
insert into Leaves values(102,8)
insert into Leaves values(103,13)
insert into Leaves values(104,11)
insert into Leaves values(105,9)

insert into leaves_applied values(101,2,'approved')



select * from Employee2
select * from Leaves
select * from leaves_applied