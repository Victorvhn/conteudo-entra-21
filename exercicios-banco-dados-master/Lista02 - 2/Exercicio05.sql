/*
	5. Selecione o estado e a cidade que a cidade termina com ‘tuba’ ordenando pelo estado em ordem
	decrescente.
*/

SELECT 
	estado, cidade 
	FROM cidades 
	WHERE cidade LIKE '%TUBA' 
	ORDER BY estado DESC;