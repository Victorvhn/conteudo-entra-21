DROP TABLE contas_receber;
DROP TABLE contas_pagar;
DROP TABLE emails;
DROP TABLE celulares;
DROP TABLE clientes;

CREATE TABLE clientes(
	id INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(200) NOT NULL,
	sexo CHAR(1) NOT NULL
);

CREATE TABLE celulares(
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	id_cliente INT NOT NULL,
	valor VARCHAR(100),
	ativo BIT DEFAULT 1,
	FOREIGN KEY(id_cliente) REFERENCES clientes(id)
);

CREATE TABLE emails(
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	id_cliente INT NOT NULL,
	valor VARCHAR(250) NOT NULL,
	ativo BIT DEFAULT 1,
	FOREIGN KEY(id_cliente) REFERENCES clientes(id)
);

CREATE TABLE contas_pagar(
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	id_cliente INT NOT NULL,
	valor DECIMAL(8,2),
	data_vencimento DATE,
	valor_pago REAL DEFAULT 0,
	status_pagar VARCHAR(100) DEFAULT 'pagar',
	ativo BIT DEFAULT 1, 
	FOREIGN KEY(id_cliente) REFERENCES clientes(id)
);

CREATE TABLE contas_receber(
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	id_cliente INT NOT NULL,
	valor_receber DECIMAL(8,2) NOT NULL,
	data_para_pagamentos DATE NOT NULL,
	valor_recebido REAL DEFAULT 0,
	data_recebimento DATE,
	status_receber VARCHAR(100) DEFAULT 'receber',
	FOREIGN KEY(id_cliente) REFERENCES clientes(id)
);

INSERT INTO clientes(nome, sexo) VALUES
('Germana', 'F'),
('Salvador', 'M'),
('Úrsula', 'F'),
('Aluísio', 'M');

INSERT INTO celulares(id_cliente, valor) VALUES
(1, '(79) 99973-5114'),
(2, '(27) 98390-6475'),
(1, '(55) 98587-4266'),
(4, '(14) 98387-5333'),
(3, '(92) 98983-2809'),
(4, '(55) 98616-2303');

INSERT INTO emails(id_cliente, valor) VALUES
(2, 'bernardodiegoalves-77@vianetfone.com.br'),
(1, 'a68341ef3b@emailna.life'),
(3, 'zpgkmkem@boximail.com'),
(1, 'ger@bol.com'),
(2, 'gabrieldiegofernandodarocha_@uoul.com'),
(3, 'iancauearaujo_@10clic.com.br'),
(1, 'germana@gmail.com'),
(2, 'salvador@hotmail.com');

INSERT INTO contas_pagar(id_cliente, data_vencimento, valor) VALUES
((SELECT id FROM clientes WHERE nome = 'Germana'), '2018-06-15', 500),
((SELECT id FROM clientes WHERE nome = 'Salvador'), '2018-06-29', 320.50),
((SELECT id FROM clientes WHERE nome = 'Úrsula'), '2018-06-07', 450),
((SELECT id FROM clientes WHERE nome = 'Aluísio'), '2018-08-27', 1300),
((SELECT id FROM clientes WHERE nome = 'Aluísio'), '2018-10-10', 777),
((SELECT id FROM clientes WHERE nome = 'Úrsula'), '2018-10-14', 8001),
((SELECT id FROM clientes WHERE nome = 'Salvador'), '2018-11-25', 232.12),
((SELECT id FROM clientes WHERE nome = 'Úrsula'), '2018-09-13', 104.23),
((SELECT id FROM clientes WHERE nome = 'Germana'), '2018-07-17', 65),
((SELECT id FROM clientes WHERE nome = 'Aluísio'), '2018-10-06', 98.33),
((SELECT id FROM clientes WHERE nome = 'Salvador'), '2018-12-12', 12.17),
((SELECT id FROM clientes WHERE nome = 'Salvador'), '2018-12-23', 6.25);

