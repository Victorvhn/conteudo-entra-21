﻿DROP TABLE alunos;
CREATE TABLE alunos(
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	nome VARCHAR(150) NOT NULL,
	codigo_matricula VARCHAR(100),
	nota_1 FLOAT NOT NULL,
	nota_2 FLOAT NOT NULL,
	nota_3 FLOAT NOT NULL,
	faltas TINYINT NOT NULL,
);

INSERT INTO alunos(nome, codigo_matricula, nota_1, nota_2, nota_3, faltas) VALUES
('Lorem Ipsum', 200109111, 10, 10, 10, 5),
('Contrary', 200004281, 6, 6, 6, 0),
('There are', 200004281, 6, 6, 6, 0),
('Randomised', 200004281, 8, 7, 10, 0),
('Therefore', 200004101, 5, 5, 3, 150);