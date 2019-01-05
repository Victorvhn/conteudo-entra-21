--SELECT COUNT(nome) FROM pokemons WHERE codigo % 2 = 0;

UPDATE pokemons SET descricao = 'Lorem ipsum.', nome = 'Tyranitar', categoria = 'Wood Gecko' WHERE codigo % 2 = 0;