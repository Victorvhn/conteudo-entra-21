

SELECT COUNT(sexo) FROM herois WHERE sexo = 'm';

SELECT raca, COUNT(id)
FROM herois
GROUP BY raca;

SELECT nome, YEAR(GETDATE()) - YEAR(data_nascimento) FROM herois WHERE data_nascimento = (SELECT MAX(data_nascimento) FROM herois);