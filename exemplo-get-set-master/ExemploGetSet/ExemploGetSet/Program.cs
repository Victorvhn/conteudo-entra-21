using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro();
            // set tem como objetivo guardar determinada informação
            cachorro.SetNome("Zika");
            cachorro.SetAltura(1);
            cachorro.SetPeso(80);
            cachorro.SetRaca("Raça");
            
            // get tem como objetivo obter determinada informação
            Console.WriteLine("Nome: " + cachorro.GetNome());
            Console.WriteLine("Altura: " + cachorro.GetAltura());
            Console.WriteLine("Peso: " + cachorro.GetPeso());
            Console.WriteLine("Raça: " + cachorro.GetRaca());
        }
    }
}
