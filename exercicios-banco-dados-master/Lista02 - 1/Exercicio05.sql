-- 5. Selecione altura, peso, com o cálculo do imc ordenando o imc em ordem decrescente.

SELECT 
altura 'ALTURA', peso 'PESO', (peso/(altura*altura)) 'IMC' 
FROM pokemons 
ORDER BY 'IMC' DESC;

-- TODO: FORMATAR CASA DECIMAL