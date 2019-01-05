-- 20. Selecione o nick e o mês de nascimento quando o mês de nascimento for maior que 6.

SELECT 
	nick'NICK', 
	MONTH(data_nascimento)'MÊS DE NASCIMENTO'
	FROM alunos
	WHERE MONTH(data_nascimento) > 6
	ORDER BY nick;