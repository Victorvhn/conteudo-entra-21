-- 7. Selecione o nome, menor nota 1.

SELECT 
	nome'NOME', nota_1'NOTA 1' 
	FROM alunos 
	WHERE nota_1 = (SELECT MIN(nota_1) FROM alunos)