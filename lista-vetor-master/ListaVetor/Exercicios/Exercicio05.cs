using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Exercicio05
    {
        public Exercicio05()
        {
            /*5. Solicite para o usuário 5 pesos e apresente a soma total dos pesos e a média
dos pesos.*/

            double[] pesos = new double[5];
            bool validacaoPeso = true;

            Console.WriteLine("Informe o peso de 5 pessoas para saber a média.");
            Console.ReadKey();
            Console.Clear();

            while (validacaoPeso == true)
            {
                try
                {
                    Console.Write("Peso 1 de 5: ");
                    pesos[0] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    validacaoPeso = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Peso' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validacaoPeso = true;

            while (validacaoPeso == true)
            {
                try
                {
                    Console.Write("Peso 2 de 5: ");
                    pesos[1] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    validacaoPeso = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Peso' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validacaoPeso = true;

            while (validacaoPeso == true)
            {
                try
                {
                    Console.Write("Peso 3 de 5: ");
                    pesos[2] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    validacaoPeso = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Peso' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validacaoPeso = true;

            while (validacaoPeso == true)
            {
                try
                {
                    Console.Write("Peso 4 de 5: ");
                    pesos[3] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    validacaoPeso = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Peso' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validacaoPeso = true;

            while (validacaoPeso == true)
            {
                try
                {
                    Console.Write("Peso 5 de 5: ");
                    pesos[4] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    validacaoPeso = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Peso' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            double media = (pesos[0] + pesos[1] + pesos[2] + pesos[3]) / 4;

            Console.WriteLine("A média dos 5 pesos é {0:n}",media);
        }
    }
}
