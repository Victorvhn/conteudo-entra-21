/*
	 9. Apagar o(s) aluno(s) que a cor preferida seja ‘Bordo’ e o signo seja ‘Capricórnio’ ou a cor preferida
	‘Cinza-claro’ e o signo seja ‘Aquários’.
*/

DELETE FROM alunos WHERE (cor_preferida = 'Bordo' AND signo = 'Capricórnio') OR (cor_preferida = 'Cinza-claro' AND signo = 'Aquários');