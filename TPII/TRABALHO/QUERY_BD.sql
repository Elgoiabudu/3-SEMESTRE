
CREATE DATABASE DbSalario

CREATE TABLE Tb_Funcionario (
	id INT NOT NULL IDENTITY(1, 1),
	nome VARCHAR(200) NOT NULL,
	cargo VARCHAR(200) NOT NULL,
	caminhoFoto VARCHAR(250) NOT NULL,
	CPF VARCHAR(20) UNIQUE NOT NULL,
	dataAdmissao DATETIME NOT NULL,	
	salarioBruto DECIMAL(14, 2) NOT NULL,
	salarioLiquido DECIMAL(14, 2) NOT NULL,
	INSS DECIMAL(14, 2) NOT NULL
);

select * from Tb_Funcionario

delete from Tb_Funcionario 

INSERT INTO Tb_Funcionario (nome, cargo, caminhoFoto, CPF, dataAdmissao, salarioBruto, salarioLiquido, INSS)
VALUES ('João da Silva', 'Analista de Vendas', '/fotos/joao.jpg', '123.456.789-00', '2023-09-08', 5000.00, 4200.00, 800.00);

alter table Tb_Funcionario
add CPF varchar(20) UNIQUE

SELECT * FROM Tb_Funcionario WHERE CPF='351.865.478-08'

UPDATE Tb_Funcionario SET
nome='tes',
cargo='tes',
caminhoFoto='a',
dataAdmissao='2023-09-09',
salarioBruto='10000',
salarioLiquido='9000',
INSS='1000'
WHERE
CPF='351.865.478-09'