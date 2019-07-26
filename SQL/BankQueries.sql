create table bank_master (
name char(30),
pass varchar(15) not null,
balance float,
primary key (name),
check (balance >= 500) 
)

create table bank_transaction(
name char(30) not null,
amount float not null,
transaction_type char(1) not null check (transaction_type in('D','W') ),
transaction_date datetime not null default getdate(),
foreign key (name) references bank_master(name)
)

insert into bank_master values ('Dhruv', 'dhruv123', 1000);

insert into bank_transaction values ('Dhruv', 1000, 'D',GETDATE());

select * from bank_master;

select * from bank_transaction;

use AurionPro;

go 
begin transaction Register
begin try
insert into bank_master values ('Sanal', 'sanal123', 450);
insert into bank_transaction values ('Sanal', 450, 'D', GETDATE());
commit
end  try
begin catch
rollback
end catch

go 
begin transaction DoTransactionDepsit
begin try
update bank_master set balance = balance + 500 where name = 'Akash';
insert into bank_transaction values ('Akash', 500, 'D', GETDATE());
commit
end  try
begin catch
rollback
end catch

go 
begin transaction DoTransactionWithdraw
begin try
update bank_master set balance = balance - 100 where name = 'Akash';
insert into bank_transaction values ('Akash', 100, 'w', GETDATE());
commit
end  try
begin catch
rollback
end catch

drop table Bank_master;
drop table Bank_transaction;

truncate table bank_master;
truncate table bank_transaction;

create table Bank_master
(
name varchar(20) primary key,
pass varchar(20) not null ,
balance float ,
check(balance> 500)
 
);

create table Bank_transaction
(
name varchar(20) not null,
amount varchar(20) not null,
transactiontype varchar(20) not null check (transactiontype in('D','W') ),
transaction_date datetime not null default getdate(),
foreign key (name) references bank_master(name)

 
);

drop table Bank_master;

drop table Bank_transaction;

select * from bank_transaction;

use AurionPro;

select * from bank_transaction;

insert into bank_transaction values ('akash', 500, 'W', GETDATE());

exec sp_executesql N'update bank_master set balance = balance - @amount where name = ''@name'';',N'@name nvarchar(30),@amount nvarchar(3)',@name=N'James                         ',@amount=N'500'
go

exec sp_executesql N'insert into bank_transaction values (''@name'', @amount, ''D'', GETDATE());',N'@name nvarchar(30),@amount nvarchar(3),@name nvarchar(30),@amount nvarchar(3)',@name=N'James                         ',@amount=N'500',@name=N'James                         ',@amount=N'500'
go

exec sp_executesql N'update bank_master set balance = balance+ @dAmount where name = '' @dName'';',N'@wName nvarchar(30),@wAmount nvarchar(3)',@wName=N'James                         ',@wAmount=N'500'
go

exec sp_executesql N'update bank_master set balance = balance+ @dAmount where name = '' @dName'';',N'@wName nvarchar(30),@wAmount nvarchar(3)',@wName=N'James                         ',@wAmount=N'500'
go

exec sp_executesql N'update bank_master set balance = balance+ @dAmount where name = '' @dName'';',N'@wName varchar(30),@wAmount float,@dAmount float',@wName='James                         ',@wAmount=500,@dAmount=default
go

exec sp_executesql N'update bank_master set balance = balance+ @Amount where name = '' @Name'';',N'@Name varchar(30),@Amount float,@Amount float',@Name='James                         ',@Amount=500,@Amount=default
go

exec sp_executesql N'insert into bank_transaction values (''@Name'', @Amount, ''D'', GETDATE());',N'@Name varchar(30),@Amount float',@Name='James                         ',@Amount=500
go

exec sp_executesql N'insert into bank_transaction values (''@Name'', @Amount, ''D'', GETDATE());',N'@Name varchar(30),@Amount float',@Name='James                         ',@Amount=500
go