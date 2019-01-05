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

/*SELECT nome			'Nome',
quantidade			'Quantidade',
preco				'Preco',
quantidade * preco	'Total'
FROM vendas
ORDER BY 'Total'; --ORDER BY quantidade * preco
*/

/*SELECT SUM(preco) 'Soma dos preços' FROM vendas;*/ -- SOMA TODOS TA COLUNA PRECO

-- SELECT SUM(preco * quantidade) 'Valor total' FROM vendas;

SELECT preco FROM vendas;
SELECT AVG(preco) 'Média de preços' FROM vendas;