-- 10. Apagar o(s) pokemon(s) que contenham a categoria ‘Flower’ e o código esteja entre 45 e 200.

DELETE FROM pokemons WHERE categoria LIKE '%Flower%' AND (codigo >= 45 AND codigo <=200)