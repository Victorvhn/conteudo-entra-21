/*
	6. Selecione a cidade que o nome da cidade contenha mais que 15 caracteres, ordenando pelo quantidade de
	caracteres.
*/

SELECT 
	cidade 'CIDADE' 
	FROM cidades 
	WHERE LEN (cidade) > 15 
	ORDER BY LEN (cidade);