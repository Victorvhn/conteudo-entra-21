using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Exercicio02
    {
        public Exercicio02()
        {
            /*2. Desenvolver um programa que armazene 7 idades, armazenar em um vetor,
solicitando ao usuário e ao final apresentar as idades ao usuário.*/

            bool validarQuantidadeCadastros = true;
            int quantidadeUsuariosCadastrados = 0;
            bool validarIdadesCadastradas = true;

            while (validarQuantidadeCadastros == true)
            {
                try
                {
                    Console.Write("Digite a quantidade de idades que você deseja armazenar\nQuantidade: ");
                    quantidadeUsuariosCadastrados = Convert.ToInt32(Console.ReadLine());
                    validarQuantidadeCadastros = false;
                    Console.Clear();
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Quantidade' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            int[] idades = new int[quantidadeUsuariosCadastrados];

            for (int i = 0; i < quantidadeUsuariosCadastrados; i++, validarIdadesCadastradas = true)
            {
                while (validarIdadesCadastradas == true)
                {
                    try
                    {
                        Console.Write("Idade " + (i + 1) + " de " + quantidadeUsuariosCadastrados + "\nIdade: ");
                        idades[i] = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        validarIdadesCadastradas = false;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("'Idade' deveria conter apenas números.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("A idades cadastradas foram: ");
            for (int j = 0; j < quantidadeUsuariosCadastrados; j++)
            {
                Console.WriteLine(idades[j] + " anos");
            }

        }
    }
}
