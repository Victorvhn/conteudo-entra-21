using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGetSet
{
    class Cachorro
    {
        private string Nome;
        private string Raca;
        private double Peso;
        private double Altura;

        // Guardar determinada informação, validando a mesma ou não
        public void SetNome(string nome)
        {
            if (nome.Count() < 3)
            {
                throw new Exception("Nome deve conter 3 letras");
            }

            if (nome.Count() > 40)
            {
                throw new Exception("Nome deve conter no máximo 40 caracteres");
            }
            Nome = nome;
        }

        public void SetAltura(double altura)
        {
            if (altura <= 0)
            {
                throw new Exception("Altura deve ser maior que 0");
            }

            if (altura > 2)
            {
                throw new Exception("Altura deve ser menor que 2 metros");
            }
            Altura = altura;
        }

        public void SetRaca(string raca)
        {
            if (raca.Count() < 3)
            {
                throw new Exception("Raca deve ter pelo menos 3 letras");
            }

            if (raca.Count() >= 40)
            {
                throw new Exception("Raca deve ter no minimo 40 letras.");
            }
            Raca = raca;
        }

        public void SetPeso(double peso)
        {
            if (peso <= 0)
            {
                throw new Exception("Peso deve ser maior que 0,1");
            }

            if (peso >= 150)
            {
                throw new Exception("Peso deve ser menor que 150");
            }
            Peso = peso;
        }

        public string GetNome()
        {
            return Nome;
        }

        public double GetAltura()
        {
            return Altura;
        }

        public double GetPeso()
        {
            return Peso;
        }

        public string GetRaca()
        {
            return Raca;
        }
    }
}
