using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
    class Exercicio08
    {
        public Exercicio08()
        {
            /*8. Solicitar a quantidade de caracteres que serão digitados. Após isto solicitando um
caracter por vez e armazenar o texto, no final deve-se apresentar o texto.*/
            string texto = "";
            char caracter;
            int auxiliarLimite = 0;

            Console.WriteLine("Informe a quantidade de caracteres que serão digitados. Para formar um texto.\n\n");
            Console.Write("Quantidade de caracteres: ");
            int quantidadeCaracteres = Convert.ToInt32(Console.ReadLine());

            while (auxiliarLimite < quantidadeCaracteres)
            {
                Console.Write("Caracter: ");
                string caracterAux = Console.ReadLine();

                if (caracterAux.Length == 0)
                {
                    caracter = ' ';
                }
                else
                {
                    caracter = Convert.ToChar(caracterAux);
                }

                texto = texto + caracter;
                
                
                auxiliarLimite++;
            }
            Console.WriteLine(texto);
        }
    }
}
