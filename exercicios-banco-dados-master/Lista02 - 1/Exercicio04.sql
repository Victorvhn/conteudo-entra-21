-- 4. Selecione altura, peso, com o cálculo do imc.

SELECT 
altura 'ALTURA', peso 'PESO', (peso/altura*altura) 'IMC' 
FROM pokemons 
ORDER BY 'IMC';