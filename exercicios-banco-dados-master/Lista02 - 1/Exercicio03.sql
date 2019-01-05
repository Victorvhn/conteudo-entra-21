-- 3. Selecione nome, categoria e ataque ordenado pelo ataque em ordem crescente.

SELECT 
nome 'NOME', categoria'CATEGORIA', ataque'ATAQUE' 
FROM pokemons 
ORDER BY ataque;