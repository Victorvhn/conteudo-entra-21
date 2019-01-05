using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFor
{
    class Exercicio04
    {
        public Exercicio04()
        {
            int tamanhoDoQuadrado = 10;
            for (int i = 1; i <= tamanhoDoQuadrado; i++)
            {
                if ((i == 1) || (i == tamanhoDoQuadrado))
                {
                    Console.Write("* ");
                    for (int j = 0; j < tamanhoDoQuadrado - 2; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine("*");
                }
                else
                {
                    Console.Write("* ");
                    for (int j = 0; j < tamanhoDoQuadrado - 2; j++)
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine("*");
                }
            }
        }
    }
}
