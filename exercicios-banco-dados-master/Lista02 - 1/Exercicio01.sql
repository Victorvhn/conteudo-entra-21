-- 1. Selecione todos as colunas.

SELECT 
id 'ID', nome 'NOME', codigo 'CÓDIGO', categoria 'CATEGORIA', altura 'ALTURA', peso 'PESO', hp 'HP', ataque 'ATAQUE', defesa 'DEFESA', especial_ataque 'ATAQUE ESPECIAL', especial_defesa 'DEFESA ESPECIAL', velocidade 'VELOCIDADE', descricao 'DESCRIÇÃO' 
FROM pokemons 
ORDER BY id;