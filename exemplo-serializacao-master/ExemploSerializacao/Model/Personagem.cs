using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Personagem
    {
        private string Nome;
        private string Cla;
        private int NivelChakra;

        public void SetNome(string nome)
        {
            if (nome.Trim().Count() < 3)
            {
                throw new Exception("Nome deve conter pelo menos 3 caracteres.");
            }
            if (nome.Trim().Count() > 100)
            {
                throw new Exception("Nome deve conter no máximo 100 caracteres.");
            }
            this.Nome = nome;
        }

        public void SetCla(string cla)
        {
            this.Cla = cla;
        }

        public void SetNivelChakra(int nivelChakra)
        {
            if (nivelChakra < 0)
            {
                throw new Exception("Nível de chakra deve ser acima de 0");
            }
            if (nivelChakra > 200000)
            {
                throw new Exception("Nível de chakra deve ser menor que 200000");
            }
            this.NivelChakra = nivelChakra;
        }

        public string GetNome()
        {
            return Nome;
        }

        public string GetCla()
        {
            return Cla;
        }

        public int GetNivelChakra()
        {
            return NivelChakra;
        }
    }
}
