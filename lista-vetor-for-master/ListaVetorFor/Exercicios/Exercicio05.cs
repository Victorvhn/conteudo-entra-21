using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Exercicio05
    {
        public Exercicio05()
        {
            /*5. A empresa GameVicio precisa armazenar os jogos que tem em estoque, para tal
                deve-se armazenar o nome e a quantidade de jogos. Para tal utilize um vetor para o
                nome dos jogos e outro vetor para a quantidade de jogos.
                Ao final apresente o nome concatenado com a quantidade.
                Exemplo:
                Nome Unidades
                Horizon Zero Dawn 190
                God Of War 350
                Spider-Man 59
                Injustice 2 27
                Crash Bandicoot 41
                Grand Theft Auto V 12
                Observação: A quantidade de jogos que serão cadastrados é o usuário que irá definir;*/
            bool validarQuantidade = true;
            int quantidadeJogosCadastrados = 0;
            while (validarQuantidade == true)
            {
                try
                {
                    Console.Write("Bem Vindo Usuário.\nQuantos jogos você deseja cadastrar?\nQuantidade: ");
                    quantidadeJogosCadastrados = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarQuantidade = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Deveria conter apenas números em 'quantidade'");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            string[] jogos = new string[quantidadeJogosCadastrados];
            int[] unidadeJogos = new int[quantidadeJogosCadastrados];

           for (int i = 0; i < quantidadeJogosCadastrados; i++)
            {
                try
                {
                    Console.Write("Nome do jogo: ");
                    jogos[i] = Console.ReadLine();
                    Console.Write("\nUnidades: ");
                    unidadeJogos[i] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Unidades' deve conter apenas números");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
           Console.WriteLine("Nome  |  Unidade");
           for (int i = 0; i < quantidadeJogosCadastrados; i++ )
           {
               Console.Write(String.Format("{0}   {1}\n",jogos[i], unidadeJogos[i]));
           }

        }
    }
}
