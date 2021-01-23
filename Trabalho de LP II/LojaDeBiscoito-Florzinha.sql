create database Loja_Florzinha;
use Loja_Florzinha;
create table if not exists Produto (
	cod_produto int auto_increment,
	nome varchar(40) not null,
    marca varchar(35) not null,
    custo double not null,
    qntd int not null,
	primary key(cod_produto)
)default charset = utf8;
drop table Funcionario;
create  table Funcionario (
	cpf  bigint not null ,
	nome varchar(50) not null,
    genero char not null,
    funcao varchar(30) not null,
    salario double not null, 
    nascimento date not null,
	primary key(cpf)
)default charset = utf8;

-- Inserir Valores
INSERT INTO `funcionario` (cpf, nome, genero, funcao, salario, nascimento) VALUES (12312312334,'carlinhos','M','Atendente',1300,'1971-03-01'),(12312312336,'carlinhos','M','Limpador',3200,'1971-03-01'),(31212312111,'312312312','F','atendente',3223,'1970-02-02'),(32132132132,'marcelo santos','M','atendente',1031,'1973-02-07'),(50050050045,'marcelo santos','F','limpador',1200,'1973-02-07'),(50050050046,'marcelo santos camara','F','limpador',1200,'1973-02-07'),(12332112332,'dsadsadsa','M','atendente',1031,'1971-02-02'),(45546647732,'nsdausdasda','M','atendente',1222,'1970-01-01');
INSERT INTO `produto` (cod_produto, nome, marca, custo, qntd) VALUES (12,'wafer ','bauduco','3,50',100),(13,'fandangos','elma chips','2,50',500),(14,'goiabinha','piraque','4,50',1000),(15,'trakinas','mondeles','1,70',100), (default,'cookies', 'bauduco', '1,30', 100);

-- Consultando
select * from produto;
select * from funcionario;
