create table tb_cadastro 
(
    id_user int not null IDENTITY(1,1) primary key,
    cpf varchar (14),
    nome varchar (60)
)

select * from tb_cadastro