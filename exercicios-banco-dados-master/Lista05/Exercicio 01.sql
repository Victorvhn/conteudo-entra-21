DROP TABLE caracteristicas;
DROP TABLE alunos;

CREATE TABLE alunos(
	id INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(200),
	idade TINYINT
);

CREATE TABLE caracteristicas(
	id INT IDENTITY(1,1) PRIMARY KEY,
	id_aluno INT,
	nome VARCHAR(150) NOT NULL,
	FOREIGN KEY(id_aluno) REFERENCES alunos(id)
);

INSERT INTO alunos(nome, idade) VALUES
('Alice', 18);

INSERT INTO alunos(nome, idade) VALUES
('Sophia', 4);

INSERT INTO alunos(nome, idade) VALUES
('Miguel', 9);

INSERT INTO alunos(nome, idade) VALUES
('Heitor', 23);

INSERT INTO alunos(nome, idade) VALUES
('Valentina', 15);

INSERT INTO alunos(nome, idade) VALUES
('Joaquim', 49);

INSERT INTO caracteristicas(id_aluno, nome) VALUES 
((SELECT id FROM alunos WHERE nome = 'Heitor'),'Egoísta');

INSERT INTO caracteristicas(id_aluno, nome) VALUES
((SELECT id FROM alunos WHERE nome = 'Alice'), 'Organizado(a)');

INSERT INTO caracteristicas(id_aluno, nome) VALUES
((SELECT id FROM alunos WHERE nome = 'Sophia'), 'Pontual');

INSERT INTO caracteristicas(id_aluno, nome) VALUES
((SELECT id FROM alunos WHERE nome = 'Miguel'), 'Criativo(a)');

INSERT INTO caracteristicas(id_aluno, nome) VALUES
((SELECT id FROM alunos WHERE nome = 'Heitor'), 'Proativo(a)');

INSERT INTO caracteristicas(id_aluno, nome) VALUES
((SELECT id FROM alunos WHERE nome = 'Alice'), 'Altruísta');

INSERT INTO caracteristicas(id_aluno, nome) VALUES
((SELECT id FROM alunos WHERE nome = 'Valentina'), 'Pessimista');

INSERT INTO caracteristicas(id_aluno, nome) VALUES
((SELECT id FROM alunos WHERE nome = 'Joaquim'), 'Flexível');

INSERT INTO caracteristicas(id_aluno, nome) VALUES
((SELECT id FROM alunos WHERE nome = 'Sophia'), 'Observadora');

INSERT INTO caracteristicas(id_aluno, nome) VALUES
((SELECT id FROM alunos WHERE nome = 'Joaquim'), 'Paciente');

INSERT INTO caracteristicas(id_aluno, nome) VALUES
((SELECT id FROM alunos WHERE nome = 'Heitor'), 'Indelicado(a)');

INSERT INTO caracteristicas(id_aluno, nome) VALUES
((SELECT id FROM alunos WHERE nome = 'Sophia'), 'Desobediente');

INSERT INTO caracteristicas(id_aluno, nome) VALUES
((SELECT id FROM alunos WHERE nome = 'Miguel'), 'Intolerante')

INSERT INTO caracteristicas(id_aluno, nome) VALUES
((SELECT id FROM alunos WHERE nome = 'Joaquim'), 'Empático(a)');

INSERT INTO caracteristicas(id_aluno, nome) VALUES
((SELECT id FROM alunos WHERE nome = 'Sophia'), 'Egoísta');

INSERT INTO caracteristicas(id_aluno, nome) VALUES
((SELECT id FROM alunos WHERE nome = 'Heitor'), 'Egoísta');

INSERT INTO caracteristicas(id_aluno, nome) VALUES
((SELECT id FROM alunos WHERE nome = 'Joaquim'),'Altruísta');

INSERT INTO caracteristicas(id_aluno, nome) VALUES
((SELECT id FROM alunos WHERE nome = 'Sophia'), 'Sensível');

SELECT id'CÓDIGO DO ALUNO', nome'NOME DO ALUNO', idade'IDADE DO ALUNO' FROM alunos;
SELECT id'CÓDIGO DA CARACTERÍSTICA', id_aluno'CÓDIGO DO ALUNO', nome'NOME DA CARACTERÍSTICA' FROM caracteristicas;