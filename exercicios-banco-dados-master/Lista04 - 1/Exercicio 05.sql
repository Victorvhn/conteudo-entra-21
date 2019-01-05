--5. Apagar o(s) pokemon(s) que o ataque especial seja um número par.

DELETE FROM pokemons WHERE especial_ataque % 2 = 0;