using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploFor
{
    class Exercicio03
    {
        public Exercicio03()
        {
            int tamanhoDoQuadrado = 10;
            for (int i = 0; i < tamanhoDoQuadrado; i++)
            {
                for (int j = 0; j < tamanhoDoQuadrado; j++)
                {
                    Console.Write("* ");
                }
            Console.WriteLine();
            }
        }
    }
}
