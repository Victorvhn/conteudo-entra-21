-- 7. Contabilize a quantidade de cidades do estado de SC.

SELECT 
	COUNT(cidade)'QUANTIDADE DE CIDADES DE SC' 
	FROM cidades 
	WHERE estado = 'SC';