using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Exercicio08
    {
        public Exercicio08()
        {
            bool validarQuantidade = true;
            bool validarNumeros = true;
            int quantidadeInfomada = 0;

            while (validarQuantidade == true)
            {
                try
                {
                    Console.Write("Informe quantos números você deseja cadastras:\nQuantidade: ");
                    quantidadeInfomada = Convert.ToInt32(Console.ReadLine());
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

            int[] numeros = new int[quantidadeInfomada];
            int[] pares = new int[numeros.Length];
            int[] impares = new int[numeros.Length];

            for (int i = 0; i < numeros.Length; i++)
            {
                while (validarNumeros == true)
                {
                    try
                    {
                        Console.Write(String.Format("{0} de {1}\nNúmero: ", (i + 1), quantidadeInfomada));
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        validarNumeros = false;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Deveria conter APENAS números em 'Número'");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                validarNumeros = true;
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    pares[i] = numeros[i];
                }
                else
                {
                    impares[i] = numeros[i];
                }
            }
            Console.Write("Vetor Original: ");
            for (int i = 0; i < quantidadeInfomada; i++)
            {
                Console.Write(numeros[i] + ", ");
            }

            Console.Write("\nVetor par: ");
            for (int i = 0; i < quantidadeInfomada; i++)
            {
                if (pares[i] != 0)
                {
                    Console.Write(pares[i] + ", ");
                }
                else
                {
                    Console.Write("");
                }
            }
            Console.Write("\nVetor ímpar: ");
            for (int i = 0; i < quantidadeInfomada; i++)
            {
                Console.Write(impares[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
