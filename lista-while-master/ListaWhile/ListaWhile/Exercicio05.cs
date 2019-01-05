using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
    class Exercicio05
    {
        public Exercicio05()
        {
            /*5. Solicite para o usuário dois números. Apresente o seguinte menu e de acordo com a
escolha deve ser apresentado a operação aritmética, isto deve ocorrer até que o
mesmo escolha a opção de sair:*/
            double numero1 = 0;
            double numero2 = 0;
            int operacao = 0;
            double resultadoOperacao = 0;

            while (operacao != 5)
            {
                Console.WriteLine("Usuário digite dois número e em seguida digite a opção da operação desejada.\n\n");

                Console.Write("Número 1: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nNúmero 2: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(String.Format(" _________________________"));
                Console.WriteLine(String.Format("|          MENU           |"));
                Console.WriteLine(String.Format("|-------------------------|"));
                Console.WriteLine(String.Format("|     1     |  Somar      |"));
                Console.WriteLine(String.Format("|     2     |  Subtrair   |"));
                Console.WriteLine(String.Format("|     3     |  Multiplicar|"));
                Console.WriteLine(String.Format("|     4     |  Dividir    |"));
                Console.WriteLine(String.Format("|     5     |  Sair       |"));
                Console.WriteLine(String.Format("|___________|_____________|"));

                Console.Write("\n\nOperação desejada: ");
                operacao = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                if ((operacao >= 1) && (operacao <= 4))
                {
                    if (operacao == 1)
                    {
                        resultadoOperacao = numero1 + numero2;
                    }
                    else if (operacao == 2)
                    {
                        resultadoOperacao = numero1 - numero2;
                    }
                    else if (operacao == 3)
                    {
                        resultadoOperacao = numero1 * numero2;
                    }
                    else if (operacao == 4)
                    {
                        resultadoOperacao = numero1 / numero2;
                    }

                    Console.WriteLine("O resultado da operação escolhida é: " + resultadoOperacao);

                    Console.ReadKey(true);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Obrigado por usar.\n");
                }
            }
        }
    }
}
