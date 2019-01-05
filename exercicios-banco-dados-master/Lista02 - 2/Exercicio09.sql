/*
	9. Selecione o nome da cidade com a quantidade de caracteres, quando o nome da cidade conter 10
	caracteres.
*/

SELECT cidade 'CIDADE', LEN (cidade) 'QUANTIDADE DE CARACTERES' FROM cidades WHERE LEN (cidade) > 10 ORDER BY 'QUANTIDADE DE CARACTERES';