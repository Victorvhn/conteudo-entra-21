using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
    class Exercicio04
    {
        public Exercicio04()
        {
            /*4. Faça um programa que solicite a quantidade de carros que o usuário deseja
cadastrar, após isto solicite para o usuário o modelo, valor e ano do carro até que
atinja a quantidade de carros para cadastro.
Apresente ao final:
Média do ano dos carros
Média do valor dos carros
Quantidade de carros que começam com a letra G
Quantidade de carros que começam com a letra A*/

            int quantidadeMaximaCarros = 0;
            int quantidadeCarrosRegistrados = 0;
            string modeloCarro = "";
            double valorCarro = 0;
            int anoCarro = 0;

            //
            double mediaAnoCarros = 0;
            int somaAnoCarros = 0;

            //
            double mediaValorCarros = 0;
            double somaValorCarros = 0;

            //
            int quantidadeCarrosComecamG = 0;
            int quantidadeCarrosComecamA = 0;

            Console.Write("Quantos carros você deseja cadastras? : ");
            quantidadeMaximaCarros = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            while (quantidadeCarrosRegistrados < quantidadeMaximaCarros)
            {
                Console.Write("Modelo do carro: ");
                modeloCarro = Console.ReadLine();
                modeloCarro = modeloCarro.ToLower();

                Console.Write("Valor do carro: ");
                valorCarro = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ano do carro: ");
                anoCarro = Convert.ToInt32(Console.ReadLine());

                modeloCarro = modeloCarro.Substring(0,1);

                 if (modeloCarro == "a")
                 {
                     quantidadeCarrosComecamA = quantidadeCarrosComecamA + 1;
                 }
                 else if (modeloCarro == "g")
                 {
                     quantidadeCarrosComecamG = quantidadeCarrosComecamG + 1;
                 }

                 somaAnoCarros = somaAnoCarros + anoCarro;
                 somaValorCarros = somaValorCarros + valorCarro;
                 
                quantidadeCarrosRegistrados = quantidadeCarrosRegistrados + 1;
                
                Console.Clear();

            }
            mediaAnoCarros = somaAnoCarros / quantidadeCarrosRegistrados;
            mediaValorCarros = somaValorCarros / quantidadeCarrosRegistrados;

            Console.WriteLine("Média do ano dos carros: " + mediaAnoCarros);
            Console.WriteLine(String.Format("Média do valor dos carros: R$ {0:n}",mediaValorCarros));
            Console.WriteLine("Quantidade de carros que começam com a letra G: " + quantidadeCarrosComecamG);
            Console.WriteLine("Quantidade de carros que começam com a letra A: " + quantidadeCarrosComecamA);
        }
    }
}
