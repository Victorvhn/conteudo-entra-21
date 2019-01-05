using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista01
{
    class Exercicio13
    {
        public Exercicio13()
        {
            int contador = 0;
            int resultado = 0;

            Console.WriteLine("Informe um número para saber a tabuada dele até o 1000.");

            Console.Write("Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            while (contador <= 1000)
            {
                resultado = numero * contador;
                Console.WriteLine(numero + " x " + contador + " = " + resultado);
                contador++;
            }
        }
    }
}
