using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal lulu = new Animal();
            Animal tota = new Animal();
        }
    }

    class Animal
    {
        public static int UltimoCodigo = 0;
        public int Codigo;

        public Animal()
        {
            UltimoCodigo++;
            Codigo = UltimoCodigo;
        }
    }
}
