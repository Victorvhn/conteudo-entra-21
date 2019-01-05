CREATE TABLE vendas(
	nome		VARCHAR(100),
	quantidade	SMALLINT,
	preco		DECIMAL (6,2)
);

INSERT INTO vendas VALUES
('Café', 4, 27.13),
('Leite', 35, 4.15),
('Açucar', 52, 24.67),
('Biscoito', 3, 1.71),
('Miojo', 9, 45.23),
('Calabresa', 17, 1.72),
('Bacon', 18, 19.52),
('Feijão', 18, 7.87),
('Sazon', 47, 4.16),
('Qboa', 50, 22.39);

SELECT nome			'Nome',
quantidade			'Quantidade',
preco				'Preco',
quantidade * preco	'Total'
FROM vendas
ORDER BY 'Total'; --ORDER BY quantidade * preco

SELECT MIN(preco) FROM vendas; -- RETORNA O MENOR PRECO

SELECT MAX(preco) FROM vendas; -- RETORNA O MAIOR PRECO

SELECT -- CONTA A QUANTIDADE DE CARACTERES
nome, LEN(nome) 'Quantidade de caracteres' 
FROM vendas 
WHERE LEN(nome) > 5
ORDER BY LEN(nome);

SELECT nome -- PEGAR O NOME COM MAIOR QUANTIDADE DE CARACTERES
FROM vendas
WHERE LEN(nome) = (SELECT MAX(LEN(nome)) FROM vendas);

SELECT nome -- PEGAR O NOME COM A MENOR QUANTIDADE DE CARACTERES QUE COMECAM COM A LETRA C
FROM vendas
WHERE LEN(nome) = (SELECT MIN(LEN(nome)) FROM vendas)
AND nome LIKE 'c%';