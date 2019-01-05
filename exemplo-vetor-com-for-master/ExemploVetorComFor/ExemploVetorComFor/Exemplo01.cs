using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploVetorComFor
{
    class Exemplo01
    {
        public Exemplo01()
        {
            string[] mortesDoFilme = new string[5];
            // FORMA OLD
            // mortesDoFilme[0] = "Tony Stark";

            // ARMAZENA AS INFORMAÇÕES DO VETOR
            for (int i = 0; i < mortesDoFilme.Length; i++)
            {
                Console.Write("Digite o nome da pessoa que morre no filme: ");
                mortesDoFilme[i] = Console.ReadLine();
            }
            
            Console.Clear();
            Console.WriteLine("Pessoas cadastradas: ");
            // APRESENTAR AS INFORMAÇÕES DO VETOR
            for (int i = 0; i < mortesDoFilme.Length; i++)
            {
                Console.WriteLine("Nome: " + mortesDoFilme[i]);
            }
        }
    }
}
