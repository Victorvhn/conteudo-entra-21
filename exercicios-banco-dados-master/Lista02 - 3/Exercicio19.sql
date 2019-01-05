-- 19. Selecione o nome e o ano da data de nascimento.

SELECT 
	nome'NOME', 
	YEAR(data_nascimento)'ANO DE NASCIMENTO' 
	FROM alunos 
	ORDER BY nome;