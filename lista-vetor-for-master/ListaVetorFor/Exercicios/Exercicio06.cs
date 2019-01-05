using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Exercicio06
    {
        public Exercicio06()
        {
            /*6. Crie um vetor que irá armazenar 10 números. Estes números deverão ser número
                aleatórios.
                Ao final apresente:
                ➔ Todos os números armazenados;
                ➔ A somatória final dos números;
                ➔ A média dos números;
                ➔ Quantidade de números pares;
                ➔ Quantidade de números positivos;
                ➔ Quantidade de números ímpares;
                ➔ Quantidade de números negativos;
                ➔ Quantidade de números neutros.
                Observação: os números aleatórios devem ser gerados pelo C Sharp.*/

            int quantidadesNumeros = 10;
            int soma = 0;
            double media = 0;
            int numerosNeutros = 0;
            int numerosPares = 0;
            int numerosImpares = 0;
            int numerosPositivos = 0;
            int numerosNegativos = 0;

            Random random = new Random();

            int[] numeros = new int[quantidadesNumeros];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(-10000, 10000);
                soma = soma + numeros[i];

                if (numeros[i] != 0)
                {
                    if (numeros[i] % 2 == 0)
                    {
                        numerosPares++;
                    }
                    else // (numeros[i] % 2 != 0)
                    {
                        numerosImpares++;
                    }

                    if (numeros[i] > 0)
                    {
                        numerosPositivos++;
                    }
                    else // (numeros[i] < 0)
                    {
                        numerosNegativos++;
                    }
                }
                else
                {
                    numerosNeutros++;
                }
            }

            media = soma / numeros.Length;
            

            

            
            Console.Write("Os números registrados foram: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(String.Format("{0}, ",numeros[i]));
            }
            Console.WriteLine(String.Format("\n\nA soma de todos os números é {0}\n" +
                                             "A média dos números é {1:n}\n" +
                                             "Existem {2} números pares\n" +
                                             "Existem {3} números positivos\n" +
                                             "Existem {4} números ímpares\n" +
                                             "Existem {5} números negativos\n" +
                                             "Existem {6} números neutros\n",soma, media, numerosPares, numerosPositivos, numerosImpares, numerosNegativos, numerosNeutros));
        }
    }
}
