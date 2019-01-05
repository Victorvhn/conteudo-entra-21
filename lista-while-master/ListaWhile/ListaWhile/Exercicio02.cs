using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
    class Exercicio02
    {
        public Exercicio02()
        {
            //2. Solicite a idade para o usuário até que ele digite uma idade maior que 128.

            int idade = 0;

            while (idade <= 128)
            {
                Console.Write("Digite uma idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
