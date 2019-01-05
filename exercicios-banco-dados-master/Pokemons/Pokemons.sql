DROP TABLE pokemons;
DROP TABLE categorias;
DROP TABLE fraquezas;

CREATE TABLE categorias(
	id INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(100) NOT NULL
);

CREATE TABLE fraquezas(
	id INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(100) NOT NULL
);

CREATE TABLE pokemons(
	id INT IDENTITY(1,1) PRIMARY KEY,
	id_categoria INT,
	id_fraqueza_1 INT,
	id_fraqueza_2 INT,
	nome VARCHAR(100) NOT NULL,
	FOREIGN KEY(id_categoria) REFERENCES categorias(id),
	FOREIGN KEY(id_fraqueza_1) REFERENCES fraquezas(id),
	FOREIGN KEY(id_fraqueza_2) REFERENCES fraquezas(id)
);

INSERT INTO fraquezas(nome) VALUES 
('Grass'),
('Electric'),
('Rock'),
('Fire'),
('Flying'),
('Water'),
('Ghost'),
('Ground'),
('Dark'),
('Ice'),
('Bug'),
('Fighting');

INSERT INTO categorias(nome) VALUES
('Tadpole'),
('Atrocious'),
('Stag Beetle'),
('Fireworks'),
('Sea Slug'),
('Bolt Strike'),
('Drowsing'),
('Big-Hearted'),
('Melody');

INSERT INTO pokemons(id_categoria, id_fraqueza_1, id_fraqueza_2, nome) VALUES
((SELECT id FROM categorias WHERE nome = 'Tadpole'), (SELECT id FROM fraquezas WHERE nome = 'Grass'), (SELECT id FROM fraquezas WHERE nome = 'Electric'),'Tympole'),
((SELECT id FROM categorias WHERE nome = 'Tadpole'), (SELECT id FROM fraquezas WHERE nome = 'Electric'), (SELECT id FROM fraquezas WHERE nome = 'Grass'), 'Poliwhirl'),
((SELECT id FROM categorias WHERE nome = 'Atrocious'), (SELECT id FROM fraquezas WHERE nome = 'Electric'), (SELECT id FROM fraquezas WHERE nome = 'Rock'), 'Gyarados'),
((SELECT id FROM categorias WHERE nome = 'Stag Beetle'), (SELECT id FROM fraquezas WHERE nome = 'Fire'), (SELECT id FROM fraquezas WHERE nome = 'Flying'), 'Pinsir'),
((SELECT id FROM categorias WHERE nome = 'Fireworks'), (SELECT id FROM fraquezas WHERE nome = 'Water'), (SELECT id FROM fraquezas WHERE nome = 'Ghost'), 'Blacephalon'),
((SELECT id FROM categorias WHERE nome = 'Sea Slug'), (SELECT id FROM fraquezas WHERE nome = 'Electric'), (SELECT id FROM fraquezas WHERE nome = 'Grass'), 'Shellos'),
((SELECT id FROM categorias WHERE nome = 'Bolt Strike'), (SELECT id FROM fraquezas WHERE nome = 'Ice'), (SELECT id FROM fraquezas WHERE nome = 'Rock'), 'Thundurus'),
((SELECT id FROM categorias WHERE nome = 'Drowsing'), (SELECT id FROM fraquezas WHERE nome = 'Bug'), (SELECT id FROM fraquezas WHERE nome = 'Ghost'), 'Musharna'),
((SELECT id FROM categorias WHERE nome = 'Big-Hearted'), (SELECT id FROM fraquezas WHERE nome = 'Fighting'), NULL, 'Stoutland'),
((SELECT id FROM categorias WHERE nome = 'Melody'), (SELECT id FROM fraquezas WHERE nome = 'Bug'), (SELECT id FROM fraquezas WHERE nome = 'Dark'), 'Meloetta');

SELECT id'CÓDIGO', nome'NOME', id_categoria'CATEGORIA', id_fraqueza_1'FRAQUEZA 1', id_fraqueza_2'FRAQUEZA 2' FROM pokemons;