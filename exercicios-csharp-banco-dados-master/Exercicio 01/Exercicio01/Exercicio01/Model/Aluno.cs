using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Model
{
    class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CodigoMatricula{ get; set; }
        public double Nota_1{ get; set; }
        public double Nota_2 { get; set; }
        public double Nota_3 { get; set; }
        public byte QuantidadeFaltas { get; set; }
        public double Media { get; set; }
        public double Frequencia { get; set; }
    }
}
