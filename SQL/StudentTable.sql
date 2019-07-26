create table Student (
student_id int primary key,
student_firstName varchar(15),
student_lastName varchar(15),
student_cgpa float
);


insert into Student values (2, 'Akash', 'Jaiswal', 8.85 );
insert into Student values (3, 'Sanal', 'Dhamanse', 8.85 );
insert into Student values (4, 'Priyank', 'Shah', 9.85 );
insert into Student values (5, 'Brijesh', 'Jaiswal', 9.65 );
insert into Student values (6, 'Akhilesh', 'Singh', 7.85 );


select * from Student;

update Student set student_cgpa = 9.00 where student_id = 5;

