CREATE TABLE tbClientes (
    ID INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(150) NOT NULL,
    sobrenome VARCHAR(100) NOT NULL,
    email VARCHAR(255) UNIQUE NOT NULL,
	cpf VARCHAR(14) UNIQUE NOT NULL,
	rg VARCHAR(12) UNIQUE NOT NULL,
    telefoneCel VARCHAR(14) NOT NULL,
	telefoneFixo VARCHAR(13),
    endereco VARCHAR(255),
    cidade VARCHAR(100),
    estado VARCHAR(50),
    CEP VARCHAR(10),
    dataCadastro DATETIME NOT NULL
				DEFAULT CURRENT_TIMESTAMP
);

select * from tbClientes

ALTER TABLE tbClientes 
ADD
foto VARCHAR(250)

INSERT INTO tbClientes (nome, sobrenome, email, cpf, rg, telefoneCel, telefoneFixo, endereco, cidade, estado, CEP)
VALUES ('João', 'Silva', 'joao.silva@email.com', '123.456.789-01', '1234567', '555-5555', '555-5555', 'Rua A', 'São Paulo', 'SP', '12345-678');

INSERT INTO tbClientes (nome, sobrenome, email, cpf, rg, telefoneCel, telefoneFixo, endereco, cidade, estado, CEP)
VALUES ('Maria', 'Pereira', 'maria.pereira@email.com', '987.654.321-09', '9876543', '555-5555', '555-5555', 'Rua B', 'Rio de Janeiro', 'RJ', '98765-432');

INSERT INTO tbClientes (nome, sobrenome, email, cpf, rg, telefoneCel, telefoneFixo, endereco, cidade, estado, CEP)
VALUES ('Carlos', 'Fernandes', 'carlos.fernandes@email.com', '111.222.333-44', '1112223', '555-5555', '555-5555', 'Rua C', 'Belo Horizonte', 'MG', '11111-222');

INSERT INTO tbClientes (nome, sobrenome, email, cpf, rg, telefoneCel, telefoneFixo, endereco, cidade, estado, CEP)
VALUES ('Ana', 'Santos', 'ana.santos@email.com', '222.333.444-55', '2223334', '555-5555', '555-5555', 'Rua D', 'Brasília', 'DF', '22222-333');


select * from tbClientes

CREATE TABLE tbFornec (
	ID INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(150) NOT NULL,
	email VARCHAR(150) NOT NULL,
	CNPJ VARCHAR (150) UNIQUE NOT NULL,
	telefone VARCHAR(14) NOT NULL,
	endereco VARCHAR(255) NOT NULL,
    cidade VARCHAR(100) NOT NULL,
    estado VARCHAR(50) NOT NULL,
	situacao VARCHAR (20) NOT NULL
);

INSERT INTO tbFornec (nome, email, CNPJ, telefone, endereco, cidade, estado, situacao)
VALUES
('Fornecedor A', 'fornecedorA@email.com', '12345678901234', '123-456-7890', 'Rua A, 123', 'Cidade A', 'Estado A', 'Ativo'),
('Fornecedor B', 'fornecedorB@email.com', '23456789012345', '234-567-8901', 'Rua B, 456', 'Cidade B', 'Estado B', 'Ativo'),
('Fornecedor C', 'fornecedorC@email.com', '34567890123456', '345-678-9012', 'Rua C, 789', 'Cidade C', 'Estado C', 'Ativo'),
('Fornecedor D', 'fornecedorD@email.com', '45678901234567', '456-789-0123', 'Rua D, 101', 'Cidade D', 'Estado D', 'Ativo'),
('Fornecedor E', 'fornecedorE@email.com', '56789012345678', '567-890-1234', 'Rua E, 222', 'Cidade E', 'Estado E', 'Ativo'),
('Fornecedor F', 'fornecedorF@email.com', '67890123456789', '678-901-2345', 'Rua F, 333', 'Cidade F', 'Estado F', 'Ativo'),
('Fornecedor G', 'fornecedorG@email.com', '78901234567890', '789-012-3456', 'Rua G, 444', 'Cidade G', 'Estado G', 'Ativo'),
('Fornecedor H', 'fornecedorH@email.com', '89012345678901', '890-123-4567', 'Rua H, 555', 'Cidade H', 'Estado H', 'Ativo'),
('Fornecedor I', 'fornecedorI@email.com', '90123456789012', '901-234-5678', 'Rua I, 666', 'Cidade I', 'Estado I', 'Ativo'),
('Fornecedor J', 'fornecedorJ@email.com', '01234567890123', '012-345-6789', 'Rua J, 777', 'Cidade J', 'Estado J', 'Ativo');

INSERT INTO tbFornec (nome, email, CNPJ, telefone, endereco, cidade, estado, situacao)
VALUES
('a', 'a', '12', '12', 'Rua A, 123', 'Cidade A', 'Estado A', 'Ativo')

SELECT * FROM tbFornec

create table tbCateg(
ID int primary key identity(1,1),
descricao varchar(100)
);

insert into tbCateg (descricao)
values
('AÇÃO'),
('AVENTURA'),
('FICÇÃO CIENTÍFICA'),
('TERROR'),
('HORROR'),
('COMÉDIA'),
('DRAMA'),
('ROMANCE');

SELECT * FROM tbCateg

SELECT * FROM tbClientes

INSERT INTO tbClientes
                (nome,
                sobrenome,
                email,
                cpf,
                rg,
                telefoneCel,
                telefoneFixo,
                endereco,
                cidade,
                estado,
                cep,
                foto)
                VALUES
                ('{txtNome.Text}',
                '{txtSobrenome.Text}',
                '{txtEmail.Text}',
                '{txtCPF.Text}',
                '{txtRG.Text}',
                '{txtCelular.Text}',
                '{txtFixo.Text}',
                '{txtEndereco.Text}',
                '{txtCidade.Text}',
                '{diretorio}')


				INSERT INTO tbClientes
                (nome,
                sobrenome,
                email,
                cpf,
                rg,
                telefoneCel,
                telefoneFixo,
                endereco,
                cidade,
                estado,
                cep,
                foto)
                VALUES
                ('{txtNome.Text}',
                '{txtSobrenome.Text}',
                '{txtEmail.Text}',
                '{txtCPF.Text}',
                '{txtRG.Text}',
                '{111111111}',
                '{111111111}',
                '{txtEndereco.Text}',
                '{txtCidade.Text}',
                '{txtEstado.Text}',
                '{txt}',
                '{diretorio}')



delete from tbClientes where id = 1006

select * from tbClientes

delete from tbClientes where ID = 1002

INSERT INTO tbClientes
                (nome,
                sobrenome,
                email,
                cpf,
                rg,
                telefoneCel,
                telefoneFixo,
                endereco,
                cidade,
                estado,
                cep,
                foto)
                VALUES
                ('{txtNome.Text}',
                '{txtSobrenome.Text}',
                '{txtEmail.Text}',
                '{maskCPF.Text}',
                '{maskRG.Text}',
                '{maskCel.Text}',
                '{maskFixo.Text}',
                '{txtEndereco.Text}',
                '{txtCidade.Text}',
                '{txtEstado.Text}',
                '{txtCEP.Text}',
                '{diretorio}')
                