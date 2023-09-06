CREATE DATABASE DbSalario 

CREATE TABLE Tb_Funcionario (
	id INT NOT NULL IDENTITY(1, 1),
	nome VARCHAR(200),
	cargo VARCHAR(200),
	caminhoFoto VARCHAR(250),
	dataAdmissao DATETIME,
	salarioBruto DECIMAL(14, 2),
	salarioLiquido DECIMAL(14, 2),
	INSS DECIMAL(14, 2)
);

create table cargo (
id int primary key identity(1,1),
cargo varchar(20) not null
)

drop table cargo

insert into cargo values
('DESENVOLVEDOR JUNIOR'),
('DESENVOLVEDOR SENIOR'),
('DESENVOLVEDOR PLENO'),
('GERENTE'),
('SUPERVISOR'),
('DIRETOR'),
('ESTAGIÁRIO'),
('PRESIDENTE')

SELECT * FROM cargo