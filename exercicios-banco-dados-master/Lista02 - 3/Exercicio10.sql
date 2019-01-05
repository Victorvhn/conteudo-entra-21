-- 10. Selecione a quantidade de alunos que o nome contém Francisco no começo.

SELECT COUNT(nome)'QUANTIDADE DE NOMES QUE COMEÇAM COM FRANCISCO' 
	FROM alunos 
	WHERE nome LIKE 'FRANCISCO%';