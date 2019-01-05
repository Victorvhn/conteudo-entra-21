using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Exercicio11
    {
        public Exercicio11()
        {
            int quantidadeNomes = 5;
            string[] nomes = new string[quantidadeNomes];
            string apresentação = "";

            for (int i =0; i < nomes.Length; i++)
            {
                Console.Write(String.Format("{0} de {1}\n" + 
                                            "Nome: ",(i + 1), nomes.Length));
                nomes[i] = Console.ReadLine();
                Console.Clear();
                
                if (i == (nomes.Length - 2))
                {
                    apresentação = apresentação + nomes[i] + " e "; 
                }
                else if (i == (nomes.Length - 1))
                {
                    apresentação = apresentação + nomes[i] + ".";
                }
                else
                {
                    apresentação = apresentação + nomes[i] + ", ";
                }
            }
            Console.WriteLine(apresentação);
        }
    }
}
