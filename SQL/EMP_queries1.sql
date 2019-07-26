use AurionPro;
Select * from Sys.objects;

select * from DEPT;

create procedure usp_giveHike @empid int, @percentage float  
as
update EMP set SAL = SAL + (SAL * @percentage/100) 
where empno = @empid
go

exec usp_giveHike @empid = 7369 , @percentage = 50;


go
create procedure usp_giveHike5 @empid int, @percentage float
as
declare @hikedsal float
update EMP set SAL = SAL + (SAL * @percentage/100) 
where empno = @empid
set @hikedsal = (select SAL from emp where empno = @empid)
return @hikedsal 
go


declare @hikedvalue float;
exec @hikedvalue = usp_giveHike5 @empid = 7369 , @percentage = 50;
select @hikedvalue as HikedSal

go 
create function getMaxSalariedEmployee5()
returns varchar(10)
begin
return (select emp.ENAME from EMP where sal = (select max(sal) from EMP));
end
go

select dbo.getMaxSalariedEmployee5();

select * from EMP;

go
create trigger makeUpperCase
on dept
instead of 
insert
as
begin
declare @deptno int, @deptname varchar(15), @loc varchar(15)
select @deptno =inserted.DEPTNO from inserted
select @deptname=inserted.DNAME from inserted
select @loc=inserted.loc from inserted
insert into dept values(@deptno,UPPER(@deptname),UPPER(@loc) );
end


insert into dept values (50, 'marketing', 'Mira road');

select * from dept;

