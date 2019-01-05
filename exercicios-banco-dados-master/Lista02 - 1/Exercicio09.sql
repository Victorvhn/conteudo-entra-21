-- 9. Selecione o ataque, ataque, nome, defesa e defesa especial ordenando pelo ataque.

SELECT 
ataque 'ATAQUE', especial_ataque 'ATAQUE ESPECIAL', defesa 'DEFESA', especial_defesa 'DEFESA ESPECIAL' 
FROM pokemons 
ORDER BY ataque;