using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Exercicio02
    {
        public Exercicio02()
        {
            //2. Crie um vetor para guardar 10 nomes e apresente os dez nomes​.

            string[] nomes = new string[10];

            Console.WriteLine("Informe 10 nomes para os mesmos serem apresentados no final.");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Nome 1 de 10\nNome: ");
            nomes[0] = Console.ReadLine();
            Console.Clear();

            Console.Write("Nome 2 de 10\nNome: ");
            nomes[1] = Console.ReadLine();
            Console.Clear();

            Console.Write("Nome 3 de 10\nNome: ");
            nomes[2] = Console.ReadLine();
            Console.Clear();

            Console.Write("Nome 4 de 10\nNome: ");
            nomes[3] = Console.ReadLine();
            Console.Clear();

            Console.Write("Nome 5 de 10\nNome: ");
            nomes[4] = Console.ReadLine();
            Console.Clear();

            Console.Write("Nome 6 de 10\nNome: ");
            nomes[5] = Console.ReadLine();
            Console.Clear();

            Console.Write("Nome 7 de 10\nNome: ");
            nomes[6] = Console.ReadLine();
            Console.Clear();

            Console.Write("Nome 8 de 10\nNome: ");
            nomes[7] = Console.ReadLine();
            Console.Clear();

            Console.Write("Nome 9 de 10\nNome: ");
            nomes[8] = Console.ReadLine();
            Console.Clear();

            Console.Write("Nome 10 de 10\nNome: ");
            nomes[9] = Console.ReadLine();
            Console.Clear();

            Console.WriteLine(String.Format("Nomes: {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}",nomes[0], nomes[1], nomes[2], nomes[3], nomes[4], nomes[5], nomes[6], nomes[7], nomes[8], nomes[9]));
        }
    }
}
