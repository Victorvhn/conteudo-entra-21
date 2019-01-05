/*
	25. Apresentar nome, nick, nota 1, nota 2, nota 3, nota 4, quando o nome conter Justino e o signo começar com
	‘A’.
*/

SELECT 
	nome'NOME',
	nick 'NICK',
	nota_1 'NOTA 1',
	nota_2 'NOTA 2',
	nota_3 'NOTA 3',
	nota_4 'NOTA 4'
	FROM alunos
	WHERE nome LIKE '%Justino%' 
	AND 
	signo LIKE 'A%'
	ORDER BY nome;