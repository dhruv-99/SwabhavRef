create table Professor (
professor_id int,
professor_name char(20),
professor_subject char(20),
professor_colllegeId int foreign key references COLLEGE(college_id),
professor_deptId int foreign key references CDepartment(dept_id)

);

insert into Professor values (1 , 'Kannan', '.net', 1, 1);
insert into Professor values (2 , 'Abhishek', 'DSP', 2, 3);
insert into Professor values (1 , 'Sandeep', 'DBMS', 3, 2);
