create table Department 
(
	dept_number int primary key ,
	dept_name char(20) not null,
	dept_location char(20) not null
);

insert into Department values (101, 'Sales', 'Mumbai');
insert into Department values (201, 'Production', 'Pune');
insert into Department values (301, 'Marketing', 'Nashik');

