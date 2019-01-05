using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista01
{
    class Exercicio09
    {
        public Exercicio09()
        {
            string texto = "Lorem Ipsum";
            string textoAuxiliar = "";
            int atual = 0;

            while (atual < texto.Length)
            {
                textoAuxiliar = texto.Substring(atual,1);
                Console.WriteLine(textoAuxiliar);
                atual++;
            }
            
        }
    }
}
