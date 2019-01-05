-- 8. Selecione o nome, nota 1, nota 2, nota 3, nota 4 com o maior nome.

SELECT nome'NOME' , nota_1'NOTA 1', nota_2'NOTA 2', nota_3'NOTA 3', nota_4'NOTA 4' 
	FROM alunos 
	WHERE LEN(nome) = (SELECT MAX(LEN(nome)) FROM alunos);