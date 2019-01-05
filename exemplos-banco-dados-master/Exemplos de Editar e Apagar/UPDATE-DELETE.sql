/*
	UPDATE outfit SET tamanho = 'XGG' WHERE marca = 'Lelis blanc';
*/ -- ALTERA O TAMANHO QUANDO A MARCA FOR LELIS BLANC

/*
	UPDATE outfit SET cor = 'Verde', tecido = 'Sla' WHERE cor = 'Rosa xoque';
*/ -- ALTERA COR E TECIDO QUANDO A COR FOR ROSA XOQUE

/*
	UPDATE outfit SET marca = 'Oakley' WHERE marca = 'Okle';	
*/ -- ALTERA A MARCA QUANDO A MARCA FOR Okle

/*
	UPDATE outfit SET cor = 'Azul espacial' WHERE tecido LIKE '%malha%';
*/ -- ALTERA A COR QUANDO TECIDO TIVER A PALAVRA MALHA

/*
	DELETE FROM outfit WHERE cor = 'Azul espacial';
*/ -- DELETA O REGISTRO QUANDO A COR É AZUL ESPACIAL

/*
	DELETE FROM outfit WHERE cor = 'Azul espacial' OR cor = 'Verde';
*/ -- DELETA O REGISTRO QUANDO A COR É AZUL OU VERDE;

SELECT * FROM outfit