-- 11. Selecione a quantidade de alunos que o nome contém Luc.

SELECT COUNT(nome)'QUANTIDADE DE ALUNOS QUE CONTEM "LUC" NO NOME' 
	FROM alunos 
	WHERE nome LIKE '%luc%';