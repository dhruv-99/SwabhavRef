create table customer(
customer_id int primary key,
customer_name varchar(20),
customer_balance float
)

create table merchant(
merchant_id int primary key,
merchant_name varchar(20),
merchant_balance float
)

insert into customer values (1,'Akash',10000);
insert into customer values (2,'Sanal',10000);
insert into customer values (3,'Dhruv',10000);

insert into merchant values (1,'James',100000);
insert into merchant values (2,'Akhilesh',50000);

go
begin transaction t1
begin try
update customer set customer.customer_balance = customer.customer_balance - 5000 where customer.customer_id = 3;
update merchant set merchant.merchant_balance = merchant.merchant_balance + 5000 where merchant.merchant_id = 'akash';
--throw 51000, 'the record does not exist',1;
commit
end try
begin catch
rollback
end catch

select * from customer;
select * from merchant;




