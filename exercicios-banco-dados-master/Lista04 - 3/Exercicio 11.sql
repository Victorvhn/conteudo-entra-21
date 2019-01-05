-- 11. Apagar o(s) aluno(s) que o dia de nascimento seja 28.

DELETE FROM alunos WHERE DAY(data_nascimento) = 28;