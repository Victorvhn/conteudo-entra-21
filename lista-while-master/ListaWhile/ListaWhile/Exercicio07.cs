using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista01
{
    class Exercicio07
    {
        public Exercicio07()
        {
            /*O comitê da seleção brasileira de futebol deseja obter algumas estatísticas dos
jogadores, para visualizar melhor o desempenho de seus atletas.*/

            int auxiliarQuantidadeJogadores = 1;
            string nome = "";
            int idade = 0;
            double altura = 0;
            double peso = 0;
            string sexo = "";
            int quantidadeGolsMarcados = 0;
            int quantidadeCartoesAmarelos = 0;
            int quantidadeCartoesVermelhos = 0;
            //
            double menorPeso = double.MaxValue;
            string nomeMenorPeso = "";
            double maiorPeso = double.MinValue;
            string nomeMaiorPeso = "";
            //
            double maiorAltura = double.MinValue;
            string nomeMaiorAltura = "";
            double menorAltura = double.MaxValue;
            string nomeMenorAltura = "";
            //
            string maiorNome = "";
            string menorNome = "";
            //
            int contadorSexoMasculino = 0;
            int contadorSexoFeminino = 0;
            //
            int maximoCartoesAmarelos = int.MinValue;
            string nomeJogadorMaisCartoesAmarelos = "";
            int minimoCartoesAmarelos = int.MaxValue;
            string nomeJogadorMenosCartoesAmarelos = "";
            //
            int maximoCartoesVermelhos = int.MinValue;
            string nomeJogadorMaisCartoesVermelhos = "";
            int minimoCartoesVermelhos = int.MaxValue;
            string nomeJogadorMenosCartoesVermelhos = "";
            Console.WriteLine("Favor informe os dados pedidos a seguir.\n");
            Console.ReadKey(true);

            Console.Clear();

            while (auxiliarQuantidadeJogadores <= 22)
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("\nIdade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nPeso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nSexo: ");
                sexo = Console.ReadLine();
                sexo = sexo.ToLower();

                Console.Write("\nAltura: ");
                altura = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nQuantidade de gols marcados: ");
                quantidadeGolsMarcados = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nQuantidade de cartões amarelos recebidos: ");
                quantidadeCartoesAmarelos = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nQuantidade de cartões vermelhos recebidos: ");
                quantidadeCartoesVermelhos = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                //menorPeso
                if (peso < menorPeso)
                {
                    menorPeso = peso;
                    nomeMenorPeso = nome;
                }
                //maior peso
                if (peso > maiorPeso)
                {
                    maiorPeso = peso;
                    nomeMaiorPeso = nome;
                }

                //maior Altura
                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                    nomeMaiorAltura = nome;
                }
                if (altura < menorAltura)
                {
                    menorAltura = altura;
                    nomeMenorAltura = nome;
                }

                //maior nome
                if (nome.Length > maiorNome.Length)
                {
                    maiorNome = nome;
                }
                //menor nome
                if (menorNome.Length == 0 || nome.Length < menorNome.Length)
                {
                    menorNome = nome;
                }

                //Contador de genero
                if (sexo == "masculino")
                {
                    contadorSexoMasculino++;
                }
                if (sexo == "feminino")
                {
                    contadorSexoFeminino++;
                }

                //menor quantidade cartao amarelo
                if (quantidadeCartoesAmarelos > maximoCartoesAmarelos)
                {
                    maximoCartoesAmarelos = quantidadeCartoesAmarelos;
                    nomeJogadorMaisCartoesAmarelos = nome;
                }
                //maior quantidade cartao amarelo
                if (quantidadeCartoesAmarelos < minimoCartoesAmarelos)
                {
                    minimoCartoesAmarelos = quantidadeCartoesAmarelos;
                    nomeJogadorMenosCartoesAmarelos = nome;
                }
                //maior quantidade cartoes vermelhos
                if (quantidadeCartoesVermelhos > maximoCartoesVermelhos)
                {
                    maximoCartoesVermelhos = quantidadeCartoesVermelhos;
                    nomeJogadorMaisCartoesVermelhos = nome;
                }
                if (quantidadeCartoesVermelhos < minimoCartoesVermelhos)
                {
                    minimoCartoesVermelhos = quantidadeCartoesVermelhos;
                    nomeJogadorMenosCartoesVermelhos = nome;
                }

                auxiliarQuantidadeJogadores++;
            }
            Console.WriteLine(
                String.Format("O jogador com o menor peso é {0}, pesando {1}\n", nomeMenorPeso, menorPeso) +
                String.Format("O jogador com o maior peso é {0}, pesando {1}\n\n", nomeMaiorPeso, maiorPeso) +
                String.Format("O jogador com o menor altura é {0}, medindo {1}\n\n", nomeMenorAltura, menorAltura) +
                String.Format("O jogador com o maior altura é {0}, medindo {1}\n\n", nomeMaiorAltura, maiorAltura) +
                String.Format("Foram registrados {0} do sexo feminino\n\n", contadorSexoFeminino) +
                String.Format("Foram registrados {0} do sexo masculino\n\n", contadorSexoMasculino) +
                String.Format("O jogador com o maior nome é: {0}\n\n", maiorNome) +
                String.Format("O jogador com o menor nome é: {0}\n\n", menorNome) +
                String.Format("O jogador com a menor quantidade de cartões amarelos recebidos é: {0}\n\n", nomeJogadorMenosCartoesAmarelos) +
                String.Format("O jogador com a maior quantidade de cartões amarelos recebidos é: {0}\n\n", nomeJogadorMaisCartoesVermelhos) +
                String.Format("O jogador com a menor quantidade de cartões vermelhos recebidos é: {0}\n\n", nomeJogadorMenosCartoesVermelhos) +
                String.Format("O jogador com a maior quantidade de cartões vermelhos recebidos é: {0}\n\n", nomeJogadorMaisCartoesVermelhos));

        }
    }
}
