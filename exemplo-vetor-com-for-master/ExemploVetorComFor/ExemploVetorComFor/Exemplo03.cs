using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploVetorComFor
{
    class Exemplo03
    {
        public Exemplo03()
        {
            Console.Write("Digite a quantidade de registros que deseja cadastrar: ");
            int quantidadeRegistros = Convert.ToInt32(Console.ReadLine());

            string[] fazendas = new string[quantidadeRegistros];
            int[] quantidadePorcos = new int[quantidadeRegistros];

            for (int i = 0; i < fazendas.Length; i++)
            {
                Console.Write("Nome da fazenda: ");
                fazendas[i] = Console.ReadLine();
                Console.Write("Quantidade de suínos: ");
                quantidadePorcos[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Fazenda com a maior quantidade de suínos
            int maiorQuantidadeSuinos = int.MinValue;
            string fazendaMaiorQuantidadesuinos = "";
            for (int i = 0; i < quantidadePorcos.Length; i++)
            {
                if (quantidadePorcos[i] > maiorQuantidadeSuinos)
                {
                    maiorQuantidadeSuinos = quantidadePorcos[i];
                    fazendaMaiorQuantidadesuinos = fazendas[i];
                }
            }
            Console.WriteLine("Fazenda com a maior quantidade de suínos: " + fazendaMaiorQuantidadesuinos + " contém " + maiorQuantidadeSuinos);

            // Fazenda com o menor nome
            string menorNome = "";
            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 == 0)
                {
                    menorNome = menorNome + "a";
                }
                else
                {
                    menorNome = menorNome + "e";
                }
            }

            for (int i = 0; i < fazendas.Length; i++)
            {
                if (fazendas[i].Length < menorNome.Length)
                {
                    menorNome = fazendas[i];
                }
            }
            Console.WriteLine("A fazenda com o menor nome é " + menorNome);
        }
    }
}

