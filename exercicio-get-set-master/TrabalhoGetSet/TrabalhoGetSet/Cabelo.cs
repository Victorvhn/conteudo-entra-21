using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGetSet
{
    class Cabelo
    {
        private int TamanhoDoFio;
        private double GrossuraDoFio;
        private string CorDoFio;

        public void SetTamanhoDoFio(int tamanhoDoFio)
        {
            if (tamanhoDoFio < 1)
            {
                throw new Exception("Tamnho do fio deve ser maior que 1");
            }

            if (tamanhoDoFio > 90)
            {
                throw new Exception("Tamnho do fio deve ser menor ou igual 90");
            }
            TamanhoDoFio = tamanhoDoFio;
        }

        public void SetGrossuraDoFio(double grossuraDoFio)
        {
            if (grossuraDoFio < 0.1)
            {
                throw new Exception("Grossura do fio deve ser maior que 0,1");
            }

            if (grossuraDoFio > 1)
            {
                throw new Exception("Grossura do fio deve ser menor ou igual a 1");
            }
            GrossuraDoFio = grossuraDoFio;
        }

        public void SetCorDoFio(string corDoFio)
        {
            if (corDoFio.Count() < 7)
            {
                throw new Exception("Cor do fio deve ter mais que 7 caracteres");
            }

            if (corDoFio.Count() > 20)
            {
                throw new Exception("Cor do fio deve ter menos que 21 caracteres");
            }
            CorDoFio = corDoFio;
        }

        public int GetTamanhoDoFio()
        {
            return TamanhoDoFio;
        }

        public double GetGrossuraDoFio()
        {
            return GrossuraDoFio;
        }

        public string GetCorDoFio()
        {
            return CorDoFio;
        }
    }
}
