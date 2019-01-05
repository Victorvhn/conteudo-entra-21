using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
    class Exercicio01
    {
        public Exercicio01()
        {
            //1. Solicite nomes ao usuário até que o mesmo digite fim para o nome.

            string nome = "";
            nome = nome.ToLower();

            while (nome != "fim")
            {
                Console.Write("Digite nomes, para parar digite fim: ");
                nome = Console.ReadLine();
                nome = nome.ToLower();
            }
        }
    }
}
