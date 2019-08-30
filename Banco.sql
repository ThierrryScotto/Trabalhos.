create database Biblioteca;

use Biblioteca;

create table Login
(
		Id int unsigned not null auto_increment unique,
        email varchar(30) not null unique,
        senha varchar(90) not null,
        primary Key(Id)
);

create table Livro
(
	Id_livro int unsigned unique not null auto_increment,
    autor varchar(30) not null,
    titulo varchar(30) not null,
    isbn bigint not null unique,
    Primary Key(Id_livro)
);


insert into Login(email, senha)
values
('admin', 'senha');

insert into Livro(titulo, isbn, autor, lancamento)
values
('PHP', 12345, 'Gamalieu', '2001-09-11');

select  email, senha from Login where email = 'admin' and senha = 'senha';
