create table tbl_expense
(
	expense_id int primary key identity(1,1),
	amount int ,
	date_of_expense date
)
select * from tbl_expense

create procedure sp_expense(@a int)
as
declare @sal int = 50000
declare @s int
declare @c int
select @s=sum(amount) from tbl_expense
if @s is null set @s=0
		if (@s+@a)<25000
		begin
			insert into tbl_expense values(@a,getdate())
			print 'Record Inserted'
		end
		else
		begin
			print'You are exceeding your expense.'
		end

drop table tbl_expense
drop procedure sp_expense
exec sp_expense 999
select * from tbl_expense

