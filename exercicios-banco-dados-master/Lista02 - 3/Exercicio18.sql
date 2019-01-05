-- 18. Selecione o nome do aluno quando a cor for ouro ou amarelo-torrado e a média for maior que seis e meio.

SELECT 
	nome 'NOME'
	FROM alunos 
	WHERE (cor_preferida = 'ouro' OR cor_preferida = 'amarelo-torrado') AND ((nota_1 + nota_2 + nota_3 + nota_4) / 4 > 6.5)
	ORDER BY nome;