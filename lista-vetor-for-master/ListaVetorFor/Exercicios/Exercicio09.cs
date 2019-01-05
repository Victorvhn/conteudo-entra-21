using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Exercicio09
    {
        public Exercicio09()
        {
            /*9. Crie um vetor para armazenar as notas de uma disciplina. A disciplina deve
                conter 4 notas.
                Solicite para o usuário o nome e as quatro notas, armazenando as notas em um
                vetor.
                Após armazenar as notas faça o cálculo da média.
                Apresentar as 4 notas e a média.*/
            bool validarNota = true;
            int quantidadeNotas = 4;
            double[] notas = new double[quantidadeNotas];
            double soma = 0;

            Console.WriteLine("Informe as 4 notas da disciplina para saber a média.");
            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i < notas.Length; i++)
            {
                while (validarNota == true)
                {
                    try
                    {
                        Console.Write(String.Format("{0} de {1}\nNota: ", (i + 1), notas.Length));
                        notas[i] = Convert.ToDouble(Console.ReadLine());
                        validarNota = false;
                        Console.Clear();
                        soma = soma + notas[i];
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Deveria conter apenas números em 'nota'");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                validarNota = true;
            }
            double media = soma / notas.Length;
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine(String.Format("Nota {0}: {1}",(i + 1),notas[i]));
            }
            Console.WriteLine("Média: {0}",media);
        }
    }
}
