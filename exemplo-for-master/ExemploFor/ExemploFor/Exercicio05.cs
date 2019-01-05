using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFor
{
    class Exercicio05
    {
        public Exercicio05()
        {
            int quantidadeNumeros = 100;
            for (int i = 0; i <= quantidadeNumeros; i++)
            {
                if ( i == 0)
                {
                    Console.WriteLine(i + " :)");
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine(i + " :)");
                }
                else
                {
                    Console.WriteLine(i + " :|");
                }
            }
        }
    }
}
