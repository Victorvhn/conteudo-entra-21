using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista01
{
    class Exercicio14
    {
        public Exercicio14()
        {
            Console.WriteLine("Informe um número para saber o fatorial dele.");

            Console.Write("Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int numeroInicial = numero;
            double fatorial = 1;

            while(numero >= 1)
            {
                fatorial = fatorial  * numero--;
            }
            Console.Clear();
            Console.WriteLine("O fatorial de {0} é {1}\n\n",numeroInicial, fatorial);
        }
    }
}
