-- 4. Apagar a(s) cidade(s) que o nome contenha irmãos em qualquer parte .

DELETE FROM cidades WHERE cidade LIKE '%irmãos%';