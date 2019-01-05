SELECT 
	herois.nome 'PERSONAGEM', 
	habilidades.nome 'HABILIDADE'
FROM habilidades
JOIN herois ON (habilidades.id_hero = herois.id);