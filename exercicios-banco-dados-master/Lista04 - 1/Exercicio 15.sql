-- 15. Apagar o(s) pokemon(s) que a descrição contenha mais que 150 caracteres

DELETE FROM pokemons WHERE DATALENGTH(descricao) > 150;