-- 16. Apagar o(s) pokemon(s) que a descrição contenha ‘good’ em qualquer parte.

DELETE FROM pokemons WHERE descricao LIKE '%GOOD%';