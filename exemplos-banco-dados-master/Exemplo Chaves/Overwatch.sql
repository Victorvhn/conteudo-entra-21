DROP TABLE habilidades;
DROP TABLE herois;

CREATE TABLE herois(
	id INT IDENTITY(1,1),
	nome VARCHAR(100) NOT NULL,
	dificuldade TINYINT NOT NULL,
	funcao VARCHAR(10) NOT NULL
	PRIMARY KEY (id)
);

CREATE TABLE habilidades(
	id INT IDENTITY(1,1) PRIMARY KEY,
	id_hero INT ,
	nome VARCHAR(200) NOT NULL,
	descricao TEXT DEFAULT 'N/A'
	FOREIGN KEY (id_hero) REFERENCES herois(id)
);

INSERT INTO herois (nome, dificuldade, funcao) VALUES
('D.VA', 2, 'TANQUE'),
('ORISA', 2, 'TANQUE'),
('REINHARDT', 1, 'TANQUE'),
('ROADHOG', 1, 'TANQUE'),
('WINSTON', 2, 'TANQUE'),
('ZARYA', 3, 'TANQUE'),
('BASTION', 1, 'DANO'),
('DOOMFIST', 3, 'DANO'),
('GENJI', 3, 'DANO'),
('HANZO', 3, 'DANO'),
('JUNKRAT', 2, 'DANO'),
('MCCREE', 2, 'DANO'),
('MEI', 3, 'DANO'),
('PHARAH', 1, 'DANO'),
('REAPER', 1, 'DANO'),
('SOLDADO: 76', 1, 'DANO'),
('SOMBRA', 3, 'DANO'),
('SYMMETRA', 2, 'DANO'),
('TORBJÖRN', 2, 'DANO'),
('TRACER', 2, 'DANO'),
('WIDOWMAKER', 2, 'DANO'),
('ANA', 3, 'SUPORTE'),
('BRIGITTE', 1, 'SUPORTE'),
('LÚCIO', 2, 'SUPORTE'),
('MERCY', 1, 'SUPORTE'),
('MOIRA', 2, 'SUPORTE'),
('ZENYATTA', 3, 'SUPORTE');

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'D.VA'), 'CANHÕES DE FUSÃO', NULL),
((SELECT id FROM herois WHERE nome = 'D.VA'), 'PISTOLA DE LUZ', NULL),
((SELECT id FROM herois WHERE nome = 'D.VA'), 'PROPULSORES', NULL),
((SELECT id FROM herois WHERE nome = 'D.VA'), 'MATRIZ DE DEFESA', NULL),
((SELECT id FROM herois WHERE nome = 'D.VA'), 'MICRO MÍSSEIS', NULL),
((SELECT id FROM herois WHERE nome = 'D.VA'), 'AUTODESTRUIR', NULL),
((SELECT id FROM herois WHERE nome = 'D.VA'), 'CHAMAR MECHA', NULL);  -- D.VA

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'ORISA'), 'METRALHADORA DE FUSÃO', NULL),
((SELECT id FROM herois WHERE nome = 'ORISA'), 'FORTIFICAR', NULL),
((SELECT id FROM herois WHERE nome = 'ORISA'), 'PARADOS!', NULL),
((SELECT id FROM herois WHERE nome = 'ORISA'), 'BARREIRA PROTETORA', NULL),
((SELECT id FROM herois WHERE nome = 'ORISA'), 'AMPLIFICADOR', NULL);  -- ORISA

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'REINHARDT'), 'MARTELO PROPULSOR', NULL),
((SELECT id FROM herois WHERE nome = 'REINHARDT'), 'CAMPO DE BARREIRA', NULL),
((SELECT id FROM herois WHERE nome = 'REINHARDT'), 'INVESTIDA', NULL),
((SELECT id FROM herois WHERE nome = 'REINHARDT'), 'TIRO FLAMEJANTE', NULL),
((SELECT id FROM herois WHERE nome = 'REINHARDT'), 'ABALO TERRESTRE', NULL);  -- REINHARDT

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'ROADHOG'), 'ARMA DE SUCATA', NULL),
((SELECT id FROM herois WHERE nome = 'ROADHOG'), 'PEGANDO FÔLEGO', NULL),
((SELECT id FROM herois WHERE nome = 'ROADHOG'), 'CORRENTE DE GANCHO', NULL),
((SELECT id FROM herois WHERE nome = 'ROADHOG'), 'CAIR MATANDO', NULL);  -- ROADHOG

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'WINSTON'), 'CANHÃO DE TESLA', NULL),
((SELECT id FROM herois WHERE nome = 'WINSTON'), 'SALTO A JATO', NULL),
((SELECT id FROM herois WHERE nome = 'WINSTON'), 'PROJETOR DE BARREIRA', NULL),
((SELECT id FROM herois WHERE nome = 'WINSTON'), 'FÚRIA PRIMATA', NULL);  -- WINSTON

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'ZARYA'), 'CANHÃO DE PARTÍCULAS', NULL),
((SELECT id FROM herois WHERE nome = 'ZARYA'), 'BARREIRA DE PARTÍCULAS', NULL),
((SELECT id FROM herois WHERE nome = 'ZARYA'), 'BARREIRA PROJETADA', NULL),
((SELECT id FROM herois WHERE nome = 'ZARYA'), 'SURTO DE GRÁVITONS', NULL);  -- ZARYA

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'BASTION'), 'CONFIGURAÇÃO: RECONHECIMENTO', NULL),
((SELECT id FROM herois WHERE nome = 'BASTION'), 'CONFIGURAÇÃO: SENTINELA', NULL),
((SELECT id FROM herois WHERE nome = 'BASTION'), 'RECONFIGURAR', NULL),
((SELECT id FROM herois WHERE nome = 'BASTION'), 'AUTO REPARO', NULL),
((SELECT id FROM herois WHERE nome = 'BASTION'), 'CONFIGURAÇÃO: TANQUE', NULL);  -- BASTION

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'DOOMFIST'), 'CANHÃO DE MÃO', NULL),
((SELECT id FROM herois WHERE nome = 'DOOMFIST'), 'ABALO SÍSMICO', NULL),
((SELECT id FROM herois WHERE nome = 'DOOMFIST'), 'GANCHO ASCENDENTE', NULL),
((SELECT id FROM herois WHERE nome = 'DOOMFIST'), 'SOCO FOGUETE', NULL),
((SELECT id FROM herois WHERE nome = 'DOOMFIST'), 'A MELHOR DEFESA...', NULL),
((SELECT id FROM herois WHERE nome = 'DOOMFIST'), 'IMPACTO METEORO', NULL);  -- DOOMFIST

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'GENJI'), 'SHURIKEN', NULL),
((SELECT id FROM herois WHERE nome = 'GENJI'), 'DESVIAR', NULL),
((SELECT id FROM herois WHERE nome = 'GENJI'), 'GOLPE VELOZ', NULL),
((SELECT id FROM herois WHERE nome = 'GENJI'), 'LÂMINA DO DRAGÃO', NULL);  -- GENJI

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'HANZO'), 'ARCO DA TEMPESTADE', NULL),
((SELECT id FROM herois WHERE nome = 'HANZO'), 'FLECHA SÔNICA', NULL),
((SELECT id FROM herois WHERE nome = 'HANZO'), 'FLECHAS DA TEMPESTAD', NULL),
((SELECT id FROM herois WHERE nome = 'HANZO'), 'SALTO', NULL),
((SELECT id FROM herois WHERE nome = 'HANZO'), 'GOLPE DO DRAGÃO', NULL);  -- HANZO

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'JUNKRAT'), 'LANÇADOR DE GRANADAS', NULL),
((SELECT id FROM herois WHERE nome = 'JUNKRAT'), 'MINA DE CONCUSSÃO', NULL),
((SELECT id FROM herois WHERE nome = 'JUNKRAT'), 'ARMADILHA DE AÇO', NULL),
((SELECT id FROM herois WHERE nome = 'JUNKRAT'), 'CAOS TOTAL', NULL),
((SELECT id FROM herois WHERE nome = 'JUNKRAT'), 'PNEU DA MORTE', NULL);  -- JUNKRAT

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'MCCREE'), 'PACIFICADOR', NULL),
((SELECT id FROM herois WHERE nome = 'MCCREE'), 'ROLAMENTO', NULL),
((SELECT id FROM herois WHERE nome = 'MCCREE'), 'CLARÃO', NULL),
((SELECT id FROM herois WHERE nome = 'MCCREE'), 'TIRO CERTEIRO', NULL);  -- MCCREE

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'MEI'), 'ANIQUILADOR ENDOTÉRMICO', NULL),
((SELECT id FROM herois WHERE nome = 'MEI'), 'CONGELAMENTO CRIOGÊNICO', NULL),
((SELECT id FROM herois WHERE nome = 'MEI'), 'MURALHA DE GELO', NULL),
((SELECT id FROM herois WHERE nome = 'MEI'), 'NEVASCA', NULL);  -- MEI

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'PHARAH'), 'LANÇADOR DE FOGUETES', NULL),
((SELECT id FROM herois WHERE nome = 'PHARAH'), 'SALTO FOGUETE', NULL),
((SELECT id FROM herois WHERE nome = 'PHARAH'), 'EXPLOSÃO CONCUSSIVA', NULL),
((SELECT id FROM herois WHERE nome = 'PHARAH'), 'BOMBARDEIO', NULL);  -- PHARAH

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'REAPER'), 'ESPINGARDAS INFERNAIS', NULL),
((SELECT id FROM herois WHERE nome = 'REAPER'), 'FORMA FANTASMA', NULL),
((SELECT id FROM herois WHERE nome = 'REAPER'), 'PASSOS DAS SOMBRAS', NULL),
((SELECT id FROM herois WHERE nome = 'REAPER'), 'DESABROCHAR DA MORTE', NULL);  -- REAPER

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'SOLDADO: 76'), 'RIFLE DE PULSO PESADO', NULL),
((SELECT id FROM herois WHERE nome = 'SOLDADO: 76'), 'FOGUETES HÉLIX', NULL),
((SELECT id FROM herois WHERE nome = 'SOLDADO: 76'), 'DISPARADA', NULL),
((SELECT id FROM herois WHERE nome = 'SOLDADO: 76'), 'CAMPO BIÓTICO', NULL),
((SELECT id FROM herois WHERE nome = 'SOLDADO: 76'), 'VISOR TÁTICO', NULL);  -- SOLDADO: 76

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'SOMBRA'), 'PISTOLA AUTOMÁTICA', NULL),
((SELECT id FROM herois WHERE nome = 'SOMBRA'), 'HACKEAR', NULL),
((SELECT id FROM herois WHERE nome = 'SOMBRA'), 'FURTIVIDADE', NULL),
((SELECT id FROM herois WHERE nome = 'SOMBRA'), 'TRANSLOCADOR', NULL),
((SELECT id FROM herois WHERE nome = 'SOMBRA'), 'PEM', NULL);  -- SOMBRA

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'SYMMETRA'), 'PROJETOR DE FÓTONS', NULL),
((SELECT id FROM herois WHERE nome = 'SYMMETRA'), 'TORRE DE SENTINELA', NULL),
((SELECT id FROM herois WHERE nome = 'SYMMETRA'), 'TELETRANSPORTADOR', NULL),
((SELECT id FROM herois WHERE nome = 'SYMMETRA'), 'BARREIRA DE FÓTONS', NULL);  -- SYMMETRA

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'TORBJÖRN'), 'PISTOLA DE REBITE', NULL),
((SELECT id FROM herois WHERE nome = 'TORBJÖRN'), 'MARTELO DE FORJA', NULL),
((SELECT id FROM herois WHERE nome = 'TORBJÖRN'), 'CONSTRUIR TORRE', NULL),
((SELECT id FROM herois WHERE nome = 'TORBJÖRN'), 'IMPLEMENTO DE ARMADURA', NULL),
((SELECT id FROM herois WHERE nome = 'TORBJÖRN'), 'NÚCLEO FUNDIDO', NULL);  -- TORBJÖRN

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'TRACER'), 'PISTOLAS ELETROMAGNÉTICAS', NULL),
((SELECT id FROM herois WHERE nome = 'TRACER'), 'TELEPORTAR', NULL),
((SELECT id FROM herois WHERE nome = 'TRACER'), 'RECORDAÇÃO', NULL),
((SELECT id FROM herois WHERE nome = 'TRACER'), 'BOMBA ELETROMAGNÉTICA', NULL);  -- TRACER

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'WIDOWMAKER'), 'BEIJO DA VIÚVA', NULL),
((SELECT id FROM herois WHERE nome = 'WIDOWMAKER'), 'ARPÉU', NULL),
((SELECT id FROM herois WHERE nome = 'WIDOWMAKER'), 'MINA VENENOSA', NULL),
((SELECT id FROM herois WHERE nome = 'WIDOWMAKER'), 'VISÃO INFRAVERMELHO', NULL);  -- WIDOWMAKER

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'ANA'), 'RIFLE BIÓTICO', NULL),
((SELECT id FROM herois WHERE nome = 'ANA'), 'DARDO SONÍFERO', NULL),
((SELECT id FROM herois WHERE nome = 'ANA'), 'GRANADA BIÓTICA', NULL),
((SELECT id FROM herois WHERE nome = 'ANA'), 'ESTIMULANTE', NULL);  -- ANA

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'BRIGITTE'), 'MANGUAL A JATO', NULL),
((SELECT id FROM herois WHERE nome = 'BRIGITTE'), 'KIT DE REPAROS', NULL),
((SELECT id FROM herois WHERE nome = 'BRIGITTE'), 'DISPARO AÇOITADOR', NULL),
((SELECT id FROM herois WHERE nome = 'BRIGITTE'), 'BARREIRA DE ESCUDO', NULL),
((SELECT id FROM herois WHERE nome = 'BRIGITTE'), 'GOLPE DE ESCUDO', NULL),
((SELECT id FROM herois WHERE nome = 'BRIGITTE'), 'REAGRUPAR', NULL);  -- BRIGITTE

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'LÚCIO'), 'AMPLIFICADOR SÔNICO', NULL),
((SELECT id FROM herois WHERE nome = 'LÚCIO'), 'TRANSIÇÃO', NULL),
((SELECT id FROM herois WHERE nome = 'LÚCIO'), 'SOLTA O SOM', NULL),
((SELECT id FROM herois WHERE nome = 'LÚCIO'), 'BARREIRA DE SOM
', NULL);  -- LÚCIO

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'MERCY'), 'BASTÃO DE CADUCEU', NULL),
((SELECT id FROM herois WHERE nome = 'MERCY'), 'DESINTEGRADOR DE CADUCEU', NULL),
((SELECT id FROM herois WHERE nome = 'MERCY'), 'ANJO DA GUARDA', NULL),
((SELECT id FROM herois WHERE nome = 'MERCY'), 'RESSURREIÇÃO', NULL),
((SELECT id FROM herois WHERE nome = 'MERCY'), 'DESCENSO ANGELICAL', NULL),
((SELECT id FROM herois WHERE nome = 'MERCY'), 'VALQUÍRIA', NULL);  -- MERCY

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'MOIRA'), 'PUNHO BIÓTICO', NULL),
((SELECT id FROM herois WHERE nome = 'MOIRA'), 'ORBE BIÓTICO', NULL),
((SELECT id FROM herois WHERE nome = 'MOIRA'), 'DESVANECER', NULL),
((SELECT id FROM herois WHERE nome = 'MOIRA'), 'COALESCÊNCIA', NULL);  -- MOIRA

INSERT INTO habilidades (id_hero, nome, descricao) VALUES
((SELECT id FROM herois WHERE nome = 'ZENYATTA'), 'ORBE DA DESTRUIÇÃO', NULL),
((SELECT id FROM herois WHERE nome = 'ZENYATTA'), 'ORBE DA HARMONIA', NULL),
((SELECT id FROM herois WHERE nome = 'ZENYATTA'), 'ORBE DA DISCÓRDIA', NULL),
((SELECT id FROM herois WHERE nome = 'ZENYATTA'), 'TRANSCENDÊNCIA', NULL);  -- ZENYATTA

SELECT id'CÓDIGO', nome'NOME', dificuldade'DIFICULDADE', funcao'FUNÇÃO' FROM herois;
SELECT id'CÓDIGO', id_hero'CÓDIGO HEROI', nome'NOME', descricao'DESCRIÇÃO' FROM habilidades;