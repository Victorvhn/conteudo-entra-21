﻿DROP TABLE alunos;
CREATE TABLE alunos(
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	nome VARCHAR(150) NOT NULL,
	codigo_matricula VARCHAR(150),
	nota_1 REAL(4,2) NOT NULL,
	nota_2 REAL(4,2) NOT NULL,
	nota_3 REAL(4,2) NOT NULL,
	frequencia TINYINT
);