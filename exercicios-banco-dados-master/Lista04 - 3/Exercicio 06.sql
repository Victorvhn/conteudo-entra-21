-- 6. Apagar o(s) aluno(s) que que nasceram no mês de julho.

DELETE FROM alunos WHERE MONTH(data_nascimento) = 07;