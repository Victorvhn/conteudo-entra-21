using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGetSet
{
    class Casaco
    {
        private string CorDoCasaco;
        private double PrecoDoCasaco;
        private string TamanhoDoCasaco;

        public void SetCorDoCasaco(string corDoCasaco)
        {
            if (corDoCasaco.Count() < 7)
            {
                throw new Exception("Cor do casado deve conter no minimo 7 caracteres");
            }

            if (corDoCasaco.Count() > 20)
            {
                throw new Exception("Cor do casaco deve ter no maximo 20 caracteres");
            }
            CorDoCasaco = corDoCasaco;
        }

        public void SetPrecoDoCasaco(double precoDoCasaco)
        {
            if (precoDoCasaco < 10)
            {
                throw new Exception("Preço do casaco deve ser maior ou igual 10");
            }

            if (precoDoCasaco > 900)
            {
                throw new Exception("Preço do casaco deve ser menor que 901");
            }
            PrecoDoCasaco = precoDoCasaco;
        }

        public void SetTamanhoDoCasaco(string tamanhoDoCasaco)
        {
            if (tamanhoDoCasaco.Count() < 1)
            {
                throw new Exception("Tamanho do casaco deve ter 1 ou mais caracteres");
            }

            if (tamanhoDoCasaco.Count() > 3)
            {
                throw new Exception("Tamanho do casaco deve ter 3 ou menos caracteres");
            }
            TamanhoDoCasaco = tamanhoDoCasaco;
        }

        public string GetCorDoCasaco()
        {
            return CorDoCasaco;
        }

        public double GetPrecoDoCasaco()
        {
            return PrecoDoCasaco;
        }

        public string GetTamanhoDoCasaco()
        {
            return TamanhoDoCasaco;
        }
    }
}
