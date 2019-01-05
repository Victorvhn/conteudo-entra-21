-- SELECT * FROM pokemons;

-- SELECT COUNT(*) FROM pokemons; -- Quantidade de registros armazenados

--SELECT nome, categoria FROM pokemons; -- trazer somente as colunas que deseja

/*SELECT 
	nome 'NOME', 
	ataque 'ATAQUE', 
	especial_ataque 'ATAQUE ESPECIAL',
	defesa 'DEFESA',
	especial_defesa 'DEFESA ESPECIAL'
	FROM pokemons;	
*/ -- Pega as colunas selecionadas e nomeia elas para a apresentação

/*SELECT 
	nome
	FROM pokemons 
	ORDER BY nome ASC;
*/ -- TRAZ A COLUNA NOME EM ORDEM ALFABETICA

/*SELECT 
	categoria, nome
	FROM pokemons 
	ORDER BY categoria ASC, nome ASC;
*/ -- TRAZ A COLUNA CATEGORIA EM ORDEM ALFABETICA E O NOME EM ORDEM ALFABETICA DENTOR DE CADA CATEGORIA

/*SELECT 
	nome 
	FROM pokemons 
	ORDER BY nome DESC;
*/ -- TRAZ A COLUNA NOME EM ORDEM DECRESCNETE

/*SELECT 
	categoria, nome
	FROM pokemons
	ORDER BY categoria ASC, nome DESC;
*/ -- TRAZ A COLUNA CATEGORIA EM ORDEM CRESCENTE E A COLUNA NOME EM ORDEM DECRESCENTE

/*SELECT 
	ataque, nome
	FROM pokemons
	ORDER BY ataque DESC, nome ASC;
*/ -- TRAZ A COLUNA ATAQUE EM ORDEM DECRESCENTE E O NOME EM ORDEM ALFABETICA

/*SELECT 
	id, nome, codigo, ataque, especial_ataque,
	defesa, especial_defesa, descricao,
	altura, peso, velocidade
	FROM pokemons
	ORDER BY nome ASC;
*/ -- TRAZ TODAS AS COLUNAS SOLICITADAS COM OS NOMES EM ORDEM ALFABETICA

/*SELECT 
	nome, ataque
	FROM pokemons
	WHERE ataque = 4;
*/ -- TRAZ TODOS OS POKEMONS QUE TEM ATAQUE 4

/*SELECT COUNT(nome) 'QUANTIDADE POKEMONS ATAQUE 4'
	FROM pokemons
	WHERE ataque = 4;
*/ -- CONTA QUANTOS POKEMONS TEM ATAQUE 4

/*SELECT
	nome, categoria
	FROM pokemons
	WHERE categoria = 'dragon'
	ORDER BY nome ASC;
*/ -- TRAZ TODOS OS POKEMONS DA CATEGORIA DRAGON COM O NOME EM ORDEM ALFABETICA

/*SELECT 
	nome, ataque
	FROM pokemons
	WHERE ataque != 4
	ORDER BY ataque;
*/ -- TRAZ TODOS OS POKEMONS COM O ATAQUE DIFERENTE DE 4 E O ATAQUE VEM EM ORDEM CRESCENTE

/*SELECT
	nome, ataque
	FROM pokemons
	WHERE 
		ataque != 3 AND 
		ataque != 4 AND
		ataque != 5 AND
		ataque != 6 AND
		ataque != 7
	ORDER BY ataque;
*/ -- TRAZ TODOS OS POKEMONS COM O ATAQUE DIFERENTE DE 3, 4, 5, 6 E 7

/*SELECT
	nome, ataque
	FROM pokemons
	WHERE ataque < 3 OR ataque > 7
	ORDER BY ataque;
*/ -- TRAZ TODOS OS POKEMONS COM O ATAQUE DIFERENTE DE 3, 4, 5, 6 E 7

/*SELECT COUNT(ataque)
	FROM pokemons
	WHERE ataque < 3 OR ataque > 7;
*/ -- CONTA QUANTOS POKEMONS TEM ATAQUE MENOR QUE 3 E MAIOR QUE 7

/*SELECT nome, defesa
	FROM pokemons
	WHERE defesa >= 2
	ORDER BY defesa, nome;
*/ -- TRAZ TODOS OS POKEMONS QUE TEM DEFESA MAIOR OU IGUAL A 2

/*SELECT 
	hp, categoria, nome 
	FROM pokemons
	WHERE hp % 2 = 0
	ORDER BY hp, categoria, nome;
*/ -- TRAZ TODOS OS POKEMONS QUE TEM HP PAR