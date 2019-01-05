using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Exercicio07
    {
        public Exercicio07()
        {
            /*7. Solicite ao usuário 20 caracteres armazenando em um vetor. Após isto verifique e
                apresente os itens abaixo:
                ➔ Quantas são as consoantes
                ➔ Quantas são as vogais;
                ➔ Quantos são caracteres especiais.
                ➔ Quais são as consoantes;
                ➔ Quais são as vogais;
                ➔ Quais são os caracteres especiais.*/

            char[] caracteres = new char[2];
            bool validarCaracteres = true;
            int quantidadeConsoantes = 0;
            string consoantes = "";
            int quantidadeVogais = 0;
            string vogais = "";
            int quantidadeEspeciais = 0;
            string especiais = "";

            for (int i = 0; i < caracteres.Length; i++)
            {
                while (validarCaracteres == true)
                {
                    try
                    {
                        Console.Write(String.Format("{0} de {1}\nCaractere: ", (i + 1), caracteres.Length));
                        caracteres[i] = Convert.ToChar(Console.ReadLine().ToLower());
                        Console.Clear();
                        validarCaracteres = false;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Deveria conter APENAS 1 caracter em 'caractere'");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                validarCaracteres = true;

                // Quantas vogais e quais;
                if ((caracteres[i] == 'a') || (caracteres[i] == 'e') || (caracteres[i] == 'i') || (caracteres[i] == 'o') || (caracteres[i] == 'u'))
                {
                    quantidadeVogais++;
                    vogais = vogais + caracteres[i] + ", ";
                }

                //quantas consoantes e quais
                if ((caracteres[i] == 'b') || (caracteres[i] == 'c') || (caracteres[i] == 'd') || (caracteres[i] == 'f') || (caracteres[i] == 'g') || (caracteres[i] == 'h') || (caracteres[i] == 'j') || (caracteres[i] == 'k') || (caracteres[i] == 'l') || (caracteres[i] == 'm') || (caracteres[i] == 'n') || (caracteres[i] == 'p') || (caracteres[i] == 'q') || (caracteres[i] == 'r') || (caracteres[i] == 's') || (caracteres[i] == 't') || (caracteres[i] == 'v') || (caracteres[i] == 'w') || (caracteres[i] == 'x') || (caracteres[i] == 'y') || (caracteres[i] == 'z'))
                {
                    quantidadeConsoantes++;
                    consoantes = consoantes + caracteres[i] + ", ";
                }

                //caracteres especiais
                if ((caracteres[i] != 'a') && (caracteres[i] != 'b') && (caracteres[i] != 'c') && (caracteres[i] != 'd') && (caracteres[i] != 'e') && (caracteres[i] != 'f') && (caracteres[i] != 'g') && (caracteres[i] != 'h') && (caracteres[i] != 'i') && (caracteres[i] != 'j') && (caracteres[i] != 'k') && (caracteres[i] != 'l') && (caracteres[i] != 'm') && (caracteres[i] != 'n') && (caracteres[i] != 'o') && (caracteres[i] != 'p') && (caracteres[i] != 'q') && (caracteres[i] != 'r') && (caracteres[i] != 's') && (caracteres[i] != 't') && (caracteres[i] != 'u') && (caracteres[i] != 'v') && (caracteres[i] != 'w') && (caracteres[i] != 'x') && (caracteres[i] != 'y') && (caracteres[i] != 'z'))
                {
                    quantidadeEspeciais++;
                    especiais = especiais + caracteres[i] + ", ";
                }
            }
            Console.WriteLine("Você digitou: ");
            if (quantidadeConsoantes != 0)
            {
                Console.WriteLine("{0} consoante(s);\n" +
                                  "As consoantes digitadas foram {1}\n\n", quantidadeConsoantes, consoantes);
            }
            if (quantidadeVogais != 0)
            {
                Console.WriteLine("{0} vogal(is);\n" + 
                                  "As vogais digitadas foram {1}\n\n",quantidadeVogais, vogais);
            }
            if (quantidadeEspeciais != 0)
            {
                Console.WriteLine("{0} caracteres especiais\n" + 
                                  "Os caracteres especiais foram {1}\n",quantidadeEspeciais, especiais);
            }
        }
    }
}
