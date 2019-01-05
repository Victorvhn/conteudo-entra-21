using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Exercicio03
    {
        public Exercicio03()
        {
            /*3. Crie dois vetores para guardar o nome e preço de 7 produtos e apresente o
nome e preço dos ​sete produtos.*/

            string[] nomes = new string[7];
            double[] precos = new double[7];
            bool validarPreco = true;

            Console.WriteLine("Digite o nome e o preço de 7 produtos.");
            Console.ReadKey();
            Console.Clear();

            while (validarPreco == true)
            {
                try
                {
                    Console.Write("Pessoa 1 de 7\nNome: ");
                    nomes[0] = Console.ReadLine();
                    Console.Write("Preço: ");
                    precos[0] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    validarPreco = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Preço' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarPreco = true;

            while (validarPreco == true)
            {
                try
                {
                    Console.Write("Pessoa 2 de 7\nNome: ");
                    nomes[1] = Console.ReadLine();
                    Console.Write("Preço: ");
                    precos[1] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    validarPreco = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Preço' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarPreco = true;

            while (validarPreco == true)
            {
                try
                {
                    Console.Write("Pessoa 3 de 7\nNome: ");
                    nomes[2] = Console.ReadLine();
                    Console.Write("Preço: ");
                    precos[2] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    validarPreco = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Preço' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarPreco = true;

            while (validarPreco == true)
            {
                try
                {
                    Console.Write("Pessoa 4 de 7\nNome: ");
                    nomes[3] = Console.ReadLine();
                    Console.Write("Preço: ");
                    precos[3] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    validarPreco = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Preço' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarPreco = true;

            while (validarPreco == true)
            {
                try
                {
                    Console.Write("Pessoa 5 de 7\nNome: ");
                    nomes[4] = Console.ReadLine();
                    Console.Write("Preço: ");
                    precos[4] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    validarPreco = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Preço' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarPreco = true;

            while (validarPreco == true)
            {
                try
                {
                    Console.Write("Pessoa 6 de 7\nNome: ");
                    nomes[5] = Console.ReadLine();
                    Console.Write("Preço: ");
                    precos[5] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    validarPreco = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Preço' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarPreco = true;

            while (validarPreco == true)
            {
                try
                {
                    Console.Write("Pessoa 7 de 7\nNome: ");
                    nomes[6] = Console.ReadLine();
                    Console.Write("Preço: ");
                    precos[6] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    validarPreco = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("'Preço' deveria conter apenas números.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            validarPreco = true;

            Console.WriteLine(String.Format("{0} custa R$ {1:n}\n" +
                                            "{2} custa R$ {3:n}\n" +
                                            "{4} custa R$ {5:n}\n" +
                                            "{6} custa R$ {7:n}\n" +
                                            "{8} custa R$ {9:n}\n" +
                                            "{10} custa R$ {11:n}\n" +
                                            "{12} custa R$ {13:n}\n",nomes[0], precos[0], nomes[1], precos[1], nomes[2], precos[2], nomes[3], precos[3], nomes[4], precos[4], nomes[5], precos[5], nomes[6], precos[6]));
        }
    }
}
