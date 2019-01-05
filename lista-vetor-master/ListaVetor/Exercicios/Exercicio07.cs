using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Exercicio07
    {
        public Exercicio07()
        {
            /*7. Solicite a altura de 4 animais, apresente ao final a altura do animal com a
            menor altura.*/

            double[] alturas = new double[4];
            bool validacaoAltura = true;
            double maiorAltura = double.MinValue;
            int contadorAnimais = 0;

            Console.WriteLine("Informe a altura de 4 animais, para saber qual tem a maior altura.\nDigite as alturas em metros.");
            Console.ReadKey();
            Console.Clear();

            while (validacaoAltura == true)
            {
                try
                {
                    Console.Write("Animal 1 de 4\nAltura: ");
                    alturas[0] = Convert.ToDouble(Console.ReadLine());
                    validacaoAltura = false;
                    Console.Clear();
                    if (alturas[0] > maiorAltura)
                    {
                        maiorAltura = alturas[0];
                        contadorAnimais = 1;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Idade' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validacaoAltura = true;

            while (validacaoAltura == true)
            {
                try
                {
                    Console.Write("Animal 2 de 4\nAltura: ");
                    alturas[1] = Convert.ToDouble(Console.ReadLine());
                    validacaoAltura = false;
                    Console.Clear();
                    if (alturas[1] > maiorAltura)
                    {
                        maiorAltura = alturas[0];
                        contadorAnimais = 2;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Idade' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validacaoAltura = true;

            while (validacaoAltura == true)
            {
                try
                {
                    Console.Write("Animal 3 de 4\nAltura: ");
                    alturas[2] = Convert.ToDouble(Console.ReadLine());
                    validacaoAltura = false;
                    Console.Clear();
                    if (alturas[2] > maiorAltura)
                    {
                        maiorAltura = alturas[2];
                        contadorAnimais = 3;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Idade' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validacaoAltura = true;

            while (validacaoAltura == true)
            {
                try
                {
                    Console.Write("Animal 4 de 4\nAltura: ");
                    alturas[3] = Convert.ToDouble(Console.ReadLine());
                    validacaoAltura = false;
                    Console.Clear();
                    if (alturas[3] > maiorAltura)
                    {
                        maiorAltura = alturas[3];
                        contadorAnimais = 4;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Idade' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            Console.WriteLine("O animal com maior altura é o {0} medindo {1:n}m", contadorAnimais, maiorAltura);

        }
    }
}


