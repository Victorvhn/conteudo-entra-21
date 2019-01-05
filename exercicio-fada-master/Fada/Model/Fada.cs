using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Fada
    {
        private int codigoCadastro;
        private string nome;
        private string familia;
        private string cor;
        private string corAsa;
        private double tamanhoAsa;
        private bool asaQuebrada;
        private bool mulher;
        private bool fazBarulho;
        private string elemento;

        public int CodigoCadastro
        {
            get
            {
                return codigoCadastro;
            }
            set
            {
                codigoCadastro = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Nome deve ser preenchido");
                }

                if (value.Count() < 3)
                {
                    throw new Exception("Nome deve conter pelo menos 3 caracteres");
                }

                if (value.Count() > 150)
                {
                    throw new Exception("Nome deve conter no máximo 150 caracteres");
                }

                nome = value;
            }
        }

        public string Familia
        {
            get
            {
                return familia;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Família deve ser preenchida");
                }

                if (value.Count() < 4)
                {
                    throw new Exception("Família deve conter pelo menos 4 caracteres");
                }

                if (value.Count() > 50)
                {
                    throw new Exception("Família deve conter no máximo 50 caracteres");
                }

                familia = value;
            }
        }

        public string Cor
        {
            get
            {
                return cor;
            }
            set
            {
                cor = value;
            }
        }

        public string CorAsa
        {
            get
            {
                return corAsa;
            }
            set
            {
                corAsa = value;
            }
        }

        public double TamanhoAsa
        {
            get
            {
                return tamanhoAsa;
            }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                {
                    throw new Exception("Tamanho de asa deve ser preenchido");
                }
                if (value <= 0)
                {
                    throw new Exception("Tamanho da asa deve ser maior que 0 centímetros");
                }

                if (value > 15)
                {
                    throw new Exception("Tamanho da asa deve ser no máximo 15 centímetros");
                }

                tamanhoAsa = value;
            }
        }

        public bool AsaQuebrada
        {
            get
            {
                return asaQuebrada;
            }
            set
            {
                asaQuebrada = value;
            }
        }

        public bool Mulher
        {
            get
            {
                return mulher;
            }
            set
            {
                mulher = value;
            }
        }

        public bool FazBarulho
        {
            get
            {
                return fazBarulho;
            }
            set
            {
                fazBarulho = value;
            }
        }

        public string Elemento
        {
            get
            {
                return elemento;
            }
            set
            {
                elemento = value;
            }
        }

        public Fada(string nome, bool mulher, bool asaQuebrada)
        {
            Nome = nome;
            Mulher = mulher;
            AsaQuebrada = asaQuebrada;
        }

        public Fada(string nome, string familia, string cor)
        {
            Nome = nome;
            Familia = familia;
            Cor = cor;
        }

        public Fada(string nome, string cor, bool mulher)
        {
            Nome = nome;
            Cor = cor;
            Mulher = mulher;
        }
    }
}
