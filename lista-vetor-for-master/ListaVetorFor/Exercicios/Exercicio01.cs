using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Exercicio01
    {
        public Exercicio01()
        {
            /*1. Desenvolver um programa que armazene 25 nomes, para tal utilize um vetor com 25
posições e o comando for​ para armazenar os valores.
Observação: para armazenar os valores deve-se solicitar os nomes ao usuário.*/

            Console.Write("Digite a quantidade de nomes que você deseja cadastrar:\nQuantidade: ");
            int quantidadesDeNomes = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            string[] nomes = new string[quantidadesDeNomes];
           

            for (int i = 0; i < quantidadesDeNomes; i++)
            {
                Console.Write("Nome " + (i + 1) + " de "+ quantidadesDeNomes +"\nNome: ");
                nomes[i] = Console.ReadLine();
                Console.Clear();
            }
            for (int j = 0; j < quantidadesDeNomes; j++)
            {
                Console.WriteLine(nomes[j]);
            }
        }
    }
}
