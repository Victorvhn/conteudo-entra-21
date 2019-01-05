/*
	22. Selecione a quantidade de pessoas de pessoas que nasceram no dia dois do mês de fevereiro do ano 1964
	ou 1994.
*/

SELECT 
	COUNT(nome) 'QUANTIDADE DE PESSOAS QUE NASCERAM 02/02/1964 e 02/02/1994'
	FROM alunos 
	WHERE DAY(data_nascimento) = 2 AND MONTH(data_nascimento) = 02 AND (YEAR(data_nascimento) = 1964 OR YEAR(data_nascimento) = 1994);