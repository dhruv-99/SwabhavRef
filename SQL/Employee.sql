create table Employee 
(
	employee_id int primary key ,
	employee_firstName char(20) not null,
	employee_lastName char(20) not null,
	employee_salary float not null,
	employee_deptId int foreign key references department(dept_number)
);

insert into Employee values (1, 'Dhruv', 'Ballikar', 5000.60, 101 );
insert into Employee values (2, 'Akash', 'Jaiswal', 6000.70 , 201);
insert into Employee values (3, 'Sanal', 'Dhamanse', 10000 , 201 );
insert into Employee values (4, 'Priyank', 'Shah', 12000 , 101 );
insert into Employee values (5, 'Brijesh', 'Jaiswal', 16000.45 , 301);
insert into Employee values (6, 'Akhilesh', 'Singh', 45000.50 , 301 );

insert into Employee values (7, 'James', 'Raj', 45000.50 , 101 );