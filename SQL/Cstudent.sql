create table Cstudent (
student_id int primary key,
student_firstName char(10),
student_lastName char(20),
student_address varchar(35),
student_class int,
department_id int,
college_id int,
 foreign key (department_id) references CDepartment(dept_id),
 foreign key (college_id) references COLLEGE(college_id)
)

insert into Cstudent values (1, 'Dhruv', 'Ballikar', 'Mira Road', 10 , 1 , 1);
insert into Cstudent values (2, 'Akash', 'Jaiswal', 'Dadar', 9 , 2 , 3);
insert into Cstudent values (3, 'Sanal', 'Dhamanse', 'Wadala', 9 , 1 , 4);