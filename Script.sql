/*Criando Banco de Dados*/
create database dbProjeto;

/*Usando banco de dados*/
use dbProjeto; 

/*Criando as tabelas do banco*/
create table tbCliente(
CodCli int primary key auto_increment,
Nome varchar(50),
Telefone varchar(20),
Email varchar(50) 
);

