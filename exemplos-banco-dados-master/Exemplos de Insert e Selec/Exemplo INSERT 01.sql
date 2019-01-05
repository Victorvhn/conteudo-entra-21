/*
	Criar uma tabela chamada pessoas,
	com duas colunas nome e sobrenome
*/
CREATE TABLE pessoas(
	nome VARCHAR(100), -- Coluna que pode armazenar até 100 caracteres
	sobrenome VARCHAR(170) -- Coluna que pode armazenar até 170 caracteres
);
/*
	Inserir um registro na tabela pessoas
	nas colunas nome e sobrenome
*/
TRUNCATE TABLE pessoas; -- Apaga todos os registros da tabela

INSERT INTO pessoas VALUES ('João', 'da Silva');        -- Adiciona uma registro 
INSERT INTO pessoas VALUES ('Pedro', 'Machado');		-- Adiciona uma registro 
INSERT INTO pessoas VALUES ('Elriclédison', 'Pereira'); -- Adiciona uma registro 
INSERT INTO pessoas VALUES ('Jailson', 'da Silva');		-- Adiciona uma registro 
INSERT INTO pessoas VALUES ('Yudi', 'da Priscila');		-- Adiciona uma registro 

/*
	Apresenta registros da Table
*/
SELECT * FROM pessoas; -- Apresenta todos os registros da Table pessoas