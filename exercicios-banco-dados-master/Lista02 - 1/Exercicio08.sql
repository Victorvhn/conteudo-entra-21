-- 8. Selecione nome, categoria, e ataque do pokemon que contém o menor valor de ataque.

SELECT 
nome 'NOME', categoria 'CATEGORIA', ataque 'ATAQUE' 
FROM pokemons 
WHERE ataque = (SELECT MIN(ataque) FROM pokemons)
ORDER BY nome;