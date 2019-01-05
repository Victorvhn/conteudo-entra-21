CREATE TABLE produtos(
	nome VARCHAR(100)
);

INSERT INTO produtos VALUES
('Calabresa'),
('X-Calabresa'),
('Pizza de Calabresa'),
('Calabresa com miojo'),
('Milk shake de calabresa'),
('Paçoca de calabresa com açai'),
('Polenta com paçoca');

SELECT * FROM produtos WHERE nome LIKE 'Calabresa%'; -- BUSCA OS PRODUTOS QUE CONTÉM O NOME INICIANDO COM CALABRESA

SELECT * FROM produtos WHERE nome LIKE '%calabresa'; -- BUSCA OS PRODUTOS QUE CONTÉM O ULTIMO NOME CALABRESA

SELECT * FROM produtos WHERE nome LIKE '%Calabresa%'; -- BUCA TODOS OS PRODUTOS QUE CONTÉM A PALAVRA CALABRESA EM QUALQUER PARTE