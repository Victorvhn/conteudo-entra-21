using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Cabelo cabelo = new Cabelo();
            Casaco casaco = new Casaco();

            cabelo.SetTamanhoDoFio(2);
            cabelo.SetGrossuraDoFio(0.2);
            cabelo.SetCorDoFio("preto claro");

            casaco.SetCorDoCasaco("preto escuro");
            casaco.SetPrecoDoCasaco(899);
            casaco.SetTamanhoDoCasaco("P");

            Console.WriteLine("Tamanho do fio: " + cabelo.GetTamanhoDoFio());
            Console.WriteLine("Grossura do fio: " + cabelo.GetGrossuraDoFio());
            Console.WriteLine("Cor do fio: " +cabelo.GetCorDoFio());

            Console.WriteLine("\nCor do casaco: " +casaco.GetCorDoCasaco());
            Console.WriteLine("Preco do casaco: " +casaco.GetPrecoDoCasaco());
            Console.WriteLine("Tamanho do casaco: " +casaco.GetTamanhoDoCasaco());
        }
    }
}
