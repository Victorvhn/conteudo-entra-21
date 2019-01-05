-- 8. Apagar o(s) pokemon(s) que a velocidade seja um número ímpar.

DELETE FROM pokemons WHERE velocidade % 2 != 0;