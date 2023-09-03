CREATE DATABASE filmeStar

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

INSERT INTO tbClientes (nome, sobrenome, email, cpf, rg, telefoneCel, telefoneFixo, endereco, cidade, estado, CEP)
VALUES ('Fernando', 'Oliveira', 'fernando.oliveira@email.com', '333.444.555-66', '3334445', '555-5555', '555-5555', 'Rua E', 'Salvador', 'BA', '33333-444');

INSERT INTO tbClientes (nome, sobrenome, email, cpf, rg, telefoneCel, telefoneFixo, endereco, cidade, estado, CEP)
VALUES ('Mariana', 'Gomes', 'mariana.gomes@email.com', '444.555.666-77', '4445556', '555-5555', '555-5555', 'Rua F', 'Fortaleza', 'CE', '44444-555');

INSERT INTO tbClientes (nome, sobrenome, email, cpf, rg, telefoneCel, telefoneFixo, endereco, cidade, estado, CEP)
VALUES ('Ricardo', 'Rodrigues', 'ricardo.rodrigues@email.com', '555.666.777-88', '5556667', '555-5555', '555-5555', 'Rua G', 'Porto Alegre', 'RS', '55555-666');

INSERT INTO tbClientes (nome, sobrenome, email, cpf, rg, telefoneCel, telefoneFixo, endereco, cidade, estado, CEP)
VALUES ('Lúcia', 'Ferreira', 'lucia.ferreira@email.com', '666.777.888-99', '6667778', '555-5555', '555-5555', 'Rua H', 'Recife', 'PE', '66666-777');

INSERT INTO tbClientes (nome, sobrenome, email, cpf, rg, telefoneCel, telefoneFixo, endereco, cidade, estado, CEP)
VALUES ('Pedro', 'Almeida', 'pedro.almeida@email.com', '777.888.999-00', '7778889', '555-5555', '555-5555', 'Rua I', 'Curitiba', 'PR', '77777-888');

INSERT INTO tbClientes (nome, sobrenome, email, cpf, rg, telefoneCel, telefoneFixo, endereco, cidade, estado, CEP)
VALUES ('Laura', 'Machado', 'laura.machado@email.com', '888.999.000-11', '8889990', '555-5555', '555-5555', 'Rua J', 'Manaus', 'AM', '88888-999');

INSERT INTO tbClientes (nome, sobrenome, email, cpf, rg, telefoneCel, telefoneFixo, endereco, cidade, estado, CEP)
VALUES ('Gustavo', 'Fernandez', 'gustavo.fernandez@email.com', '999.000.111-22', '9990001', '555-5555', '555-5555', 'Rua K', 'Natal', 'RN', '99999-000');

INSERT INTO tbClientes (nome, sobrenome, email, cpf, rg, telefoneCel, telefoneFixo, endereco, cidade, estado, CEP)
VALUES ('Sofia', 'Silveira', 'sofia.silveira@email.com', '000.111.222-33', '0001112', '555-5555', '555-5555', 'Rua L', 'Florianópolis', 'SC', '00000-111');

INSERT INTO tbClientes (nome, sobrenome, email, cpf, rg, telefoneCel, telefoneFixo, endereco, cidade, estado, CEP)
VALUES ('Diego', 'Carvalho', 'diego.carvalho@email.com', '111.222.333-44', '1112223', '555-5555', '555-5555', 'Rua M', 'Porto Velho', 'RO', '11111-222');

INSERT INTO tbClientes (nome, sobrenome, email, cpf, rg, telefoneCel, telefoneFixo, endereco, cidade, estado, CEP)
VALUES ('Isabella', 'Lima', 'isabella.lima@email.com', '222.333.444-55', '2223334', '555-5555', '555-5555', 'Rua N', 'Cuiabá', 'MT', '22222-333');

INSERT INTO tbClientes (nome, sobrenome, email, cpf, rg, telefoneCel, telefoneFixo, endereco, cidade, estado, CEP)
VALUES ('Felipe', 'Ramos', 'felipe.ramos@email.com', '333.444.555-66', '3334445', '555-5555', '555-5555', 'Rua O', 'Vitória', 'ES', '33333-444');

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

SELECT * FROM tbFornec

