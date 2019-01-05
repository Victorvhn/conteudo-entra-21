--SELECT * from alunos WHERE DAY(data_nascimento) = 30; 51
--SELECT * FROM alunos WHERE DAY(data_nascimento) = 31; 56

UPDATE alunos SET data_nascimento = DATEFROMPARTS(YEAR(data_nascimento),MONTH(data_nascimento),30) WHERE DAY(data_nascimento) = 31;