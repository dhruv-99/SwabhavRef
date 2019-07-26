create table CMapping (
	Map_id int primary key,
	college_id int foreign key references COLLEGE(college_id),
	dept_id int foreign key references CDepartment(dept_id)
)

insert into CMapping values (1, 1 , 1);
insert into CMapping values (2, 1 , 2);
insert into CMapping values (3, 1 , 3);

insert into CMapping values (4, 2 , 1);
insert into CMapping values (5, 2 , 3);
insert into CMapping values (6, 2 , 4);

insert into CMapping values (7, 3 , 1);
insert into CMapping values (8, 3 , 4);

insert into CMapping values (9, 4 , 1);
insert into CMapping values (10, 4 , 2);
insert into CMapping values (11, 4 , 3);
insert into CMapping values (12, 4 , 4);

select * from CMapping;