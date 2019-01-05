-- 21. Selecione a quantidade de pessoas que nasceram no ano de 1996

SELECT 
	COUNT(nome) 'QUANTIDADE DE PESSOAS QUE NASCERAM EM 1996'
	FROM alunos
	WHERE YEAR(data_nascimento) = 1996;