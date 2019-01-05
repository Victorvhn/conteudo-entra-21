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
('Alice', 18),
('Sophia', 4),
('Miguel', 9),
('Heitor', 23),
('Valentina', 15),
('Joaquim', 49);

INSERT INTO caracteristicas(id_aluno, nome) VALUES 
((SELECT id FROM alunos WHERE nome = 'Heitor'),'Egoísta'),
((SELECT id FROM alunos WHERE nome = 'Alice'), 'Organizado(a)'),
((SELECT id FROM alunos WHERE nome = 'Sophia'), 'Pontual'),
((SELECT id FROM alunos WHERE nome = 'Miguel'), 'Criativo(a)'),
((SELECT id FROM alunos WHERE nome = 'Heitor'), 'Proativo(a)'),
((SELECT id FROM alunos WHERE nome = 'Alice'), 'Altruísta'),
((SELECT id FROM alunos WHERE nome = 'Valentina'), 'Pessimista'),
((SELECT id FROM alunos WHERE nome = 'Joaquim'), 'Flexível'),
((SELECT id FROM alunos WHERE nome = 'Sophia'), 'Observadora'),
((SELECT id FROM alunos WHERE nome = 'Joaquim'), 'Paciente'),
((SELECT id FROM alunos WHERE nome = 'Heitor'), 'Indelicado(a)'),
((SELECT id FROM alunos WHERE nome = 'Sophia'), 'Desobediente'),
((SELECT id FROM alunos WHERE nome = 'Miguel'), 'Intolerante'),
((SELECT id FROM alunos WHERE nome = 'Joaquim'), 'Empático(a)'),
((SELECT id FROM alunos WHERE nome = 'Sophia'), 'Egoísta'),
((SELECT id FROM alunos WHERE nome = 'Heitor'), 'Egoísta'),
((SELECT id FROM alunos WHERE nome = 'Joaquim'),'Altruísta'),
((SELECT id FROM alunos WHERE nome = 'Sophia'), 'Sensível');

--SELECT id'CÓDIGO DO ALUNO', nome'NOME DO ALUNO', idade'IDADE DO ALUNO' FROM alunos;
--SELECT id'CÓDIGO DA CARACTERÍSTICA', id_aluno'CÓDIGO DO ALUNO', nome'NOME DA CARACTERÍSTICA' FROM caracteristicas;

SELECT	
	alunos.nome 'Aluno', 
	caracteristicas.nome 'Característica'
FROM caracteristicas
JOIN alunos ON(alunos.id = caracteristicas.id_aluno)
ORDER BY alunos.nome;

SELECT 
	COUNT(caracteristicas.id)'Quantidade de alunos altruístas'
FROM caracteristicas
JOIN alunos ON(caracteristicas.id_aluno = alunos.id)
WHERE caracteristicas.nome = 'Altruísta';

SELECT
	caracteristicas.nome 'Característica',
	COUNT(caracteristicas.id) 'Quantidade de alunos'
FROM caracteristicas
GROUP BY caracteristicas.nome
ORDER BY caracteristicas.nome;

SELECT
	caracteristicas.nome 'Características de Sophia'
FROM caracteristicas
JOIN alunos ON(alunos.id = caracteristicas.id_aluno)
WHERE alunos.nome = 'Sophia'
ORDER BY caracteristicas.nome;