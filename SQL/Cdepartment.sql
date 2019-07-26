create table CDepartment (
	dept_id int primary key,
	dept_name char(20)
)

alter table CDepartment alter column dept_name char(30); 

insert into CDepartment values (1, 'Computer Engineering');
insert into CDepartment values (2, 'Information Technology');
insert into CDepartment values (3, 'Electrical Engineering');
insert into CDepartment values (4, 'Civil Engineering');

select * from CDepartment;