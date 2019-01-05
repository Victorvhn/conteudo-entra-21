--9. Apagar o(s) pokemon(s) que o nome comece com ‘Uno’ ou ‘Charm’.

DELETE FROM pokemons WHERE nome LIKE 'Uno%' OR nome LIKE 'Charm%';