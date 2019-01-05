-- 6. Selecione nome e o tamanho do nome em ordem decrescente pelo nome.

SELECT
 nome 'NOME', LEN (nome) 'QUANTIDADE DE CARACTERES' 
 FROM pokemons 
 ORDER BY 'QUANTIDADE DE CARACTERES' DESC;