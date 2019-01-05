-- 2. Apagar o(s) aluno(s) que nasceram no ano de 1994.

DELETE FROM alunos WHERE YEAR(data_nascimento) = 1994;