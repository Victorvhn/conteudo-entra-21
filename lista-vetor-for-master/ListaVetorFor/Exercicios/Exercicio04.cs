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
            /*4. Desenvolver um programa que armazene o tamanho de 40 camisas, após isto
                apresentar:
                ➔ Tamanho de todas as camisas armazenadas
                ➔ Quantidade de camisas PP
                ➔ Quantidade de camisas P
                ➔ Quantidade de camisas M
                ➔ Quantidade de camisas G
                ➔ Quantidade de camisas GG
                ➔ Quantidade de camisas XG
                ➔ Quantidade de camisas XGG*/
            string[] tamanhoCamisas = new string[2];
            int camisasPP = 0;
            int camisasP = 0;
            int camisasM = 0;
            int camisasG = 0;
            int camisasGG = 0;
            int camisasXG = 0;
            int camisasXGG = 0;

            for (int i = 0; i < tamanhoCamisas.Length; i++)
            {
                Console.Write(String.Format("Camisa {0} de {1}\nTamanho: ", (i + 1), tamanhoCamisas.Length));
                tamanhoCamisas[i] = Console.ReadLine().ToLower();
                while ((tamanhoCamisas[i] != "pp") && (tamanhoCamisas[i] != "p") && (tamanhoCamisas[i] != "m") && (tamanhoCamisas[i] != "g") && (tamanhoCamisas[i] != "g") && (tamanhoCamisas[i] != "gg") && (tamanhoCamisas[i] != "xg") && (tamanhoCamisas[i] != "xgg"))
                {
                    Console.Clear();
                    Console.WriteLine("O tamanho das camisas deve ser APENAS: PP, P, M, G, GG, XG, XGG.");
                    Console.Write(String.Format("Camisa {0} de {1}\nTamanho: ", (i + 1), tamanhoCamisas.Length));
                    tamanhoCamisas[i] = Console.ReadLine().ToLower();
                    Console.Clear();
                }
            }
            //Contar PP
            for (int j = 0; j < tamanhoCamisas.Length; j++)
            {
                if (tamanhoCamisas[j] == "pp")
                {
                    camisasPP++;
                }
            }

            //Contar P
            for (int j = 0; j < tamanhoCamisas.Length; j++)
            {
                if (tamanhoCamisas[j] == "p")
                {
                    camisasP++;
                }
            }

            //Contar M
            for (int j = 0; j < tamanhoCamisas.Length; j++)
            {
                if (tamanhoCamisas[j] == "m")
                {
                    camisasM++;
                }
            }

            //Contar G
            for (int j = 0; j < tamanhoCamisas.Length; j++)
            {
                if (tamanhoCamisas[j] == "g")
                {
                    camisasG++;
                }
            }

            //Contar GG
            for (int j = 0; j < tamanhoCamisas.Length; j++)
            {
                if (tamanhoCamisas[j] == "gg")
                {
                    camisasGG++;
                }
            }

            //Contador XG
            for (int j = 0; j < tamanhoCamisas.Length; j++)
            {
                if (tamanhoCamisas[j] == "xg")
                {
                    camisasXG++;
                }
            }

            //Contador XGG
            for (int j = 0; j < tamanhoCamisas.Length; j++)
            {
                if (tamanhoCamisas[j] == "xgg")
                {
                    camisasXGG++;
                }
            }


            Console.Write(String.Format("Tamanho de todas as camisas armazenadas: \n" +
                                        "Quantidade de camisas PP  : {0}\n" +
                                        "Quantidade de camisas P   : {1}\n" +
                                        "Quantidade de camisas M   : {2}\n" +
                                        "Quantidade de camisas G   : {3}\n" +
                                        "Quantidade de camisas GG  : {4}\n" +
                                        "Quantidade de camisas XG  : {5}\n" +
                                        "Quantidade de camisas XGG : {6}\n", camisasPP, camisasP, camisasM, camisasG, camisasGG, camisasXG, camisasXGG));
        }
    }
}
