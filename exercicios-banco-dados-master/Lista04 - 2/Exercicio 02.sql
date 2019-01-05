-- 2. Apagar a(s) cidade(s) do estado do Acre que a cidade comece com a letra ‘R’.

DELETE FROM cidades WHERE estado = 'AC' AND cidade LIKE 'r%';