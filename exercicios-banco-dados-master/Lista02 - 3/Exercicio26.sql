-- 26. Apresentar a média das médias.

SELECT 
	((SUM(nota_1 + nota_2 + nota_3 + nota_4) / 4) / COUNT(nome)) 'MÉDIA DAS MÉDIAS' 
	FROM alunos;