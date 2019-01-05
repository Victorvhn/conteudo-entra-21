using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFor
{
    class Exemplo03
    {
        public Exemplo03()
        {
            /*string nome1 = Console.ReadLine();
             string nome2 = Console.ReadLine();
             string nome3 = Console.ReadLine();
             string nome4 = Console.ReadLine();*/

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Console.WriteLine(\"Digite o nome" + i + ": \");");
                Console.WriteLine("string nome" + i + " = Console.ReadLine();");
            }
        }
    }
}
