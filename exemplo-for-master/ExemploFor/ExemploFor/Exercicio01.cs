using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFor
{
    class Exercicio01
    {
        public Exercicio01()
        {
            bool validarNumero = true;
            int numero = 0;

            while (validarNumero == true)
            {
                try
                {
                    Console.Write("Digite a tabuada que você quer saber.\nNúmero: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarNumero = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Número' deveria conter apenas números");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            for (int i = -1000000; (i >= -1000000) && (i <= 1000000); i++)
            {
                int tabuada = numero * i;
                Console.WriteLine(String.Format("{0} x {1}= {2}",numero,i,tabuada));
            }

        }
    }
}