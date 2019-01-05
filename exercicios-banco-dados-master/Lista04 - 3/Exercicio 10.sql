-- 10. Apagar o(s) aluno(s) que a média seja menor que 4.

DELETE FROM alunos WHERE ((nota_1 + nota_2 + nota_3 + nota_4) / 4) < 4;