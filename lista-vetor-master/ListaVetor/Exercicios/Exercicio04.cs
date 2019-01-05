using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Exercicio04
    {
        public Exercicio04()
        {
            /*4. Crie um vetor para armazenar as notas de uma disciplina. A disciplina deve
conter 4 notas.
Solicite para o usuário o nome e as quatro notas, armazenando as notas em um
vetor, realize a média destas notas e apresente.*/

            double[] notas = new double[4];
            bool validarNota = true;

            Console.WriteLine("Informe 4 notas de uma matéria para calcular a média.");
            Console.ReadKey();
            Console.Clear();

            while (validarNota == true)
            {
                try
                {
                    Console.Write("Nota 1 de 4: ");
                    notas[0] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    validarNota = false;
                }
                catch
                {
                    Console.Clear();
                    Console.Write("'Nota' deve contar apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarNota = true;

            while (validarNota == true)
            {
                try
                {
                    Console.Write("Nota 2 de 4: ");
                    notas[1] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    validarNota = false;
                }
                catch
                {
                    Console.Clear();
                    Console.Write("'Nota' deve contar apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarNota = true;

            while (validarNota == true)
            {
                try
                {
                    Console.Write("Nota 3 de 4: ");
                    notas[2] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    validarNota = false;
                }
                catch
                {
                    Console.Clear();
                    Console.Write("'Nota' deve contar apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarNota = true;

            while (validarNota == true)
            {
                try
                {
                    Console.Write("Nota 4 de 4: ");
                    notas[3] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    validarNota = false;
                }
                catch
                {
                    Console.Clear();
                    Console.Write("'Nota' deve contar apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            double media = (notas[0] + notas[1] + notas[2] + notas[3]) /4;

            Console.WriteLine(String.Format("A média da matéria é {0:n}",media));

        }
    }
}
