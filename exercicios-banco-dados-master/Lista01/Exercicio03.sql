CREATE TABLE champions(
	nome VARCHAR(100),
	descricao VARCHAR(100),
	habilidade_1 VARCHAR(100),
	habilidade_2 VARCHAR(100),
	habilidade_3 VARCHAR(100),
	habilidade_4 VARCHAR(100),
	habilidade_5 VARCHAR(100)
);

INSERT INTO champions VALUES('Katarina', 'a Lâmina Sinistra', 'Voracidade', 'Lâmina Saltitante', 'Preparação', 'Shunpo', 'Lótus da Morte');
INSERT INTO champions(nome, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5) VALUES('Yasuo', 'Estilo do Errante', 'Estilo do Errante', 'Parede de Vento', 'Espada Ágil', 'Último Suspiro');
INSERT INTO champions(nome, descricao, habilidade_1) VALUES('Master Yi', 'o Espadachim Wuju', 'Ataque Duplo');
INSERT INTO champions VALUES('Vayne', 'a Caçadora Noturna', 'Caçadora Noturna', 'Rolamento', 'Dardos de Prata', 'Condenar', 'Hora Final');
INSERT INTO champions(nome, descricao, habilidade_1,habilidade_2,habilidade_3,habilidade_4) VALUES('Lee Sin', 'o Monge Cego', 'Agitação', 'Onda Sônica Ataque Ressonante', 'Proteger / Vontade de Ferro', 'Tempestade / Mutilar');
INSERT INTO champions(nome, descricao, habilidade_1, habilidade_3,habilidade_4,habilidade_5) VALUES('Vi', 'a Defensora de Piltover', 'Blindagem', 'Pancada Certeira', 'Força Excessiva', 'Saque e Enterrada');
INSERT INTO champions VALUES('Diana', 'o Escárnio da Lua', 'Espada de Prata Lunar', 'Golpe Crescente', 'Cascata Lívida', 'Colapso Minguante', 'Zênite Lunar');
INSERT INTO champions VALUES('Annie', 'a Criança Sombria', 'Piromania', 'Desintegrar', 'Incinerar', 'Escudo Fundido', 'Invocar: Tibbers');
INSERT INTO champions(nome, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5) VALUES('Aatrox', 'Poço de Sangue', 'Voo Sombrio','Sede de Sangue / Preço em Sangue', 'Lâminas da Aflição', 'Massacre');

SELECT * FROM champions;