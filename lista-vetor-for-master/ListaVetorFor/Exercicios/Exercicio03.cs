using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Exercicio03
    {
        public Exercicio03()
        {
            /*3. Desenvolver um programa que armazene preços, deve-se solicitar ao usuário a
   quantidade de registros que o mesmo deseja armazenar. Após isto, solicitar os
   preços de acordo com a quantidade de registros.
   Ao final apresentar todos os preços e o total dos preços.*/

            bool validarQuantidadeRegistros = true;
            int quantidadeProdutosCadastras = 0;
            double somaPrecos = 0;

            while (validarQuantidadeRegistros == true)
            {
                try
                {
                    Console.Write("Quantos produtos você deseja cadastras:\nQuantidade: ");
                    quantidadeProdutosCadastras = Convert.ToInt32(Console.ReadLine());
                    validarQuantidadeRegistros = false;
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
            
            int[] produtos = new int[quantidadeProdutosCadastras];
            double[] precoDosProdutos = new double[quantidadeProdutosCadastras];
            bool validarPrecos = true;

            for (int i = 0; i < quantidadeProdutosCadastras; i++, validarPrecos = true)
            {
                while (validarPrecos == true)
                {
                    try
                    {
                        Console.Write(String.Format("Produto {0} de {1}\nPreço: ",(i + 1), quantidadeProdutosCadastras));
                        precoDosProdutos[i] = Convert.ToDouble(Console.ReadLine());
                        validarPrecos = false;
                        Console.Clear();
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("'Preço' deveria conter apenas números.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }

            for (int j = 0; j < quantidadeProdutosCadastras; j++)
            {
                Console.WriteLine(String.Format("Produto {0} : R$ {1:n}",(j + 1),precoDosProdutos[j]));
                somaPrecos = somaPrecos + precoDosProdutos[j];
            }
            Console.WriteLine("\nPreço total: R$ {0:n}",somaPrecos);
        }
    }
}
