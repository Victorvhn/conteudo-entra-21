--7. Apagar o(s) pokemon(s) que a categoria contenha menos que 4 caracteres.

DELETE FROM pokemons WHERE LEN(categoria) < 4;