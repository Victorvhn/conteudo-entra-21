using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista01
{
    class Exercicio15
    {
        public Exercicio15()
        {
            Console.WriteLine("Digite um número para saber seus 50 antecessores pares e seus 50 sucessores ímpares.");
            Console.Write("Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            //NUMEROS PARES
            int quantidadeNumerosPares = 0;
            int numeroPar = 0;
            string numerosPares = "";
            int auxiliarNumeroPar = numero - 2;

            //NUMEROS IMPARES
            int quantidadeNumerosImpares = 0;
            int numeroImpar = 0;
            string numerosImpares = "";
            int auxiliarNumerosImpares = numero + 2;

            //numeros pares
            while (quantidadeNumerosPares < 50)
            {
                if (auxiliarNumeroPar % 2 == 0)
                {
                    numeroPar = auxiliarNumeroPar;
                    numerosPares = numerosPares + numeroPar + ", ";
                    quantidadeNumerosPares++;
                    auxiliarNumeroPar = auxiliarNumeroPar - 2;
                }
                else
                {
                    auxiliarNumeroPar = auxiliarNumeroPar + 1;
                    numeroPar = auxiliarNumeroPar;
                    numerosPares = numerosPares + numeroPar + ", ";
                    quantidadeNumerosPares++;
                    auxiliarNumeroPar = auxiliarNumeroPar - 2;
                }
            }

            //numeros impares
            while (quantidadeNumerosImpares < 50)
            {
                if (auxiliarNumerosImpares % 2 != 0)
                {

                }
            }
            Console.WriteLine(numerosPares);
        }
    }
}
