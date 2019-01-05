-- 2. Selecione o ataque, ataque, defesa e defesa especial.

SELECT 
ataque 'ATAQUE', especial_ataque 'ATAQUE ESPECIAL', defesa 'DEFESA', especial_defesa 'DEFESA ESPECIAL' 
FROM pokemons 
ORDER BY ataque DESC, defesa DESC;