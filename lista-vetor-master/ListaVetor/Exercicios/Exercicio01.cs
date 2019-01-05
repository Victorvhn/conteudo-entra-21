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
            /*1 -​ Crie um vetor para guardar 16 números inteiros.
Preencha todas as posições com números e apresente a soma destes números.*/

            int[] numeros = new int[16];
            bool validarNumero = true;

            Console.WriteLine("Digite 16 números inteiros para serem somados.");
            Console.ReadLine();
            Console.Clear();
            while (validarNumero == true)
            {
                try
                {
                    Console.Write("Número 1 de 16\nNúmero: ");
                    numeros[0] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarNumero = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("'Número' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarNumero = true;

            while (validarNumero == true)
            {
                try
                {
                    Console.Write("Número 2 de 16\nNúmero: ");
                    numeros[1] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarNumero = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("'Número' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarNumero = true;

            while (validarNumero == true)
            {
                try
                {
                    Console.Write("Número 3 de 16\nNúmero: ");
                    numeros[2] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarNumero = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("'Número' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarNumero = true;
            while (validarNumero == true)
            {
                try
                {
                    Console.Write("Número 4 de 16\nNúmero: ");
                    numeros[3] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarNumero = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("'Número' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarNumero = true;

            while (validarNumero == true)
            {
                try
                {
                    Console.Write("Número 5 de 16\nNúmero: ");
                    numeros[4] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarNumero = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("'Número' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarNumero = true;

            while (validarNumero == true)
            {
                try
                {
                    Console.Write("Número 6 de 16\nNúmero: ");
                    numeros[5] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarNumero = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("'Número' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarNumero = true;

            while (validarNumero == true)
            {
                try
                {
                    Console.Write("Número 7 de 16\nNúmero: ");
                    numeros[6] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarNumero = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("'Número' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarNumero = true;

            while (validarNumero == true)
            {
                try
                {
                    Console.Write("Número 8 de 16\nNúmero: ");
                    numeros[7] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarNumero = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("'Número' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarNumero = true;

            while (validarNumero == true)
            {
                try
                {
                    Console.Write("Número 9 de 16\nNúmero: ");
                    numeros[8] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarNumero = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("'Número' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarNumero = true;

            while (validarNumero == true)
            {
                try
                {
                    Console.Write("Número 10 de 16\nNúmero: ");
                    numeros[9] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarNumero = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("'Número' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarNumero = true;

            while (validarNumero == true)
            {
                try
                {
                    Console.Write("Número 11 de 16\nNúmero: ");
                    numeros[10] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarNumero = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("'Número' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarNumero = true;

            while (validarNumero == true)
            {
                try
                {
                    Console.Write("Número 12 de 16\nNúmero: ");
                    numeros[11] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarNumero = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("'Número' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarNumero = true;

            while (validarNumero == true)
            {
                try
                {
                    Console.Write("Número 13 de 16\nNúmero: ");
                    numeros[12] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarNumero = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("'Número' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarNumero = true;

            while (validarNumero == true)
            {
                try
                {
                    Console.Write("Número 14 de 16\nNúmero: ");
                    numeros[13] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarNumero = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("'Número' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarNumero = true;

            while (validarNumero == true)
            {
                try
                {
                    Console.Write("Número 15 de 16\nNúmero: ");
                    numeros[14] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarNumero = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("'Número' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarNumero = true;

            while (validarNumero == true)
            {
                try
                {
                    Console.Write("Número 16 de 16\nNúmero: ");
                    numeros[15] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validarNumero = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("'Número' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            int somaVetor = numeros[0] + numeros[1] + numeros[2] + numeros[3] + numeros[4] + numeros[5] + numeros[6] + numeros[7] + numeros[8] + numeros[9] + numeros[10] + numeros[11] + numeros[12] + numeros[13] + numeros[14] + numeros[15];

            Console.WriteLine("A soma de todos esses números é {0}", somaVetor);
        }
    }
}
