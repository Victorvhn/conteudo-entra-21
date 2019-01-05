--SELECT nome 'NOME', LEN(nome),SUBSTRING (nome, 0, 11)'NOME 10', LEN(SUBSTRING (nome, 0, 11)) FROM pokemons ORDER BY LEN(nome) DESC;

UPDATE pokemons SET nome = SUBSTRING (nome, 0, 11) WHERE LEN(nome) > 10;