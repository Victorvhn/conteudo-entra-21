DROP TABLE players;
CREATE TABLE players(
	estado CHAR(2),
	cidade VARCHAR(40),
	bairro VARCHAR(120),
	cep CHAR(10),
	lagradouro VARCHAR(250),
	numero SMALLINT,
	complemento TEXT
);

INSERT INTO players VALUES('AC', 'Rio Branco', 'Ayrton Senna', '69.911-866', 'Estrada Deputado José Rui da Silveira Lino', 282, 'Casa');
INSERT INTO players VALUES('AC', 'Rio Branco', 'Ayrton Senna', '69.911-866', 'Estrada Deputado José Rui da Silveira Lino', 282, 'Casa');
INSERT INTO players(estado, cidade, bairro, cep, numero) VALUES('SC', 'Biguaçu', 'Fundos', '88.161-400', 995);
INSERT INTO players VALUES('MG', 'Santa Luzia', 'Padre Miguel', '33.082-050', 'Rua Buenos Aires',  371, 'Apartamento');
INSERT INTO players(estado, bairro, cep, lagradouro, numero) VALUES('BA', 'São Tomé de
Paripe', '40.800-361', 'Travessa Luís Hage', 685);
INSERT INTO players(estado, cidade, bairro, lagradouro, numero) VALUES('MG', 'Ipatinga', 'Vila Celeste', 'Rua Antônio Boaventura Batista', 645);
INSERT INTO players(estado, cidade, bairro, cep, numero) VALUES('RS', 'Passo Fundo', 'Nenê Graeff', '99.030-250', 154);
INSERT INTO players VALUES('AM', 'Manaus', 'Petrópolis', '69.079-300', 'Rua Coronel Ferreira Sobrinho', 264, 'Fundos');
INSERT INTO players(estado, cidade, bairro, cep, lagradouro, numero) VALUES('TO', 'Gurupi', 'Muniz Santana', '77.402-130', 'Rua Adelmo Aires Negri', 794);
INSERT INTO players(estado, bairro, lagradouro, numero, complemento) VALUES('AC', 'Preventório', 'Beco da Ligação', 212, 'Bloco B');
INSERT INTO players(estado, cidade, bairro, cep, lagradouro, numero) VALUES('AP', 'Santana', 'Comercial', '68.925-073', 'Rua Calçoene', 648);
INSERT INTO players(estado, cidade, bairro, cep, lagradouro, numero) VALUES('PB', 'Cabedelo', 'Camalaú', '58.103-052', 'Rua Siqueira Campos', 249);

SELECT * FROM players;