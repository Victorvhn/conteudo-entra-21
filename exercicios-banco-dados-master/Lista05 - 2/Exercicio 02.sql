DROP TABLE carros;
DROP TABLE pessoas;

CREATE TABLE pessoas(
	id INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(200),
	cpf VARCHAR(11)
);

CREATE TABLE carros(
	id INT IDENTITY(1,1) PRIMARY KEY,
	id_pessoa INT,
	marca VARCHAR(150) NOT NULL,
	modelo VARCHAR(150) NOT NULL,
	ano_lancamento SMALLINT NOT NULL,
	ano_fabricacao SMALLINT NOT NULL,
	motor VARCHAR(150),
	cor VARCHAR(100),
	preco DECIMAL(7,2)
	FOREIGN KEY(id_pessoa) REFERENCES pessoas(id)
);

INSERT INTO pessoas(nome, cpf) VALUES 
('Abraão Nobre', '95232829483'),
('Severino Braga', '87677033300'),
('Samuel Faria', '98927203429'),
('Florêncio Robalo', '36263517425');

INSERT INTO carros(id_pessoa, marca, modelo, ano_lancamento, ano_fabricacao, motor, cor, preco) VALUES
((SELECT pessoas.id FROM pessoas WHERE nome = 'Abraão Nobre'), 'Volkswagen', 'Gol', 2010, 2009, '8v Power Flex', 'Vermelho', 18000.00),
((SELECT pessoas.id FROM pessoas WHERE nome = 'Severino Braga'), 'Fiat', 'Brava', 2000, 1999, 'SX 1.6 16V', 'Cinza', 9000.00),
((SELECT pessoas.id FROM pessoas WHERE nome = 'Samuel Faria'), 'Renault', 'Clio', 1997, 1996, '1.0 8v', 'Verde', 5500.00),
((SELECT pessoas.id FROM pessoas WHERE nome = 'Florêncio Robalo'), 'Volkswagen', 'Golf', 1994, 1994, '2.0 120cv', 'Azul', 17000.00);

SELECT 
	carros.id 'Código', 
	pessoas.nome 'Pessoa', 
	carros.marca 'Marca', 
	carros.modelo 'Modelo', 
	carros.ano_lancamento 'Ano lançamento', 
	carros.ano_fabricacao 'Ano fabricação',  
	carros.motor 'Motor', 
	carros.cor 'Cor', 
	carros.preco 'Preço' 
FROM carros
JOIN pessoas ON(pessoas.id = carros.id_pessoa);

SELECT 
	carros.id 'Código', 
	pessoas.nome 'Pessoa', 
	carros.marca 'Marca', 
	carros.modelo 'Modelo', 
	carros.ano_lancamento 'Ano lançamento', 
	carros.ano_fabricacao 'Ano fabricação',  
	carros.motor 'Motor', 
	carros.cor 'Cor', 
	carros.preco 'Preço' 
FROM carros
JOIN pessoas ON(pessoas.id = carros.id_pessoa)
WHERE pessoas.nome LIKE 'Samuel%';