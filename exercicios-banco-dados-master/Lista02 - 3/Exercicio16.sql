-- 16. Selecione a quantidade de alunos em que a média foi maior que 7

SELECT COUNT(nome)'QUANTIDADE DE ALUNOS COM MÉDIA MAIOR QUE 7' 
	FROM alunos 
	WHERE ((nota_1 + nota_2 + nota_3 + nota_4)/4) > 7;