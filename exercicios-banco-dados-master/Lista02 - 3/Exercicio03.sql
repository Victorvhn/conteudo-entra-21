-- 3. Selecione o nome do aluno, nota 1, nota 2, nota 3, nota 4, e a média.

SELECT 
nome 'NOME', 
nota_1 'NOTA 1', 
nota_2 'NOTA 2', 
nota_3 'NOTA 3',
nota_4 'NOTA 4', 
(nota_1 + nota_2 + nota_3 + nota_4)/4 'MÉDIA' 
FROM alunos 
ORDER BY nome;