using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Time
    {
        public string Nome{ get; set; }
        public string Pais { get; set; }
        public int QuantidadeGolsFeitos { get; set; }
        public int QuantidadeGolsSofridos { get; set; }
        public int QuantidadeCartosAmarelos { get; set; }
        public int QuantidadeCartoesVermelhos { get; set; }
        public int Substituicoes { get; set; }
        public int QuantidadeFinais { get; set; }
        public int QuantidadeDerrotas { get; set; }
        public int QuantidadeSemiFinais { get; set; }
        public int QuantidadeGolsContra { get; set; }
        public int QuantidadeVitorias { get; set; }
        public decimal Faturamento { get; set; }
        public string Serie { get; set; }

        public Time (string nome, string pais, string serie)
        {
            Nome = nome;
            Pais = pais;
            Serie = serie;
        }

        public Time (string nome, string pais)
        {
            Nome = nome;
            Pais = pais;
        }

        public Time (string nome, string serie, decimal faturamento)
        {
            Nome = nome;
            Serie = serie;
            Faturamento = faturamento;
        }
    }
}
