using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
    class Exercicio03
    {
        public Exercicio03()
        {
            /*3. Solicite o peso para o usuário até que o peso seja menor que 0 ou maior que
300,00, apresente ao final a quantidade de pessoas que informaram o peso.*/

            int quantidadePessoas = 0;
            double PesoPessoas = 0;

            Console.Write("Digite o peso da pessoa: ");
            PesoPessoas = Convert.ToDouble(Console.ReadLine());

            while ((PesoPessoas > 0) && (PesoPessoas < 300))
            {
                Console.Write("Digite o peso da pessoa: ");
                PesoPessoas = Convert.ToDouble(Console.ReadLine());

                quantidadePessoas = quantidadePessoas + 1;
            }
            Console.WriteLine(String.Format("Foram registradas {0} pessoas",quantidadePessoas));
        }
    }
}
