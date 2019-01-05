-- 6. Apagar o(s) pokemon(s) que o nome contenha dez caracteres.

DELETE FROM pokemons WHERE LEN(nome) = 10;