INSERT INTO contas_receber(id_cliente, data_para_pagamentos, valor_receber) VALUES
((SELECT id FROM clientes WHERE nome = 'Úrsula'), '2018-12-08', 78.97),
((SELECT id FROM clientes WHERE nome = 'Salvador'), '2018-11-24', 700),
((SELECT id FROM clientes WHERE nome = 'Germana'), '2018-10-09', 45.87),
((SELECT id FROM clientes WHERE nome = 'Germana'), '2019-01-04', 39.50),
((SELECT id FROM clientes WHERE nome = 'Aluísio'), '2018-11-30', 123.45),
((SELECT id FROM clientes WHERE nome = 'Úrsula'), '2018-09-07', 987.65),
((SELECT id FROM clientes WHERE nome = 'Salvador'), '2018-07-06', 456);

/*SELECT 
	clientes.nome 'Cliente', 
	emails.valor 'E-mail'
FROM emails
JOIN clientes ON(clientes.id = emails.id_cliente);*/

/*SELECT 
	clientes.nome 'Cliente', 
	emails.valor 'E-mail'
FROM emails
JOIN clientes ON(clientes.id = emails.id_cliente)
ORDER BY clientes.nome, emails.valor;*/

 /*length MAX E GROUP BY*/
SELECT 
	cli.nome 'Cliente',
 	MAX(ema.valor) 'E-mail'
FROM 
	emails ema
JOIN 
	clientes cli ON(cli.id = ema.id_cliente)
GROUP BY
	cli.nome;	   


/*SELECT 
	clientes.nome 'Cliente',
	celulares.valor 'Celular'
FROM celulares
JOIN clientes ON(clientes.id = celulares.id_cliente);*/

/*SELECT 
	clientes.nome 'Cliente',
	celulares.valor 'Celular'
FROM celulares
JOIN clientes ON(clientes.id = celulares.id_cliente)
WHERE ativo = 1;*/

/*UPDATE 
	contas_pagar
SET 
	valor_pago = 100, 
	status_pagar = 'pago'
WHERE 
	id_cliente = (SELECT id FROM clientes WHERE nome LIKE 'Salvador%');*/

/*UPDATE 
	contas_pagar 
SET 
	valor_pago = 700, 
	status_pagar = 'pago'
WHERE 
	id_cliente = (SELECT id FROM clientes WHERE nome LIKE 'Salvador%')
AND 
	valor = 700;*/

/*SELECT 
	clientes.nome 'Cliente',
	contas_pagar.valor 'Valor',
	contas_pagar.data_vencimento 'Data de Vencimento',
	contas_pagar.valor_pago 'Valor Pago'
FROM contas_pagar
JOIN clientes ON(clientes.id = contas_pagar.id_cliente);*/

/*SELECT 
	clientes.nome'Cliente',
	contas_pagar.valor 'Valor',
	MONTH(contas_pagar.data_vencimento) 'Data de Vencimento'
FROM contas_pagar
JOIN clientes ON(clientes.id = contas_pagar.id_cliente);*/

/*SELECT 
	clientes.nome 'Cliente',
	SUM(contas_pagar.valor) 'Valor'
FROM 
	contas_pagar
JOIN 
	clientes ON(clientes.id = contas_pagar.id_cliente)
GROUP BY 
	clientes.nome
ORDER BY 
	clientes.nome;*/

/*UPDATE 
	contas_receber
SET
	valor_recebido = 1000
FROM
	contas_receber
INNER JOIN clientes
	ON contas_receber.id_cliente = clientes.id
WHERE
	clientes.sexo = 'F';*/

/*UPDATE 
	contas_receber
SET
	data_recebimento = '2018-07-06'
FROM
	contas_receber
INNER JOIN clientes
	ON contas_receber.id_cliente = clientes.id
WHERE
	(clientes.nome LIKE 'A%') OR (clientes.nome LIKE 'S%');*/

/*SELECT 
	clientes.nome 'Cliente',
	SUM(contas_receber.valor_receber) 'Total Receber'
FROM
	contas_receber
JOIN 
	clientes ON(clientes.id = contas_receber.id_cliente)
GROUP BY 
	clientes.nome*/

/*SELECT 
	nome 'Cliente',
	COUNT(contas_receber.id) 'Quantidade de contas a receber'
FROM
	contas_receber
JOIN
	clientes ON(clientes.id = contas_receber.id_cliente)
GROUP BY 
	clientes.nome;*/