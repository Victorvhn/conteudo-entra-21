/*
	Criar uma tabela chamada pessoas,
	com duas colunas nome e sobrenome
*/
CREATE TABLE mangas(
	nome VARCHAR(120),
	volume INT,
	ano INT
);

/*
	Inserir um registro na tabela pessoas
	nas colunas nome e sobrenome
*/

TRUNCATE TABLE pessoas; -- Apaga todos os registros da tabela

INSERT INTO mangas VALUES('Naruto',67 , 2015);
INSERT INTO mangas VALUES('Bleach', 70, 2015);
INSERT INTO mangas VALUES('Nanatsu', 20, 2015);
INSERT INTO mangas VALUES('Dragon Ball', 8001, 2004);

/*
	Apresenta registros da Table
*/
SELECT * FROM mangas; -- Apresenta todos os registros da Table pessoas