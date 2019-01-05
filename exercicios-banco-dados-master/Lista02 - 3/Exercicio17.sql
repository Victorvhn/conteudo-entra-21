-- 17. Selecione o nome, nick do aluno que o nick contém 5 caracteres.

SELECT nome'NOME', nick 'NICK'
	FROM alunos 
	WHERE LEN(nick) = 5
	ORDER BY nome;