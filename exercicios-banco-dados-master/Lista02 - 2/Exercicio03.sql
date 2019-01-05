-- 3. Selecione as cidades que contenham no ‘apar’ em qualquer parte do nome

SELECT 
	cidade 
	FROM cidades 
	WHERE cidade LIKE '%APAR%' 
	ORDER BY cidade;