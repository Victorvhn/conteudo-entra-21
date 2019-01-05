using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploVetorComFor
{
    class Exemplo02
    {
        public Exemplo02()
        {
            int[] levelNoLol = new int[3];

            for (int i = 0; i < levelNoLol.Length; i++)
            {
                Console.Write("Digite seu level no lol: ");
                levelNoLol[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Soma todos os valores contidos no vetor para posteriormente poder realizar a média
            int somaLevels = 0;
            for (int i = 0; i < levelNoLol.Length; i++)
            {
                somaLevels = levelNoLol[i] + somaLevels;
            }
            double mediaLevel = somaLevels / levelNoLol.Length;
            Console.WriteLine("Média: " + mediaLevel);
        }
    }
}
