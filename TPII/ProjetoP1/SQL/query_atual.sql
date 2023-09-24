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
    foto VARCHAR(250),
    dataCadastro DATETIME NOT NULL
				DEFAULT CURRENT_TIMESTAMP
);

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

create table tbCateg(
ID int primary key identity(1,1),
descricao varchar(100)
);

CREATE TABLE tbFilmes (
    IDfilme INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(250) NOT NULL,
    lancamento DATETIME NOT NULL,
    codFornec int,
    codCateg INT,
    valor DECIMAL(10,2),
    sinopse VARCHAR (250),
    FOREIGN KEY (codFornec) REFERENCES tbFornec(ID),
    FOREIGN KEY (codCateg) REFERENCES tbCateg(ID)
)

select * from tbFilmes
select * from tbFornec
SELECT * from tbCateg
select * from tbClientes

INSERT INTO tbFilmes 
(nome,
lancamento,
codFornec,
codCateg,
valor,
sinopse)
VALUES
('teste', '2023-09-03 12:55:28.847', 1, 1, 5.00, 'adasdasdasdasdas')


INSERT INTO tbClientes (nome, sobrenome, email, cpf, rg, telefoneCel, telefoneFixo, endereco, cidade, estado, CEP)
VALUES ('João', 'Silva', 'joao.silva@email.com', '123.456.789-01', '1234567', '555-5555', '555-5555', 'Rua A', 'São Paulo', 'SP', '12345-678');

INSERT INTO tbClientes (nome, sobrenome, email, cpf, rg, telefoneCel, telefoneFixo, endereco, cidade, estado, CEP)
VALUES ('Maria', 'Pereira', 'maria.pereira@email.com', '987.654.321-09', '9876543', '555-5555', '555-5555', 'Rua B', 'Rio de Janeiro', 'RJ', '98765-432');

INSERT INTO tbClientes (nome, sobrenome, email, cpf, rg, telefoneCel, telefoneFixo, endereco, cidade, estado, CEP)
VALUES ('Carlos', 'Fernandes', 'carlos.fernandes@email.com', '111.222.333-44', '1112223', '555-5555', '555-5555', 'Rua C', 'Belo Horizonte', 'MG', '11111-222');

INSERT INTO tbClientes (nome, sobrenome, email, cpf, rg, telefoneCel, telefoneFixo, endereco, cidade, estado, CEP)
VALUES ('Ana', 'Santos', 'ana.santos@email.com', '222.333.444-55', '2223334', '555-5555', '555-5555', 'Rua D', 'Brasília', 'DF', '22222-333');

INSERT INTO tbFornec (nome, email, CNPJ, telefone, endereco, cidade, estado, situacao)
VALUES
('Fornecedor A', 'fornecedorA@email.com', '12345678901234', '123-456-7890', 'Rua A, 123', 'Cidade A', 'Estado A', 'ATIVO'),
('Fornecedor B', 'fornecedorB@email.com', '23456789012345', '234-567-8901', 'Rua B, 456', 'Cidade B', 'Estado B', 'ATIVO'),
('Fornecedor C', 'fornecedorC@email.com', '34567890123456', '345-678-9012', 'Rua C, 789', 'Cidade C', 'Estado C', 'ATIVO'),
('Fornecedor D', 'fornecedorD@email.com', '45678901234567', '456-789-0123', 'Rua D, 101', 'Cidade D', 'Estado D', 'ATIVO'),
('Fornecedor E', 'fornecedorE@email.com', '56789012345678', '567-890-1234', 'Rua E, 222', 'Cidade E', 'Estado E', 'ATIVO'),
('Fornecedor F', 'fornecedorF@email.com', '67890123456789', '678-901-2345', 'Rua F, 333', 'Cidade F', 'Estado F', 'ATIVO'),
('Fornecedor G', 'fornecedorG@email.com', '78901234567890', '789-012-3456', 'Rua G, 444', 'Cidade G', 'Estado G', 'ATIVO'),
('Fornecedor H', 'fornecedorH@email.com', '89012345678901', '890-123-4567', 'Rua H, 555', 'Cidade H', 'Estado H', 'ATIVO'),
('Fornecedor I', 'fornecedorI@email.com', '90123456789012', '901-234-5678', 'Rua I, 666', 'Cidade I', 'Estado I', 'INATIVO'),
('Fornecedor J', 'fornecedorJ@email.com', '01234567890123', '012-345-6789', 'Rua J, 777', 'Cidade J', 'Estado J', 'INATIVO');

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

select * from tbFilmes