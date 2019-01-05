--SELECT nome FROM pokemons WHERE nome LIKE 'R%'; 25
--SELECT nome FROM pokemons WHERE nome LIKE 'C%' ORDER BY nome;

UPDATE pokemons SET nome = REPLACE(nome,SUBSTRING(nome,0,2),'C') WHERE nome LIKE 'R%';