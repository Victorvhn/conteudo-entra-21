-- 12. Selecione a média dos ataques especiais quando o nome do pokemon começar com ‘P’.

SELECT AVG(especial_ataque) 'MÉDIA DO ATAQUE ESPECIAL' FROM pokemons WHERE nome LIKE 'P%';