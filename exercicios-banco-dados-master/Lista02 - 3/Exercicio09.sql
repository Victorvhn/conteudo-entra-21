-- 9. Selecione a cor e quantidade com a cor Gelo.

SELECT COUNT(cor_preferida) 'QUANTIDADE DE COR GELO' 
	FROM alunos 
	WHERE cor_preferida = 'Gelo';