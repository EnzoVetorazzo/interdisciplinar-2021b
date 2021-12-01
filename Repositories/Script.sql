-- Data Source = localhost
-- Integrated Security = True
-- Initial Catalog = BDTodo

create database Atletica_BD
go

use Atletica_BD
go

create table Usuario
(
	usuario_id			int		not null	primary key identity,
	nome				varchar(100)		not null,
	telefone			varchar(11)		not null,
	senha				varchar(20)		not null
)
go

create table Cliente
(
	id					int				not null	primary key identity,
	fgk_usuario			int				not null	references usuario,
	email				varchar(40)		not null
)
go



create table Funcionario
(
	id					int				not null	primary key identity,
	fgk_usuario			int				not null	references usuario,
	funcao				varchar(25)		not null
)
go

create table Servicos
(
	id					int					not null	primary key identity,
	fgk_funcionario		int					not null	references funcionario,
	duracao				varchar(10)			not null,
	dias				varchar(30)			not null,
	horarios			varchar(40)			not null,
	nome				varchar(20)			not null
)
go

create table Agendamentos
(
	id					int					not null	primary key identity,
	fgk_servicos		int					not null	references servicos,
	nome				varchar(25)			not null,
	hora_inicio			smalldatetime		not null,
	hora_fim			datetime			not null
)
go

create table Agenda
(
	id_agenda			int				not null	primary key identity,
	fgk_agendamentos	int				not null	references agendamentos,
	fgk_cliente			int				not null	references cliente
)
go
