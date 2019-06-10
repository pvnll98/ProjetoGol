create table Clientes(
	Id int identity(1,1) primary key,
	Nome varchar(200),
	DataNascimento datetime,
	Salario float
)

insert into Clientes values('Lucas','1990-04-06 00:00:00',1000)
insert into Clientes values('Eduardo','1990-10-10 00:00:00',2000)
