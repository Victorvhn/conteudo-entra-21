UPDATE cidades SET cidade = REPLACE(cidade, 'Belo', 'Lindo') WHERE cidade LIKE '%belo%';

--SELECT * FROM cidades WHERE cidade LIKE '%BELO%'