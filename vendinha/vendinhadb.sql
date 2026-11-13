create table cliente (
id int generated always as identity primary key,
nome varchar(100) not null,
cpf char(11) not null unique,
data_nascimento date not null,
email varchar(150)
);

create table divida (
id int generated always as identity primary key,
cliente_id int not null,
valor decimal(6, 2) not null,
pago boolean not null,
data_criacao timestamp not null,
data_pagamento timestamp,
constraint fk_cliente foreign key (cliente_id) references cliente(id)
);
