/*
	14. Selecione o nome, média e caso a média for menor que 5 apresentar reprovado, caso for menor que 7
	apresentar em exame senão apresentar aprovado.
	Dica: buscar como fazer IF em sql.
*/

SELECT 
	nome'NOME', 
	(nota_1 + nota_2 + nota_3 + nota_4)/4 'MÉDIA', 
	IIF((nota_1 + nota_2 + nota_3 + nota_4)/4 < 5, 'REPROVADO', 
	IIF((nota_1 + nota_2 + nota_3 + nota_4)/4 > 5 AND (nota_1 + nota_2 + nota_3 + nota_4)/4 < 7, 'RECUPERAÇÃO',
	IIF((nota_1 + nota_2 + nota_3 + nota_4)/4 > 7, 'APROVADO','')))'SITUAÇÃO' 
	FROM alunos 
	ORDER BY nome;