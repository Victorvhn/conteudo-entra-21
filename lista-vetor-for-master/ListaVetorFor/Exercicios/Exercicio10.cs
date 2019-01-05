using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Exercicio10
    {
        public Exercicio10()
        {
            /*10.Crie um vetor para guardar 10 nomes, solicite-os e apresente:
                ➔ Todos os nomes;
                ➔ Nome com o maior nome;
                ➔ Nome com o menor nome;
                ➔ Quantidade de pessoas que contém o nome começando com S;
                ➔ Quantidade de pessoas que contém o nome começando com A;
                ➔ Quantidade de pessoas que o último sobrenome é Silva.*/

            int quantidadeNomes = 2;
            string[] nomes = new string[quantidadeNomes];
            int quantidadePessoasComS = 0;
            int quantidadePessoasComA = 0;
            int quantidadePessoasComSilva = 0;

            Console.WriteLine("Informe o nome COMPLETO de {0} pessoas para saber algumas informações no final",quantidadeNomes);
            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i < nomes.Length; i++)
            {

                Console.Write(String.Format("{0} de {1}\n" +
                                            "Nome: ", (i + 1), nomes.Length));
                nomes[i] = Console.ReadLine().ToLower();
                Console.Clear();
                if (nomes[i].Substring(0,1) == "s")
                {
                    quantidadePessoasComS++;
                }

                if (nomes[i].Substring(0,1) == "a")
                {
                    quantidadePessoasComA++;
                }

                if (nomes[i].Length >= 5)
                {
                    if (nomes[i].Substring(nomes[i].Length - 5, 5) == "silva")
                    {
                        quantidadePessoasComSilva++;
                    }
                }
            }
            Console.WriteLine(String.Format("Foram registradas {0} pessoas que contém o primeiro nome começando com S;\n" +
                                            "Foram registradas {1} pessoas que contém o primeiro nome começando com A;\n" + 
                                            "Foram registradas {2} pessoas que o último sobrenome é Silva.",quantidadePessoasComS,quantidadePessoasComA,quantidadePessoasComSilva));
        }
    }
}

