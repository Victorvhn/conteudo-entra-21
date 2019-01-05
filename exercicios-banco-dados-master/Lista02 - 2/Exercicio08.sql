-- 8. Contabilize a quantidade de cidades do estado de SP.

SELECT 
	COUNT(cidade)'QUANTIDADE DE CIDADES DE SP' 
	FROM cidades 
	WHERE estado = 'SP';