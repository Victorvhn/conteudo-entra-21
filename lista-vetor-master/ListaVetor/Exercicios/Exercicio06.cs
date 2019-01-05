using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Exercicio06
    {
        public Exercicio06()
        {
            /*6. Solicite a idade de 9 pessoas, apresente ao final a pessoa com a maior
idade.*/
            int[] idades = new int[9];
            int maiorIdade = int.MinValue;
            int contadorPessoas = 0;
            bool validarIdade = true;

            Console.WriteLine("Digite 9 idades para saber qual é maior.");
            Console.ReadKey();
            Console.Clear();

            while (validarIdade == true)
            {
                try
                {
                    Console.Write("Idade 1 de 9\nIdade: ");
                    idades[0] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarIdade = false;
                    if (idades[0] > maiorIdade)
                    {
                        maiorIdade = idades[0];
                        contadorPessoas = 1;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Idade' deve contar apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarIdade = true;

            while (validarIdade == true)
            {
                try
                {
                    Console.Write("Idade 2 de 9\nIdade: ");
                    idades[1] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarIdade = false;
                    if (idades[1] > maiorIdade)
                    {
                        maiorIdade = idades[1];
                        contadorPessoas = 2;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Idade' deve contar apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarIdade = true;

            while (validarIdade == true)
            {
                try
                {
                    Console.Write("Idade 3 de 9\nIdade: ");
                    idades[2] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarIdade = false;
                    if (idades[2] > maiorIdade)
                    {
                        maiorIdade = idades[2];
                        contadorPessoas = 3;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Idade' deve contar apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarIdade = true;

            while (validarIdade == true)
            {
                try
                {
                    Console.Write("Idade 4 de 9\nIdade: ");
                    idades[3] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarIdade = false;
                    if (idades[3] > maiorIdade)
                    {
                        maiorIdade = idades[3];
                        contadorPessoas = 4;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Idade' deve contar apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarIdade = true;

            while (validarIdade == true)
            {
                try
                {
                    Console.Write("Idade 5 de 9\nIdade: ");
                    idades[4] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarIdade = false;
                    if (idades[4] > maiorIdade)
                    {
                        maiorIdade = idades[4];
                        contadorPessoas = 5;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Idade' deve contar apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarIdade = true;

            while (validarIdade == true)
            {
                try
                {
                    Console.Write("Idade 6 de 9\nIdade: ");
                    idades[5] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarIdade = false;
                    if (idades[5] > maiorIdade)
                    {
                        maiorIdade = idades[5];
                        contadorPessoas = 6;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Idade' deve contar apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarIdade = true;

            while (validarIdade == true)
            {
                try
                {
                    Console.Write("Idade 7 de 9\nIdade: ");
                    idades[6] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarIdade = false;
                    if (idades[6] > maiorIdade)
                    {
                        maiorIdade = idades[6];
                        contadorPessoas = 7;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Idade' deve contar apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarIdade = true;

            while (validarIdade == true)
            {
                try
                {
                    Console.Write("Idade 8 de 9\nIdade: ");
                    idades[7] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarIdade = false;
                    if (idades[7] > maiorIdade)
                    {
                        maiorIdade = idades[7];
                        contadorPessoas = 8;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Idade' deve contar apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarIdade = true;

            while (validarIdade == true)
            {
                try
                {
                    Console.Write("Idade 9 de 9\nIdade: ");
                    idades[8] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarIdade = false;
                    if (idades[8] > maiorIdade)
                    {
                        maiorIdade = idades[8];
                        contadorPessoas = 9;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Idade' deve contar apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.WriteLine("A pessoa com maior idade é a pessoa número {0} que tem {1} anos.",contadorPessoas,maiorIdade);
        }
    }
}
