create table foo (
	id int ,
	name varchar (20)
)

insert into foo values (1, 'Akash');
insert into foo values (3, 'Sanal');
insert into foo values (2, 'Dhruv');


select * from foo;

alter table foo 
add constraint pk_id primary key (id);

alter table foo alter column id int not null;

select * from sys.objects;

insert into foo values (6, 'Bheem');
insert into foo values (4, 'zaid');
insert into foo values (5, 'karan');

create index NC_cluster
on foo 