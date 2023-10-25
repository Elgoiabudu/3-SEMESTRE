CREATE DATABASE P2_TP2

CREATE TABLE Clientes (
    ID INT PRIMARY KEY identity(1,1),
    dataCadastro datetime default CURRENT_TIMESTAMP,
    cpf VARCHAR(14) not null,
    nome VARCHAR(100) not null,
    telefone varchar(20) not null,
    celular varchar(20) not null,
    email VARCHAR(150) not null,
    CEP VARCHAR(8) not null,
    logradouro VARCHAR(100) not null,
    bairro VARCHAR(20) not null,
    numero VARCHAR(100) not null,
    cidade VARCHAR(100) not null,
    estado VARCHAR(50) not null
);

select * from Clientes

delete from Clientes