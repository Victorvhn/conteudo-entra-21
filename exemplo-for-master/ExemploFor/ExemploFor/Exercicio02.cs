using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFor
{
    class Exercicio02
    {
        int j = 1;
        int multiplicando = 1;
        public Exercicio02()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (j = 0; j <= 10; j++)
			    {
			         int tabuada = multiplicando * j;
                     Console.WriteLine(String.Format("{0} x {1}= {2}",multiplicando,j,tabuada));
			    }
                Console.WriteLine();
                multiplicando++; 
            }
        }
    }
}
