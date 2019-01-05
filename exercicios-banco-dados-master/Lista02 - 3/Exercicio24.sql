-- 24. Apresentar a média da aluna Josefina.

SELECT 
	nome'NOME',
	(nota_1 + nota_2 + nota_3 + nota_4) / 4 'MÉDIA'
	FROM alunos
	WHERE nome LIKE 'Josefina%';