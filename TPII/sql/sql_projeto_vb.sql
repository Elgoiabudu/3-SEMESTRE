create database cadastro_dsm3s

USE cadastro_dsm3s

CREATE TABLE cad_cli
(
id int primary key identity(1,1) not null,
nome varchar (200),
cpf varchar (14),
foto varchar (250)
)