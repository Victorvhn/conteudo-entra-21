﻿/*	
	SELECT pokemons.name, categories.name FROM pokemons
	JOIN categories ON (categories.id = pokemons.id_categoryI)
	WHERE pokemons.name = 'Bulbasaur'
*/

/*
	SELECT categories.name'Categoria', pokemons.name'Pokemon' FROM categories
	JOIN pokemons ON (categories.id = pokemons.id_categoryI)
	ORDER BY categories.name, pokemons.name;
*/

/*
	SELECT COUNT(pokemons.id)'Quantidade de Pokemons Bug' FROM categories
	JOIN pokemons ON (pokemons.id_categoryI = categories.id),,
	WHERE categories.name = 'Bug';
*/

/*
	SELECT categories.name 'Categoria', COUNT(pokemons.id) 'Quantidade de Pokemons'
	FROM categories
	JOIN pokemons ON(pokemons.id_categoryI = categories.id)
	GROUP BY categories.name
	ORDER BY COUNT(pokemons.id) DESC;
*/